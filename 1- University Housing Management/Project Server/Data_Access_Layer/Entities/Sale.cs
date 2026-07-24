namespace Data_Access_Layer.Entities;

public class Sale
{
    public int SaleId { get; set; }

    public DateTime Date { get; set; }

    public int CreatedByUserId { get; set; }

    public virtual User CreatedByUser { get; set; } = null!;

    public virtual ICollection<SaleDetail> SaleDetails { get; set; } = new List<SaleDetail>();
}
