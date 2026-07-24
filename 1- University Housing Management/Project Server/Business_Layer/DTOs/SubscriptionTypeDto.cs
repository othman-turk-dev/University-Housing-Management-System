namespace Business_Layer.DTOs
{
    public class SubscriptionTypeDto
    {
        public int SubscriptionTypeId { get; set; }
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }

    }
}
