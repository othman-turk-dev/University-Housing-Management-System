using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Helpers;

namespace University_Housing_Management_Project.Services
{
    public class ViolationService
    {
        
        public async Task<ViolationDto> AddViolation(AddViolationDto violationDto)
        {
            var json = JsonConvert.SerializeObject(violationDto);

            var response = await ApiClient.PostAsync("Violations", json);

            if (!response.IsSuccessStatusCode)
                return null;

            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ViolationDto>(result);
        }
        public async Task<bool> PayFineForViolation(int violationId)
        {
            var response = await ApiClient.PutAsync($"Violations/{violationId}/pay", "");

            return response.IsSuccessStatusCode;
        }
        public async Task<bool> DeleteViolation(int violationId)
        {
            var response = await ApiClient.DeleteAsync($"Violations/{violationId}");

            return response.IsSuccessStatusCode;
        }

        public async Task<List<AllViolationsDto>> GetAllViolations()
        {
            return await ApiClient.GetFromJsonAsync<List<AllViolationsDto>>("Violations");
        }
        public async Task<List<AllViolationsDto>> FilterViolation(ViolationsFilterDto filterDto)
        {
            string query = new QueryBuilder()
                .Add("StudentName", filterDto.StudentName)
                .Add("PaymentStatus", filterDto.PaymentStatus)
                .Add("ViolationDate", filterDto.ViolationDate)
                .Add("ViolationType", filterDto.ViolationType)
                .Build();

            return await ApiClient.GetFromJsonAsync<List<AllViolationsDto>>($"Violations/Filter{query}");
        }
        public async Task<List<ViolationDetailsDto>> GetViolationDetails(string UniversityNumber)
        {
            return await ApiClient.GetFromJsonAsync<List<ViolationDetailsDto>>($"Violations/Student/{UniversityNumber}/Details");
        }

        public async Task<List<ViolationRateDto>> GetViolationStatistics()
        {
            return await ApiClient.GetFromJsonAsync<List<ViolationRateDto>>("Violations/Statistics");
        }

    }
}