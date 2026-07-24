using Business_Layer.DTOs;

namespace Business_Layer.Interfaces
{
    public interface IViolationTypeService
    {

        Task<ViolationTypeDto?> GetViolationTypeByIdAsync(int id);
        Task<ViolationTypeDto?> GetViolationTypeByNameAsync(string name);
        Task<bool> IsViolationTypeExistAsync(int id);
        Task <IEnumerable<ViolationTypeDto>> GetAllAsync();


    }
}
