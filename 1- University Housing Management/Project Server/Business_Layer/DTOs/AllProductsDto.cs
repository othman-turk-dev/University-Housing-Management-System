namespace Business_Layer.DTOs
{
    public class AllProductsDto
    {

        public string ProductId { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string AddedBy { get; set; } = null!;
        public DateTime AddedDate { get; set; }
        public string EditedBy { get; set; } = null!;
        public string EditedDate { get; set; } = null!;

    }
}
