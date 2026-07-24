using System;
using Common_Library;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Services;
using University_Housing_Management_Project.Helpers;
using University_Housing_Management_Project.Forms.Home.UserManagement.Users;

namespace University_Housing_Management_Project.Forms.Home.UserManagement
{
    public partial class CtrlAddNewUser : UserControl
    {

        private readonly UserService _userService = new UserService();
        private const int _FullPermission = 255;

        enum enMode { Add, Update }
        private enMode _Mode;

        private SimpleUserDto _User = null;
        private int _UserID = -1;

        public CtrlAddNewUser()
        {
            InitializeComponent();

            _Mode = enMode.Add;
        }
        public CtrlAddNewUser(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
            _Mode = enMode.Update;
        }

        // Load data
        private void _ConfigureUpdateMode()
        {
            TxtPassword.Visible = false;
            TxtConfirmPassword.Visible = false;

            LbNote1.Visible = false;
            LbNote2.Visible = false;

            LbConfirmPassword.Visible = false;
            LbPassword.Visible = false;

            LbUsername.Location = new Point(285, 218);
            TxtUserName.Location = new Point(293, 252);
        }
        private async Task _LoadData()
        {
            try
            {
                _User = await _userService.FindUserById(_UserID);

                if (_User == null)
                {
                    ShowMessagebox.Error("User not found.", "Error", ParentForm);
                    return;
                }

                TxtUserName.Text = _User.Username;
                LbTitle.Text = "Update User";

                _ConfigureUpdateMode();

                _CheckedPermissions(_User.Permmission);
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Failed to load user data: {ex.Message}"
                    , "Error", ParentForm);
            }
        }
        private void _DefaultData()
        {

            LbTitle.Text = "Add New User";

            TxtConfirmPassword.Clear();
            TxtUserName.Text = string.Empty;
            TxtPassword.Text = string.Empty;
        }
        private async void CtrlAddNewUser_Load(object sender, EventArgs e)
        {

            if (_Mode == enMode.Update)
                await _LoadData();
            else
                _DefaultData();
        }

