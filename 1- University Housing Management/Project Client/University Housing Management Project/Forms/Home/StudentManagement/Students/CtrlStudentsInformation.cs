using System;
using System.IO;
using Common_Library;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Helpers;
using University_Housing_Management_Project.Services;
using University_Housing_Management_Project.Helpers.Pdf;

namespace University_Housing_Management_Project.Forms.Home.StudentManagement.Students
{
    public partial class CtrlStudentsInformation : UserControl
    {
        
        private readonly StudentService _studentService = new StudentService();
        private readonly SpecializationService _specializationService = new SpecializationService();

        private List<StudentWithDetailsDto> _students = null;

        public CtrlStudentsInformation()
        {
            InitializeComponent();
        }

        private async void CtrlStudentsInformation_Load(object sender, EventArgs e)
        {
            try
            {
                await _RefreshDataGridView();

                var specializations = await _specializationService.GetAllSpecializations();
                _FillComboBoxes(specializations, CbSpecilizationFilter);

                if (DGVShowAllStudents.Rows.Count > 0 && DGVShowAllStudents.Columns.Count > 0)
                {
                    DGVShowAllStudents.Columns[0].HeaderText = "Uni. number";
                    DGVShowAllStudents.Columns[1].HeaderText = "Name";
                    DGVShowAllStudents.Columns[3].HeaderText = "P. Phone";
                    DGVShowAllStudents.Columns[5].HeaderText = "Level";
                    DGVShowAllStudents.Columns[6].HeaderText = "Room location";


                    DGVShowAllStudents.Columns[0].Width = 130;
                    DGVShowAllStudents.Columns[1].Width = 120;
                    DGVShowAllStudents.Columns[2].Width = 120;
                    DGVShowAllStudents.Columns[3].Width = 120;
                    DGVShowAllStudents.Columns[4].Width = 150;
                    DGVShowAllStudents.Columns[5].Width = 120;
                }
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error loading student data: {ex.Message}", "Error", ParentForm);
            }
        }

        private void _DefaultSelected()
        {
            TxtSearch.Text = string.Empty;

            CbAcademiclLevelFilter.SelectedItem = "All";
            CbSpecilizationFilter.SelectedItem = "All";
            CbRoomLocationFilter.SelectedItem = "All";
        }
        private void _FillComboBoxes(List<string> list, ComboBox comboBoxName)
        {
            if (list == null || comboBoxName == null) return;

            foreach (var item in list)
            {
                comboBoxName.Items.Add(item);
            }
        }
        private async Task _RefreshDataGridView()
        {
            try
            {
                _students = await _studentService.GetAllStudents();
                DGVShowAllStudents.DataSource = _students;

                _DefaultSelected();
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Error refreshing data: {ex.Message}", "Error", ParentForm);
            }
        }

        private async Task _ApplyFilterForStudent()
        {
            try
            {
                var filter = new StudentFilterDto
                {
                    UniversityNumber = TxtSearch.Text.Trim(),
                    Floor = CbRoomLocationFilter.Text,
                    Specialization = CbSpecilizationFilter.Text,
                    AcademiclLevel = CbAcademiclLevelFilter.Text == "All" ? (int?)null : CbAcademiclLevelFilter.SelectedIndex
                };

                var result = await _studentService.StudentsFilter(filter);
                DGVShowAllStudents.DataSource = result;
            }
            catch
            {
                // Ignoring transient search errors
            }
        }
        private async void CbSpecilizationFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _ApplyFilterForStudent();
        }
        private async void CbAcademiclLevelFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _ApplyFilterForStudent();
        }
        private async void CbRoomLocationFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _ApplyFilterForStudent();
        }
        private async void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            await _ApplyFilterForStudent();
        }

        private void BtnAddNewStudent_Click(object sender, EventArgs e)
        {
            UserControlManagement.ShowUserControl(new CtrlAddUpdateStudent());
        }
        private void BtnUpdateStudentInfo_Click(object sender, EventArgs e)
        {
            if (DGVShowAllStudents.CurrentRow == null)
                return;

            string universityNumber = DGVShowAllStudents.CurrentRow.Cells[0].Value?.ToString();

            if (!string.IsNullOrEmpty(universityNumber))
            {
                UserControlManagement.ShowUserControl(new CtrlAddUpdateStudent(universityNumber));
            }
        }
        private void updateStudentInfoItem_Click(object sender, EventArgs e)
        {
            BtnUpdateStudentInfo_Click(sender, e);
        }
        private void BtnShowStudentInfo_Click(object sender, EventArgs e)
        {
            if (DGVShowAllStudents.CurrentRow == null)
                return;

            string universityNumber = DGVShowAllStudents.CurrentRow.Cells[0].Value?.ToString();

            if (!string.IsNullOrEmpty(universityNumber))
            {
                UserControlManagement.ShowUserControl(new CtrlAddUpdateStudent(universityNumber, false));
            }
        }
        private void ShowStudentInfoItem_Click(object sender, EventArgs e)
        {
            BtnShowStudentInfo_Click(sender, e);
        }
        private async void BtnDeleteStudent_Click(object sender, EventArgs e)
        {
            
            if (DGVShowAllStudents.CurrentRow == null)
                return;

            DialogResult result = ShowMessagebox.Question("Are you sure you want to delete this student?",
                "Confirmation", ParentForm);

            if (result == DialogResult.Yes)
            {
                string universityNumber = DGVShowAllStudents.CurrentRow.Cells[0].Value?.ToString();

                if (string.IsNullOrEmpty(universityNumber))
                    return;

                StudentDto student = await _studentService.FindByUniversityNumber(universityNumber);
                bool isDeleted = await _studentService.DeleteStudent(universityNumber);

                if (isDeleted)
                {
                    _IsImageDelete(student);
                    ShowMessagebox.Information("Student deleted successfully", "Deleted Successfully", ParentForm);
                }
                else
                {
                    ShowMessagebox.Error("There is associated data with this student;\nCannot delete.", "Deletion Failed", ParentForm);
                }

                await _RefreshDataGridView();
            }
        }
        private void deleteStudentItem_Click(object sender, EventArgs e)
        {
            BtnDeleteStudent_Click(sender, e);
        }
        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            await _RefreshDataGridView();
        }
        private async void BtnPrintTheReport_Click(object sender, EventArgs e)
        {
            var data = await _studentService.GetAllStudents();
            if (data != null)
            {
                PdfGenerator.Export(data, "Students");
            }
        }

        private bool _IsImageDelete(StudentDto student)
        {
            if (student == null) return false;

            bool success = true;

            if (!string.IsNullOrEmpty(student.UniversityCardPhoto) && File.Exists(student.UniversityCardPhoto))
            {
                try
                {
                    File.Delete(student.UniversityCardPhoto);
                }
                catch (Exception)
                {
                    success = false;
                }
            }

            if (!string.IsNullOrEmpty(student.Idphoto) && File.Exists(student.Idphoto))
            {
                try
                {
                    File.Delete(student.Idphoto);
                }
                catch (Exception)
                {
                    success = false;
                }
            }

            return success;
        }
        private void CMStripStudents_Opening(object sender, CancelEventArgs e)
        {
            bool hasRows = DGVShowAllStudents.CurrentRow != null;

            deleteStudentItem.Visible = hasRows;
            updateStudentInfoItem.Visible = hasRows;
            ShowStudentInfoItem.Visible = hasRows;
        }

    }
}