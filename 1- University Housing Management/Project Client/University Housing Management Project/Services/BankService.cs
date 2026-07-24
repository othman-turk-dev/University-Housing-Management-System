using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Helpers;

namespace University_Housing_Management_Project.Services
{
    public class BankService
    {

        public async Task<List<StudentOperationsDto>> GetAllStudentOperations()
        {
            return await ApiClient.GetFromJsonAsync<List<StudentOperationsDto>>("Bank/StudentOperations");
        }
        public async Task<List<StudentOperationsDto>> GetAllStudentOperationsInThisMonth()
        {
            return await ApiClient.GetFromJsonAsync<List<StudentOperationsDto>>("Bank/StudentOperations/ThisMonth");
        }
        public async Task<List<StudentOperationsDto>> FilterStudentOperations(StudentOperationsFilterDto filterDto)
        {
            string query = new QueryBuilder()
                .Add("StudentName", filterDto.StudentName)
                .Add("OperationDate", filterDto.OperationDate)
                .Add("OperationType", filterDto.OperationType)
                .Build();

            return await ApiClient.GetFromJsonAsync<List<StudentOperationsDto>>($"Bank/StudentOperations/Filter{query}");
        }

        public async Task<List<StoreOperationsDto>> GetAllStoreOperations()
        {
            return await ApiClient.GetFromJsonAsync<List<StoreOperationsDto>>("Bank/StoreOperations");
        }
        public async Task<List<StoreOperationsDto>> GetAllStoreOperationsInThisMonth()
        {
            return await ApiClient.GetFromJsonAsync<List<StoreOperationsDto>>("Bank/StoreOperations/ThisMonth");
        }
        public async Task<List<StoreOperationsDto>> FilterStoreOperations(StoreOperationsFilterDto filterDto)
        {
            string query = new QueryBuilder()
                .Add("OperationDate", filterDto.OperationDate)
                .Add("OperationType", filterDto.OperationType)
                .Build();

            return await ApiClient.GetFromJsonAsync<List<StoreOperationsDto>>($"Bank/StoreOperations/Filter{query}");
        }

    }
}
