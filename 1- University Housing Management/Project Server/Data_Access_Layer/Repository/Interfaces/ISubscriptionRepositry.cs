using Data_Access_Layer.Entities;

namespace Data_Access_Layer.Repository.Interfaces
{
    public interface ISubscriptionRepositry
    {

        Task<Subscription> AddNewSubscriptionAsync(Subscription subscription);
        IQueryable<Subscription> GetAllSubscriptions();
    
    }
}
