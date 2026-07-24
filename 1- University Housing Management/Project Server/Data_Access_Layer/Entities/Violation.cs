namespace Data_Access_Layer.Entities;

public class Violation
{
    public int ViolationId { get; set; }

    public string StudentId { get; set; } = null!;

    public int ViolationTypeId { get; set; }

    public DateTime Date { get; set; }

    public decimal Fine { get; set; }

    public bool IsPaid { get; set; }

    public int CreatedByUserId { get; set; }

    public virtual User CreatedByUser { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;

    public virtual ViolationType ViolationType { get; set; } = null!;
}
