using University_Housing_Management_Project.Helpers.Pdf;

namespace University_Housing_Management_Project.DTOs
{
    public class StudentWithDetailsDto
    {

        [PdfDisplayName("Uni. Number")]
        public string UniversityNumber { get; set; }

        [PdfDisplayName("Name")]
        public string FullName { get; set; }

        
        [PdfIgnore]
        public string Phone { get; set; }
        [PdfIgnore]
        public string GuardiansNumber { get; set; }
        

        public string Specialization { get; set; }

        [PdfDisplayName("Academic Level")]
        public string AcademicLevel { get; set; }

        [PdfDisplayName("Room Location")]
        public string RoomLocation { get; set; }
    }

}
