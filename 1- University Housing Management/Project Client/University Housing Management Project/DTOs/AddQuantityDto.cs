namespace University_Housing_Management_Project.DTOs
{
    public class AddQuantityDto
    {
        public string ProductId { get; set; }
        public decimal Price { get; set; }
        public decimal PurchasePrice { get; set; }
        public int Quantity { get; set; }

    }
}
