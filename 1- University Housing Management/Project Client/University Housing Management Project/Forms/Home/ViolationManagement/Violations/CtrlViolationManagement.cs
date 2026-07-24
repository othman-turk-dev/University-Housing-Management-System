using System;
using Common_Library;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Helpers;
using University_Housing_Management_Project.Services;
using University_Housing_Management_Project.Helpers.Pdf;

namespace University_Housing_Management_Project.Forms.Home.ViolationManagement.Violations
{
    public partial class CtrlViolationManagement : UserControl
    {

        private readonly ViolationService _violationService = new ViolationService();
        private readonly ViolationTypeService _violationTypeService = new ViolationTypeService();

        List<AllViolationsDto> _AllViolation = null;

        public CtrlViolationManagement()
        {
            InitializeComponent();
        }

        // Load data
        private async Task _LoadData()
        {
            try
            {
                _AllViolation = await _violationService.GetAllViolations();
                DGVShowAllViolations.DataSource = _AllViolation;
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Failed to load violations: {ex.Message}", "Error", ParentForm);
            }
        }
        private void _DefaultSelected()
        {
            TxtSearch.Text = string.Empty;
            ChBDateFilter.Checked = false;

            CbIsPaidFilter.Text = "Unpaid";
            CbViolationTypesFilter.Text = "All";

            DateTimeViolation.MaxDate = DateTime.Now.AddSeconds(+3);
            DateTimeViolation.MinDate = DateTime.Now.AddYears(-1);
            DateTimeViolation.Value = DateTime.Now;
        }
        private async Task _FillAllComboboxes()
        {
            try
            {
                var list = await _violationTypeService.GetAllViolationTypes();

                if (list != null)
                {
                    foreach (var row in list)
                    {
                        CbViolationTypesFilter.Items.Add(row.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Failed to load violation types: {ex.Message}"
                    , "Error", ParentForm);
            }
        }
        private async Task _RefreshDataGridView()
        {
            await _LoadData();
            _DefaultSelected();
            await _ApplyFilters();
        }
        private async void CtrlViolationManagement_Load(object sender, EventArgs e)
        {
            await _RefreshDataGridView();
            await _FillAllComboboxes();

            if (DGVShowAllViolations.Rows.Count > 0 && DGVShowAllViolations.Columns.Count > 0)
            {

                DGVShowAllViolations.Columns[0].HeaderText = "Id";
                DGVShowAllViolations.Columns[0].Width = 38;

                DGVShowAllViolations.Columns[1].HeaderText = "Violation type";
                DGVShowAllViolations.Columns[1].Width = 360;

                DGVShowAllViolations.Columns[2].HeaderText = "Student";
                DGVShowAllViolations.Columns[2].Width = 130;

                DGVShowAllViolations.Columns[3].HeaderText = "Uni. number";
                DGVShowAllViolations.Columns[3].Width = 140;

                DGVShowAllViolations.Columns[4].HeaderText = "IsPaid";
                DGVShowAllViolations.Columns[4].Width = 80;

                DGVShowAllViolations.Columns[5].HeaderText = "Fine";
                DGVShowAllViolations.Columns[5].Width = 90;

                DGVShowAllViolations.Columns[6].Width = 120;

                DGVShowAllViolations.Columns[7].HeaderText = "Username";
            }
        }

        // Filter
        private async Task _ApplyFilters()
        {
            try
            {
                ViolationsFilterDto violationsFilterDto = new ViolationsFilterDto
                {
                    StudentName = TxtSearch.Text.Trim(),
                    ViolationDate = (ChBDateFilter.Checked) ? DateTimeViolation.Value.Date : (DateTime?)null,
                    PaymentStatus = CbIsPaidFilter.Text,
                    ViolationType = CbViolationTypesFilter.Text,
                };

                var result = await _violationService.FilterViolation(violationsFilterDto);

                DGVShowAllViolations.DataSource = result;
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Filter error: {ex.Message}", "Error", ParentForm);
            }
        }
        private async void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            await _ApplyFilters();
        }
        private async void CbViolationTypesFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _ApplyFilters();
        }
        private async void CbIsPaidFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _ApplyFilters();
        }
        private async void ChBDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            await _ApplyFilters();
        }
        private async void DateTimeViolation_CloseUp(object sender, EventArgs e)
        {
            await _ApplyFilters();
        }

        // Operations
        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            await _RefreshDataGridView();
        }
        private async void BtnAddNewViolation_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlAddNewViolation());
            await _RefreshDataGridView();
        }
        private async void PaidFineItem_Click(object sender, EventArgs e)
        {
            
            if (DGVShowAllViolations.Rows.Count <= 0 || DGVShowAllViolations.CurrentRow == null)
                return;

            var fineValue = DGVShowAllViolations.CurrentRow.Cells[5].Value;
            var nameValue = DGVShowAllViolations.CurrentRow.Cells[2].Value;
            var idValue = DGVShowAllViolations.CurrentRow.Cells[0].Value;

            if (fineValue == null || nameValue == null || idValue == null)
                return;

            decimal Fine = Convert.ToDecimal(fineValue.ToString());
            string Name = nameValue.ToString();

            DialogResult result = ShowMessagebox.Question($"For the student: {Name} \n " +
                $"Do you definitely want to pay this fine {Fine}?",
                "Confirmation", ParentForm);

            if (result == DialogResult.Yes)
            {
                int ViolationID = Convert.ToInt32(idValue.ToString());

                try
                {
                    if (await _violationService.PayFineForViolation(ViolationID))
                        ShowMessagebox.Information("Payment successful.",
                            "The operation was successful.", ParentForm);
                    else
                        ShowMessagebox.Error("Payment for this violation could not be processed.",
                            "The operation failed.", ParentForm);

                    await _RefreshDataGridView();
                }
                catch (Exception ex)
                {
                    ShowMessagebox.Error($"Payment process failed: {ex.Message}"
                        , "Error", ParentForm);
                }
            }
        }
        private async void DeleteViolationItem_Click(object sender, EventArgs e)
        {
            
            if (DGVShowAllViolations.Rows.Count <= 0 || DGVShowAllViolations.CurrentRow == null)
                return;

            var idValue = DGVShowAllViolations.CurrentRow.Cells[0].Value;
            if (idValue == null)
                return;

            DialogResult result = ShowMessagebox.Question($"Are you sure you want to delete this violation?",
                "Confirmation", ParentForm);

            if (result == DialogResult.Yes)
            {
                int ViolationID = Convert.ToInt32(idValue.ToString());

                try
                {
                    if (await _violationService.DeleteViolation(ViolationID))
                        ShowMessagebox.Information("Deleted successfully.",
                            "The operation was successful.", ParentForm);
                    else
                        ShowMessagebox.Error("Unable to delete this violation\nthere is associated data.",
                            "The operation failed.", ParentForm);

                    await _RefreshDataGridView();
                }
                catch (Exception ex)
                {
                    ShowMessagebox.Error($"Delete process failed: {ex.Message}"
                        , "Error", ParentForm);
                }
            }
        }
        private void BtnStatistics_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlViolationsStatistics());
        }
        private void BtnShowViolations_Click(object sender, EventArgs e)
        {
            
            if (DGVShowAllViolations.Rows.Count <= 0 || DGVShowAllViolations.CurrentRow == null)
                return;

            var studentIdValue = DGVShowAllViolations.CurrentRow.Cells[3].Value;
            if (studentIdValue == null)
                return;

            string StudentID = studentIdValue.ToString();

            UserControlManagement.ShowUserControl(new CtrlShowViolationDetails(StudentID));
        }
        private void BtnPrintTheReport_Click(object sender, EventArgs e)
        {
            
            if (_AllViolation == null || _AllViolation.Count == 0)
            {
                ShowMessagebox.Error("No data available to print.", "Warning", ParentForm);
                return;
            }

            try
            {
                PdfGenerator.Export(_AllViolation, "Violations");
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Export error: {ex.Message}", "Error", ParentForm);
            }
        }

        // Validations
        private void CMStripViolations_Opening(object sender, CancelEventArgs e)
        {
            
            DeleteViolationItem.Visible = false;
            PaidFineItem.Visible = false;

            if (DGVShowAllViolations.Rows.Count <= 0 || DGVShowAllViolations.CurrentRow == null)
                return;

            DeleteViolationItem.Visible = true;

            var isPaidValue = DGVShowAllViolations.CurrentRow.Cells[4].Value;
            if (isPaidValue != null)
            {
                PaidFineItem.Visible = isPaidValue.ToString() == "Unpaid";
            }
        }

    }
}