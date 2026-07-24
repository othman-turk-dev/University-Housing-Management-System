using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;

namespace University_Housing_Management_Project.Services
{
    public class SpecializationService
    {
        public async Task<List<SpecializationStatisticsDto>> GetSpecializationStatistics()
        {
            return await ApiClient.GetFromJsonAsync<List<SpecializationStatisticsDto>>("Specializations/Statistics");
        }
        public async Task<List<string>> GetAllSpecializations()
        {
            return await ApiClient.GetFromJsonAsync<List<string>>("Specializations");
        }
        public async Task<SpecializationDto> GetSpecializationById(int Id)
        {
            return await ApiClient.GetFromJsonAsync<SpecializationDto>($"Specializations/{Id}");
        }
        public async Task<SpecializationDto> GetSpecializationByName(string Name)
        {
            return await ApiClient.GetFromJsonAsync<SpecializationDto>($"Specializations/Name/{Name}");
        }

    }
}