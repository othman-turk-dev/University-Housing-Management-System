using Data_Access_Layer.Entities;

namespace Data_Access_Layer.Repository.Interfaces
{
    public interface IViolationRepositry
    {

        Task<Violation> AddViolationAsync(Violation violation);
        Task<Violation> UpdateViolationAsync(Violation violation);
        Task<Violation?> GetViolationByIdAsync(int ViolationID);
        Task<bool> DeleteViolationAsync(int ViolationID);
        Task<bool> IsViolationExistAsync(int id);
        IQueryable<Violation> GetAllViolations();

    }
}
