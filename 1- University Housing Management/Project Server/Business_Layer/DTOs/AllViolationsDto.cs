namespace Business_Layer.DTOs
{
    public class AllViolationsDto
    {
        public int ViolationId {  get; set; }
        public string ViolationType { get; set; } = null!;
        public string Student { get; set; } = null!;
        public string UniversityNumber { get; set; } = null!;
        public string IsPaid { get; set; } = null!;
        public decimal Fine {  get; set; }
        public DateTime Date {  get; set; }
        public string CreatedByUser { get; set; } = null!;

    }
}
