using System;
using University_Housing_Management_Project.Helpers.Pdf;

namespace University_Housing_Management_Project.DTOs
{
    public class AllViolationsDto
    {

        [PdfIgnore()]
        public int ViolationId { get; set; }

        [PdfDisplayName("Violation type")]
        public string ViolationType { get; set; }

        public string Student { get; set; }

        [PdfDisplayName("Uni. number")]
        public string UniversityNumber { get; set; }
        public string IsPaid { get; set; }
        public decimal Fine { get; set; }
        public DateTime Date { get; set; }

        [PdfIgnore()]
        public string CreatedByUser { get; set; }

    }
}
