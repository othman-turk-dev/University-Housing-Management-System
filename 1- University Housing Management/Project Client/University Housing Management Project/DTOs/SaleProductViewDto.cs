using System;
using System.ComponentModel;
using University_Housing_Management_Project.Helpers.Pdf;

namespace University_Housing_Management_Project.DTOs
{
    public class SaleProductViewDto
    {

        [PdfDisplayName("Product id")]
        public string ProductId { get; set; }


        [PdfDisplayName("Product name")]
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        [PdfDisplayName("Total price")]
        public decimal TotalPrice => Price * Quantity;
        
        [Browsable(false)]
        [PdfIgnore()]
        public int MaxAvailableQuantity { get; set; }

    }
}
