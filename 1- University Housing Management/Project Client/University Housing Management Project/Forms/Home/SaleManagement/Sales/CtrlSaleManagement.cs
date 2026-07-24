using System;
using Common_Library;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Helpers;
using University_Housing_Management_Project.Services;
using University_Housing_Management_Project.Helpers.Pdf;

namespace University_Housing_Management_Project.Forms.Home.SaleManagement.Sales
{
    public partial class CtrlSaleManagement : UserControl
    {

        private readonly SaleDetailService _saleDetailService = new SaleDetailService();
        private List<SaleSummaryDto> _AllSales = null;

        public CtrlSaleManagement()
        {
            InitializeComponent();
        }

        // Load data
        private void _DefaultData()
        {
            TxtSearch.Text = string.Empty;
            SalesDateTime.MaxDate = DateTime.Now.AddSeconds(1);
            SalesDateTime.Value = DateTime.Now;
        }
        private async Task _RefreshDataGridView()
        {
            try
            {
                _DefaultData();
                await _ApplyFilters();
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error refreshing sales list: {ex.Message}", "Error", ParentForm);
            }
        }
        private async void CtrlSaleManagement_Load(object sender, EventArgs e)
        {
            await _RefreshDataGridView();

            if (DGVShowAllSales.Rows.Count > 0 && DGVShowAllSales.Columns.Count > 0)
            {

                DGVShowAllSales.Columns[0].HeaderText = "Sale id";
                DGVShowAllSales.Columns[1].HeaderText = "Sale date";
                DGVShowAllSales.Columns[2].HeaderText = "Sold by";
                DGVShowAllSales.Columns[3].HeaderText = "Total product types";
                DGVShowAllSales.Columns[4].HeaderText = "Total amount";
            }
        }

        // Operations
        private async void BtnAddNewSale_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlAddNewSale());
            await _RefreshDataGridView();
        }
        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            await _RefreshDataGridView();
        }
        private void BtnShowSaleDetails_Click(object sender, EventArgs e)
        {

            if (DGVShowAllSales.CurrentRow == null || DGVShowAllSales.Rows.Count <= 0)
                return;

            string saleIdStr = DGVShowAllSales.CurrentRow.Cells[0].Value?.ToString();

            if (int.TryParse(saleIdStr, out int saleID))
            {
                UserControlManagement.ShowUserControl(new CtrlShowSaleDetails(saleID));
            }
            else
            {
                ShowMessagebox.Error("Invalid sale ID selected.", "Error", ParentForm);
            }
        }
        private async void BtnPrintTheReport_Click(object sender, EventArgs e)
        {

            try
            {
                var Sales = await _saleDetailService.GetAllSalesInThisMonth();


                if (Sales.Count == 0)
                {
                    ShowMessagebox.Error(
                        "No sales available for printing.",
                        "Warning",
                        ParentForm);
                    return;
                }


                PdfGenerator.Export(Sales, "Sales In This Month");
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error printing report: {ex.Message}", "Error", ParentForm);
            }
        }

        // Filter
        private async Task _ApplyFilters()
        {
            try
            {
                SalesFilterDto salesFilterDto = new SalesFilterDto
                {
                    SaleDate = SalesDateTime.Value.Date,
                    SoldBy = TxtSearch.Text.Trim()
                };

                _AllSales = await _saleDetailService.FilterSales(salesFilterDto);
                DGVShowAllSales.DataSource = _AllSales;
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error filtering sales: {ex.Message}", "Error", ParentForm);
            }
        }
        private async void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            await _ApplyFilters();
        }
        private async void SalesDateTime_CloseUp(object sender, EventArgs e)
        {
            await _ApplyFilters();
        }

    }
}