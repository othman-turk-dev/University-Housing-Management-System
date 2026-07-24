using System;
using Common_Library;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Helpers;
using University_Housing_Management_Project.Services;
using University_Housing_Management_Project.Helpers.Pdf;

namespace University_Housing_Management_Project.Forms.Home.BankManagement.Bank
{
    public partial class CtrlBankManagement : UserControl
    {
        private readonly BankService _bankService = new BankService();

        private List<StudentOperationsDto> _allStudentOperation;
        private List<StoreOperationsDto> _allStoreOperation;

        public CtrlBankManagement()
        {
            InitializeComponent();
        }

        private async void CtrlBankManagement_Load(object sender, EventArgs e)
        {
            try
            {
                await Task.WhenAll(
                    _RefreshDataGridViewForStores(),
                    _RefreshDataGridViewForStudents()
                );
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Failed to load bank operations data: {ex.Message}", "Error", ParentForm);
            }

            if(DGVShowAllStoreOperations.Rows.Count >= 0)
            {

                DGVShowAllStoreOperations.Columns[0].HeaderText = "Operation type";
            }

            if (DGVShowAllStudentOperations.Rows.Count >= 0)
            {

                DGVShowAllStudentOperations.Columns[0].HeaderText = "Uni. number";
                DGVShowAllStudentOperations.Columns[2].HeaderText = "Operation type";
            }

        }

        private void _DefaultSelectedForStores()
        {
            CbStoreOperationTypesFilter.Text = "All";
            ChBStoreDateFilter.Checked = false;

            DateTimeStores.MaxDate = DateTime.Now.AddSeconds(3);
            DateTimeStores.Value = DateTime.Now;
        }
        private void _DefaultSelectedForStudents()
        {
            TxtSearch.Text = string.Empty;
            CbStudentOperationTypesFilter.Text = "All";

            ChBStudentDateFilter.Checked = false;
            DateTimeStudents.MaxDate = DateTime.Now.AddSeconds(3);
            DateTimeStudents.Value = DateTime.Now;
        }
        private async Task _RefreshDataGridViewForStores()
        {
            _allStoreOperation = await _bankService.GetAllStoreOperations();
            DGVShowAllStoreOperations.DataSource = _allStoreOperation;

            _DefaultSelectedForStores();
        }
        private async Task _RefreshDataGridViewForStudents()
        {
            _allStudentOperation = await _bankService.GetAllStudentOperations();
            DGVShowAllStudentOperations.DataSource = _allStudentOperation;

            _DefaultSelectedForStudents();
            await _ApplyFilterForStudent();
        }

        private void DGVShowAllStoreOperations_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DGVShowAllStoreOperations.Columns[e.ColumnIndex].Name == "Amount" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal value) && value < 0)
                {
                    e.CellStyle.ForeColor = Color.Maroon;
                }
            }
        }

        
        private async Task _ApplyFilterForStudent()
        {
            try
            {
                var filter = new StudentOperationsFilterDto
                {
                    StudentName = TxtSearch.Text.Trim(),
                    OperationDate = ChBStudentDateFilter.Checked ? DateTimeStudents.Value.Date : (DateTime?)null,
                    OperationType = CbStudentOperationTypesFilter.Text == "All" ? null : CbStudentOperationTypesFilter.Text
                };

                var result = await _bankService.FilterStudentOperations(filter);
                DGVShowAllStudentOperations.DataSource = result;
            }
            catch
            {
                // Silence or log transient filtering errors
            }
        }
        private async void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            await _ApplyFilterForStudent();
        }
        private async void CbStudentOperationTypesFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _ApplyFilterForStudent();
        }
        private async void ChBStudentDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            await _ApplyFilterForStudent();
        }
        private async void DateTimeStudents_CloseUp(object sender, EventArgs e)
        {
            await _ApplyFilterForStudent();
        }

        private async Task _ApplyFilterForStore()
        {
            try
            {
                var filter = new StoreOperationsFilterDto
                {
                    OperationDate = ChBStoreDateFilter.Checked ? DateTimeStores.Value.Date : (DateTime?)null,
                    OperationType = CbStoreOperationTypesFilter.Text == "All" ? null : CbStoreOperationTypesFilter.Text
                };

                var result = await _bankService.FilterStoreOperations(filter);
                DGVShowAllStoreOperations.DataSource = result;
            }
            catch
            {
                // Silence or log transient filtering errors
            }
        }
        private async void CbStoreOperationTypesFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _ApplyFilterForStore();
        }
        private async void ChBStoreDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            await _ApplyFilterForStore();
        }
        private async void DateTimeStores_CloseUp(object sender, EventArgs e)
        {
            await _ApplyFilterForStore();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlHomePage());
        }

        private async void BtnPrintFullTheReportForStudent_Click(object sender, EventArgs e)
        {
            var data = await _bankService.GetAllStudentOperations();
            if (data != null)
            {
                PdfGenerator.Export(data, "Student Operations");
            }
        }
        private async void BtnPrintMonthTheReportForStudent_Click(object sender, EventArgs e)
        {
            var data = await _bankService.GetAllStudentOperationsInThisMonth();
            if (data != null)
            {
                PdfGenerator.Export(data, "Student Operations This Month");
            }
        }

        private async void BtnPrintFullTheReportForStore_Click(object sender, EventArgs e)
        {
            var data = await _bankService.GetAllStoreOperations();
            if (data != null)
            {
                PdfGenerator.Export(data, "Store Operations");
            }
        }
        private async void BtnPrintMonthTheReportForStore_Click(object sender, EventArgs e)
        {
            var data = await _bankService.GetAllStoreOperationsInThisMonth();
            if (data != null)
            {
                PdfGenerator.Export(data, "Store Operations This Month");
            }
        }

    }
}