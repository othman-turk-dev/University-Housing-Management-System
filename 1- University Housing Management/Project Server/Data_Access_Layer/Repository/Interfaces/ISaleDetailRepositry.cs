using Data_Access_Layer.Entities;

namespace Data_Access_Layer.Repository.Interfaces
{
    public interface ISaleDetailRepositry
    {
        Task<SaleDetail> AddSaleDetailAsync(SaleDetail saleDetail);
        IQueryable<SaleDetail> AllSaleDetails();

    }
}
