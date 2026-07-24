namespace University_Housing_Management_Project.DTOs
{
    public class ViolationTypeDto
    {
        public int ViolationTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal PenaltyAmount { get; set; }
    }
}
