using Data_Access_Layer.Data;
using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Data_Access_Layer.Repository.Interfaces;

namespace Data_Access_Layer.Repository.Implementaions
{
    public class SaleDetailRepositry: ISaleDetailRepositry
    {

        private readonly AppDbContext _context;
        public SaleDetailRepositry(AppDbContext context)
            => _context = context;


        public async Task<SaleDetail> AddSaleDetailAsync(SaleDetail saleDetail)
        {

            await _context.SaleDetails.AddAsync(saleDetail);
            await _context.SaveChangesAsync();

            return saleDetail;
        }
        public IQueryable<SaleDetail> AllSaleDetails() 
            => _context.SaleDetails.AsNoTracking();

    }
}
