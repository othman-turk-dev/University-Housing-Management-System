using Business_Layer.Authorization;
using Business_Layer.DTOs;
using Business_Layer.Global.Enums;
using Business_Layer.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace University_Housing_Management_Project.Controllers
{

    [Authorize]
    [ApiController]
    [Route("api/Students")]
    [EnableRateLimiting("ApiLimiter")]
    [Permission(UserPermission.StudentManagement)]
    public class StudentsController : ControllerBase
    {

        private readonly IRoomService _roomService;
        private readonly IStudentService _studentService;
        private readonly ISpecializationService _specializationService;
        public StudentsController(IStudentService studentService,
            IRoomService roomService, ISpecializationService specializationService)
        {
            _studentService = studentService;
            _roomService = roomService;
            _specializationService = specializationService;
        }


        private async Task<ActionResult?> ValidateStudent(StudentDto student)
        {
            if (student == null ||
                string.IsNullOrWhiteSpace(student.UniversityNumber) ||
                string.IsNullOrWhiteSpace(student.FullName) ||
                string.IsNullOrWhiteSpace(student.Phone) ||
                string.IsNullOrWhiteSpace(student.GuardiansNumber) ||
                string.IsNullOrWhiteSpace(student.Address))
            {
                return BadRequest("Student data is invalid.");
            }

            if (student.AcademiclLevel < 1 || student.AcademiclLevel > 6)
                return BadRequest("Academic level must be between 1 and 6.");

            if (student.RoomId <= 0)
                return BadRequest("Invalid room ID.");

            if (!await _roomService.IsRoomExistAsync(student.RoomId))
                return NotFound($"Room with ID {student.RoomId} not found.");

            if (student.SpecilizationId <= 0)
                return BadRequest("Invalid specialization ID.");

            if (!await _specializationService.IsExistByIdAsync(student.SpecilizationId))
                return NotFound($"Specialization with ID {student.SpecilizationId} not found.");

            if (!student.Phone.All(char.IsDigit))
                return BadRequest("Phone number must contain only digits.");

            if (!student.GuardiansNumber.All(char.IsDigit))
                return BadRequest("Guardian's phone number must contain only digits.");

            return null;
        }

        
        [HttpPost()]
        public async Task<ActionResult<StudentDto>> AddStudent([FromBody] StudentDto student)
        {

            var validationResult = await ValidateStudent(student);

            if (validationResult != null) 
                return validationResult;

            if ( await _studentService.IsStudentExistAsync(student.UniversityNumber))
                return BadRequest("Student with the same university number already exists.");

            var addedStudent = await _studentService.AddStudentAsync(student);

            if (addedStudent == null)
                return BadRequest("Failed to add the student.");

            return CreatedAtRoute("GetStudentByUniversityNumber", new { universityNumber = addedStudent.UniversityNumber }, addedStudent);
        }


        [HttpPut()]
        public async Task<ActionResult<StudentDto>> UpdateStudent([FromBody] StudentDto student)
        {

            var validationResult = await ValidateStudent(student);

            if (validationResult != null)
                return validationResult;

            if (!await _studentService.IsStudentExistAsync(student.UniversityNumber))
                return NotFound($"Student with university number {student.UniversityNumber} not found.");

            var updatedStudent = await _studentService.UpdateStudentAsync(student);

            if (updatedStudent == null)
                return NotFound($"Student with university number {student.UniversityNumber} update failed.");

            return Ok(updatedStudent);
        }


        [HttpDelete("{universityNumber}")]
        public async Task<IActionResult> DeleteStudent(string universityNumber)
        {
            if (string.IsNullOrWhiteSpace(universityNumber))
                return BadRequest("Invalid university number.");

            if (!await _studentService.IsStudentExistAsync(universityNumber))
                return NotFound($"Student with university number {universityNumber} not found.");

            var result = await _studentService.DeleteStudentAsync(universityNumber);

            if (!result)
                return NotFound($"Student with university number {universityNumber} deletion failed.");

            return NoContent();

        }


        [HttpGet("{universityNumber}", Name = "GetStudentByUniversityNumber")]
        public async Task<ActionResult<StudentDto>> GetStudentByUniversityNumber(string universityNumber)
        {

            if (string.IsNullOrWhiteSpace(universityNumber))
                return BadRequest("Invalid university number.");

            var student = await _studentService.GetStudentByUniversityNumberAsync(universityNumber);

            if (student == null)
                return NotFound($"Student with university number {universityNumber} not found.");

            return Ok(student);
        }


        [HttpGet("IsExist/{universityNumber}")]
        public async Task<ActionResult<bool>> IsStudentExist(string universityNumber)
        {

            if (string.IsNullOrWhiteSpace(universityNumber))
                return BadRequest("Invalid university number.");

            var exists = await _studentService.IsStudentExistAsync(universityNumber);

            if (!exists)
                return NotFound($"Student with university number {universityNumber} not found.");

            return Ok(exists);
        }


        [HttpGet("Filter")]
        public async Task<ActionResult<IEnumerable<StudentWithDetailsDto>>> 
            StudentsFilter([FromQuery]StudentFilterDto studentFilter)
        {

            if (studentFilter.AcademiclLevel.HasValue && studentFilter.AcademiclLevel <= 0)
                return BadRequest("Student data is invalid.");

            return Ok(await _studentService.StudetFilterAsync(studentFilter));
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<StudentWithDetailsDto>>> GetAllStudents()
        {

            return Ok(await _studentService.GetAllStudentsAsync());
        }


        [HttpGet("Room/{roomId}")]
        public async Task<ActionResult<IEnumerable<StudentWithDetailsDto>>> GetAllStudentsInThisRoom(int roomId)
        {

            if (roomId <= 0)
                return BadRequest("Room ID must be a positive integer.");

            if (!await _roomService.IsRoomExistAsync(roomId))
                return NotFound($"Room with ID {roomId} not found.");

            return Ok(await _studentService.GetAllStudentsInThisRoomAsync(roomId));
        }


        [AllowAnonymous]
        [HttpGet("Number")]
        public async Task<ActionResult<int>> GetNumberOfStudents()
        {
            return Ok(await _studentService.GetNumberOfStudentsAsync());

        }
    
    }
}
