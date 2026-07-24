using Business_Layer.DTOs;

namespace Business_Layer.Interfaces
{
    public interface IBankService
    {

        Task<IEnumerable<StudentOperationsDto>> GetAllStudentOperationsAsync();
        Task<IEnumerable<StoreOperationsDto>> GetAllStoreOperationsAsync();


        Task<IEnumerable<StudentOperationsDto>> StudentOperationsFilterAsync(StudentOperationsFilterDto filterDto);
        Task<IEnumerable<StoreOperationsDto>> StoreOperationsFilterAsync(StoreOperationsFilterDto filterDto);


        Task<IEnumerable<StudentOperationsDto>> GetAllStudentOperationsInThisMonthAsync();
        Task<IEnumerable<StoreOperationsDto>> GetAllStoreOperationsInThisMonthAsync();
    }
}
