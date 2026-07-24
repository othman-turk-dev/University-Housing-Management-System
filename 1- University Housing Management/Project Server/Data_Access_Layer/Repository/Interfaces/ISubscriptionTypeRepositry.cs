using Data_Access_Layer.Entities;

namespace Data_Access_Layer.Repository.Interfaces
{
    public interface ISubscriptionTypeRepositry
    {
        Task<SubscriptionType?> GetSubscriptionTypeByIdAsync(int id);
        Task<SubscriptionType?> GetSubscriptionTypeByDescriptionAsync(string Description);

        IQueryable<SubscriptionType> GetAllSubscriptionTypes();
    }
}
