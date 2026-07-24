using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Helpers;

namespace University_Housing_Management_Project.Services
{
    public class SaleDetailService
    {

        public async Task<List<SaleSummaryDto>> GetAllSales()
        {
            return await ApiClient.GetFromJsonAsync<List<SaleSummaryDto>>("Sales");
        }
        public async Task<List<SaleSummaryDto>> GetAllSalesInThisMonth()
        {
            return await ApiClient.GetFromJsonAsync<List<SaleSummaryDto>>("Sales/Month");
        }
        public async Task<List<SaleSummaryDto>> FilterSales(SalesFilterDto filterDto)
        {
            string query = new QueryBuilder()
                .Add("SaleDate", filterDto.SaleDate)
                .Add("SoldBy", filterDto.SoldBy)
                .Build();

            return await ApiClient.GetFromJsonAsync<List<SaleSummaryDto>>($"Sales/Filter{query}");
        }
        public async Task<List<SaleDetailsByIdDto>> GetAllSaleDetails(int saleId)
        {
            return await ApiClient.GetFromJsonAsync<List<SaleDetailsByIdDto>>($"Sales/Details/{saleId}");
        }

        public async Task<bool> AddNewSale(List<SaleInfoDto> saleDetails)
        {
            var json = JsonConvert.SerializeObject(saleDetails);

            var response = await ApiClient.PostAsync("Sales", json);

            return response.IsSuccessStatusCode;
        }

    }
}