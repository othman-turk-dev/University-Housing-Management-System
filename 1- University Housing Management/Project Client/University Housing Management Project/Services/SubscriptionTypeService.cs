using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;

namespace University_Housing_Management_Project.Services
{
    public class SubscriptionTypeService
    {
       
        public async Task<List<SubscriptionTypeDto>> GetAllSubscriptionTypes()
        {
            return await ApiClient.GetFromJsonAsync<List<SubscriptionTypeDto>>("SubscriptionTypes");
        }
        public async Task<SubscriptionTypeDto> GetSubscriptionTypeByDescription(string Description)
        {
            return await ApiClient.GetFromJsonAsync<SubscriptionTypeDto>($"SubscriptionTypes/Description/{Description}");
        }

    }
}