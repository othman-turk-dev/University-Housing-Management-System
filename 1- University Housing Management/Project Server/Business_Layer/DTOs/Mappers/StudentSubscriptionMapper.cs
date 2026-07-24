using Data_Access_Layer.Entities;

namespace Business_Layer.DTOs.Mappers
{
    public static class StudentSubscriptionMapper
    {

        public static StudentSubscriptionDto ToDto(StudentSubscription studentSubscription)
            => new StudentSubscriptionDto
            {
                
                StudentId = studentSubscription.StudentId,
                StudentSubscriptionId = studentSubscription.StudentSubscriptionId,
                EndDate = studentSubscription.EndDate,
                SubscriptionId = studentSubscription.SubscriptionId 
            };

    }
}
