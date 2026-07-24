using Business_Layer.DTOs;
using Business_Layer.Interfaces;
using Business_Layer.DTOs.Mappers;
using Microsoft.EntityFrameworkCore;
using Data_Access_Layer.Repository.Interfaces;

namespace Business_Layer.Services
{
    public class SpecializationService : ISpecializationService
    {

        public readonly IStudentRepositry _studentRepository;
        private readonly ISpecializationRepositry _specializationRepo;
        public SpecializationService(ISpecializationRepositry specializationRepo,
            IStudentRepositry studentRepository)
        {
            _specializationRepo = specializationRepo;
            _studentRepository = studentRepository;
        }

        public async Task<IEnumerable<string>> GetAll()
        {

            return await _specializationRepo.GetAll().OrderBy(s => s.Name)
                .Select(s => s.Name).ToListAsync();
        }
        public async Task<SpecializationDto?> GetByIdAsync(int id)
        {
            
            var specialization = await _specializationRepo.GetByIdAsync(id);

            if (specialization == null) 
                return null;

            return SpecializationMapper.ToDto(specialization);
        }
        public async Task<SpecializationDto?> GetByNameAsync(string name)
        {
            var specialization = await _specializationRepo.GetByNameAsync(name);

            if (specialization == null)
                return null;

            return SpecializationMapper.ToDto(specialization);
        }
        public Task<bool> IsExistByIdAsync(int id)
        {
            return _specializationRepo.IsExistByIdAsync(id);
        }
        public async Task<IEnumerable<SpecializationStatisticsDto>> GetSpecializationStatisticsAsync()
        {

            var totalStudents = await _studentRepository
            .GetAllStudents()
            .CountAsync();

            return await _specializationRepo.GetAll()
            .AsNoTracking()
            .Select(s => new SpecializationStatisticsDto
            {
                SpecializationName = s.Name,
                StudentsCount = s.Students.Count(),
                Percentage = totalStudents == 0
                    ? 0
                    : (100.0 * s.Students.Count()) / totalStudents
            })
            .OrderByDescending(s => s.Percentage)
            .ToListAsync();

        }

    }
}
