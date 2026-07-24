using System;
using System.Linq;
using Common_Library;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Services;
using University_Housing_Management_Project.Helpers.Pdf;
using University_Housing_Management_Project.Forms.Home.ProductManagement;
using University_Housing_Management_Project.Helpers;
using University_Housing_Management_Project.Forms.Home.SaleManagement.Sales;

namespace University_Housing_Management_Project.Forms.Home.SaleManagement
{
    public partial class CtrlAddNewSale : UserControl
    {

        private readonly SaleDetailService _saleDetailService = new SaleDetailService();

        private BindingList<SaleProductViewDto> _SaleProducts = new BindingList<SaleProductViewDto>();
        private Dictionary<string, int> _RequestedProducts = new Dictionary<string, int>();
        public AllProductsWithoutDetailsDto Product;

        public CtrlAddNewSale()
        {
            InitializeComponent();
        }

        // Load data
        private void _LoadData()
        {
            _SaleProducts.Clear();
            _RequestedProducts.Clear();

            _DefaultProductData();
            _RefreshGrid();
        }
        private void _RefreshGrid()
        {
            DGVShowProdects.DataSource = _SaleProducts;
        }
        private void _DefaultProductData()
        {
            Product = null;

            TxtProductName.Clear();
            TxtPrice.Clear();
            TxtQuantity.Clear();
            TxtTotalPrice.Clear();

            TxtQuantity.PlaceholderText = string.Empty;
            TxtQuantity.ReadOnly = true;
        }
        private void CtrlAddNewSale_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        // Choose Product
        private void _FillTextboxes()
        {
            if (Product == null)
                return;

            TxtProductName.Text = Product.ProductName;
            TxtPrice.Text = Product.Price.ToString("N2");

            TxtQuantity.Clear();
            TxtTotalPrice.Clear();

            TxtQuantity.Focus();
            TxtQuantity.PlaceholderText = "Enter Quantity";
            TxtQuantity.ReadOnly = false;
        }
        private void BtnChooseProduct_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowProducts(this);
            frm.ShowDialog();

            if (Product == null)
                return;

            _FillTextboxes();
        }