        // Operations
        private int _CalculatPermmisson()
        {

            int Permission = 0;

            if (PermissionList.CheckedItems.Contains(PermissionList.Items[0]))
            {
                Permission += 1;
            }

            if (PermissionList.CheckedItems.Contains(PermissionList.Items[1]))
            {
                Permission += 2;
            }

            if (PermissionList.CheckedItems.Contains(PermissionList.Items[2]))
            {
                Permission += 4;
            }

            if (PermissionList.CheckedItems.Contains(PermissionList.Items[3]))
            {
                Permission += 8;
            }

            if (PermissionList.CheckedItems.Contains(PermissionList.Items[4]))
            {
                Permission += 16;
            }

            if (PermissionList.CheckedItems.Contains(PermissionList.Items[5]))
            {
                Permission += 32;
            }

            if (PermissionList.CheckedItems.Contains(PermissionList.Items[6]))
            {
                Permission += 64;
            }

            if (PermissionList.CheckedItems.Contains(PermissionList.Items[7]))
            {
                Permission += 128;
            }

            return Permission;
        }
        private void _CheckedPermissions(int permission)
        {

            if ((permission & 1) == 1)
            {
                PermissionList.SetItemChecked(0, true);
            }

            if ((permission & 2) == 2)
            {
                PermissionList.SetItemChecked(1, true);
            }

            if ((permission & 4) == 4)
            {
                PermissionList.SetItemChecked(2, true);
            }

            if ((permission & 8) == 8)
            {
                PermissionList.SetItemChecked(3, true);
            }

            if ((permission & 16) == 16)
            {
                PermissionList.SetItemChecked(4, true);
            }

            if ((permission & 32) == 32)
            {
                PermissionList.SetItemChecked(5, true);
            }

            if ((permission & 64) == 64)
            {
                PermissionList.SetItemChecked(6, true);
            }

            if ((permission & 128) == 128)
            {
                PermissionList.SetItemChecked(7, true);
            }

        }
        private async void BtnSave_Click(object sender, EventArgs e)
        {

            if (!_IsValidationSuccessfully())
                return;

            try
            {
                int permission = _CalculatPermmisson();
                var permissionValue = permission == _FullPermission ? -1 : permission;

                if (_Mode == enMode.Add)
                {

                    UserDto userDto = new UserDto
                    {

                        Username = TxtUserName.Text.Trim(),
                        Password = TxtPassword.Text.Trim(),
                        Permmission = permissionValue,
                        IsActive = true
                    };

                    var result = await _userService.AddUser(userDto);

                    if (result != null)
                    {

                        _User = await _userService.FindUserById(result.UserId);
                        _Mode = enMode.Update;

                        LbTitle.Text = "Update User";

                        _ConfigureUpdateMode();

                        ShowMessagebox.Information(
                            "Information saved successfully.",
                            "Success",
                            ParentForm);
                    }
                    else
                    {
                        ShowMessagebox.Error(
                            "Failed to save user.",
                            "Failed",
                            ParentForm);
                    }

                }
                else
                {
                    if (_User == null)
                    {
                        ShowMessagebox.Error("User reference is missing.", "Failed", ParentForm);
                        return;
                    }

                    SimpleUserDto updateUser = new SimpleUserDto
                    {
                        UserId = _User.UserId,
                        Username = TxtUserName.Text.Trim(),
                        Permmission = permissionValue,
                        IsActive = _User.IsActive,
                    };

                    var result = await _userService.UpdateUser(updateUser);

                    if (result != null)
                    {

                        _User = result;
                        _User.Username = result.Username;
                        _User.Permmission = permissionValue;

                        ShowMessagebox.Information(
                            "Information updated successfully.",
                            "Success",
                            ParentForm);
                    }
                    else
                    {
                        ShowMessagebox.Error(
                            "Failed to update user.",
                            "Failed",
                            ParentForm);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error occurred while saving: {ex.Message}"
                    , "Error", ParentForm);
            }

        }
        private void BtnReturn_Click(object sender, EventArgs e)
        {

            UserControlManagement.ShowUserControl(new CtrlUserManagement());
        }

        // Validation
        private bool _IsValidationSuccessfully()
        {

            if (ValidationHelper.IsTxtEmpty(TxtUserName.Text.Trim()))
            {

                ShowMessagebox.Error("The username must be filled in.",
                    "The save operation failed.", ParentForm);

                TxtUserName.Focus();
                return false;
            }

            if (_Mode == enMode.Add)
            {
                if (ValidationHelper.IsTxtEmpty(TxtPassword.Text.Trim()))
                {
                    ShowMessagebox.Error(
                        "The password field must be filled in.",
                        "The save operation failed.",
                        ParentForm);

                    TxtPassword.Focus();
                    return false;
                }

                if (ValidationHelper.IsTxtEmpty(TxtConfirmPassword.Text.Trim()))
                {
                    ShowMessagebox.Error(
                        "The confirm password field must be filled in.",
                        "The save operation failed.",
                        ParentForm);

                    TxtConfirmPassword.Focus();
                    return false;
                }

                if (TxtPassword.Text != TxtConfirmPassword.Text)
                {
                    ShowMessagebox.Error(
                        "Password and confirm password do not match.",
                        "Invalid input",
                        ParentForm);

                    TxtConfirmPassword.Clear();
                    TxtConfirmPassword.Focus();
                    return false;
                }
            }

            if (_CalculatPermmisson() == 0)
            {

                ShowMessagebox.Error("Permissions must be selected.",
                    "The save operation failed.", ParentForm);

                return false;
            }

            return true;
        }
        private async void TxtUserName_Leave(object sender, EventArgs e)
        {

            if (ValidationHelper.IsTxtEmpty(TxtUserName.Text.Trim()))
                return;

            try
            {
                if (_Mode == enMode.Add &&
                    await _userService.IsUserExist(TxtUserName.Text.Trim()))
                {

                    ShowMessagebox.Error("This username is not available.",
                        "Invalid input", ParentForm);

                    TxtUserName.Clear();
                    TxtUserName.Focus();
                    return;
                }

                if (_Mode == enMode.Update && _User != null &&
                    (await _userService.IsUserExist(TxtUserName.Text.Trim())
                    && TxtUserName.Text.Trim() != _User.Username))
                {

                    ShowMessagebox.Error("This username is not available.",
                        "Invalid input", ParentForm);

                    TxtUserName.Clear();
                    TxtUserName.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error checking username: {ex.Message}"
                    , "Error", ParentForm);
            }
        }
        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

            if (ValidationHelper.IsTxtEmpty(TxtPassword.Text.Trim())
                || _Mode == enMode.Update)
                return;

            if (string.IsNullOrWhiteSpace(TxtPassword.Text))
            {
                LbNote1.Visible = false;
                LbNote2.Visible = false;
                return;
            }

            bool isStrong =
                ValidationHelper.ValidatePasswordStrength(TxtPassword.Text);

            LbNote1.Visible = !isStrong;
            LbNote2.Visible = !isStrong;
        }

    }
}