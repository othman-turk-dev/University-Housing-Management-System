namespace Business_Layer.DTOs
{
    public class StudentOperationsDto
    {
        public string UniversityNumber { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string OperationType { get; set; } = null!;
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Username { get; set; } = null!;

    }
}
