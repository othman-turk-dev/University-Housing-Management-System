using Data_Access_Layer.Data;
using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Data_Access_Layer.Repository.Interfaces;

namespace Data_Access_Layer.Repository.Implementaions
{
    public class SubscriptionRepositry : ISubscriptionRepositry
    {

        private readonly AppDbContext _context;
        public SubscriptionRepositry(AppDbContext context)
            => _context = context;
        
        public async Task<Subscription> AddNewSubscriptionAsync(Subscription subscription)
        {
            
            await _context.Subscriptions.AddAsync(subscription);
            await _context.SaveChangesAsync();

            return subscription;
        }
        public IQueryable<Subscription> GetAllSubscriptions()
        {
            
            return _context.Subscriptions.AsNoTracking();
        }

    }
}
