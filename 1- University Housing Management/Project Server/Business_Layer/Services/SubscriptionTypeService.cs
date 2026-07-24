using Business_Layer.DTOs;
using Business_Layer.Interfaces;
using Business_Layer.DTOs.Mappers;
using Microsoft.EntityFrameworkCore;
using Data_Access_Layer.Repository.Interfaces;

namespace Business_Layer.Services
{
    public class SubscriptionTypeService: ISubscriptionTypeService
    {

        private readonly ISubscriptionTypeRepositry _subscriptionTypeRepositry;

        public SubscriptionTypeService(ISubscriptionTypeRepositry subscriptionTypeRepositry)
            => _subscriptionTypeRepositry = subscriptionTypeRepositry;

        public async Task<SubscriptionTypeDto?> GetSubscriptionTypeByIdAsync(int id)
        {

            var SubscriptionType = await _subscriptionTypeRepositry
                .GetSubscriptionTypeByIdAsync(id);

            return SubscriptionType == null ? null :
                SubscriptionTypeMapper.ToDto(SubscriptionType);
        }
        public async Task<SubscriptionTypeDto?> GetSubscriptionTypeByDescriptionAsync(string Description)
        {

            var SubscriptionType = await _subscriptionTypeRepositry
                .GetSubscriptionTypeByDescriptionAsync(Description);

            return SubscriptionType == null ? null :
                SubscriptionTypeMapper.ToDto(SubscriptionType);
        }
        public async Task<IEnumerable<SubscriptionTypeDto>> GetAllSubscriptionTypesAsync()
        {

            return await _subscriptionTypeRepositry.GetAllSubscriptionTypes().
                Select(s => SubscriptionTypeMapper.ToDto(s))
                .ToListAsync();

        }

    }
}
