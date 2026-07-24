using System;

namespace University_Housing_Management_Project.DTOs
{
    public class SaleDetailsByIdDto
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }
        public DateTime Date { get; set; }
    }
}
