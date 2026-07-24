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

namespace University_Housing_Management_Project.Forms.Home.SubscriptionManagement.StudentSubscriptions
{
    public partial class CtrlSubscriptionManagement : UserControl
    {

        private readonly SubscriptionService _subscriptionService = new SubscriptionService();
        private readonly SubscriptionTypeService _subscriptionTypeService = new SubscriptionTypeService();

        private List<AllSubscriptionsDto> _GetAllSubscriptions;

        public CtrlSubscriptionManagement()
        {
            InitializeComponent();
        }

        // Load Data
        private void _DefaultSelected()
        {
            TxtSearch.Text = string.Empty;

            CbSubscriptionTypes.SelectedItem = "All";
            CbSubscriptionStatus.SelectedItem = "Active";
            CbExpiryDate.SelectedItem = "All";
        }
        private void _FillComboBoxe(List<SubscriptionTypeDto> list, ComboBox comboBoxName)
        {
            //comboBoxName.Items.Clear();

            if (list == null) return;

            foreach (var item in list)
            {
                comboBoxName.Items.Add(item.Description);
            }
        }
        private async Task _RefreshDataGridView()
        {
            try
            {
                await _subscriptionService.DeactivateExpiredSubscriptions();
                _GetAllSubscriptions = await _subscriptionService.GetAllSubscriptions();
                DGVShowSubscriptionsInfo.DataSource = _GetAllSubscriptions;

                _DefaultSelected();
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error refreshing subscriptions: {ex.Message}", "Error", ParentForm);
            }
        }
        private async void CtrlSubscriptionManagement_Load(object sender, EventArgs e)
        {
            try
            {
                await _RefreshDataGridView();

                var types = await _subscriptionTypeService.GetAllSubscriptionTypes();
                _FillComboBoxe(types, CbSubscriptionTypes);


                if (DGVShowSubscriptionsInfo.Rows.Count > 0 && DGVShowSubscriptionsInfo.Columns.Count > 0)
                {
                    DGVShowSubscriptionsInfo.Columns[0].HeaderText = "Uni. number";
                    DGVShowSubscriptionsInfo.Columns[1].HeaderText = "Name";
                    DGVShowSubscriptionsInfo.Columns[2].HeaderText = "Room location";
                    DGVShowSubscriptionsInfo.Columns[3].HeaderText = "Subscription type";
                    DGVShowSubscriptionsInfo.Columns[4].HeaderText = "Status";
                    DGVShowSubscriptionsInfo.Columns[5].HeaderText = "Start date";
                    DGVShowSubscriptionsInfo.Columns[6].HeaderText = "End date";

                    DGVShowSubscriptionsInfo.Columns[0].Width = 110;
                    DGVShowSubscriptionsInfo.Columns[1].Width = 110;
                    DGVShowSubscriptionsInfo.Columns[2].Width = 270;
                    DGVShowSubscriptionsInfo.Columns[3].Width = 100;
                    DGVShowSubscriptionsInfo.Columns[4].Width = 80;
                    DGVShowSubscriptionsInfo.Columns[5].Width = 101;
                    DGVShowSubscriptionsInfo.Columns[6].Width = 120;
                }
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error loading management page: {ex.Message}", "Error", ParentForm);
            }
        }

        // Filters
        private async Task _ApplyFilter()
        {
            try
            {
                var filter = new SubscriptionsFilterDto
                {
                    StudentName = TxtSearch.Text.Trim(),
                    NearestOrFurthestDate = CbExpiryDate.Text,
                    SubscriptionStatus = CbSubscriptionStatus.Text,
                    SubscriptionType = CbSubscriptionTypes.Text
                };

                var result = await _subscriptionService.StudentSubscriptionsFilter(filter);
                DGVShowSubscriptionsInfo.DataSource = result;
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error applying filters: {ex.Message}", "Error", ParentForm);
            }
        }
        private async void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            await _ApplyFilter();
        }
        private async void CbSubscriptionTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _ApplyFilter();
        }
        private async void CbSubscriptionStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _ApplyFilter();
        }
        private async void CbExpiryDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _ApplyFilter();
        }

        // Operations
        private async void BtnAddNewSubscription_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlAddNewSubscription());
            await _RefreshDataGridView();
        }
        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            await _RefreshDataGridView();
            await _ApplyFilter();
        }
        private void BtnRenewSubscription_Click(object sender, EventArgs e)
        {
            
            if (DGVShowSubscriptionsInfo.CurrentRow == null || DGVShowSubscriptionsInfo.Rows.Count <= 0)
                return;

            string status = DGVShowSubscriptionsInfo.CurrentRow.Cells[4].Value?.ToString();

            if (status != "Unactive")
                return;

            string studentID = DGVShowSubscriptionsInfo.CurrentRow.Cells[0].Value?.ToString();
            string dateStr = DGVShowSubscriptionsInfo.CurrentRow.Cells[6].Value?.ToString();

            if (DateTime.TryParse(dateStr, out DateTime endDate) && !string.IsNullOrWhiteSpace(studentID))
            {
                UserControlManagement.ShowUserControl(new CtrlRenewSubscription(studentID, endDate));
                BtnRefresh_Click(null, null);
            }
            else
            {
                ShowMessagebox.Error("Invalid student or date information selected.", "Error", ParentForm);
            }
        }
        private void RenewSubscriptionInfoItem_Click(object sender, EventArgs e)
        {
            BtnRenewSubscription_Click(null, null);
        }
        private async void BtnPrintTheReport_Click(object sender, EventArgs e)
        {
            try
            {
                var activeSubscriptions = await _subscriptionService.GetAllActiveSubscriptions();
                PdfGenerator.Export(activeSubscriptions, "Student Subscriptions");
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error printing report: {ex.Message}", "Error", ParentForm);
            }
        }
        private void CMStripSubscriptions_Opening(object sender, CancelEventArgs e)
        {
            RenewSubscriptionInfoItem.Visible = false;

            if (DGVShowSubscriptionsInfo.CurrentRow == null || DGVShowSubscriptionsInfo.Rows.Count <= 0)
                return;

            string status = DGVShowSubscriptionsInfo.CurrentRow.Cells[4].Value?.ToString();
            RenewSubscriptionInfoItem.Visible = (status == "Unactive");
        }

    }
}