using System;

namespace University_Housing_Management_Project.DTOs
{
    public class AllProductsDto
    {

        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public string EditedBy { get; set; }
        public string EditedDate { get; set; }

    }
}
