using Data_Access_Layer.Entities;

namespace Data_Access_Layer.Repository.Interfaces
{
    public interface IStudentRepositry
    {

        Task<Student> AddStudentAsync(Student student);
        Task<Student> UpdateStudentAsync(Student student);
        Task<bool> DeleteStudentAsync(string universityNumber);
        Task<Student?> GetStudentByUniversityNumberAsync(string universityNumber);
        Task <bool> IsStudentExistAsync(string universityNumber);
        IQueryable<Student> GetAllStudents();

    }

}
