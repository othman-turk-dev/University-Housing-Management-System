namespace Business_Layer.DTOs
{
    public class SaleSummaryDto
    {
        public int SaleId { get; set; }
        public DateTime SaleDate { get; set; }
        public string SoldBy { get; set; } = null!;
        public int TotalProductTypes { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
