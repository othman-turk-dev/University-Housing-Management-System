using System;
using Common_Library;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Helpers;
using University_Housing_Management_Project.Services;
using University_Housing_Management_Project.Helpers.Pdf;

namespace University_Housing_Management_Project.Forms.Home.RoomManagement.Rooms
{
    public partial class CtrlRoomManagement : UserControl
    {

        private readonly SettingService _settingService = new SettingService();
        private readonly RoomService _roomService = new RoomService();

        List<RoomStatusDto> _AllRooms = null;
        private int _maxStudentsInRoom;

        private bool _isLoading = false;

        public CtrlRoomManagement()
        {
            InitializeComponent();
        }

        // Load data
        private void _DefaultSelected()
        {
            TxtSearch.Text = string.Empty;

            CbRoomStatusFilter.SelectedItem = "All";
            CbRoomLocationFilter.SelectedItem = "All";

            NumUpDownStudentsCount.Value = 0;
        }
        private async Task _RefreshDataGridView()
        {
            _AllRooms = await _roomService.GetAllRoomsWithDetails();
            DGVShowRoomsInfo.DataSource = _AllRooms;

            _DefaultSelected();
        }
        private async void CtrlRoomManagement_Load(object sender, EventArgs e)
        {
            _isLoading = true;

            try
            {
                _maxStudentsInRoom = (int)await _settingService.GetRoomCapacityAsync();

                NumUpDownStudentsCount.Minimum = 0;
                NumUpDownStudentsCount.Maximum = _maxStudentsInRoom;

                await _RefreshDataGridView();

                if (DGVShowRoomsInfo.Rows.Count > 0 && DGVShowRoomsInfo.Columns.Count >= 2)
                {
                    DGVShowRoomsInfo.Columns[0].Width = 100;
                    DGVShowRoomsInfo.Columns[1].Width = 500;

                    DGVShowRoomsInfo.Columns[0].HeaderText = "Room id";
                    DGVShowRoomsInfo.Columns[1].HeaderText = "Room location";
                    DGVShowRoomsInfo.Columns[2].HeaderText = "Students count";
                    DGVShowRoomsInfo.Columns[3].HeaderText = "Room Status";
                }
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error loading room management data: {ex.Message}", "Error", ParentForm);
            }
            finally
            {
                _isLoading = false;
            }
        }

