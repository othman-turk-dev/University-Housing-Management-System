using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Helpers;

namespace University_Housing_Management_Project.Services
{
    public class StudentService
    {

        public async Task<StudentDto> AddStudent(StudentDto student)
        {
            var json = JsonConvert.SerializeObject(student);

            // 🟢 تمرير json مباشرة لحل مشكلة ObjectDisposedException
            var response = await ApiClient.PostAsync("Students", json);

            if (!response.IsSuccessStatusCode)
                return null;

            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<StudentDto>(result);
        }
        public async Task<StudentDto> UpdateStudent(StudentDto student)
        {
            var json = JsonConvert.SerializeObject(student);

            var response = await ApiClient.PutAsync("Students", json);

            if (!response.IsSuccessStatusCode)
                return null;

            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<StudentDto>(result);
        }
        public async Task<bool> DeleteStudent(string universityNumber)
        {
            var response = await ApiClient.DeleteAsync($"Students/{universityNumber}");
            return response.IsSuccessStatusCode;
        }

        public async Task<int?> GetStudentCountAsync()
        {
            return await ApiClient.GetFromJsonAsync<int?>("Students/Number");
        }
        public async Task<StudentDto> FindByUniversityNumber(string UniversityNumber)
        {
            return await ApiClient.GetFromJsonAsync<StudentDto>($"Students/{UniversityNumber}");
        }
        public async Task<bool> IsStudentExist(string UniversityNumber)
        {
            return await ApiClient.GetFromJsonAsync<bool>($"Students/IsExist/{UniversityNumber}");
        }

        public async Task<List<StudentWithDetailsDto>> GetAllStudents()
        {
            return await ApiClient.GetFromJsonAsync<List<StudentWithDetailsDto>>("Students");
        }
        public async Task<List<StudentWithDetailsDto>> StudentsFilter(StudentFilterDto filterDto)
        {
            string query = new QueryBuilder()
                .Add("UniversityNumber", filterDto.UniversityNumber)
                .Add("Floor", filterDto.Floor)
                .Add("Specialization", filterDto.Specialization)
                .Add("AcademiclLevel", filterDto.AcademiclLevel)
                .Build();

            return await ApiClient.GetFromJsonAsync<List<StudentWithDetailsDto>>($"Students/Filter{query}");
        }

    }
}