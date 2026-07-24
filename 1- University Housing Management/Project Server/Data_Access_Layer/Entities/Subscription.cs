namespace Data_Access_Layer.Entities;

public class Subscription
{
    public int SubscriptionId { get; set; }

    public int SubscriptionTypeId { get; set; }

    public virtual ICollection<StudentSubscription> StudentSubscriptions { get; set; } = new List<StudentSubscription>();

    public virtual SubscriptionType SubscriptionType { get; set; } = null!;
}
