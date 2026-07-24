namespace Business_Layer.DTOs
{
    public class StudentDto
    {
        public string UniversityNumber { get; set; } = null!;

        public int RoomId { get; set; }

        public string FullName { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string GuardiansNumber { get; set; } = null!;

        public string Address { get; set; } = null!;

        public byte AcademiclLevel { get; set; }

        public int SpecilizationId { get; set; }

        public string? Idphoto { get; set; }

        public string? UniversityCardPhoto { get; set; }

    }
}
