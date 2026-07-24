using System;
using Common_Library;
using System.Windows.Forms;
using System.Threading.Tasks;
using University_Housing_Management_Project.Global;
using University_Housing_Management_Project.Services;
using University_Housing_Management_Project.DTOs.Auth;
using University_Housing_Management_Project.Forms.Home;

namespace University_Housing_Management_Project.Forms.Login
{
    public partial class frmLogin : Form
    {
        private readonly AuthService _authService = new AuthService();
        private readonly UserService _userService = new UserService();

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void BtnLogin_ClickAsync(object sender, EventArgs e)
        {
            await LoginAsync();
        }
        private async Task LoginAsync()
        {
            if (!ValidateInput())
                return;

            try
            {

                SetLoadingState(isLoading: true);

                var request = new LoginRequest
                {
                    Username = TxtUserName.Text.Trim(),
                    Password = TxtPassword.Text
                };

                var response = await _authService.LoginAsync(request);

                if (response == null)
                {
                    ShowErrorMessage("Invalid username or password.");
                    return;
                }

                CurrentUser.AccessToken = response.AccessToken;
                CurrentUser.RefreshToken = response.RefreshToken;
                CurrentUser.RefreshTokenExpiresAt = response.RefreshTokenExpiresAt;

                ApiClient.SetToken();

                var user = await _userService.GetCurrentUserAsync();

                if (user == null)
                {
                    ShowErrorMessage("Failed to load user information.");
                    return;
                }

                if (!user.IsActive)
                {
                    ShowErrorMessage("This account has been deactivated. Please contact administrator.");
                    return;
                }

                CurrentUser.UserId = user.UserId;
                CurrentUser.Username = user.Username;
                CurrentUser.Permissions = user.Permmission;
                CurrentUser.IsActive = user.IsActive;

                this.Hide();

                var frm = new frmHome();
                frm.FormClosed += (s, e) => Close();
                frm.Show();
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Connection error: {ex.Message}");
            }
            finally
            {
                SetLoadingState(isLoading: false);
            }
        }
       
        private bool ValidateInput()
        {
            if (ValidationHelper.IsTxtEmpty(TxtUserName.Text))
            {
                ShowErrorMessage("Please enter username.");
                return false;
            }

            if (ValidationHelper.IsTxtEmpty(TxtPassword.Text))
            {
                ShowErrorMessage("Please enter password.");
                return false;
            }

            return true;
        }
        private void SetLoadingState(bool isLoading)
        {
            BtnLogin.Enabled = !isLoading;
            TxtUserName.Enabled = !isLoading;
            TxtPassword.Enabled = !isLoading;

            this.Cursor = isLoading ? Cursors.WaitCursor : Cursors.Default;
        }
        private void ShowErrorMessage(string text)
        {
            string title = "Login failed";
            ShowMessagebox.Error(text, title, this);

            ClearTextboxes();
        }
        private void ClearTextboxes()
        {
            TxtPassword.Text = string.Empty;
            TxtUserName.Focus();
        }

    }
}