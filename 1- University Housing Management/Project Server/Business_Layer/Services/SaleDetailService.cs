using Business_Layer.DTOs;
using Business_Layer.Interfaces;
using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Business_Layer.Global.Constants;
using Data_Access_Layer.Repository.Interfaces;

namespace Business_Layer.Services
{
    public class SaleDetailService: ISaleDetailService
    {

        private readonly IBankRepositry _bankRepositry;
        private readonly ISaleRepositry _saleRepositry;
        private readonly IProductService _productService;
        private readonly ICurrentUserService _currentUserService;
        private readonly ITransactionManager _transactionManager;
        private readonly ISaleDetailRepositry _saleDetailRepositry;

        public SaleDetailService(ISaleRepositry saleRepositry,ICurrentUserService currentUserService,
            ITransactionManager transactionManager, ISaleDetailRepositry saleDetailRepositry,
            IBankRepositry bankRepositry, IProductService productService)
        {
            
            _bankRepositry = bankRepositry;
            _saleRepositry = saleRepositry;
            _productService = productService;
            _currentUserService = currentUserService;
            _transactionManager = transactionManager;
            _saleDetailRepositry = saleDetailRepositry;
        }

        public async Task<bool> AddNewSaleAsync(List<SaleInfoDto> saleDetails)
        {


            if(saleDetails == null || saleDetails.Count == 0)
                return false;


            await _transactionManager.BeginTransactionAsync();

            try
            {

                Sale sale = new Sale
                {

                    CreatedByUserId = _currentUserService.UserId,
                    Date = DateTime.UtcNow,
                };

                var addedSale = await _saleRepositry.AddSaleAsync(sale);

                if(addedSale == null)
                {

                    await _transactionManager.RollbackAsync();
                    return false;
                }

                decimal SaleAmount = 0;

                for (int i = 0; i < saleDetails.Count; i++)
                {

                    var product = await _productService.GetProductByIdAsync(saleDetails[i].ProductId);

                    if (product == null)
                    {
                        
                        await _transactionManager.RollbackAsync();
                        return false;
                    }

                    SaleDetail saleDetail = new SaleDetail
                    {

                        SaleId = addedSale.SaleId,
                        ProductId = saleDetails[i].ProductId,
                        Quantity = saleDetails[i].Quantity,
                        UnitPrice = product.Price,
                        LineTotal = saleDetails[i].Quantity * product.Price,
                      
                    };

                    if(! await _productService.DecreaseStockAsync
                        (saleDetails[i].ProductId, saleDetails[i].Quantity))
                    {

                        await _transactionManager.RollbackAsync();
                        return false;
                    }
                      

                    SaleAmount += saleDetails[i].Quantity * product.Price; 

                    var addedsaleDetail = await _saleDetailRepositry.AddSaleDetailAsync(saleDetail);

                    if(addedsaleDetail == null)
                    {

                        await _transactionManager.RollbackAsync();
                        return false;
                    }

                }

                var bank = new Bank
                {
                    Amount = SaleAmount,
                    OperationType = BankOperations.SellProducts,
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
        public async Task<IEnumerable<SaleSummaryDto>> GetAllSalesAsync()
        {

            return await _saleDetailRepositry.AllSaleDetails().
                GroupBy(s => new
                {
                    s.SaleId,
                    s.Sale.Date,
                    s.Sale.CreatedByUser.Username
                }).
                Select(g => new SaleSummaryDto
                {
                    
                    SaleId = g.Key.SaleId,
                    SaleDate = g.Key.Date,
                    SoldBy = g.Key.Username,
                    TotalProductTypes =  g.Count(),
                    TotalAmount = g.Sum(x => x.LineTotal)

                }).
                OrderByDescending(s => s.SaleDate).
                ToListAsync();

        }
        public async Task<IEnumerable<SaleSummaryDto>> GetAllSalesInThisMonthAsync()
        {

            var firstDayOfMonth = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 1);

            return await _saleDetailRepositry.AllSaleDetails().
                Where(s => s.Sale.Date >= firstDayOfMonth).
                GroupBy(s => new
                {
                    s.SaleId,
                    s.Sale.Date,
                    s.Sale.CreatedByUser.Username
                }).
                Select(g => new SaleSummaryDto
                {

                    SaleId = g.Key.SaleId,
                    SaleDate = g.Key.Date,
                    SoldBy = g.Key.Username,
                    TotalProductTypes = g.Count(),
                    TotalAmount = g.Sum(x => x.LineTotal)

                }).
                OrderByDescending(s => s.SaleDate).
                ToListAsync();

        }
        public async Task<IEnumerable<SaleDetailsByIdDto>> GetAllSaleDetailsAsync(int saleId)
        {

            return await _saleDetailRepositry.AllSaleDetails().
                Where(s => s.SaleId == saleId).
                Select(s => new SaleDetailsByIdDto
                {

                    ProductName = s.Product.ProductName,
                    Quantity = s.Quantity,
                    UnitPrice = s.UnitPrice,
                    LineTotal = s.LineTotal,
                    Date = s.Sale.Date

                }).ToListAsync();

        }

        public async Task<IEnumerable<SaleSummaryDto>> FilterSalesAsync(SalesFilterDto salesFilter)
        {

            var query = _saleDetailRepositry.AllSaleDetails();


            if (salesFilter.SaleDate.HasValue)
            {

                var start = salesFilter.SaleDate.Value.Date;
                var end = start.AddDays(1);

                query = query.Where(s =>
                    s.Sale.Date >= start &&
                    s.Sale.Date < end);

            }
                
            if (!string.IsNullOrWhiteSpace(salesFilter.SoldBy))
                query = query.Where(s => s.Sale.CreatedByUser.Username.Contains(salesFilter.SoldBy));


            return await query.
                GroupBy(s => new
                {
                    s.SaleId,
                    s.Sale.Date,
                    s.Sale.CreatedByUser.Username
                }).
                Select(g => new SaleSummaryDto
                {

                    SaleId = g.Key.SaleId,
                    SaleDate = g.Key.Date,
                    SoldBy = g.Key.Username,
                    TotalProductTypes = g.Count(),
                    TotalAmount = g.Sum(x => x.LineTotal)

                }).
                OrderByDescending(s => s.SaleDate).
                ToListAsync();

        }

    }
}
