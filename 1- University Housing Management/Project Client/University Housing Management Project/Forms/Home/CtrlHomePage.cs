using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using University_Housing_Management_Project.Global;
using University_Housing_Management_Project.Helpers;
using University_Housing_Management_Project.Services;
using University_Housing_Management_Project.Forms.Home.BankManagement.Bank;

namespace University_Housing_Management_Project.Forms.Home
{
    public partial class CtrlHomePage : UserControl
    {
        private readonly RoomService _roomService = new RoomService();
        private readonly StudentService _studentService = new StudentService();

        [Flags]
        private enum enPermission
        {
            All = -1,
            BankManagement = 128
        }

        public CtrlHomePage()
        {
            InitializeComponent();
        }
        private async void CtrlHomePage_Load(object sender, EventArgs e)
        {
            _CheckPermissions();
            await _FillLabelsAsync();
        }

        private void _CheckPermissions()
        {
            int permission = CurrentUser.Permissions;

            if (permission == (int)enPermission.All)
                return;

            bool hasBankPermission = (permission & (int)enPermission.BankManagement) == (int)enPermission.BankManagement;
            BtnBank.Enabled = hasBankPermission;
        }
        private async Task _FillLabelsAsync()
        {
            try
            {
                var totalRoomsFillTask = _roomService.GetTotalRoomsFillAsync();
                var totalRoomsTask = _roomService.GetTotalRoomsAsync();
                var studentCountTask = _studentService.GetStudentCountAsync();

                await Task.WhenAll(totalRoomsFillTask, totalRoomsTask, studentCountTask);

                var totalRoomsFill = await totalRoomsFillTask;
                var totalRooms = await totalRoomsTask;
                var studentCount = await studentCountTask;

                LbRoomsCount.Text = $"{totalRoomsFill ?? 0}/{totalRooms ?? 0}";
                LbStudentCount.Text = (studentCount ?? 0).ToString();
            }
            catch
            {
                LbRoomsCount.Text = "N/A";
                LbStudentCount.Text = "N/A";
            }
        }
        private void BtnBank_Click(object sender, EventArgs e)
        {
            int permission = CurrentUser.Permissions;

            if (permission != (int)enPermission.All && (permission &
                (int)enPermission.BankManagement) != (int)enPermission.BankManagement)
            {
                return;
            }

            UserControlManagement.ShowUserControl(new CtrlBankManagement());
        }

    }
}