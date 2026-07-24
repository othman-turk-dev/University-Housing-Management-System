using System.ComponentModel;
using University_Housing_Management_Project.Helpers.Pdf;

namespace University_Housing_Management_Project.DTOs
{
    public class AllProductsWithoutDetailsDto
    {

        [PdfDisplayName("Product id")]
        public string ProductId { get; set; }


        [PdfDisplayName("Product name")]
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        
        [Browsable(false)]
        public int Quantity { get; set; }

    }
}
