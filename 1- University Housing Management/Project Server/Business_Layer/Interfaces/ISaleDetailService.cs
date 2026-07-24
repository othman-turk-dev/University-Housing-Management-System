using Business_Layer.DTOs;

namespace Business_Layer.Interfaces
{
    public interface ISaleDetailService
    {

        Task<bool> AddNewSaleAsync(List<SaleInfoDto> saleDetails);
        Task<IEnumerable<SaleSummaryDto>> GetAllSalesAsync();
        Task<IEnumerable<SaleSummaryDto>> GetAllSalesInThisMonthAsync();
        Task<IEnumerable<SaleDetailsByIdDto>> GetAllSaleDetailsAsync(int saleId);
        Task<IEnumerable<SaleSummaryDto>> FilterSalesAsync(SalesFilterDto salesFilter);
    }
}
