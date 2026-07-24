using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;

namespace University_Housing_Management_Project.Services
{
    public class ViolationTypeService
    {

        public async Task<List<ViolationTypeDto>> GetAllViolationTypes()
        {
            return await ApiClient.GetFromJsonAsync<List<ViolationTypeDto>>("ViolationTypes");
        }
        public async Task<ViolationTypeDto> GetViolationTypeByName(string Name)
        {
            return await ApiClient.GetFromJsonAsync<ViolationTypeDto>($"ViolationTypes/Name/{Name}");
        }

    }
}