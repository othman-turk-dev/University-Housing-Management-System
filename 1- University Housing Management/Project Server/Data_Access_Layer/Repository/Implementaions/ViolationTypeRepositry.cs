using Data_Access_Layer.Data;
using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Data_Access_Layer.Repository.Interfaces;

namespace Data_Access_Layer.Repository.Implementaions
{
    public class ViolationTypeRepositry : IViolationTypeRepositry
    {
       
        private readonly AppDbContext _context;
        public ViolationTypeRepositry(AppDbContext context) 
            => _context = context;

        public async Task<ViolationType?> GetViolationByIdAsync(int id)
        {
            
            return await _context.ViolationTypes
                .FindAsync(id);
        }
        public async Task<ViolationType?> GetViolationByNameAsync(string name)
        {
            
            return await _context.ViolationTypes
                .FirstOrDefaultAsync(v => v.Name == name);
        }
        public async Task<bool> IsViolationTypeExistAsync(int id)
        {

            return await _context.ViolationTypes.AsNoTracking()
                .AnyAsync(v => v.ViolationTypeId == id);
        }

        public IQueryable<ViolationType> GetAll()
        {

            return _context.ViolationTypes.AsNoTracking();
        }

    }
}
