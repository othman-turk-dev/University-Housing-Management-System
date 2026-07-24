namespace University_Housing_Management_Project.DTOs
{
    public class ViolationDto
    {
        public int ViolationId { get; set; }
        public string StudentId { get; set; }
        public int ViolationTypeId { get; set; }
        public decimal Fine { get; set; }
        public bool IsPaid { get; set; }
        public int CreatedByUserId { get; set; }

    }
}
