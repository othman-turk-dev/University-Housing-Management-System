using Data_Access_Layer.Entities;

namespace Data_Access_Layer.Repository.Interfaces
{
    public interface IStudentSubscriptionRepositry
    {
        Task<StudentSubscription> AddNewStudentSubscriptionAsync(StudentSubscription studentSubscription);
        Task<StudentSubscription> UpdateStudentSubscriptionAsync(StudentSubscription studentSubscription);
        Task<StudentSubscription?> GetStudentSubscriptionByIdAsync(string UniversityNumber);
        Task<bool> IsStudentSubscriptionExistAsync(string UniversityNumber);
        Task<int> DeactivateExpiredSubscriptionsAsync();
        IQueryable<StudentSubscription> GetAllStudentSubscriptions();

    }
}



