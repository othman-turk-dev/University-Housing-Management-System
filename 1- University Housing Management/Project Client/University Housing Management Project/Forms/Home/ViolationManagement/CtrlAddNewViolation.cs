using System;
using Common_Library;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Global;
using University_Housing_Management_Project.Services;
using University_Housing_Management_Project.Helpers;
using University_Housing_Management_Project.Forms.Home.ViolationManagement.Violations;

namespace University_Housing_Management_Project.Forms.Home.ViolationManagement
{
    public partial class CtrlAddNewViolation : UserControl
    {

        private readonly StudentService _studentService = new StudentService();
        private readonly ViolationService _violationService = new ViolationService();
        private readonly ViolationTypeService _violationTypeService = new ViolationTypeService();

        public CtrlAddNewViolation()
        {
            InitializeComponent();
        }

        // Load data
        private async Task _LoadData()
        {
            try
            {
                TxtStudentID.Focus();
                await _FillAllComboboxes();
                CbViolationTypes.SelectedIndex = -1;
                TxtUserName.Text = CurrentUser.Username;
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error loading form data: {ex.Message}", "System Error", ParentForm);
            }
        }
        private async Task _FillAllComboboxes()
        {
            List<ViolationTypeDto> list = await _violationTypeService.GetAllViolationTypes();

            CbViolationTypes.Items.Clear();
            if (list != null)
            {
                foreach (var row in list)
                {
                    CbViolationTypes.Items.Add(row.Name);
                }
            }
        }
        private async void CtrlAddNewViolation_Load(object sender, EventArgs e)
        {
            await _LoadData();
        }

        // Operations
        private async void BtnSave_Click(object sender, EventArgs e)
        {

            if (CbViolationTypes.SelectedIndex == -1)
            {
                ShowMessagebox.Error("You must select the type of violation first.",
                    "The operation failed.", ParentForm);
                return;
            }

            if (ValidationHelper.IsTxtEmpty(TxtStudentID.Text.Trim()))
            {
                ShowMessagebox.Error("You must write the university ID number first.",
                    "The operation failed.", ParentForm);
                return;
            }

            try
            {
                var violationType = await _violationTypeService.GetViolationTypeByName(CbViolationTypes.Text);

                if (violationType == null)
                {
                    ShowMessagebox.Error("Selected violation type could not be loaded."
                        , "Error", ParentForm);
                    return;
                }

                AddViolationDto violationDto = new AddViolationDto
                {
                    UniversityNumber = TxtStudentID.Text.Trim(),
                    ViolationTypeId = violationType.ViolationTypeId,
                };

                var addedViolation = await _violationService.AddViolation(violationDto);

                if (addedViolation != null)
                {
                    ShowMessagebox.Information("The violation has been successfully added.",
                        "The operation has been completed.", ParentForm);

                    BtnSave.Enabled = false;
                    CbViolationTypes.Enabled = false;
                    TxtStudentID.ReadOnly = true;
                }
                else
                {
                    ShowMessagebox.Error("This violation was not added.",
                        "The operation failed.", ParentForm);
                }
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"An error occurred while saving the violation: {ex.Message}"
                    , "System Error", ParentForm);
            }
        }
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlViolationManagement());
        }

        // Validations
        private async void TxtStudentID_Leave(object sender, EventArgs e)
        {
            
            if (ValidationHelper.IsTxtEmpty(TxtStudentID.Text.Trim()))
                return;

            try
            {
                StudentDto student = await _studentService.FindByUniversityNumber(TxtStudentID.Text.Trim());

                if (ValidationHelper.ObjectIsNull(student))
                {

                    ShowMessagebox.Error("There is no student with this university ID number.",
                        "Not found.", ParentForm);

                    TxtStudentID.Clear();
                    TxtStudentID.Focus();
                    return;
                }

                TxtName.Text = student.FullName;
                TxtStudentID.ReadOnly = true;
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error finding student: {ex.Message}"
                    , "Error", ParentForm);
            }
        }
        private async void CbViolationTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (CbViolationTypes.SelectedIndex == -1)
                return;

            try
            {
                var violationType = await _violationTypeService.GetViolationTypeByName(CbViolationTypes.Text);

                if (violationType != null)
                {
                    TxtFine.Text = violationType.PenaltyAmount.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error fetching penalty details: {ex.Message}"
                    , "Error", this.FindForm());
            }
        }
    
    }
}