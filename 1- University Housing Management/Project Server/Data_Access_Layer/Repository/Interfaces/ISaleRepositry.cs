using Data_Access_Layer.Entities;

namespace Data_Access_Layer.Repository.Interfaces
{
    public interface ISaleRepositry
    {
        Task<Sale> AddSaleAsync(Sale sale);
        IQueryable<Sale> AllSales();

    }
}
