using System;
using Common_Library;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Helpers;
using University_Housing_Management_Project.Services;
using University_Housing_Management_Project.Helpers.Pdf;

namespace University_Housing_Management_Project.Forms.Home.ProductManagement.Products
{
    public partial class CtrlProductManagement : UserControl
    {

        private readonly ProductService _productService = new ProductService();

        private List<AllProductsDto> _AllProducts = null;

        public CtrlProductManagement()
        {
            InitializeComponent();
        }

        // Load data
        private async Task _RefreshDataGridView()
        {
            try
            {
                _AllProducts = await _productService.GetAllProducts();
                DGVShowProductsInfo.DataSource = _AllProducts;

                TxtSearch.Text = string.Empty;
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error refreshing products data: {ex.Message}", "Error", ParentForm);
            }
        }
        private async void CtrlProductManagement_Load(object sender, EventArgs e)
        {
            await _RefreshDataGridView();

            if (DGVShowProductsInfo.Rows.Count > 0 && DGVShowProductsInfo.Columns.Count > 0)
            {
                DGVShowProductsInfo.Columns[0].HeaderText = "Product id";
                DGVShowProductsInfo.Columns[1].HeaderText = "Name";
                DGVShowProductsInfo.Columns[4].HeaderText = "Added by";
                DGVShowProductsInfo.Columns[5].HeaderText = "Added date";
                DGVShowProductsInfo.Columns[6].HeaderText = "Edited by";
                DGVShowProductsInfo.Columns[7].HeaderText = "Edited date";


                DGVShowProductsInfo.Columns[0].Width = 75;
                DGVShowProductsInfo.Columns[1].Width = 190;
                DGVShowProductsInfo.Columns[2].Width = 80;
                DGVShowProductsInfo.Columns[3].Width = 80;
                DGVShowProductsInfo.Columns[5].Width = 195;
                DGVShowProductsInfo.Columns[7].Width = 190;
            }

        }
        private async void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _AllProducts = await _productService.ProductsFilter(TxtSearch.Text.Trim());
                DGVShowProductsInfo.DataSource = _AllProducts;
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error filtering products: {ex.Message}", "Error", ParentForm);
            }
        }

        // Operations
        private async void BtnAddNewProduct_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlAddUpdateProduct());
            await _RefreshDataGridView();
        }
        private async void BtnUpdateProduct_Click(object sender, EventArgs e)
        {

            if (DGVShowProductsInfo.CurrentRow == null || DGVShowProductsInfo.Rows.Count <= 0)
                return;

            string productID = DGVShowProductsInfo.CurrentRow.Cells[0].Value?.ToString();

            if (!string.IsNullOrWhiteSpace(productID))
            {
                UserControlManagement.ShowUserControl(new CtrlAddUpdateProduct(productID));
                await _RefreshDataGridView();
            }
        }
        private void UpdateProductInfoItem_Click(object sender, EventArgs e)
        {
            BtnUpdateProduct_Click(null, null);
        }
        private async void BtnAddNewQuantity_Click(object sender, EventArgs e)
        {
            
            if (DGVShowProductsInfo.CurrentRow == null || DGVShowProductsInfo.Rows.Count <= 0)
                return;

            string productID = DGVShowProductsInfo.CurrentRow.Cells[0].Value?.ToString();

            if (!string.IsNullOrWhiteSpace(productID))
            {
                UserControlManagement.ShowUserControl(new CtrlAddQuantityForProduct(productID));
                await _RefreshDataGridView();
            }
        }
        private void AddQuantityItem_Click(object sender, EventArgs e)
        {
            BtnAddNewQuantity_Click(null, null);
        }
        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            await _RefreshDataGridView();
        }
        private async void BtnStatistics_Click(object sender, EventArgs e)
        {

            try
            {
                decimal result = await _productService.TotalPrice() ?? 0;

                string message = $"Price of all products: {result.ToString("N2")} $ ";

                ShowMessagebox.Information(message,
                    "Product Statistics", ParentForm);
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error loading statistics: {ex.Message}", "Error", ParentForm);
            }
        }
        private async void BtnPrintTheReport_Click(object sender, EventArgs e)
        {
            try
            {
                var productsWithoutDetails = await _productService.GetAllProductsWithoutDetails();
                PdfGenerator.Export(productsWithoutDetails, "Products");
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error printing report: {ex.Message}", "Error", ParentForm);
            }
        }
        private void CMStripProducts_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            AddQuantityItem.Visible = false;
            UpdateProductInfoItem.Visible = false;

            if (DGVShowProductsInfo.CurrentRow == null || DGVShowProductsInfo.Rows.Count <= 0)
                return;

            AddQuantityItem.Visible = true;
            UpdateProductInfoItem.Visible = true;
        }

    }
}