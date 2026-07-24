namespace Data_Access_Layer.Entities;

public class Product
{
    public string ProductId { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public decimal Price { get; set; }

    public decimal PurchasePrice { get; set; }

    public int Quantity { get; set; }

    public int CreateByUserId { get; set; }

    public DateTime CreateDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public virtual User CreateByUser { get; set; } = null!;

    public virtual User? LastModifiedByUser { get; set; }

    public virtual ICollection<SaleDetail> SaleDetails { get; set; } = new List<SaleDetail>();
}
