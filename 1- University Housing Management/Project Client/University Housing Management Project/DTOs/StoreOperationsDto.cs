using System;
using University_Housing_Management_Project.Helpers.Pdf;

namespace University_Housing_Management_Project.DTOs
{
    public class StoreOperationsDto
    {

        [PdfDisplayName("Operation type")]
        public string OperationType { get; set; }

        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Username { get; set; }
    }
}
