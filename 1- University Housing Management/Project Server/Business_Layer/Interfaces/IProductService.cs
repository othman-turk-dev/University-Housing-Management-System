using Business_Layer.DTOs;

namespace Business_Layer.Interfaces
{
    public interface IProductService
    {

        Task<AddProductDto?> AddProductAsync(AddProductDto product);
        Task<bool> UpdateProductAsync(UpdateProductDto product);
        Task<bool> AddNewQuantityAsync(AddQuantityDto product);
        Task<bool> DecreaseStockAsync(string productId, int Quantity);
        Task<bool> IncreaseStockAsync(string productId, int quantity);
        Task<ProductDto?> GetProductByIdAsync(string productId);
        Task<bool> IsProductExistAsync(string productId);
        Task<IEnumerable<AllProductsDto>> GetAllProductsAsync();
        Task<IEnumerable<AllProductsWithoutDetailsDto>> GetAllProductsWithoutDetailsAsync();
        Task<decimal> TotalPriceAsync();

        Task<IEnumerable<AllProductsDto>> ProductsFilterAsync(string? Product);
        Task<IEnumerable<AllProductsWithoutDetailsDto>> ProductsFilterWithoutDetailsAsync(string? Product);

    }
}
