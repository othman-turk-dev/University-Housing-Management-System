using System;
using Common_Library;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Services;
using University_Housing_Management_Project.Helpers;
using University_Housing_Management_Project.Forms.Home.ViolationManagement.Violations;

namespace University_Housing_Management_Project.Forms.Home.ViolationManagement
{
    public partial class CtrlShowViolationDetails : UserControl
    {

        private readonly StudentService _studentService = new StudentService();
        private readonly ViolationService _violationService = new ViolationService();

        private string _StudentID = string.Empty;
        private List<ViolationDetailsDto> _ViolationDetails = null;

        public CtrlShowViolationDetails(string StudentID)
        {
            InitializeComponent();
            _StudentID = StudentID;
        }

        private async Task _LoadData()
        {
            
            if (string.IsNullOrWhiteSpace(_StudentID))
            {
                ShowMessagebox.Error("Invalid student ID provided.", "Error", ParentForm);
                return;
            }

            try
            {
                var student = await _studentService.FindByUniversityNumber(_StudentID);

                if (student != null)
                {
                    TxtStudentID.Text = _StudentID;
                    LbTitle.Text = student.FullName;
                    TxtStudentPhone.Text = student.Phone;
                    TxtFatherPhone.Text = student.GuardiansNumber;
                }
                else
                {
                    ShowMessagebox.Error("Student details could not be found.", "Warning", ParentForm);
                }

                _ViolationDetails = await _violationService.GetViolationDetails(_StudentID);
                DGVShowAllViolations.DataSource = _ViolationDetails;
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error loading violation details: {ex.Message}"
                    , "Error", ParentForm);
            }
        }
        private async void CtrlShowViolationDetails_Load(object sender, EventArgs e)
        {
            await _LoadData();

            if (DGVShowAllViolations.Rows.Count > 0 && DGVShowAllViolations.Columns.Count > 0)
            {
                DGVShowAllViolations.Columns[3].HeaderText = "Number of violations";

                DGVShowAllViolations.Columns[0].Width = 400;
                DGVShowAllViolations.Columns[1].Width = 400;
                DGVShowAllViolations.Columns[2].Width = 80;
                DGVShowAllViolations.Columns[3].Width = 90;
            }
        }
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlViolationManagement());
        }

    }
}