using Data_Access_Layer.Data;
using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Data_Access_Layer.Repository.Interfaces;

namespace Data_Access_Layer.Repository.Implementaions
{
    public class SpecializationRepositry : ISpecializationRepositry
    {

        private readonly AppDbContext _context;
        public SpecializationRepositry(AppDbContext context) => _context = context;

        public async Task<Specialization?> GetByIdAsync(int id)
        {
            
            return await _context.Specializations.FindAsync(id);
        }
        public async Task<Specialization?> GetByNameAsync(string name)
        {
            
            return await _context.Specializations.
                FirstOrDefaultAsync(s => s.Name == name);
        }
        public async Task<bool> IsExistByIdAsync(int id)
        {
            return await _context.Specializations.
                AsNoTracking().AnyAsync(s => s.SpecializationId == id);
        }
        public IQueryable<Specialization> GetAll()
        {
            
            return _context.Specializations.AsNoTracking();
        }

    }
}
