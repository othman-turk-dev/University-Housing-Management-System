using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Helpers;

namespace University_Housing_Management_Project.Services
{
    public class SubscriptionService
    {

        public async Task<bool> AddStudentSubscription(string universityNumber, int subscriptionTypeId)
        {
            var query = new QueryBuilder()
                .Add("UniversityNumber", universityNumber)
                .Add("subscriptionTypeId", subscriptionTypeId);

            var response = await ApiClient.PostAsync("StudentSubscriptions" + query.Build(), "");

            return response.IsSuccessStatusCode;
        }
        public async Task<bool> RenewSubscription(string universityNumber, int subscriptionTypeId, decimal latePenalty)
        {
            var query = new QueryBuilder()
                .Add("UniversityNumber", universityNumber)
                .Add("subscriptionTypeId", subscriptionTypeId)
                .Add("latePenalty", latePenalty);

            var response = await ApiClient.PutAsync("StudentSubscriptions/Renew" + query.Build(), "");

            return response.IsSuccessStatusCode;
        }
        public async Task<bool> DeactivateExpiredSubscriptions()
        {
            var response = await ApiClient.PutAsync("StudentSubscriptions/DeactivateExpired", "");

            if (!response.IsSuccessStatusCode)
                return false;

            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<bool>(result);
        }
        public async Task<bool> IsStudentSubscriptionExist(string UniversityNumber)
        {
            return await ApiClient.GetFromJsonAsync<bool>($"StudentSubscriptions/IsExist/{UniversityNumber}");
        }

        public async Task<List<AllSubscriptionsDto>> GetAllSubscriptions()
        {
            return await ApiClient.GetFromJsonAsync<List<AllSubscriptionsDto>>("StudentSubscriptions");
        }
        public async Task<List<AllSubscriptionsDto>> GetAllActiveSubscriptions()
        {
            return await ApiClient.GetFromJsonAsync<List<AllSubscriptionsDto>>("StudentSubscriptions/Active");
        }
        public async Task<List<AllSubscriptionsDto>> StudentSubscriptionsFilter(SubscriptionsFilterDto filterDto)
        {
            string query = new QueryBuilder()
                .Add("StudentName", filterDto.StudentName)
                .Add("SubscriptionStatus", filterDto.SubscriptionStatus)
                .Add("NearestOrFurthestDate", filterDto.NearestOrFurthestDate)
                .Add("SubscriptionType", filterDto.SubscriptionType)
                .Build();

            return await ApiClient.GetFromJsonAsync<List<AllSubscriptionsDto>>($"StudentSubscriptions/Filter{query}");
        }

    }
}