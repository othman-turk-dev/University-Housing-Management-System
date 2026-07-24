using Data_Access_Layer.Data;
using Data_Access_Layer.Entities;
using Data_Access_Layer.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data_Access_Layer.Repository.Implementaions
{
    public class ProductRepositry: IProductRepositry
    {

        private readonly AppDbContext _context;
        public ProductRepositry(AppDbContext context)
            => _context = context;


        public async Task<Product> AddProductAsync(Product product)
        {

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return product;
        }
        public async Task<Product> UpdateProductAsync(Product product)
        {

            _context.Products.Update(product);
            await _context.SaveChangesAsync();

            return product;
        }
        public async Task<Product?> GetProductByIdAsync(string productId)
        {

            return await _context.Products.FindAsync(productId);
        }
        public async Task<bool> IsProductExist(string productId)
        {

            return await _context.Products.AsNoTracking()
                .AnyAsync(p => p.ProductId == productId);
        }
        public IQueryable<Product> AllProducts() 
            => _context.Products.AsNoTracking();

    }
}
