using System;
using Common_Library;
using System.Windows.Forms;
using System.Threading.Tasks;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Services;
using University_Housing_Management_Project.Helpers;
using University_Housing_Management_Project.Forms.Home.ProductManagement.Products;

namespace University_Housing_Management_Project.Forms.Home.ProductManagement
{
    public partial class CtrlAddQuantityForProduct : UserControl
    {

        private readonly ProductService _productService = new ProductService();

        private ProductDto _Product = null;
        private string _ProductID = string.Empty;

        public CtrlAddQuantityForProduct(string ProductID)
        {
            InitializeComponent();
            _ProductID = ProductID;
        }

        // Load data
        private async Task _LoadData()
        {
            try
            {
                _Product = await _productService.FindProductById(_ProductID);

                if (_Product == null)
                {
                    ShowMessagebox.Error($"Product with ID {_ProductID} not found.", "Not Found", ParentForm);
                    return;
                }

                TxtProductID.Text = _Product.ProductId;
                TxtProductName.Text = _Product.ProductName;
                TxtPrice.Text = _Product.Price.ToString("N2");
                TxtPurchasePrice.Text = _Product.PurchasePrice.ToString("N2");
                TxtQuantity.Text = _Product.Quantity.ToString();

                TxtQuantity.ReadOnly = true;
                TxtProductName.ReadOnly = true;
                TxtProductID.ReadOnly = true;

                TxtPurchasePrice.Focus();
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error loading product details: {ex.Message}", "Error", ParentForm);
            }
        }
        private async void CtrlAddQuantityForProduct_Load(object sender, EventArgs e)
        {
            await _LoadData();
        }

        // Operations
        private async void BtnSave_Click(object sender, EventArgs e)
        {

            if (_Product == null)
            {
                ShowMessagebox.Error("Cannot save quantity because product information is missing.",
                    "Error", ParentForm);

                return;
            }

            try
            {

                decimal.TryParse(TxtPrice.Text.Trim(), out decimal price);
                decimal.TryParse(TxtPurchasePrice.Text.Trim(), out decimal purchasePrice);
                int addedQuantity = Convert.ToInt32(NumUpDownAddedQuantity.Value);

                AddQuantityDto quantityDto = new AddQuantityDto
                {
                    ProductId = _ProductID,
                    Price = price,
                    PurchasePrice = purchasePrice,
                    Quantity = addedQuantity
                };

                if (await _productService.AddNewQuantity(quantityDto))
                {
                    ShowMessagebox.Information("The quantity has been successfully added.",
                        "The operation was successful.", ParentForm);

                    _Product.Quantity += addedQuantity;
                    TxtQuantity.Text = _Product.Quantity.ToString();

                    NumUpDownAddedQuantity.Value = 1;

                    TxtPrice.ReadOnly = true;
                    TxtPurchasePrice.ReadOnly = true;

                    NumUpDownAddedQuantity.Enabled = false;
                    BtnSave.Enabled = false;
                }
                else
                {
                    ShowMessagebox.Error("Unable to add the new quantity.",
                        "The operation failed.", ParentForm);
                }
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"An error occurred while adding quantity: {ex.Message}"
                    , "System Error", ParentForm);
            }
        }
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlProductManagement());
        }

        // Validation
        private void NumUpDownAddedQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void OnlyNumbersAndDot(object sender, KeyPressEventArgs e)
        {
            if (ValidationHelper.WriteOnlyNumber(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

    }
}