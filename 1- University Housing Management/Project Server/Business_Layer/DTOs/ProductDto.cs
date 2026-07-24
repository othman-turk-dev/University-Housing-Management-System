namespace Business_Layer.DTOs
{
    public class ProductDto
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

    }
}
