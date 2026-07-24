using Data_Access_Layer.Entities;

namespace Business_Layer.DTOs.Mappers
{
    public static class SubscriptionTypeMapper
    {

        public static SubscriptionTypeDto ToDto(SubscriptionType subscriptionType)
            => new SubscriptionTypeDto
            {
                SubscriptionTypeId = subscriptionType.SubscriptionTypeId,
                Description = subscriptionType.Description,
                Price = subscriptionType.Price,
            };

    }
}
