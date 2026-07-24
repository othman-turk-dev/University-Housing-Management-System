using System;
using Common_Library;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Services;
using University_Housing_Management_Project.Forms.Home.SaleManagement;

namespace University_Housing_Management_Project.Forms.Home.ProductManagement
{
    public partial class frmShowProducts : Form
    {

        private readonly ProductService _productService = new ProductService();

        private CtrlAddNewSale _CtrlNewSale = null;
        private List<AllProductsWithoutDetailsDto> _AllProducts;

        public frmShowProducts(CtrlAddNewSale newSale)
        {
            InitializeComponent();
            _CtrlNewSale = newSale;
        }

        private async Task _LoadDataToDataGridView()
        {
            try
            {
                _AllProducts = await _productService.GetAllProductsWithoutDetails();
                DGVShowProdects.DataSource = _AllProducts;
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error loading products: {ex.Message}", "Error", this);
            }
        }
        private async void frmShowProducts_Load(object sender, EventArgs e)
        {
            await _LoadDataToDataGridView();
        }
        private async void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _AllProducts = await _productService.ProductsFilterWithoutDetails(TxtSearch.Text.Trim());
                DGVShowProdects.DataSource = _AllProducts;
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error filtering products: {ex.Message}", "Error", this);
            }
        }
        private async void DGVShowProdects_DoubleClick(object sender, EventArgs e)
        {

            if (DGVShowProdects.CurrentRow == null || 
                DGVShowProdects.Rows.Count <= 0 ||
                _CtrlNewSale == null)

                return;

            try
            {
                string productIdStr = DGVShowProdects.CurrentRow.Cells[0].Value?.ToString();

                if (string.IsNullOrWhiteSpace(productIdStr))
                    return;

                var productDto = await _productService.FindProductById(productIdStr);

                if (productDto != null)
                {
                    var product = new AllProductsWithoutDetailsDto
                    {
                        ProductId = productDto.ProductId,
                        ProductName = productDto.ProductName,
                        Price = productDto.Price,
                        Quantity = productDto.Quantity
                    };

                    _CtrlNewSale.Product = product;
                    this.Close();
                }
                else
                {
                    ShowMessagebox.Error("Selected product details could not be found.", "Error", this);
                }
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error selecting product: {ex.Message}", "Error", this);
            }
        }

    }
}