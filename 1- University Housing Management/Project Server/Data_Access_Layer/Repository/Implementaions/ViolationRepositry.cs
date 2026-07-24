using Data_Access_Layer.Data;
using Data_Access_Layer.Entities;
using Data_Access_Layer.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data_Access_Layer.Repository.Implementaions
{
    public class ViolationRepositry : IViolationRepositry
    {

        private readonly AppDbContext _context;
        public ViolationRepositry(AppDbContext context)
            => _context = context;


        public async Task<Violation> AddViolationAsync(Violation violation)
        {
            
            await _context.AddAsync(violation);
            await _context.SaveChangesAsync();

            return violation;
        }
        public async Task<Violation> UpdateViolationAsync(Violation violation)
        {
            
            _context.Violations.Update(violation);
            await _context.SaveChangesAsync();

            return violation;
        }
        public async Task<bool> DeleteViolationAsync(int ViolationID)
        {
            
            var violation = await _context.Violations.FindAsync(ViolationID);

            if (violation != null)
            {

                _context.Violations.Remove(violation);
                await _context.SaveChangesAsync();

                return true;
            }

            return false;
        }
        public async Task<Violation?> GetViolationByIdAsync(int ViolationID)
        {
            
            return await _context.Violations
                .FindAsync(ViolationID);
        }
        public async Task<bool> IsViolationExistAsync(int id)
        {

            return await _context.Violations.AsNoTracking().
                AnyAsync(v => v.ViolationId == id);
        }

        public IQueryable<Violation> GetAllViolations()
        {
            return _context.Violations.AsQueryable();
        }

    }
}