        // Operations
        private void _CalculateTotalPrice()
        {
            TxtTotalPrice.Text = _SaleProducts
                .Sum(x => x.TotalPrice)
                .ToString("N2");
        }
        private bool _ChackQuantity(int quantity)
        {

            if (Product == null)
            {
                ShowMessagebox.Error("Please choose a product first.", "Product Not Selected", ParentForm);
                return false;
            }

            if (quantity <= 0)
            {
                ShowMessagebox.Error(
                    "Quantity must be greater than zero.",
                    "Invalid quantity",
                    ParentForm);

                TxtQuantity.Focus();
                return false;
            }

            int requested = 0;
            _RequestedProducts.TryGetValue(Product.ProductId, out requested);

            if (requested + quantity > Product.Quantity)
            {
                ShowMessagebox.Error(
                    $"Only {Product.Quantity - requested} items are available.",
                    "Quantity not available",
                    ParentForm);

                TxtQuantity.Clear();
                TxtQuantity.Focus();
                return false;
            }

            return true;
        }
        private void _AddProduct()
        {
            
            if (Product == null)
                return;

            if (ValidationHelper.IsTxtEmpty(TxtQuantity.Text.Trim()))
                return;

            if (!int.TryParse(TxtQuantity.Text.Trim(), out int quantity))
                return;

            if (!_ChackQuantity(quantity))
                return;

            if (_RequestedProducts.ContainsKey(Product.ProductId))
                _RequestedProducts[Product.ProductId] += quantity;
            else
                _RequestedProducts.Add(Product.ProductId, quantity);

            _SaleProducts.Add(new SaleProductViewDto
            {
                ProductId = Product.ProductId,
                ProductName = Product.ProductName,
                Price = Product.Price,
                Quantity = quantity,
                MaxAvailableQuantity = Product.Quantity
            });

            _DefaultProductData();
            _CalculateTotalPrice();
        }
        private void TxtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                _AddProduct();
            }
        }

        // Update
        private async Task _UpdateProductAsync()
        {
            if (DGVShowProdects.CurrentRow == null || DGVShowProdects.Rows.Count <= 0)
                return;

            var selectedItem = DGVShowProdects.CurrentRow.DataBoundItem as SaleProductViewDto;
            if (selectedItem == null)
                return;

            Product = new AllProductsWithoutDetailsDto
            {
                ProductId = selectedItem.ProductId,
                ProductName = selectedItem.ProductName,
                Price = selectedItem.Price,
                Quantity = selectedItem.MaxAvailableQuantity
            };

            TxtProductName.Text = selectedItem.ProductName;
            TxtPrice.Text = selectedItem.Price.ToString("N2");
            TxtQuantity.Text = selectedItem.Quantity.ToString();

            if (_RequestedProducts.ContainsKey(selectedItem.ProductId))
            {
                _RequestedProducts[selectedItem.ProductId] -= selectedItem.Quantity;

                if (_RequestedProducts[selectedItem.ProductId] <= 0)
                    _RequestedProducts.Remove(selectedItem.ProductId);
            }

            _SaleProducts.Remove(selectedItem);

            TxtQuantity.ReadOnly = false;
            TxtQuantity.Focus();

            _CalculateTotalPrice();
            await Task.CompletedTask;
        }
        private async void UpdateQuantityItem_Click(object sender, EventArgs e)
        {
            await _UpdateProductAsync();
        }

        // Delete
        private void DeleteProductItem_Click(object sender, EventArgs e)
        {
            
            if (DGVShowProdects.CurrentRow == null || DGVShowProdects.Rows.Count <= 0)
                return;

            var selected = DGVShowProdects.CurrentRow.DataBoundItem as SaleProductViewDto;
            if (selected == null)
                return;

            if (_RequestedProducts.ContainsKey(selected.ProductId))
            {
                _RequestedProducts[selected.ProductId] -= selected.Quantity;

                if (_RequestedProducts[selected.ProductId] <= 0)
                    _RequestedProducts.Remove(selected.ProductId);
            }

            _SaleProducts.Remove(selected);

            _DefaultProductData();
            _CalculateTotalPrice();
        }
        private void DeleteAllProductsItem_Click(object sender, EventArgs e)
        {
            _SaleProducts.Clear();
            _RequestedProducts.Clear();

            _DefaultProductData();
            _CalculateTotalPrice();
        }

        // Save
        private async void BtnSave_Click(object sender, EventArgs e)
        {

            if (_SaleProducts.Count == 0)
            {
                ShowMessagebox.Error(
                    "At least one product must be added.",
                    "The operation failed.",
                    ParentForm);

                return;
            }

            DialogResult result = ShowMessagebox.Question(
                "Do you definitely want to save the sale?",
                "Confirmation",
                ParentForm);

            if (result != DialogResult.Yes)
                return;

            try
            {
                var saleInfoDto = new List<SaleInfoDto>();

                foreach (var item in _SaleProducts)
                {
                    saleInfoDto.Add(new SaleInfoDto
                    {
                        ProductId = item.ProductId,
                        Quantity = item.Quantity,
                    });
                }

                bool isSaved = await _saleDetailService.AddNewSale(saleInfoDto);

                if (isSaved)
                {
                    ShowMessagebox.Information(
                        "The sale was completed successfully.",
                        "The operation was successful.",
                        ParentForm);

                    _SaleProducts.Clear();
                    _RequestedProducts.Clear();

                    _DefaultProductData();
                    _CalculateTotalPrice();

                    BtnSave.Enabled = true;
                    BtnChooseProduct.Enabled = true;
                    CMStripProducts.Enabled = true;
                }
                else
                {
                    ShowMessagebox.Error(
                        "Unable to save the sale transaction.",
                        "The operation failed.",
                        ParentForm);
                }
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"An error occurred while saving the sale: {ex.Message}", "System Error", ParentForm);
            }
        }
        private void BtnPrint_Click(object sender, EventArgs e)
        {

            if (_SaleProducts.Count == 0)
            {
                ShowMessagebox.Error(
                    "No products available for printing.",
                    "Warning",
                    ParentForm);
                return;
            }

            List<SaleProductViewDto> sales = _SaleProducts.ToList();

            PdfGenerator.Export(sales, "Order");
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            _SaleProducts.Clear();
            _RequestedProducts.Clear();

            UserControlManagement.ShowUserControl(new CtrlSaleManagement());
        }

        // Validations
        private void CMStripProducts_Opening(object sender, CancelEventArgs e)
        {
            DeleteProductItem.Visible = false;
            DeleteAllProductsItem.Visible = false;
            UpdateQuatityItem.Visible = false;

            if (DGVShowProdects.Rows.Count <= 0)
                return;

            DeleteProductItem.Visible = true;
            DeleteAllProductsItem.Visible = true;
            UpdateQuatityItem.Visible = true;
        }
        private void TxtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidationHelper.WriteOnlyNumber(e.KeyChar))
                e.Handled = true;
        }

    }
}