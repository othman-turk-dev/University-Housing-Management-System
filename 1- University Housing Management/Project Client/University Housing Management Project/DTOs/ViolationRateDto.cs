using University_Housing_Management_Project.Helpers.Pdf;

namespace University_Housing_Management_Project.DTOs
{
    public class ViolationRateDto
    {

        [PdfDisplayName("Violation name")]
        public string ViolationName { get; set; }

        [PdfDisplayName("Students have violations")]
        public int StudentsHaveViolations { get; set; }

        [PdfDisplayName("Violation rate")]
        public decimal ViolationRate { get; set; }
    }
}
