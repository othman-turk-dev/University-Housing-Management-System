using Data_Access_Layer.Entities;

namespace Data_Access_Layer.Repository.Interfaces
{
    public interface IProductRepositry
    {

        Task<Product> AddProductAsync(Product product);
        Task<Product> UpdateProductAsync(Product product);
        Task<Product?> GetProductByIdAsync(string productId);
        Task<bool> IsProductExist(string productId);
        IQueryable<Product> AllProducts();

    }
}
