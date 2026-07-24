namespace Business_Layer.DTOs
{
    public class ViolationTypeDto
    {
        public int ViolationTypeId { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal PenaltyAmount { get; set; }
    }
}
