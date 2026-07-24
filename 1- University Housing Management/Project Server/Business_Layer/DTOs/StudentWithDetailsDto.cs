namespace Business_Layer.DTOs
{
    public class StudentWithDetailsDto
    {
        public string UniversityNumber { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string GuardiansNumber { get; set; } = null!;
        public string Specialization { get; set; } = null!;
        public string AcademicLevel { get; set; } = null!;
        public string RoomLocation { get; set; } = null!;
    }
}
