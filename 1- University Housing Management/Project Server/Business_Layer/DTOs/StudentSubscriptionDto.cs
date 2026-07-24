namespace Business_Layer.DTOs
{
    public class StudentSubscriptionDto
    {
        public int StudentSubscriptionId { get; set; }
        public string StudentId { get; set; } = null!;
        public int SubscriptionId { get; set; }
        public DateTime EndDate { get; set; }
    }
}
