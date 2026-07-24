namespace Business_Layer.DTOs
{
    public class ViolationDetailsDto
    {
        public string Violation { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Fine { get; set; }
        public int NumberOfViolations { get; set; }

    }
}
