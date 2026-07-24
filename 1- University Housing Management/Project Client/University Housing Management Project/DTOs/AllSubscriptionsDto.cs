using System;
using University_Housing_Management_Project.Helpers.Pdf;

namespace University_Housing_Management_Project.DTOs
{
    public class AllSubscriptionsDto
    {

        [PdfDisplayName("Uni. number")]
        public string UniversityNumber { get; set; }
        public string Name { get; set; }

        [PdfDisplayName("Room location")]
        public string RoomLocation { get; set; }
        
        [PdfDisplayName("Subscription type")]
        public string SubscriptionType { get; set; }

        [PdfIgnore]
        public string Status { get; set; }

        [PdfDisplayName("Start date")]
        public DateTime StartDate { get; set; }

        [PdfDisplayName("End date")]
        public DateTime EndDate { get; set; }

    }
}
