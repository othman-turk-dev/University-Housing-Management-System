namespace Business_Layer.DTOs
{
    public class ViolationDto
    {
        public int ViolationId { get; set; }
        public string StudentId { get; set; } = null!;
        public int ViolationTypeId { get; set; }
        public decimal Fine { get; set; }
        public bool IsPaid { get; set; }
        public int CreatedByUserId { get; set; }

    }
}
