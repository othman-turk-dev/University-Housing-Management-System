namespace Business_Layer.DTOs
{
    public class SubscriptionsFilterDto
    {
        public string? SubscriptionType { get; set; }
        public string? SubscriptionStatus { get; set; }
        public string? NearestOrFurthestDate { get; set; }
        public string? StudentName { get; set; }
    }
}
