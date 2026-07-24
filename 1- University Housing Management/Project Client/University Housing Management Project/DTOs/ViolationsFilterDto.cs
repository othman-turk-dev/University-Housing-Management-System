using System;

namespace University_Housing_Management_Project.DTOs
{
    public class ViolationsFilterDto
    {
        public string StudentName { get; set; }
        public string ViolationType { get; set; }
        public DateTime? ViolationDate { get; set; }
        public string PaymentStatus { get; set; }

    }
}
