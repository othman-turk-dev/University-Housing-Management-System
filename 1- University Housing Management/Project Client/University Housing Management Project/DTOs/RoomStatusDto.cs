using University_Housing_Management_Project.Helpers.Pdf;

namespace University_Housing_Management_Project.DTOs
{
    public class RoomStatusDto
    {

        [PdfDisplayName("Room id")]
        public int RoomId { get; set; }
        
        [PdfDisplayName("Room location")]
        public string RoomLocation { get; set; }

        [PdfDisplayName("Number of students in the room")]
        public int StudentsCount { get; set; }
        
        [PdfDisplayName("Room status")]
        public string RoomState { get; set; }
    }
}
