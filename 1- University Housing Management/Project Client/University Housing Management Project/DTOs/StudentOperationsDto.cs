using System;
using University_Housing_Management_Project.Helpers.Pdf;

namespace University_Housing_Management_Project.DTOs
{
    public class StudentOperationsDto
    {

        [PdfDisplayName("Uni. Number")]
        public string UniversityNumber { get; set; }
        
        [PdfDisplayName("Name")]
        public string FullName { get; set; }
        
        [PdfDisplayName("Operation Type")]
        public string OperationType { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Username { get; set; }

    }
}
