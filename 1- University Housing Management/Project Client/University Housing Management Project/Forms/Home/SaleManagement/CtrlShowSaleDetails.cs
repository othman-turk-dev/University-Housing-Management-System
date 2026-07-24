using System;
using Common_Library;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Services;
using University_Housing_Management_Project.Helpers;
using University_Housing_Management_Project.Forms.Home.SaleManagement.Sales;

namespace University_Housing_Management_Project.Forms.Home.SaleManagement
{
    public partial class CtrlShowSaleDetails : UserControl
    {

        private readonly SaleDetailService _saleDetailService = new SaleDetailService();

        private int _SaleID = -1;
        private List<SaleDetailsByIdDto> _AllSaleDetails;

        public CtrlShowSaleDetails(int SaleID)
        {
            InitializeComponent();
            _SaleID = SaleID;
        }

        private async Task _RefreshDataGridView()
        {
            if (_SaleID <= 0)
            {
                ShowMessagebox.Error("Invalid Sale ID provided.", "Error", ParentForm);
                return;
            }

            try
            {
                _AllSaleDetails = await _saleDetailService.GetAllSaleDetails(_SaleID);
                DGVShowSaleDetails.DataSource = _AllSaleDetails;
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error loading sale details: {ex.Message}", "Error", ParentForm);
            }
        }
        private async void CtrlShowSaleDetails_Load(object sender, EventArgs e)
        {
            await _RefreshDataGridView();

            if (DGVShowSaleDetails.Rows.Count > 0 && DGVShowSaleDetails.Columns.Count > 0)
            {
                DGVShowSaleDetails.Columns[0].HeaderText = "Product name";
                DGVShowSaleDetails.Columns[1].HeaderText = "Quantity";
                DGVShowSaleDetails.Columns[2].HeaderText = "Unit price";
                DGVShowSaleDetails.Columns[3].HeaderText = "Line total";
                DGVShowSaleDetails.Columns[4].HeaderText = "Date";

                DGVShowSaleDetails.Columns[4].Width = 250;
            }
        }
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlSaleManagement());
        }
    
    }
}