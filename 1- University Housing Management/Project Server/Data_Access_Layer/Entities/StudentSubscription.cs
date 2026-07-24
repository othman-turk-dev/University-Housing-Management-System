namespace Data_Access_Layer.Entities;

public class StudentSubscription
{
    public int StudentSubscriptionId { get; set; }

    public string StudentId { get; set; } = null!;

    public int SubscriptionId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public bool IsActive { get; set; }

    public virtual Student Student { get; set; } = null!;

    public virtual Subscription Subscription { get; set; } = null!;
}
