using Data_Access_Layer.Data;
using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Data_Access_Layer.Repository.Interfaces;

namespace Data_Access_Layer.Repository.Implementaions
{
    public class StudentRepositry : IStudentRepositry
    {
        private readonly AppDbContext _context;
        public StudentRepositry(AppDbContext context) => _context = context;

        public async Task<Student> AddStudentAsync(Student student)
        {

            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
            
            return student;
        }
        public async Task<Student> UpdateStudentAsync(Student student)
        {
            
            _context.Students.Update(student);
            await _context.SaveChangesAsync();

            return student;
        }
        public async Task<bool> DeleteStudentAsync(string universityNumber)
        {
            
           var existingStudent = await _context.Students
                .FindAsync(universityNumber);
            
            if (existingStudent == null)
                return false; 

            _context.Students.Remove(existingStudent);
            await _context.SaveChangesAsync();
            
            return true; 
        }
        public async Task<Student?> GetStudentByUniversityNumberAsync(string universityNumber)
        {
            return await _context.Students.
                FindAsync(universityNumber);
        }
        public async Task<bool> IsStudentExistAsync(string universityNumber)
        {

            return await _context.Students.AsNoTracking().
                AnyAsync(s => s.UniversityNumber == universityNumber);
        }
        public IQueryable<Student> GetAllStudents()
        {

            return _context.Students.AsNoTracking();
        }

    }
}
