namespace Business_Layer.DTOs
{
    public class AllSubscriptionsDto
    {
        public string UniversityNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string RoomLocation { get; set; } = null!;
        public string SubscriptionType { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
