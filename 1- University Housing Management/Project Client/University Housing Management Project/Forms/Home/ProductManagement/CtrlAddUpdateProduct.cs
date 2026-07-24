using System;
using Common_Library;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Threading.Tasks;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Services;
using University_Housing_Management_Project.Helpers;
using University_Housing_Management_Project.Forms.Home.ProductManagement.Products;

namespace University_Housing_Management_Project.Forms.Home.ProductManagement
{
    public partial class CtrlAddUpdateProduct : UserControl
    {

        private readonly ProductService _productService = new ProductService();

        enum enMode { Add, Update }

        private enMode _Mode;
        private ProductDto _Product;
        private string _ProductID;

        public CtrlAddUpdateProduct()
        {
            InitializeComponent();
            _Mode = enMode.Add;
        }
        public CtrlAddUpdateProduct(string productId)
        {
            InitializeComponent();
            
            _ProductID = productId;
            _Mode = enMode.Update;
        }

        private void _DefaultData()
        {
            TxtProductID.Clear();
            TxtProductName.Clear();
            TxtQuantity.Clear();
            TxtPrice.Clear();
            TxtPurchasePrice.Clear();

            LbTitle.Text = "Add New Product";
            TxtProductID.Focus();
        }
        private async Task _LoadData()
        {
            try
            {
                _Product = await _productService.FindProductById(_ProductID);

                if (_Product == null)
                {
                    ShowMessagebox.Error(
                        $"Product {_ProductID} not found.",
                        "Not Found", ParentForm);

                    return;
                }

                TxtProductID.Text = _Product.ProductId;
                TxtProductName.Text = _Product.ProductName;
                TxtQuantity.Text = _Product.Quantity.ToString();
                TxtPrice.Text = _Product.Price.ToString("N2");
                TxtPurchasePrice.Text = _Product.PurchasePrice.ToString("N2");

                TxtProductID.ReadOnly = true;
                TxtQuantity.ReadOnly = true;
                TxtPurchasePrice.ReadOnly = true;

                LbNote1.Visible = true;
                LbNote2.Visible = true;

                LbTitle.Text = "Update Product";
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error loading product details: {ex.Message}", "Error", ParentForm);
            }
        }
        private async void CtrlAddUpdateProduct_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.Add)
                _DefaultData();
            else
                await _LoadData();
        }

        // Save
        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if (!_IsValidationSuccessfully())
                return;

            try
            {

                int.TryParse(TxtQuantity.Text.Trim(), out int quantity);
                decimal.TryParse(TxtPurchasePrice.Text.Trim(), out decimal purchasePrice);
                decimal.TryParse(TxtPrice.Text.Trim(), out decimal price);

                if (_Mode == enMode.Add)
                {
                    AddProductDto addProduct = new AddProductDto
                    {
                        ProductId = TxtProductID.Text.Trim(),
                        ProductName = TxtProductName.Text.Trim(),
                        Quantity = quantity,
                        PurchasePrice = purchasePrice,
                        Price = price
                    };

                    var result = await _productService.AddProduct(addProduct);

                    if (result != null)
                    {
                        _Product = await _productService.FindProductById(TxtProductID.Text.Trim());
                        _Mode = enMode.Update;

                        TxtProductID.ReadOnly = true;
                        TxtQuantity.ReadOnly = true;
                        TxtPurchasePrice.ReadOnly = true;

                        LbNote1.Visible = true;
                        LbNote2.Visible = true;

                        LbTitle.Text = "Update Product";

                        ShowMessagebox.Information(
                            "Information saved successfully.",
                            "Success",
                            ParentForm);
                    }
                    else
                    {
                        ShowMessagebox.Error(
                            "Failed to save product.",
                            "Failed",
                            ParentForm);
                    }
                }
                else
                {
                    if (_Product == null) return;

                    UpdateProductDto updateProduct = new UpdateProductDto
                    {
                        ProductId = _Product.ProductId,
                        ProductName = TxtProductName.Text.Trim(),
                        Price = price
                    };

                    bool result = await _productService.UpdateProduct(updateProduct);

                    if (result)
                    {
                        _Product.ProductName = updateProduct.ProductName;
                        _Product.Price = updateProduct.Price;

                        ShowMessagebox.Information(
                            "Information updated successfully.",
                            "Success",
                            ParentForm);
                    }
                    else
                    {
                        ShowMessagebox.Error(
                            "Failed to update product.",
                            "Failed",
                            ParentForm);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"An error occurred while saving: {ex.Message}", "System Error", ParentForm);
            }
        }
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlProductManagement());
        }

        // Validations
        private bool _ValidateTextBox(Guna2TextBox Txt, string ErrorMessage)
        {
            if (ValidationHelper.IsTxtEmpty(Txt.Text.Trim()))
            {
                ShowMessagebox.Error(ErrorMessage, "The save operation failed.", ParentForm);
                Txt.Focus();
                return false;
            }

            return true;
        }
        private bool _IsValidationSuccessfully()
        {
            if (!_ValidateTextBox(TxtProductID, "The product ID must be entered."))
                return false;

            if (!_ValidateTextBox(TxtProductName, "The product name must be entered."))
                return false;

            if (!_ValidateTextBox(TxtQuantity, "You must enter the product quantity."))
                return false;

            if (!_ValidateTextBox(TxtPrice, "The selling price must be entered."))
                return false;

            if (!_ValidateTextBox(TxtPurchasePrice, "The product price must be entered."))
                return false;

            return true;
        }
        private async void TxtProductID_Leave(object sender, EventArgs e)
        {

            string productID = TxtProductID.Text.Trim();

            if (ValidationHelper.IsTxtEmpty(productID))
                return;

            try
            {
                if (_Mode == enMode.Add && await _productService.IsProductExist(productID))
                {
                    ShowMessagebox.Error("A product with the same ID exists.",
                        "Invalid input", ParentForm);

                    TxtProductID.Focus();
                    return;
                }

                if (_Mode == enMode.Update && _Product != null &&
                    (await _productService.IsProductExist(productID) && productID != _Product.ProductId))
                {
                    ShowMessagebox.Error("A product with the same ID exists.",
                        "Invalid input", ParentForm);

                    TxtProductID.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error validating product ID: {ex.Message}", "Error", ParentForm);
            }
        }
        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (ValidationHelper.WriteOnlyNumber(e.KeyChar))
                e.Handled = true;
        }
        private void OnlyNumbersAndDot(object sender, KeyPressEventArgs e)
        {
            if (ValidationHelper.WriteOnlyNumber(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

    }
}