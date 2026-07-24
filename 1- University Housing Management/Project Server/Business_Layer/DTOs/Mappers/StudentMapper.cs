using Data_Access_Layer.Entities;

namespace Business_Layer.DTOs.Mappers
{
    public static class StudentMapper
    {

        public static StudentDto ToDto(Student student)
        {
            return new StudentDto
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
        }

        public static Student ToEntity(StudentDto studentDto)
        {
            return new Student
            {
                UniversityNumber = studentDto.UniversityNumber,
                RoomId = studentDto.RoomId,
                FullName = studentDto.FullName,
                Phone = studentDto.Phone,
                GuardiansNumber = studentDto.GuardiansNumber,
                Address = studentDto.Address,
                AcademiclLevel = studentDto.AcademiclLevel,
                SpecilizationId = studentDto.SpecilizationId,
                Idphoto = studentDto.Idphoto,
                UniversityCardPhoto = studentDto.UniversityCardPhoto
            };
        }


    }
}
