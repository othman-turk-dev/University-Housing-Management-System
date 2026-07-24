namespace Data_Access_Layer.Entities;

public class SubscriptionType
{
    public int SubscriptionTypeId { get; set; }

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }

    public virtual ICollection<Subscription> Subscriptions { get; set; } = new List<Subscription>();
}
