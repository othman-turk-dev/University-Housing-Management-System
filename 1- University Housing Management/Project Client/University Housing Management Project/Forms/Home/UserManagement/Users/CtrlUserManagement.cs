using System;
using Common_Library;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Helpers;
using University_Housing_Management_Project.Services;

namespace University_Housing_Management_Project.Forms.Home.UserManagement.Users
{
    public partial class CtrlUserManagement : UserControl
    {

        private readonly UserService _userService = new UserService();

        List<CustomUserDto> _AllUsers = null;

        public CtrlUserManagement()
        {
            InitializeComponent();
        }

        // Load data
        private async Task _RefreshDataGridView()
        {
            try
            {
                TxtSearch.Text = string.Empty;

                _AllUsers = await _userService.GetAllUsers();
                DGVShowAllUsers.DataSource = _AllUsers;
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Failed to load users data: {ex.Message}"
                    , "Error", ParentForm);
            }
        }
        private async void CtrlUserManagement_Load(object sender, EventArgs e)
        {
           
            await _RefreshDataGridView();

            if (DGVShowAllUsers.Rows.Count > 0 && DGVShowAllUsers.Columns.Count > 0)
            {
                DGVShowAllUsers.Columns[0].HeaderText = "User id";
                DGVShowAllUsers.Columns[1].HeaderText = "Username";
                DGVShowAllUsers.Columns[2].HeaderText = "Status";
                DGVShowAllUsers.Columns[3].HeaderText = "Students";
                DGVShowAllUsers.Columns[4].HeaderText = "Subscriptions";
                DGVShowAllUsers.Columns[5].HeaderText = "Rooms";
                DGVShowAllUsers.Columns[6].HeaderText = "Products";
                DGVShowAllUsers.Columns[7].HeaderText = "Sales";
                DGVShowAllUsers.Columns[8].HeaderText = "Violations";
                DGVShowAllUsers.Columns[9].HeaderText = "Users";
                DGVShowAllUsers.Columns[10].HeaderText = "Bank";
            }
        }

        // Operations
        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            await _RefreshDataGridView();
        }
        private async void BtnAddNewUser_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlAddNewUser());
            await _RefreshDataGridView();
        }
        private async void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            
            if (DGVShowAllUsers.Rows.Count <= 0 || DGVShowAllUsers.CurrentRow == null)
                return;

            var idValue = DGVShowAllUsers.CurrentRow.Cells[0].Value;
            if (idValue == null)
                return;

            int UserID = Convert.ToInt32(idValue);

            UserControlManagement.ShowUserControl(new CtrlAddNewUser(UserID));
            await _RefreshDataGridView();
        }
        private async void ChangePasswordItem_Click(object sender, EventArgs e)
        {
            
            if (DGVShowAllUsers.Rows.Count <= 0 || DGVShowAllUsers.CurrentRow == null)
                return;

            var idValue = DGVShowAllUsers.CurrentRow.Cells[0].Value;
            if (idValue == null)
                return;

            int UserID = Convert.ToInt32(idValue);

            UserControlManagement.ShowUserControl(new CtrlChangePassword(UserID));
            await _RefreshDataGridView();
        }
        private async void BtnActive_Click(object sender, EventArgs e)
        {
            
            if (DGVShowAllUsers.Rows.Count <= 0 || DGVShowAllUsers.CurrentRow == null)
                return;

            var statusValue = DGVShowAllUsers.CurrentRow.Cells["Status"].Value;
            var idValue = DGVShowAllUsers.CurrentRow.Cells[0].Value;

            if (statusValue == null || idValue == null)
                return;

            string Status = statusValue.ToString();

            if (Status == "Active")
                return;

            DialogResult result = ShowMessagebox.Question("Are you sure you want to activate this user?",
                "Confirmation", ParentForm);

            if (result == DialogResult.Yes)
            {
                int UserID = Convert.ToInt32(idValue);

                try
                {
                    if (await _userService.SetActive(UserID))
                        ShowMessagebox.Information("The user has been successfully activated.",
                            "The operation was successful.", ParentForm);
                    else
                        ShowMessagebox.Error("Unable to activate this user.",
                            "The operation failed.", ParentForm);

                    await _RefreshDataGridView();
                }
                catch (Exception ex)
                {
                    ShowMessagebox.Error($"Error activating user: {ex.Message}"
                        , "Error", ParentForm);
                }
            }
        }
        private async void BtnInActiveUser_Click(object sender, EventArgs e)
        {
            
            if (DGVShowAllUsers.Rows.Count <= 0 || DGVShowAllUsers.CurrentRow == null)
                return;

            var statusValue = DGVShowAllUsers.CurrentRow.Cells["Status"].Value;
            var idValue = DGVShowAllUsers.CurrentRow.Cells[0].Value;

            if (statusValue == null || idValue == null)
                return;

            string Status = statusValue.ToString();

            if (Status == "Inactive")
                return;

            DialogResult result = ShowMessagebox.Question("Are you sure you want to deactivate this user?",
                "Confirmation", ParentForm);

            if (result == DialogResult.Yes)
            {
                int UserID = Convert.ToInt32(idValue);

                try
                {
                    if (await _userService.SetInActive(UserID))
                        ShowMessagebox.Information("The user has been successfully deactivated.",
                            "The operation was successful.", ParentForm);
                    else
                        ShowMessagebox.Error("Unable to deactivate this user.",
                            "The operation failed.", ParentForm);

                    await _RefreshDataGridView();
                }
                catch (Exception ex)
                {
                    ShowMessagebox.Error($"Error deactivating user: {ex.Message}", "Error", ParentForm);
                }
            }
        }

        // Filter
        private async void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _AllUsers = await _userService.UsersFilter(TxtSearch.Text);
                DGVShowAllUsers.DataSource = _AllUsers;
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Filter error: {ex.Message}", "Error", ParentForm);
            }
        }

    }
}