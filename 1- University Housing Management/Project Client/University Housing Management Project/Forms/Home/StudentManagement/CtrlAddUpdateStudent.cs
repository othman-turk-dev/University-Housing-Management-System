using System;
using System.IO;
using System.Linq;
using Common_Library;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Helpers;
using University_Housing_Management_Project.Services;
using University_Housing_Management_Project.Forms.Home.StudentManagement.Students;

namespace University_Housing_Management_Project.Forms.Home.StudentManagement
{
    public partial class CtrlAddUpdateStudent : UserControl
    {

        private readonly StudentService _studentService = new StudentService();
        private readonly RoomService _roomService = new RoomService();
        private readonly SpecializationService _specializationService = new SpecializationService();
        enum EnMode { Add = 0, Update = 1, Show = 2 }
        EnMode _Mode = EnMode.Add;

        private bool _isLoading = false;
        private StudentDto _Student = null;
        string _UniversityNumber = string.Empty;

        string IDPhotoPath = string.Empty;
        string UniversityCardPhotoPath = string.Empty;

        public CtrlAddUpdateStudent()
        {
            InitializeComponent();
            _Mode = EnMode.Add;
        }
        public CtrlAddUpdateStudent(string UniversityNumber, bool IsUpdate = true)
        {
            InitializeComponent();
            _UniversityNumber = UniversityNumber;
            _Mode = IsUpdate ? EnMode.Update : EnMode.Show;
        }

        private void _Clear()
        {
            TxtUniversityNumber.Text = string.Empty;
            TxtFullName.Text = string.Empty;
            TxtPhone.Text = string.Empty;
            TxtFatherPhone.Text = string.Empty;
            TxtAddress.Text = string.Empty;

            CbRoomLocation.SelectedIndex = -1;
            CbSpecialization.SelectedIndex = -1;
            CbLevel.SelectedIndex = -1;

            UniversityCardPhotoPath = string.Empty;
            IDPhotoPath = string.Empty;

            PicIDPhoto.Image = null;
            PicUniversityCardPhoto.Image = null;
        }
        private async Task _DefaultData()
        {
            _FillComboBoxes(await _specializationService.GetAllSpecializations(), CbSpecialization);
            _FillComboBoxes(await _roomService.GetAllAvailableRoomAsync(), CbRoomLocation);

            LbTitle.Text = "Add New Student";
            _Clear();
        }
        private async Task _LoadDataOnForm()
        {

            _isLoading = true;

            try
            {
                _Student = await _studentService.FindByUniversityNumber(_UniversityNumber);

                if (_Student == null)
                {
                    ShowMessagebox.Error($"Student with university number {_UniversityNumber} not found.", "Not found", ParentForm);
                    return;
                }

                TxtUniversityNumber.Text = _Student.UniversityNumber;
                TxtFullName.Text = _Student.FullName;
                TxtPhone.Text = _Student.Phone;
                TxtFatherPhone.Text = _Student.GuardiansNumber;
                TxtAddress.Text = _Student.Address;

                UniversityCardPhotoPath = _Student.UniversityCardPhoto;
                IDPhotoPath = _Student.Idphoto;

                _FillComboBoxes(await _specializationService.GetAllSpecializations(), CbSpecialization);
                _FillComboBoxes(await _roomService.GetCurrentAndAllAvailableRoomAsync(_Student.UniversityNumber), CbRoomLocation);

                var SpecializationInfo = await _specializationService.GetSpecializationById(_Student.SpecilizationId);
                var RoomInfo = await _roomService.GetRoomById(_Student.RoomId);

                if (RoomInfo != null)
                    CbRoomLocation.SelectedItem = RoomInfo.RoomLocation;

                if (_Student.AcademiclLevel > 0)
                    CbLevel.SelectedIndex = (_Student.AcademiclLevel - 1);

                if (SpecializationInfo != null)
                    CbSpecialization.SelectedItem = SpecializationInfo.Name;

                if (!string.IsNullOrWhiteSpace(_Student.Idphoto) && File.Exists(_Student.Idphoto))
                    PicIDPhoto.Load(_Student.Idphoto);

                if (!string.IsNullOrWhiteSpace(_Student.UniversityCardPhoto) && File.Exists(_Student.UniversityCardPhoto))
                    PicUniversityCardPhoto.Load(_Student.UniversityCardPhoto);

                LbTitle.Text = "Update Student Info";
            }
            finally
            {
                _isLoading = false;
            }

        }
        private void _CloseAllControls()
        {
            LbTitle.Text = "Show Student Info";

            foreach (Control c in this.Controls)
            {
                if (c == BtnReturn)
                    continue;

                c.Enabled = false;
            }
        }
        private void _FillComboBoxes(List<string> list, ComboBox comboBoxName)
        {

            if (list == null || comboBoxName == null) return;

            comboBoxName.Items.Clear();

            foreach (var item in list)
            {
                comboBoxName.Items.Add(item);
            }
        }
        private async void CtrlAddUpdateStudent_Load(object sender, System.EventArgs e)
        {

            try
            {
                if (_Mode == EnMode.Show)
                {
                    await _LoadDataOnForm();
                    _CloseAllControls();
                }
                else if (_Mode == EnMode.Update)
                {
                    BtnClear.Visible = false;

                    BtnIDPhoto.Enabled = false;
                    BtnUniversityCardPhoto.Enabled = false;

                    await _LoadDataOnForm();
                }
                else
                {
                    await _DefaultData();
                }
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error loading student form: {ex.Message}", "Error", ParentForm);
            }
        }

