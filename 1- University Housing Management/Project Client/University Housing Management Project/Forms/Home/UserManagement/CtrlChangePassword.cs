using System;
using Common_Library;
using System.Windows.Forms;
using System.Threading.Tasks;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Helpers;
using University_Housing_Management_Project.Services;

namespace University_Housing_Management_Project.Forms.Home.UserManagement.Users
{
    public partial class CtrlChangePassword : UserControl
    {
        private readonly UserService _userService = new UserService();

        int _userid = -1;
        SimpleUserDto _user = null;

        public CtrlChangePassword(int userid)
        {
            InitializeComponent();

            _userid = userid;
        }

        private async Task _loadData()
        {
            try
            {
                _user = await _userService.FindUserById(_userid);

                if (_user == null)
                {
                    ShowMessagebox.Error(
                        "User not found.",
                        "Error",
                        ParentForm);

                    BtnSave.Enabled = false;
                    return;
                }

                TxtUserName.Text = _user.Username;
                TxtUserName.ReadOnly = true;

                LbNote1.Visible = false;
                LbNote2.Visible = false;
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error(
                    $"Failed to load user data: {ex.Message}",
                    "Error",
                    ParentForm);

                BtnSave.Enabled = false;
            }
        }
        private async void CtrlChangePassword_Load(object sender, EventArgs e)
        {
            await _loadData();
        }
        private async void BtnSave_Click(object sender, EventArgs e)
        {
            
            if (!_IsValidationSuccessfully())
                return;

            try
            {
                ChangePasswordDto dto = new ChangePasswordDto
                {
                    UserId = _user.UserId,
                    CurrentPassword = TxtCurrentPassword.Text.Trim(),
                    NewPassword = TxtNewPassword.Text.Trim()
                };

                bool result = await _userService.ChangePassword(dto);

                if (result)
                {
                    ShowMessagebox.Information(
                        "Password changed successfully.",
                        "Success",
                        ParentForm);

                    BtnSave.Enabled = false;

                    TxtCurrentPassword.Clear();
                    TxtNewPassword.Clear();
                    TxtConfirmPassword.Clear();
                }
                else
                {
                    ShowMessagebox.Error(
                        "Failed to change password.",
                        "Failed",
                        ParentForm);
                }
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error(
                    $"Error occurred while changing password: {ex.Message}",
                    "Error",
                    ParentForm);
            }
        }
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlUserManagement());
        }

        private bool _IsValidationSuccessfully()
        {

            if (ValidationHelper.IsTxtEmpty(TxtCurrentPassword.Text.Trim()))
            {
                ShowMessagebox.Error(
                    "Current password is required.",
                    "Change password failed.",
                    ParentForm);

                TxtCurrentPassword.Focus();
                return false;
            }

            if (ValidationHelper.IsTxtEmpty(TxtNewPassword.Text.Trim()))
            {
                ShowMessagebox.Error(
                    "New password is required.",
                    "Change password failed.",
                    ParentForm);

                TxtNewPassword.Focus();
                return false;
            }

            if (ValidationHelper.IsTxtEmpty(TxtConfirmPassword.Text.Trim()))
            {
                ShowMessagebox.Error(
                    "Confirm password is required.",
                    "Change password failed.",
                    ParentForm);

                TxtConfirmPassword.Focus();
                return false;
            }

            if (!ValidationHelper.ValidatePasswordStrength(TxtNewPassword.Text.Trim()))
            {
                ShowMessagebox.Error(
                    "The new password is weak.",
                    "Invalid input.",
                    ParentForm);

                TxtNewPassword.Focus();
                return false;
            }

            if (TxtNewPassword.Text.Trim() != TxtConfirmPassword.Text.Trim())
            {
                ShowMessagebox.Error(
                    "The new password and confirmation password do not match.",
                    "Invalid input.",
                    ParentForm);

                TxtConfirmPassword.Focus();
                return false;
            }

            if (TxtCurrentPassword.Text.Trim() == TxtNewPassword.Text.Trim())
            {
                ShowMessagebox.Error(
                    "The new password must be different from the current password.",
                    "Invalid input.",
                    ParentForm);

                TxtNewPassword.Focus();
                return false;
            }

            return true;
        }
        private void TxtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNewPassword.Text))
            {
                LbNote1.Visible = false;
                LbNote2.Visible = false;
                return;
            }

            bool isStrong =
                ValidationHelper.ValidatePasswordStrength(TxtNewPassword.Text);

            LbNote1.Visible = !isStrong;
            LbNote2.Visible = !isStrong;
        }
    
    }
}