using System;
using University_Housing_Management_Project.Helpers.Pdf;

namespace University_Housing_Management_Project.DTOs
{
    public class SaleSummaryDto
    {

        [PdfIgnore()]
        public int SaleId { get; set; }

        [PdfDisplayName("Sale date")]
        public DateTime SaleDate { get; set; }


        [PdfDisplayName("Sold by")]
        public string SoldBy { get; set; }


        [PdfDisplayName("Total product types")]
        public int TotalProductTypes { get; set; }


        [PdfDisplayName("Total amount")]
        public decimal TotalAmount { get; set; }
    }
}
