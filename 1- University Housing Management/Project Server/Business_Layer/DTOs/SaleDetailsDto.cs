namespace Business_Layer.DTOs
{
    public class SaleDetailsDto
    {

        public string ProductId { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }

    }
}
