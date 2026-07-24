using Business_Layer.DTOs;

namespace Business_Layer.Interfaces
{
    public interface IStudentService
    {

        Task<StudentDto?> AddStudentAsync(StudentDto student);  
        Task<StudentDto?> UpdateStudentAsync(StudentDto student);
        Task<bool> DeleteStudentAsync(string UniversityNumber);
        Task<StudentDto?> GetStudentByUniversityNumberAsync(string UniversityNumber);
        Task<bool> IsStudentExistAsync(string UniversityNumber);

        Task<IEnumerable<StudentWithDetailsDto>> StudetFilterAsync(StudentFilterDto studentFilter);
        Task<IEnumerable<StudentWithDetailsDto>> GetAllStudentsAsync();
        Task<IEnumerable<StudentWithDetailsDto>> GetAllStudentsInThisRoomAsync(int roomId);
        Task<int> GetNumberOfStudentsAsync();
    }
}
