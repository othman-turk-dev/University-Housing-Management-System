using System;
using Common_Library;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Services;
using University_Housing_Management_Project.Helpers;
using University_Housing_Management_Project.Forms.Home.RoomManagement.Rooms;

namespace University_Housing_Management_Project.Forms.Home.RoomManagement
{
    public partial class CtrlShowStudentInRoom : UserControl
    {

        private readonly RoomService _roomService = new RoomService();

        private int _RoomID = -1;
        private List<StudentWithDetailsDto> _AllStudentsInRoom = null;

        public CtrlShowStudentInRoom(int RoomID)
        {
            InitializeComponent();
            _RoomID = RoomID;
        }

        private async Task _GetRoomLocationForTitle()
        {
            var room = await _roomService.GetRoomById(_RoomID);

            if (room != null && !string.IsNullOrWhiteSpace(room.RoomLocation))
            {
                string location = room.RoomLocation;
                int index = location.LastIndexOf("Room", StringComparison.OrdinalIgnoreCase);

                if (index > -1)
                {
                    string result = location.Substring(index);
                    LbTitle.Text += $" {result}";
                }
                else
                {
                    LbTitle.Text += $" - {location}";
                }
            }
        }
        private async void CtrlShowStudentInRoom_Load(object sender, EventArgs e)
        {

            try
            {
                await _GetRoomLocationForTitle();

                _AllStudentsInRoom = await _roomService.GetAllStudentsInThisRoom(_RoomID);
                DGVShowStudentsInfo.DataSource = _AllStudentsInRoom;

                if (DGVShowStudentsInfo.Rows.Count > 0 && DGVShowStudentsInfo.Columns.Count > 0)
                {
                    DGVShowStudentsInfo.Columns[0].HeaderText = "Uni. number";
                    DGVShowStudentsInfo.Columns[1].HeaderText = "Name";
                    DGVShowStudentsInfo.Columns[3].HeaderText = "P. Phone";
                    DGVShowStudentsInfo.Columns[5].HeaderText = "Level";
                    DGVShowStudentsInfo.Columns[6].HeaderText = "Room location";


                    DGVShowStudentsInfo.Columns[0].Width = 130;
                    DGVShowStudentsInfo.Columns[1].Width = 120;
                    DGVShowStudentsInfo.Columns[2].Width = 120;
                    DGVShowStudentsInfo.Columns[3].Width = 120;
                    DGVShowStudentsInfo.Columns[4].Width = 150;
                    DGVShowStudentsInfo.Columns[5].Width = 120;
                }
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error loading students in room: {ex.Message}", "Error", ParentForm);
            }
        }

        private void CallItem_Click(object sender, EventArgs e)
        {
            ShowMessagebox.Information("Feature not added yet", "Soon", ParentForm);
        }
        private void SendMessageItem_Click(object sender, EventArgs e)
        {
            ShowMessagebox.Information("Feature not added yet", "Soon", ParentForm);
        }
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlRoomManagement());
        }

    }
}