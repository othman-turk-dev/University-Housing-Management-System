using System;
using Common_Library;
using System.Windows.Forms;
using System.Threading.Tasks;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Services;
using University_Housing_Management_Project.Forms.Home.RoomManagement.Rooms;
using University_Housing_Management_Project.Helpers;

namespace University_Housing_Management_Project.Forms.Home.RoomManagement
{
    public partial class CtrlAddUpdateRoom : UserControl
    {

        private readonly RoomService _roomService = new RoomService();

        enum EnMode { Add = 0, Update = 1 }
        EnMode _Mode = EnMode.Add;

        int _RoomID = -1;
        RoomDto _Room = null;

        public CtrlAddUpdateRoom()
        {
            InitializeComponent();
            _Mode = EnMode.Add;
        }
        public CtrlAddUpdateRoom(int RoomID)
        {
            InitializeComponent();

            _RoomID = RoomID;
            _Mode = EnMode.Update;
        }

        // Load data
        private async Task _LoadData()
        {

            _Room = await _roomService.GetRoomById(_RoomID);

            if (_Room == null)
            {
                ShowMessagebox.Error($"Room with ID {_RoomID} not found.", "Not Found", ParentForm);
                return;
            }

            TxtRoomID.Text = _Room.RoomId.ToString();
            _ConvertRoomLocationToFloorAndRoomNumber(_Room.RoomLocation.ToString());

            LbTitle.Text = "Update Room";

            TxtRoomNumber.Focus();
        }
        private void _DefaultData()
        {
            TxtRoomID.Text = string.Empty;
            TxtRoomNumber.Text = string.Empty;
            CbRoomLocationFilter.SelectedIndex = -1;

            LbTitle.Text = "Add New Room";
        }
        private string _CollectionOfRoomLocation()
        {
            string Location = "Building: Residence";
            string floor = CbRoomLocationFilter.Text;
            string RoomNumber = $"Room {TxtRoomNumber.Text.Trim()}";

            return $"{Location}, {floor}, {RoomNumber}";
        }
        private void _ConvertRoomLocationToFloorAndRoomNumber(string RoomLocation)
        {
            if (string.IsNullOrWhiteSpace(RoomLocation)) return;

            // Building: Residence, Floor 1, Room 1
            string[] Parts = RoomLocation.Split(',');

            if (Parts.Length >= 3)
            {
                for (int i = 0; i < Parts.Length; i++)
                    Parts[i] = Parts[i].Trim();

                string floor = Parts[1];
                CbRoomLocationFilter.SelectedItem = floor;

                string room = Parts[2].Replace("Room", "").Trim();
                TxtRoomNumber.Text = room;
            }
            else
            {
                TxtRoomNumber.Text = RoomLocation;
            }
        }
        private async void CtrlAddUpdateRoom_Load_1(object sender, EventArgs e)
        {
            try
            {
                if (_Mode == EnMode.Add)
                    _DefaultData();
                else
                    await _LoadData();
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error loading room data: {ex.Message}", "Error", ParentForm);
            }
        }

        // Save
        private async void BtnSave_Click(object sender, EventArgs e)
        {
            
            if (!await _IsValidationSuccessfully())
                return;

            try
            {
                RoomDto room = new RoomDto();

                if (_Mode == EnMode.Update) room = _Room;

                room.RoomLocation = _CollectionOfRoomLocation();

                if (_Mode == EnMode.Update)
                {
                    var result = await _roomService.UpdateRoom(room);

                    if (result != null)
                        ShowMessagebox.Information("Information saved successfully",
                            "Process saved successfully", ParentForm);
                    else
                        ShowMessagebox.Error("Failed to save information", "Process failed", ParentForm);
                }
                else if (_Mode == EnMode.Add)
                {
                    var result = await _roomService.AddRoom(room);

                    if (result != null)
                    {
                        _Room = result;
                        _RoomID = result.RoomId;
                        _Mode = EnMode.Update;

                        TxtRoomID.Text = result.RoomId.ToString();
                        LbTitle.Text = "Update Room";

                        ShowMessagebox.Information("Information saved successfully",
                            "Process saved successfully", ParentForm);
                    }
                    else
                        ShowMessagebox.Error("Failed to save information", "Process failed", ParentForm);
                }
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"An error occurred while saving: {ex.Message}", "System Error", ParentForm);
            }
        }
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlRoomManagement());
        }

        // Validation
        private async Task<bool> _IsValidationSuccessfully()
        {

            if (CbRoomLocationFilter.SelectedIndex == -1)
            {
                ShowMessagebox.Error("Select the floor of the room",
                    "Addition failed", ParentForm);

                CbRoomLocationFilter.Focus();
                return false;
            }

            if (ValidationHelper.IsTxtEmpty(TxtRoomNumber.Text.Trim()))
            {
                ShowMessagebox.Error("Enter the room number",
                    "Addition failed", ParentForm);

                TxtRoomNumber.Focus();
                return false;
            }

            if (_Mode == EnMode.Update &&
                ValidationHelper.IsTxtEmpty(TxtRoomID.Text.Trim()))
            {
                ShowMessagebox.Error("Room ID is required",
                    "Update failed", ParentForm);

                return false;
            }

            string RoomLocation = _CollectionOfRoomLocation();

            try
            {
                if (_Mode == EnMode.Add &&
                    await _roomService.IsRoomLocationExist(RoomLocation))
                {
                    ShowMessagebox.Error("Room already exists in this location",
                        "Invalid input", ParentForm);

                    return false;
                }

                if (_Mode == EnMode.Update &&
                    (await _roomService.IsRoomLocationExist(RoomLocation)
                    && _Room != null && RoomLocation != _Room.RoomLocation))
                {
                    ShowMessagebox.Error("Room already exists in this location",
                        "Invalid input", ParentForm);

                    return false;
                }
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Validation check failed: {ex.Message}", "Error", ParentForm);
                return false;
            }

            return true;
        }
        private void TxtRoomNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidationHelper.WriteOnlyNumber(e.KeyChar))
                e.Handled = true;
        }
    
    }
}