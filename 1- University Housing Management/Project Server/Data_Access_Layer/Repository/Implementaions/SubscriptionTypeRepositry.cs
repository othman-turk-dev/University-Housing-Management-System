using Data_Access_Layer.Data;
using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Data_Access_Layer.Repository.Interfaces;

namespace Data_Access_Layer.Repository.Implementaions
{
    public class SubscriptionTypeRepositry : ISubscriptionTypeRepositry
    {

        private readonly AppDbContext _context;
        public SubscriptionTypeRepositry(AppDbContext context)
            => _context = context;


        public async Task<SubscriptionType?> GetSubscriptionTypeByIdAsync(int id)
        {
            
             return await _context.SubscriptionTypes.FindAsync(id);
        }
        public async Task<SubscriptionType?> GetSubscriptionTypeByDescriptionAsync(string Description)
        {
             
            return await _context.SubscriptionTypes.
                FirstOrDefaultAsync(s=>s.Description == Description);
        }
        public IQueryable<SubscriptionType> GetAllSubscriptionTypes()
        {
            return _context.SubscriptionTypes.AsNoTracking();
        }

    }
}
