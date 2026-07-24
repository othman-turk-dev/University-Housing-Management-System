namespace Business_Layer.DTOs
{
    public class StoreOperationsDto
    {
        public string OperationType { get; set; } = null!;
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Username { get; set; } = null!;
    }
}
