using Business_Layer.DTOs;
using Business_Layer.Interfaces;
using Business_Layer.DTOs.Mappers;
using Microsoft.EntityFrameworkCore;
using Data_Access_Layer.Repository.Interfaces;

namespace Business_Layer.Services
{
    public class ViolationTypeService : IViolationTypeService
    {
        
        private readonly IViolationTypeRepositry _violationTypeRepositry;
        public ViolationTypeService(IViolationTypeRepositry violationTypeRepositry)
        => _violationTypeRepositry = violationTypeRepositry;


        public async Task<ViolationTypeDto?> GetViolationTypeByIdAsync(int id)
        {
            
            var violationType = await _violationTypeRepositry.GetViolationByIdAsync(id);

            return violationType != null ? ViolationTypeMapper.ToDto(violationType) : null;
        }
        public async Task<ViolationTypeDto?> GetViolationTypeByNameAsync(string name)
        {

            var violationType = await _violationTypeRepositry.GetViolationByNameAsync(name);
            
            return violationType != null ? ViolationTypeMapper.ToDto(violationType) : null;
        }
        public async Task<bool> IsViolationTypeExistAsync(int id)
        {

            return await _violationTypeRepositry.
                IsViolationTypeExistAsync(id);
        }

        public async Task<IEnumerable<ViolationTypeDto>> GetAllAsync()
        {
            
            return await _violationTypeRepositry.GetAll()
                .Select(r => ViolationTypeMapper.ToDto(r))
                .ToListAsync();
        }

    }
}
