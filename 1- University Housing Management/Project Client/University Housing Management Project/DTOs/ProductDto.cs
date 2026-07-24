using System;

namespace University_Housing_Management_Project.DTOs
{
    public class ProductDto
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal PurchasePrice { get; set; }
        public int Quantity { get; set; }
        public int CreateByUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedDate { get; set; }

    }
}
