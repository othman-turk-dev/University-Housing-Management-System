namespace Data_Access_Layer.Entities;

public class SaleDetail
{
    public int SaleDetailId { get; set; }

    public int SaleId { get; set; }

    public string ProductId { get; set; } = null!;

    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal LineTotal { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual Sale Sale { get; set; } = null!;
}
