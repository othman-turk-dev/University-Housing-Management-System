namespace Data_Access_Layer.Entities;

public class Bank
{
    public int BankId { get; set; }

    public string? StudentId { get; set; }

    public string OperationType { get; set; } = null!;

    public DateTime Date { get; set; }

    public decimal Amount { get; set; }

    public int CreatedByUserId { get; set; }

    public virtual User CreatedByUser { get; set; } = null!;
}
