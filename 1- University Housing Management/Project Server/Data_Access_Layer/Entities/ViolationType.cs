namespace Data_Access_Layer.Entities;

public class ViolationType
{
    public int ViolationTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal PenaltyAmount { get; set; }

    public virtual ICollection<Violation> Violations { get; set; } = new List<Violation>();
}
