using System;
using Common_Library;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Helpers;
using University_Housing_Management_Project.Services;
using University_Housing_Management_Project.Forms.Home.SubscriptionManagement.StudentSubscriptions;

namespace University_Housing_Management_Project.Forms.Home.SubscriptionManagement
{
    public partial class CtrlAddNewSubscription : UserControl
    {

        private readonly RoomService _roomService = new RoomService();
        private readonly StudentService _studentService = new StudentService();
        private readonly SubscriptionService _subscriptionService = new SubscriptionService();
        private readonly SubscriptionTypeService _subscriptionTypeService = new SubscriptionTypeService();

        public CtrlAddNewSubscription()
        {
            InitializeComponent();
        }

        // Load data
        private void _ClearStudentInfo()
        {
            TxtUniversityNumber.Clear();
            TxtFullName.Clear();
            TxtRoomLocation.Clear();
            TxtSubscriptionCost.Clear();
        }
        private void _FillComboBoxe(List<SubscriptionTypeDto> list, ComboBox comboBoxName)
        {
            comboBoxName.Items.Clear();

            if (list == null) return;

            foreach (var item in list)
            {
                comboBoxName.Items.Add(item.Description);
            }
        }
        private async void CtrlAddNewSubscription_Load(object sender, EventArgs e)
        {
            try
            {
                var types = await _subscriptionTypeService.GetAllSubscriptionTypes();
                _FillComboBoxe(types, CbSubscriptionTypes);
                TxtUniversityNumber.Focus();
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error loading subscription types: {ex.Message}", "Error", ParentForm);
            }
        }

        // Operations
        private async Task _CalculatSubscriptionCost()
        {
            
            if (CbSubscriptionTypes.SelectedIndex == -1)
                return;

            try
            {
                var subscriptionType = await _subscriptionTypeService.
                    GetSubscriptionTypeByDescription(CbSubscriptionTypes.Text);

                if (subscriptionType != null)
                {
                    TxtSubscriptionCost.Text = (subscriptionType.Price).ToString("N2");
                }
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error calculating cost: {ex.Message}", "Calculation Error", ParentForm);
            }
        }
        private async void BtnSave_Click(object sender, EventArgs e)
        {
            
            if (!_IsValidationSuccessfully())
                return;

            try
            {
                string universityNumber = TxtUniversityNumber.Text.Trim();
                var subscriptionType = await _subscriptionTypeService.
                    GetSubscriptionTypeByDescription(CbSubscriptionTypes.Text);

                if (subscriptionType == null)
                {
                    ShowMessagebox.Error("Selected subscription type was not found.", "Process Failed", ParentForm);
                    return;
                }

                bool result = await _subscriptionService.
                    AddStudentSubscription(universityNumber, subscriptionType.SubscriptionTypeId);

                if (result)
                {
                    ShowMessagebox.Information("This student has been successfully enrolled.",
                        "The subscription process has been completed.", ParentForm);

                    TxtUniversityNumber.ReadOnly = true;
                    TxtSubscriptionCost.ReadOnly = true;
                    TxtRoomLocation.ReadOnly = true;
                    TxtFullName.ReadOnly = true;

                    CbSubscriptionTypes.Enabled = false;
                    BtnSave.Enabled = false;
                }
                else
                {
                    ShowMessagebox.Error("Failed to complete the subscription process.",
                        "The subscription process failed.", ParentForm);
                }
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"An error occurred while saving: {ex.Message}", "System Error", ParentForm);
            }
        }
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlSubscriptionManagement());
        }

        // Validations
        private bool _IsValidationSuccessfully()
        {

            if (ValidationHelper.IsTxtEmpty(TxtFullName.Text))
            {
                ShowMessagebox.Error("A student must be selected first.",
                    "The subscription process failed.", ParentForm);

                return false;
            }

            if (CbSubscriptionTypes.SelectedIndex == -1)
            {
                ShowMessagebox.Error("The subscription type must be specified first.",
                    "The subscription process failed.", ParentForm);

                return false;
            }

            return true;
        }
        private async void CbSubscriptionTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _CalculatSubscriptionCost();
        }
        private async void TxtUniversityNumber_Leave(object sender, EventArgs e)
        {
            
            if (ValidationHelper.IsTxtEmpty(TxtUniversityNumber.Text.Trim()))
                return;

            try
            {
                string uniNumber = TxtUniversityNumber.Text.Trim();
                StudentDto student = await _studentService.FindByUniversityNumber(uniNumber);

                if (ValidationHelper.ObjectIsNull(student))
                {
                    ShowMessagebox.Error($"There is no student with {uniNumber}.",
                        "Not found", ParentForm);

                    _ClearStudentInfo();
                    TxtUniversityNumber.Focus();
                    return;
                }

                if (await _subscriptionService.IsStudentSubscriptionExist(uniNumber))
                {
                    ShowMessagebox.Information("This student is already enrolled.",
                        "The student is a subscriber.", ParentForm);

                    _ClearStudentInfo();
                    TxtUniversityNumber.Focus();
                    return;
                }

                var roomInfo = await _roomService.GetRoomById(student.RoomId);

                TxtRoomLocation.Text = roomInfo != null ? roomInfo.RoomLocation : "No Room Assigned";
                TxtFullName.Text = student.FullName;
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error validating student ID: {ex.Message}", "Error", ParentForm);
            }
        }

    }
}