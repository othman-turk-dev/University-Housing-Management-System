using Business_Layer.DTOs;
using Business_Layer.Interfaces;
using Data_Access_Layer.Entities;
using Business_Layer.DTOs.Mappers;
using Microsoft.EntityFrameworkCore;
using Data_Access_Layer.Repository.Interfaces;

namespace Business_Layer.Services
{
    public class StudentService : IStudentService
    {

        private readonly IStudentRepositry _studentRepository;
        public StudentService(IStudentRepositry studentRepository)
            => _studentRepository = studentRepository;

        public async Task<StudentDto?> AddStudentAsync(StudentDto student)
        {

            Student newStudent = new Student
            {
                UniversityNumber = student.UniversityNumber,
                RoomId = student.RoomId,
                FullName = student.FullName,
                Phone = student.Phone,
                GuardiansNumber = student.GuardiansNumber,
                Address = student.Address,
                AcademiclLevel = student.AcademiclLevel,
                SpecilizationId = student.SpecilizationId,
                Idphoto = student.Idphoto,
                UniversityCardPhoto = student.UniversityCardPhoto
            };

            var AddedStudent = await _studentRepository.AddStudentAsync(newStudent);

            if (AddedStudent == null)
                return null;

            return StudentMapper.ToDto(AddedStudent);
        }
        public async Task<StudentDto?> UpdateStudentAsync(StudentDto student)
        {

            var existingStudent = await _studentRepository.
                GetStudentByUniversityNumberAsync(student.UniversityNumber);

            if (existingStudent == null)
                return null;

            existingStudent.UniversityNumber = student.UniversityNumber;
            existingStudent.RoomId = student.RoomId;
            existingStudent.FullName = student.FullName;
            existingStudent.Phone = student.Phone;
            existingStudent.GuardiansNumber = student.GuardiansNumber;
            existingStudent.Address = student.Address;
            existingStudent.AcademiclLevel = student.AcademiclLevel;
            existingStudent.SpecilizationId = student.SpecilizationId;
            existingStudent.Idphoto = student.Idphoto;
            existingStudent.UniversityCardPhoto = student.UniversityCardPhoto;

            var updatedStudent = await _studentRepository
                .UpdateStudentAsync(existingStudent);

            if (updatedStudent == null)
                return null;

            return StudentMapper.ToDto(updatedStudent);
        }
        public async Task<bool> DeleteStudentAsync(string UniversityNumber)
        {

            return await _studentRepository.
                DeleteStudentAsync(UniversityNumber);
        }
        public async Task<StudentDto?> GetStudentByUniversityNumberAsync(string UniversityNumber)
        {

            var student = await _studentRepository.
                GetStudentByUniversityNumberAsync(UniversityNumber);

            return student != null ? StudentMapper.ToDto(student) : null;
        }
        public async Task<bool> IsStudentExistAsync(string UniversityNumber)
        {

            return await _studentRepository.
                IsStudentExistAsync(UniversityNumber);
        }

        public async Task<IEnumerable<StudentWithDetailsDto>> GetAllStudentsAsync()
        {

            var Students = await _studentRepository.GetAllStudents()
             .AsNoTracking()
             .Select(s => new StudentWithDetailsDto
             {
                 UniversityNumber = s.UniversityNumber,
                 FullName = s.FullName,
                 Phone = s.Phone,
                 GuardiansNumber = s.GuardiansNumber,
                 Specialization = s.Specilization.Name,
                 AcademicLevel = 
                                  (s.AcademiclLevel == 1 ? "First year"
                                 : s.AcademiclLevel == 2 ? "Second year"
                                 : s.AcademiclLevel == 3 ? "Third year"
                                 : s.AcademiclLevel == 4 ? "Fourth year"
                                 : s.AcademiclLevel == 5 ? "Fifth year"
                                 : s.AcademiclLevel == 6 ? "Sixth year"
                                 : "Seventh year"
                                  ),
                 RoomLocation = s.Room.RoomLocation
             })
             .ToListAsync();

            return Students;
        }
        public async Task<IEnumerable<StudentWithDetailsDto>> GetAllStudentsInThisRoomAsync(int roomId)
        {
            
            var Students = await _studentRepository.GetAllStudents()
             .AsNoTracking()
             .Where(s => s.RoomId == roomId)
             .Select(s => new StudentWithDetailsDto
             {
                 UniversityNumber = s.UniversityNumber,
                 FullName = s.FullName,
                 Phone = s.Phone,
                 GuardiansNumber = s.GuardiansNumber,
                 Specialization = s.Specilization.Name,
                 AcademicLevel =
                                  (s.AcademiclLevel == 1 ? "First year"
                                 : s.AcademiclLevel == 2 ? "Second year"
                                 : s.AcademiclLevel == 3 ? "Third year"
                                 : s.AcademiclLevel == 4 ? "Fourth year"
                                 : s.AcademiclLevel == 5 ? "Fifth year"
                                 : "Sixth year"
                                  ),
                 RoomLocation = s.Room.RoomLocation
             })
             .ToListAsync();

            return Students;
        }
        public async Task<int> GetNumberOfStudentsAsync()
        {

            return await _studentRepository.
                GetAllStudents().CountAsync();
        }


        public async Task<IEnumerable<StudentWithDetailsDto>> StudetFilterAsync(StudentFilterDto studentFilter)
        {

            var query = _studentRepository.GetAllStudents();


            if (!string.IsNullOrWhiteSpace(studentFilter.UniversityNumber))
                query = query.Where(s => s.UniversityNumber.Contains(studentFilter.UniversityNumber));

            if (!string.IsNullOrWhiteSpace(studentFilter.Specialization) && studentFilter.Specialization != "All")
                query = query.Where(s => s.Specilization.Name == studentFilter.Specialization);

            if (!string.IsNullOrWhiteSpace(studentFilter.Floor) && studentFilter.Floor != "All")
                query = query.Where(s => s.Room.RoomLocation.Contains(studentFilter.Floor));

            if (studentFilter.AcademiclLevel.HasValue)
                query = query.Where(s => s.AcademiclLevel == studentFilter.AcademiclLevel.Value);
            
            return await query.Select(s => new StudentWithDetailsDto
            {
                UniversityNumber = s.UniversityNumber,
                FullName = s.FullName,
                Phone = s.Phone,
                GuardiansNumber = s.GuardiansNumber,
                Specialization = s.Specilization.Name,
                AcademicLevel =
                                  (s.AcademiclLevel == 1 ? "First year"
                                 : s.AcademiclLevel == 2 ? "Second year"
                                 : s.AcademiclLevel == 3 ? "Third year"
                                 : s.AcademiclLevel == 4 ? "Fourth year"
                                 : s.AcademiclLevel == 5 ? "Fifth year"
                                 : "Sixth year"
                                  ),
                RoomLocation = s.Room.RoomLocation
            })
             .ToListAsync();

        }

    }
}
