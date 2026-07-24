namespace Business_Layer.DTOs
{
    public class AllProductsWithoutDetailsDto
    {
        public string ProductId { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public decimal Price { get; set; }
        public int Quantity { get; set; }

    }
}
