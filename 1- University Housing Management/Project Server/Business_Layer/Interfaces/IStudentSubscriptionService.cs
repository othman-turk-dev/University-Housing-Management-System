using Business_Layer.DTOs;

namespace Business_Layer.Interfaces
{
    public interface IStudentSubscriptionService
    {

        Task<bool> AddStudentSubscriptionAsync(string studentId, int subscriptionTypeId);
        Task<bool> IsStudentSubscriptionExistAsync(string UniversityNumber);
        Task<bool> DeactivateExpiredSubscriptionsAsync();
        Task<bool> RenewSubscriptionAsync(string UniversityNumber,
            int subscriptionTypeId, decimal latePenalty);
        Task<IEnumerable<AllSubscriptionsDto>> GetAllSubscriptionsAsync();
        Task<IEnumerable<AllSubscriptionsDto>> GetAllActiveSubscriptionsAsync();

        Task<IEnumerable<AllSubscriptionsDto>>
            SubscriptionsFilterAsync(SubscriptionsFilterDto subscriptionsFilter);


    }
}
