using System;
using Common_Library;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Helpers;
using University_Housing_Management_Project.Services;
using University_Housing_Management_Project.Global.Constants;
using University_Housing_Management_Project.Forms.Home.SubscriptionManagement.StudentSubscriptions;

namespace University_Housing_Management_Project.Forms.Home.SubscriptionManagement
{
    public partial class CtrlRenewSubscription : UserControl
    {

        private readonly RoomService _roomService = new RoomService();
        private readonly StudentService _studentService = new StudentService();
        private readonly SubscriptionService _subscriptionService = new SubscriptionService();
        private readonly SubscriptionTypeService _subscriptionTypeService = new SubscriptionTypeService();

        private string _StudentID = string.Empty;
        private DateTime _EndDate = DateTime.MinValue;

        public CtrlRenewSubscription(string StudentID, DateTime EndDate)
        {
            InitializeComponent();

            _StudentID = StudentID;
            _EndDate = EndDate;
        }

        // Load Data
        private async Task<bool> _IsStudentExist()
        {

            StudentDto student = await _studentService.FindByUniversityNumber(_StudentID);

            if (!ValidationHelper.ObjectIsNull(student))
            {
                var roomInfo = await _roomService.GetRoomById(student.RoomId);

                TxtUniversityNumber.Text = student.UniversityNumber;
                TxtFullName.Text = student.FullName;

                TxtRoomLocation.Text = roomInfo != null ? roomInfo.RoomLocation : "No Room Assigned";

                TimeSpan diff = DateTime.Now.Date - _EndDate;
                int numberOfDelayDay = diff.Days;

                // Allow delay 3 days
                if (numberOfDelayDay > Settings.numberOfDaysOfDealyAllowed)
                    TxtFine.Text = (numberOfDelayDay * Settings.latePenalty).ToString("N2");
                else
                    TxtFine.Text = 0m.ToString("N2");

                return true;
            }
            else
            {
                ShowMessagebox.Error("There is no student with this university ID number.",
                    "Not Found", ParentForm);
            }

            return false;
        }
        private void _FillComboBoxe(List<SubscriptionTypeDto> list, ComboBox comboBoxName)
        {
            comboBoxName.Items.Clear();

            if (list == null) return;

            foreach (var item in list)
            {
                comboBoxName.Items.Add(item.Description);
            }

            comboBoxName.SelectedIndex = -1;
        }
        private async void CtrlRenewSubscription_Load(object sender, EventArgs e)
        {
            try
            {
                var types = await _subscriptionTypeService.GetAllSubscriptionTypes();
                _FillComboBoxe(types, CbSubscriptionTypes);

                if (!await _IsStudentExist())
                    return;
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error loading renewal details: {ex.Message}", "Error", ParentForm);
            }
        }

        // Operations
        private async Task _CalculatSubscriptionCost()
        {
            if (CbSubscriptionTypes.SelectedIndex == -1)
                return;

            try
            {
                var subscriptionType = await _subscriptionTypeService
                    .GetSubscriptionTypeByDescription(CbSubscriptionTypes.Text);

                if (subscriptionType == null) return;

                decimal cost = subscriptionType.Price * 0.75m;
                TxtSubscriptionCost.Text = cost.ToString("N2");

                decimal.TryParse(TxtFine.Text, out decimal fineAmount);

                TxtTotalCost.Text = (cost + fineAmount).ToString("N2");
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error calculating cost: {ex.Message}", "Calculation Error", ParentForm);
            }
        }
        private async void CbSubscriptionTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _CalculatSubscriptionCost();
        }
        private async void BtnRenew_Click(object sender, EventArgs e)
        {

            if (CbSubscriptionTypes.SelectedIndex == -1)
            {
                ShowMessagebox.Error("The subscription period must be specified.",
                    "The operation failed.", ParentForm);

                CbSubscriptionTypes.Focus();
                return;
            }

            try
            {
                var subscriptionType = await _subscriptionTypeService.
                    GetSubscriptionTypeByDescription(CbSubscriptionTypes.Text);

                if (subscriptionType == null)
                {
                    ShowMessagebox.Error("Selected subscription type was not found.", "Process Failed", ParentForm);
                    return;
                }

                int subscriptionTypeID = subscriptionType.SubscriptionTypeId;

                decimal.TryParse(TxtFine.Text, out decimal latePenalty);

                if (await _subscriptionService.RenewSubscription(_StudentID, subscriptionTypeID, latePenalty))
                {
                    ShowMessagebox.Information("The subscription has been successfully renewed.",
                        "The operation was successful.", ParentForm);

                    BtnRenew.Enabled = false;
                }
                else
                {
                    ShowMessagebox.Error("Subscription renewal failed for this student.",
                        "The operation failed.", ParentForm);
                }
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"An error occurred during renewal: {ex.Message}", "System Error", ParentForm);
            }
        }
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlSubscriptionManagement());
        }
    
    }
}