        // Filter
        private async Task _ApplyFilters()
        {

            if (_isLoading) return;

            try
            {
                var filter = new RoomFilterDto
                {
                    RoomLocation = TxtSearch.Text.Trim(),
                    Floor = CbRoomLocationFilter.Text,
                    Status = CbRoomStatusFilter.Text,
                    StudentsCount = NumUpDownStudentsCount.Enabled ? (int?)NumUpDownStudentsCount.Value : null
                };

                var result = await _roomService.RoomFilter(filter);
                DGVShowRoomsInfo.DataSource = result;
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error applying filter: {ex.Message}", "Error", ParentForm);
            }
        }
        private async void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            await _ApplyFilters();
        }
        private async void CbRoomLocationFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _ApplyFilters();
        }
        private async void CbRoomStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;

            switch (CbRoomStatusFilter.Text)
            {
                case "All":
                case "Empty":
                    NumUpDownStudentsCount.Enabled = false;
                    NumUpDownStudentsCount.Value = 0;
                    break;

                case "Full":
                    NumUpDownStudentsCount.Enabled = false;
                    NumUpDownStudentsCount.Value = _maxStudentsInRoom;
                    break;

                case "Available":
                    NumUpDownStudentsCount.Enabled = true;

                    if (NumUpDownStudentsCount.Value == 0)
                        NumUpDownStudentsCount.Value = 1;

                    if (NumUpDownStudentsCount.Value >= _maxStudentsInRoom)
                        NumUpDownStudentsCount.Value = _maxStudentsInRoom - 1;

                    break;
            }

            await _ApplyFilters();
        }
        private async void NumUpDownStudentsCount_ValueChanged(object sender, EventArgs e)
        {
            await _ApplyFilters();
        }

        // Read Only
        private void NumUpDownStudentsCount_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
        private void NumUpDownStudentsCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Operations
        private void BtnAddNewRoom_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlAddUpdateRoom());
            BtnRefresh_Click(null, null);
        }
        private void UpdateRoomInfoItem_Click(object sender, EventArgs e)
        {
            if (DGVShowRoomsInfo.CurrentRow == null || DGVShowRoomsInfo.Rows.Count <= 0)
                return;

            if (int.TryParse(DGVShowRoomsInfo.CurrentRow.Cells[0].Value?.ToString(), out int roomID))
            {
                UserControlManagement.ShowUserControl(new CtrlAddUpdateRoom(roomID));
                BtnRefresh_Click(null, null);
            }
        }
        private async void DeleteRoomItem_Click(object sender, EventArgs e)
        {
            if (DGVShowRoomsInfo.CurrentRow == null || DGVShowRoomsInfo.Rows.Count <= 0)
                return;

            DialogResult result = ShowMessagebox.Question("Are you sure you want to delete this room?",
                "Certainly", ParentForm);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (int.TryParse(DGVShowRoomsInfo.CurrentRow.Cells[0].Value?.ToString(), out int roomID))
                    {
                        var isExist = await _roomService.IsRoomExist(roomID);

                        if (isExist)
                        {
                            var deleted = await _roomService.DeleteRoom(roomID);

                            if (deleted)
                                ShowMessagebox.Information("The room has been successfully deleted.",
                                    "Deleted Successfully", ParentForm);
                            else
                                ShowMessagebox.Error("This room cannot be deleted\nthere is data associated with it.",
                                    "Delete Failed", ParentForm);
                        }
                        else
                        {
                            ShowMessagebox.Error($"Room with ID {roomID} not found.",
                                "Delete Failed", ParentForm);
                        }
                    }
                }
                catch (Exception ex)
                {
                    ShowMessagebox.Error($"An error occurred while deleting: {ex.Message}", "Error", ParentForm);
                }

                BtnRefresh_Click(null, null);
            }
        }
        private void BtnShowStudentsInRoom_Click(object sender, EventArgs e)
        {
            if (DGVShowRoomsInfo.CurrentRow == null || DGVShowRoomsInfo.Rows.Count <= 0)
                return;

            string roomStatus = DGVShowRoomsInfo.CurrentRow.Cells[3].Value?.ToString();

            if (roomStatus == "Empty")
                return;

            if (int.TryParse(DGVShowRoomsInfo.CurrentRow.Cells[0].Value?.ToString(), out int roomID))
            {
                UserControlManagement.ShowUserControl(new CtrlShowStudentInRoom(roomID));
            }
        }
        private async void BtnStatistics_Click(object sender, EventArgs e)
        {
            try
            {
                var totalRoomsTask = _roomService.GetTotalRoomsAsync();
                var fullRoomsTask = _roomService.GetTotalRoomsFillAsync();
                var availableRoomsTask = _roomService.GetTotalAvailableRoomsAsync();

                await Task.WhenAll(
                    totalRoomsTask,
                    fullRoomsTask,
                    availableRoomsTask);

                var totalRooms = totalRoomsTask.Result;
                var fullRooms = fullRoomsTask.Result;
                var availableRooms = availableRoomsTask.Result;

                string totalEmptyRooms = (totalRooms - fullRooms - availableRooms).ToString();

                string message = $"[Number of empty rooms] = {totalEmptyRooms}";
                message += "\n" + $"[Number of available rooms] = {availableRooms}";
                message += "\n" + $"[Number of full rooms] = {fullRooms}";

                ShowMessagebox.Information(message, "Room Statistics", ParentForm);
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error loading statistics: {ex.Message}", "Error", ParentForm);
            }
        }
        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                await _RefreshDataGridView();
                await _ApplyFilters();
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error refreshing data: {ex.Message}", "Error", ParentForm);
            }
        }
        private async void BtnPrintTheReport_Click(object sender, EventArgs e)
        {
            try
            {
                var rooms = await _roomService.GetAllRoomsWithDetails();
                PdfGenerator.Export(rooms, "Rooms");
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error printing report: {ex.Message}", "Error", ParentForm);
            }
        }
        private void CMStripRooms_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DeleteRoomItem.Visible = false;
            UpdateRoomInfoItem.Visible = false;

            if (DGVShowRoomsInfo.CurrentRow == null || DGVShowRoomsInfo.Rows.Count <= 0)
                return;

            UpdateRoomInfoItem.Visible = true;

            string roomStatus = DGVShowRoomsInfo.CurrentRow.Cells[3].Value?.ToString();
            DeleteRoomItem.Visible = ("Empty" == roomStatus);
        }

    }
}