using Business_Layer.DTOs;
using Business_Layer.Global.Constants;
using Business_Layer.Interfaces;
using Data_Access_Layer.Entities;
using Data_Access_Layer.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Business_Layer.Services
{
    public class ProductService : IProductService
    {

        private readonly IBankRepositry _bankRepositry;
        private readonly IProductRepositry _productRepositry;
        private readonly ICurrentUserService _currentUserService;
        private readonly ITransactionManager _transactionManager;
        public ProductService(IProductRepositry productRepositry,IBankRepositry bankRepositry,
            ICurrentUserService currentUserService, ITransactionManager transactionManager)
        {

            _bankRepositry = bankRepositry;
            _productRepositry = productRepositry;
            _transactionManager = transactionManager;
            _currentUserService = currentUserService;
        }


        public async Task<AddProductDto?> AddProductAsync(AddProductDto product)
        {

            await _transactionManager.BeginTransactionAsync();

            try
            {
                Product newProduct = new Product
                {

                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    Price = product.Price,
                    PurchasePrice = product.PurchasePrice,
                    Quantity = product.Quantity,
                    CreateDate = DateTime.UtcNow,
                    CreateByUserId = _currentUserService.UserId,
                    LastModifiedDate = null,
                    LastModifiedByUserId = null,

                };

                var addedProduct = await _productRepositry.AddProductAsync(newProduct);

                if (addedProduct == null)
                {
                    await _transactionManager.RollbackAsync();
                    return null;
                }

                var bank = new Bank
                {
                    Amount = -(addedProduct.PurchasePrice * addedProduct.Quantity),
                    OperationType = BankOperations.BuyNewProduct,
                    CreatedByUserId = _currentUserService.UserId,
                    Date = DateTime.UtcNow
                };

                var addedBank = await _bankRepositry.AddBankAsync(bank);

                if (addedBank == null)
                {
                    await _transactionManager.RollbackAsync();
                    return null;
                }

                await _transactionManager.CommitAsync();

                return new AddProductDto
                {

                    ProductId = addedProduct.ProductId,
                    Price = addedProduct.Price,
                    ProductName = addedProduct.ProductName,
                    PurchasePrice = addedProduct.PurchasePrice,
                    Quantity = addedProduct.Quantity,

                };
                    
            }
            catch 
            {

                await _transactionManager.RollbackAsync();
                return null;
            }
        }
        public async Task<bool> UpdateProductAsync(UpdateProductDto product)
        {

            var existingProduct = await _productRepositry.
                GetProductByIdAsync(product.ProductId);

            if (existingProduct == null)
                return false;

            existingProduct.ProductName = product.ProductName;
            existingProduct.Price = product.Price;
            existingProduct.LastModifiedDate = DateTime.UtcNow;
            existingProduct.LastModifiedByUserId = _currentUserService.UserId;


            var updatedStudent = await _productRepositry
                .UpdateProductAsync(existingProduct);

            if (updatedStudent == null)
                return false;

            return true;
        }
        public async Task<bool> AddNewQuantityAsync(AddQuantityDto product)
        {

            var exist = await _productRepositry.GetProductByIdAsync(product.ProductId);

            if (exist == null)
                return false;
            
            await _transactionManager.BeginTransactionAsync();

            try
            {

                exist.PurchasePrice = product.PurchasePrice;
                exist.Price = product.Price;
                exist.Quantity += product.Quantity;
                exist.LastModifiedByUserId = _currentUserService.UserId;
                exist.LastModifiedDate = DateTime.UtcNow;

                var updatedProduct = await _productRepositry.UpdateProductAsync(exist);

                if (updatedProduct == null)
                {

                    await _transactionManager.RollbackAsync();
                    return false;
                }

                var bank = new Bank
                {
                    Amount = -(updatedProduct.PurchasePrice * product.Quantity),
                    OperationType = BankOperations.PurchaseNewQuantity,
                    CreatedByUserId = _currentUserService.UserId,
                    Date = DateTime.UtcNow
                };

                var addedBank = await _bankRepositry.AddBankAsync(bank);

                if (addedBank == null)
                {
                    await _transactionManager.RollbackAsync();
                    return false;
                }

                await _transactionManager.CommitAsync();

                return true;

            }
            catch 
            {
                
                await _transactionManager.RollbackAsync(); 
                return false; 
            }
        }
        public async Task<bool> DecreaseStockAsync(string  productId, int Quantity)
        {

            var exist = await _productRepositry.GetProductByIdAsync(productId);

            if (exist == null)
                return false;

            if (exist.Quantity < Quantity)
                return false;

            exist.Quantity -= Quantity;

            var updatedProduct = await _productRepositry.UpdateProductAsync(exist);

            return updatedProduct != null ? true : false;
        }
        public async Task<bool> IncreaseStockAsync(string productId, int quantity)
        {

            var exist = await _productRepositry.GetProductByIdAsync(productId);

            if (exist == null)
                return false;

            exist.Quantity += quantity;

            var updatedProduct = await _productRepositry.UpdateProductAsync(exist);

            return updatedProduct != null ? true : false;
        }

        public async Task<ProductDto?> GetProductByIdAsync(string productId)
        {

            var product = await _productRepositry.GetProductByIdAsync(productId);

            return product == null ? null : 
                new ProductDto
                {

                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    Price = product.Price,
                    PurchasePrice = product.PurchasePrice,
                    Quantity = product.Quantity,

                    CreateDate = product.CreateDate,
                    CreateByUserId = product.CreateByUserId,
                    LastModifiedDate = product.LastModifiedDate,
                    LastModifiedByUserId = product.LastModifiedByUserId,

                };

        }
        public async Task<bool> IsProductExistAsync(string productId)
        {

            return await _productRepositry.IsProductExist(productId);
        }
        public async Task<IEnumerable<AllProductsDto>> GetAllProductsAsync()
        {

            return await _productRepositry.AllProducts()
                .Select(p => new AllProductsDto
                {

                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    Price = p.Price,
                    Quantity = p.Quantity,
                    AddedBy = p.CreateByUser.Username,
                    AddedDate = p.CreateDate,
                    EditedBy = p.LastModifiedByUser == null ? "-------" : p.LastModifiedByUser.Username,
                    EditedDate = p.LastModifiedDate == null ? "-------" : p.LastModifiedDate.Value.ToString(),

                })
                .OrderByDescending(p => p.AddedDate)
                .ToListAsync();
        }
        public async Task<IEnumerable<AllProductsWithoutDetailsDto>> GetAllProductsWithoutDetailsAsync()
        {
            
            return await _productRepositry.AllProducts()
               .Select(p => new AllProductsWithoutDetailsDto
               {

                   ProductId = p.ProductId,
                   ProductName = p.ProductName,
                   Price = p.Price,
                   Quantity = p.Quantity,
               })
               .OrderBy(p => p.ProductId)
               .ToListAsync();
        }
        public async Task<decimal> TotalPriceAsync()
        {
            return await _productRepositry.AllProducts().SumAsync(p => p.Price * p.Quantity);
        }


        public async Task<IEnumerable<AllProductsDto>> ProductsFilterAsync(string? Product)
        {

            var query = _productRepositry.AllProducts();

            if (!string.IsNullOrWhiteSpace(Product)) 
                query = query.Where(p => p.ProductId.Contains(Product) || p.ProductName.Contains(Product));

            
            return await query.Select(p => new AllProductsDto
                        {

                            ProductId = p.ProductId,
                            ProductName = p.ProductName,
                            Price = p.Price,
                            Quantity = p.Quantity,
                            AddedBy = p.CreateByUser.Username,
                            AddedDate = p.CreateDate,
                            EditedBy = p.LastModifiedByUser == null ? "-------" : p.LastModifiedByUser.Username,
                            EditedDate = p.LastModifiedDate == null ? "-------" : p.LastModifiedDate.Value.ToString(),

                        }).ToListAsync();

        }
        public async Task<IEnumerable<AllProductsWithoutDetailsDto>> ProductsFilterWithoutDetailsAsync(string? Product)
        {

            var query = _productRepositry.AllProducts();

            if (!string.IsNullOrWhiteSpace(Product))
                query = query.Where(p => p.ProductId.Contains(Product) || p.ProductName.Contains(Product));


            return await query.Select(p => new AllProductsWithoutDetailsDto
            {

                ProductId = p.ProductId,
                ProductName = p.ProductName,
                Price = p.Price,
                Quantity = p.Quantity,

            }).ToListAsync();

        }

    }
}
