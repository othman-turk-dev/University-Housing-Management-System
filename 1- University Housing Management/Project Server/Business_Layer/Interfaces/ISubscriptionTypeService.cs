using Business_Layer.DTOs;

namespace Business_Layer.Interfaces
{
    public interface ISubscriptionTypeService
    {

        Task<SubscriptionTypeDto?> GetSubscriptionTypeByIdAsync(int id);
        Task<SubscriptionTypeDto?> GetSubscriptionTypeByDescriptionAsync(string Description);
        Task<IEnumerable<SubscriptionTypeDto>> GetAllSubscriptionTypesAsync();
    
    }
}
