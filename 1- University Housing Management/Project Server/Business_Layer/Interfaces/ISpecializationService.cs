using Business_Layer.DTOs;

namespace Business_Layer.Interfaces
{
    public interface ISpecializationService
    {

        Task<SpecializationDto?> GetByIdAsync(int id);
        Task<SpecializationDto?> GetByNameAsync(string name);
        Task <bool> IsExistByIdAsync(int id);
        Task<IEnumerable<string>> GetAll();
        Task<IEnumerable<SpecializationStatisticsDto>> GetSpecializationStatisticsAsync();

    }
}
