using Data_Access_Layer.Data;
using Data_Access_Layer.Entities;
using Data_Access_Layer.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data_Access_Layer.Repository.Implementaions
{
    public class SaleRepositry: ISaleRepositry
    {

        private readonly AppDbContext _context;
        public SaleRepositry(AppDbContext context)
            => _context = context;


        public async Task<Sale> AddSaleAsync(Sale sale)
        {

            await _context.Sales.AddAsync(sale);
            await _context.SaveChangesAsync();

            return sale;
        }
        public IQueryable<Sale> AllSales() 
            => _context.Sales.AsNoTracking();

    }
}
