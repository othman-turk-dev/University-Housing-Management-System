using Business_Layer.DTOs;

namespace Business_Layer.Interfaces
{
    public interface IViolationService
    {

        Task<ViolationDto?> AddViolationAsync(AddViolationDto violation);
        Task<ViolationDto?> GetViolationByIdAsync(int ViolationId);
        Task<bool> DeleteViolationAsync(int ViolationId);
        Task<bool> IsViolationExistAsync(int id);
        Task<bool> PayFineForViolationAsync(int ViolationId);
        Task<IEnumerable<AllViolationsDto>> GetAllViolationsAsync();
        Task<IEnumerable<ViolationDetailsDto>> GetViolationDetailsAsync(string UniversityNumber);
        Task<IEnumerable<ViolationRateDto>> GetStatisticsForViolationsAsync();

        Task<IEnumerable<AllViolationsDto>> ViolationsFilterAsync(ViolationsFilterDto violationsFilter);
    }
}
