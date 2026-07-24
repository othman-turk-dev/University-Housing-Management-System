using Data_Access_Layer.Entities;

namespace Data_Access_Layer.Repository.Interfaces
{
    public interface IViolationTypeRepositry
    {

        Task<ViolationType?> GetViolationByIdAsync(int id);
        Task<ViolationType?> GetViolationByNameAsync(string name);
        Task<bool> IsViolationTypeExistAsync(int id);
        IQueryable <ViolationType> GetAll();

    }
}