        private void _OpenFolderDialogSettings()
        {
            ChooseImages.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            ChooseImages.FilterIndex = 1;
            ChooseImages.RestoreDirectory = true;
        }
        private void _ChooseImagesFunction(PictureBox pictureBox)
        {
            _OpenFolderDialogSettings();

            string selectedFilePath = string.Empty;

            if (ChooseImages.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = ChooseImages.FileName;
                pictureBox.Load(selectedFilePath);
            }

            if (pictureBox == PicIDPhoto)
                IDPhotoPath = selectedFilePath;
            else
                UniversityCardPhotoPath = selectedFilePath;
        }
        private bool _HandleStudentImage(ref string oldImagePath, PictureBox pictureBox)
        {

            if (_Mode == EnMode.Add)
                oldImagePath = string.Empty;

            if (oldImagePath != pictureBox.ImageLocation)
            {

                if (!string.IsNullOrEmpty(oldImagePath) && File.Exists(oldImagePath))
                {
                    try
                    {
                        File.Delete(oldImagePath);
                    }
                    catch
                    {
                        ShowMessagebox.Error("Older image is not found or is currently locked",
                            "Error", ParentForm);
                        return false;
                    }
                }

                if (pictureBox.ImageLocation != null)
                {
                    string sourceImagePath = pictureBox.ImageLocation;

                    if (DealWithImage.CopyImageToProjectImagesFolder(ref sourceImagePath))
                    {
                        pictureBox.ImageLocation = sourceImagePath;
                        oldImagePath = sourceImagePath;

                        return true;
                    }
                    else
                    {
                        ShowMessagebox.Error("Error occurred while copying image file",
                            "Error", ParentForm);

                        return false;
                    }
                }
            }

            return true;
        }
        private void BtnUniversityCardPhoto_Click(object sender, EventArgs e)
        {
            _ChooseImagesFunction(PicUniversityCardPhoto);
        }
        private void BtnIDPhoto_Click(object sender, EventArgs e)
        {
            _ChooseImagesFunction(PicIDPhoto);
        }
        private async void BtnSave_Click(object sender, EventArgs e)
        {
            
            if (!_IsValidationSuccessfully())
                return;

            try
            {
                StudentDto student = new StudentDto();

                if (_Mode == EnMode.Update)
                    student = _Student;

                student.UniversityNumber = TxtUniversityNumber.Text.Trim();
                student.FullName = TxtFullName.Text.Trim();
                student.Phone = TxtPhone.Text.Trim();
                student.GuardiansNumber = TxtFatherPhone.Text.Trim();
                student.Address = TxtAddress.Text.Trim();

                var SpecializationInfo = await _specializationService
                    .GetSpecializationByName(CbSpecialization.Text);

                var RoomInfo = await _roomService
                    .GetRoomByRoomLocation(CbRoomLocation.Text);

                if (SpecializationInfo == null)
                {
                    ShowMessagebox.Error("Selected specialization was not found.", "Save Failed", ParentForm);
                    return;
                }

                if (RoomInfo == null)
                {
                    ShowMessagebox.Error("Selected room location was not found.", "Save Failed", ParentForm);
                    return;
                }

                student.RoomId = RoomInfo.RoomId;
                student.SpecilizationId = SpecializationInfo.SpecializationId;
                student.AcademiclLevel = (byte)(CbLevel.SelectedIndex + 1);

                if (!_HandleStudentImage(ref IDPhotoPath, PicIDPhoto))
                    return;

                if (!_HandleStudentImage(ref UniversityCardPhotoPath, PicUniversityCardPhoto))
                    return;

                student.Idphoto = IDPhotoPath;
                student.UniversityCardPhoto = UniversityCardPhotoPath;


                if (_Mode == EnMode.Update)
                {
                    var result = await _studentService.UpdateStudent(student);

                    if (result != null)
                        ShowMessagebox.Information("Information saved successfully",
                            "Process saved successfully", ParentForm);
                    else
                        ShowMessagebox.Error("Failed to save information", "Process failed", ParentForm);
                }

                if (_Mode == EnMode.Add)
                {
                    var result = await _studentService.AddStudent(student);

                    if (result != null)
                    {
                        _Student = result;
                        _UniversityNumber = result.UniversityNumber;
                        _Mode = EnMode.Update;

                        BtnIDPhoto.Enabled = false;
                        BtnUniversityCardPhoto.Enabled = false;

                        BtnClear.Visible = false;
                        LbTitle.Text = "Update Student Info";

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
            UserControlManagement.ShowUserControl(new CtrlStudentsInformation());
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            _Clear();
        }

        private bool _ValidateTextBox(Guna2TextBox Txtbox, string ErrorMessage)
        {

            if (ValidationHelper.IsTxtEmpty(Txtbox.Text))
            {
                ShowMessagebox.Information(ErrorMessage, "Save failed", ParentForm);
                
                Txtbox.Focus();
                return false;
            }

            return true;
        }
        private bool _ValidateComboBox(Guna2ComboBox Combobox, string ErrorMessage)
        {

            if (Combobox.SelectedIndex == -1)
            {
                ShowMessagebox.Information(ErrorMessage, "Save failed", ParentForm);
                
                Combobox.Focus();
                return false;
            }

            return true;
        }
        private async void TxtUniversityNumber_Leave(object sender, EventArgs e)
        {
            
            if (ValidationHelper.IsTxtEmpty(TxtUniversityNumber.Text.Trim()))
                return;

            try
            {

                var IsStudentExist = await _studentService
                    .IsStudentExist(TxtUniversityNumber.Text.Trim());

                if (_Mode == EnMode.Add && IsStudentExist)
                {
                    ShowMessagebox.Error("This university ID is already taken, try another one",
                        "Invalid input", ParentForm);

                    TxtUniversityNumber.Focus();
                    return;
                }

                if (_Mode == EnMode.Update && IsStudentExist
                    && _Student != null && TxtUniversityNumber.Text.Trim() != _Student.UniversityNumber)
                {
                    ShowMessagebox.Error("This university ID is already taken, try another one",
                        "Invalid input", ParentForm);

                    TxtUniversityNumber.Focus();
                    return;
                }
            }
            catch
            {
                // Ignore
            }
        }
        private bool _IsValidationSuccessfully()
        {

            if (!_ValidateTextBox(TxtUniversityNumber, "University number is required"))
                return false;

            if (!_ValidateTextBox(TxtFullName, "Name is required"))
                return false;

            if (!_ValidateTextBox(TxtPhone, "Phone number is required"))
                return false;

            if (!_ValidateTextBox(TxtFatherPhone, "Parent phone is required"))
                return false;

            if (!_ValidateTextBox(TxtAddress, "Address is required"))
                return false;

            if (!_ValidateComboBox(CbRoomLocation, "Room location is required"))
                return false;

            if (!_ValidateComboBox(CbLevel, "Academic year is required"))
                return false;

            if (!_ValidateComboBox(CbSpecialization, "Specialization is required"))
                return false;

            return true;
        }
        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {

            if (ValidationHelper.WriteOnlyNumber(e.KeyChar))
                e.Handled = true;
        }
        private void OnlyLetters(object sender, KeyPressEventArgs e)
        {

            if (ValidationHelper.WriteOnlyLetters(e.KeyChar))
                e.Handled = true;
        }


        private readonly List<string> _sixYearSpecializations = new List<string> { "Human Medicine" };
        private async void CbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(_isLoading) return;

            if (CbLevel.SelectedIndex == 5)
            {

                var allSpecializations = await _specializationService.GetAllSpecializations();

                var filteredSpecs = allSpecializations
                    .Where(s => _sixYearSpecializations.Contains(s, StringComparer.OrdinalIgnoreCase))
                    .ToList();

                _FillComboBoxes(filteredSpecs, CbSpecialization);

                if (CbSpecialization.SelectedItem != null &&
                    !_sixYearSpecializations.Contains(CbSpecialization.SelectedItem.ToString(), StringComparer.OrdinalIgnoreCase))
                {
                    CbSpecialization.SelectedIndex = -1;
                }
            }
            else
            {
                string currentSelectedSpec = CbSpecialization.SelectedItem?.ToString();

                var allSpecializations = await _specializationService.GetAllSpecializations();
                _FillComboBoxes(allSpecializations, CbSpecialization);

                if (!string.IsNullOrEmpty(currentSelectedSpec))
                {
                    CbSpecialization.SelectedItem = currentSelectedSpec;
                }
            }
        }
        private void CbSpecialization_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (_isLoading) return;

            if (CbSpecialization.SelectedItem == null) return;

            string selectedSpec = CbSpecialization.SelectedItem.ToString();

            bool isSixYearSpec = _sixYearSpecializations.Contains(selectedSpec, StringComparer.OrdinalIgnoreCase);

            if (!isSixYearSpec)
            {
                if (CbLevel.SelectedIndex == 5)
                {
                    CbLevel.SelectedIndex = -1;

                    ShowMessagebox.Information(
                        "This specialization does not have a 6th academic year.",
                        "Notice",
                        ParentForm
                    );
                }
            }
        }

    }
}
