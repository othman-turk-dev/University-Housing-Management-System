using System;

namespace University_Housing_Management_Project.DTOs
{
    public class StudentOperationsFilterDto
    {

        public string OperationType { get; set; }
        public DateTime? OperationDate { get; set; }
        public string StudentName { get; set; }

    }
}
