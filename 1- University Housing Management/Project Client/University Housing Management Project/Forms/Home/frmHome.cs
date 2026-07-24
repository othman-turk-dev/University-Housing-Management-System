using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.Global;
using University_Housing_Management_Project.Helpers;
using University_Housing_Management_Project.Services;
using University_Housing_Management_Project.DTOs.Auth;
using University_Housing_Management_Project.Forms.Login;
using University_Housing_Management_Project.Forms.Home.AboutMe;
using University_Housing_Management_Project.Forms.Home.UserManagement.Users;
using University_Housing_Management_Project.Forms.Home.SaleManagement.Sales;
using University_Housing_Management_Project.Forms.Home.RoomManagement.Rooms;
using University_Housing_Management_Project.Forms.Home.ProductManagement.Products;
using University_Housing_Management_Project.Forms.Home.StudentManagement.Students;
using University_Housing_Management_Project.Forms.Home.ViolationManagement.Violations;
using University_Housing_Management_Project.Forms.Home.SubscriptionManagement.StudentSubscriptions;

namespace University_Housing_Management_Project.Forms.Home
{
    public partial class frmHome : Form
    {
        private readonly AuthService _authService = new AuthService();

        [Flags]
        private enum enPermission
        {
            All = -1,
            StudentManagement = 1,
            SubscriptionManagement = 2,
            RoomManagement = 4,
            Products = 8,
            Sales = 16,
            Violations = 32,
            UserManagement = 64
        }

        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            UserControlManagement.Initialize(PnContainAllUserControls);
            UserControlManagement.ShowUserControl(new CtrlHomePage());

            _ChangeButtonImageAndColors(BtnHomePage);
            _SetThePermissionToTheUser(CurrentUser.Permissions);
        }
        private void _SetThePermissionToTheUser(int permission)
        {
            if (permission == (int)enPermission.All)
                return;

            BtnStudentManagement.Enabled = (permission & (int)enPermission.StudentManagement) == (int)enPermission.StudentManagement;
            BtnSubscriptionManagement.Enabled = (permission & (int)enPermission.SubscriptionManagement) == (int)enPermission.SubscriptionManagement;
            BtnRoomManagement.Enabled = (permission & (int)enPermission.RoomManagement) == (int)enPermission.RoomManagement;
            BtnProducts.Enabled = (permission & (int)enPermission.Products) == (int)enPermission.Products;
            BtnSales.Enabled = (permission & (int)enPermission.Sales) == (int)enPermission.Sales;
            BtnViolations.Enabled = (permission & (int)enPermission.Violations) == (int)enPermission.Violations;
            BtnUserManagment.Enabled = (permission & (int)enPermission.UserManagement) == (int)enPermission.UserManagement;
        }
        private void _ChangeButtonImageAndColors(Guna.UI2.WinForms.Guna2Button clickedButton)
        {
            Color defaultFill = Color.FromArgb(30, 60, 90);
            Color activeFore = Color.FromArgb(30, 60, 90);

            var buttonsInfo = new Dictionary<Guna.UI2.WinForms.Guna2Button, (Color fill, Color fore, Image imgActive, Image imgInActive)>
            {
                { BtnHomePage, (Color.White, activeFore, Properties.Resources.hom1, Properties.Resources.Hom) },
                { BtnStudentManagement, (Color.White, activeFore, Properties.Resources.users_4x, Properties.Resources.ue1) },
                { BtnSubscriptionManagement, (Color.White, activeFore, Properties.Resources.subscription_model__1_, Properties.Resources.subscription_model) },
                { BtnRoomManagement, (Color.White, activeFore, Properties.Resources.door_handle__1_, Properties.Resources.door_handle) },
                { BtnProducts, (Color.White, activeFore, Properties.Resources.wsq1, Properties.Resources.food_svgrepo_com) },
                { BtnSales, (Color.White, activeFore, Properties.Resources.shopping_bag__1_, Properties.Resources.shopping_bag) },
                { BtnViolations, (Color.White, activeFore, Properties.Resources.ban__2_, Properties.Resources.ban) },
                { BtnUserManagment, (Color.White, activeFore, Properties.Resources.user_laptop_4x, Properties.Resources.e1) },
                { BtnAboutProgrammer, (Color.White, activeFore, Properties.Resources.AboutProgrammer2, Properties.Resources.AboutProgrammer) },
                { BtnExite, (Color.White, activeFore, Properties.Resources.z1, Properties.Resources.arrow_door_out_3_4x) }
            };

            foreach (var kvp in buttonsInfo)
            {
                var btn = kvp.Key;
                var info = kvp.Value;

                if (btn == clickedButton)
                {
                    btn.FillColor = info.fill;
                    btn.ForeColor = info.fore;
                    btn.Image = info.imgActive;
                }
                else
                {
                    btn.FillColor = defaultFill;
                    btn.ForeColor = Color.White;
                    btn.Image = info.imgInActive;
                }
            }
        }

        private void BtnHomePage_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlHomePage());
            _ChangeButtonImageAndColors(BtnHomePage);
        }
        private void BtnStudentManagement_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlStudentsInformation());
            _ChangeButtonImageAndColors(BtnStudentManagement);
        }
        private void BtnRoomManagement_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlRoomManagement());
            _ChangeButtonImageAndColors(BtnRoomManagement);
        }
        private void BtnSubscriptionManagement_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlSubscriptionManagement());
            _ChangeButtonImageAndColors(BtnSubscriptionManagement);
        }
        private void BtnProducts_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlProductManagement());
            _ChangeButtonImageAndColors(BtnProducts);
        }
        private void BtnSales_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlSaleManagement());
            _ChangeButtonImageAndColors(BtnSales);
        }
        private void BtnViolations_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlViolationManagement());
            _ChangeButtonImageAndColors(BtnViolations);
        }
        private void BtnUserManagment_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlUserManagement());
            _ChangeButtonImageAndColors(BtnUserManagment);
        }
        private void BtnAboutProgrammer_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlAboutMe());
            _ChangeButtonImageAndColors(BtnAboutProgrammer);
        }
        private async void BtnExite_Click(object sender, EventArgs e)
        {
            _ChangeButtonImageAndColors(BtnExite);
            await LogoutAsync();
        }

        private async Task LogoutAsync()
        {
            try
            {
                var request = new LogoutRequest
                {
                    Username = CurrentUser.Username,
                    RefreshToken = CurrentUser.RefreshToken
                };

                await _authService.LogoutAsync(request);
            }
            catch
            {
                // Ignoring network failures on logout to guarantee user can return to login screen
            }
            finally
            {
                CurrentUser.Clear();
                ApiClient.client.DefaultRequestHeaders.Authorization = null;

                this.Hide();
                var login = new frmLogin();
                login.FormClosed += (s, e) => Close();
                login.Show();
            }
        }
    
    }
}