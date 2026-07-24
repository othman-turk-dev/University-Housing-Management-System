namespace Business_Layer.DTOs
{
    public class ViolationRateDto
    {
        public string ViolationName { get; set; } = null!;
        public int StudentsHaveViolations { get; set; }
        public decimal ViolationRate { get; set; }
    }
}
