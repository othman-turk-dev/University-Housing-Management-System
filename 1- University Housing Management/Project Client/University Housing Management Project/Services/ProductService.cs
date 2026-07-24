using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Helpers;

namespace University_Housing_Management_Project.Services
{
    public class ProductService
    {

        public async Task<AddProductDto> AddProduct(AddProductDto product)
        {
            var json = JsonConvert.SerializeObject(product);

            var response = await ApiClient.PostAsync("Products", json);

            if (!response.IsSuccessStatusCode)
                return null;

            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<AddProductDto>(result);
        }
        public async Task<bool> UpdateProduct(UpdateProductDto product)
        {
            var json = JsonConvert.SerializeObject(product);

            var response = await ApiClient.PutAsync("Products", json);

            if (!response.IsSuccessStatusCode)
                return false;

            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<bool>(result);
        }
        public async Task<bool> AddNewQuantity(AddQuantityDto product)
        {
            var json = JsonConvert.SerializeObject(product);

            var response = await ApiClient.PutAsync("Products/AddNewQuantity", json);

            if (!response.IsSuccessStatusCode)
                return false;

            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<bool>(result);
        }

        public async Task<ProductDto> FindProductById(string productId)
        {
            return await ApiClient.GetFromJsonAsync<ProductDto>($"Products/{productId}");
        }
        public async Task<bool> IsProductExist(string productId)
        {
            return await ApiClient.GetFromJsonAsync<bool>($"Products/IsExist/{productId}");
        }
        public async Task<List<AllProductsWithoutDetailsDto>> GetAllProductsWithoutDetails()
        {
            return await ApiClient.GetFromJsonAsync<List<AllProductsWithoutDetailsDto>>("Products/WithoutDetails");
        }
        public async Task<List<AllProductsDto>> GetAllProducts()
        {
            return await ApiClient.GetFromJsonAsync<List<AllProductsDto>>("Products");
        }
        public async Task<List<AllProductsDto>> ProductsFilter(string Product)
        {
            string query = new QueryBuilder()
                .Add("Product", Product)
                .Build();

            return await ApiClient.GetFromJsonAsync<List<AllProductsDto>>($"Products/Filter{query}");
        }
        public async Task<List<AllProductsWithoutDetailsDto>> ProductsFilterWithoutDetails(string Product)
        {
            string query = new QueryBuilder()
                .Add("Product", Product)
                .Build();

            return await ApiClient.GetFromJsonAsync<List<AllProductsWithoutDetailsDto>>($"Products/WithoutDetails/Filter{query}");
        }
        public async Task<decimal?> TotalPrice()
        {
            return await ApiClient.GetFromJsonAsync<decimal?>("Products/TotalPrice");
        }

    }
}