namespace Business_Layer.DTOs
{
    public class UpdateProductDto
    {
        public string ProductId { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public decimal Price { get; set; }

    }
}
