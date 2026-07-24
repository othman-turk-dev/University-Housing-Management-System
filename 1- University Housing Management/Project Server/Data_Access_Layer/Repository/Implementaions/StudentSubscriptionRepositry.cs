using Data_Access_Layer.Data;
using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Data_Access_Layer.Repository.Interfaces;

namespace Data_Access_Layer.Repository.Implementaions
{
    public class StudentSubscriptionRepositry : IStudentSubscriptionRepositry
    {

        private readonly AppDbContext _context;
        public StudentSubscriptionRepositry(AppDbContext context)
            => _context = context;

        
        public async Task<StudentSubscription> AddNewStudentSubscriptionAsync(StudentSubscription studentSubscription)
        {
            
            await _context.StudentSubscriptions.AddAsync(studentSubscription);
            await _context.SaveChangesAsync();

            return studentSubscription;
        }
        public async Task<StudentSubscription> UpdateStudentSubscriptionAsync(StudentSubscription studentSubscription)
        {
            
            _context.StudentSubscriptions.Update(studentSubscription);
            await _context.SaveChangesAsync();

            return studentSubscription;
        }
        public async Task<StudentSubscription?> GetStudentSubscriptionByIdAsync(string UniversityNumber)
        {

            return await _context.StudentSubscriptions.Include(s => s.Subscription)
                .FirstOrDefaultAsync(s => s.StudentId == UniversityNumber);
        }
        public async Task<bool> IsStudentSubscriptionExistAsync(string UniversityNumber)
        {

            return await _context.StudentSubscriptions
                .AnyAsync(s => s.StudentId == UniversityNumber);
        }
        public async Task<int> DeactivateExpiredSubscriptionsAsync()
        {
            
            return await _context.StudentSubscriptions
                .Where(s => s.IsActive &&
                            s.EndDate < DateTime.UtcNow)
                .ExecuteUpdateAsync(setters => setters
                    .SetProperty(s => s.IsActive, false));
        }

        public IQueryable<StudentSubscription> GetAllStudentSubscriptions()
        {
            return _context.StudentSubscriptions.AsNoTracking();
        }


    }
}
