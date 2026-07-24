using System;
using System.Drawing;
using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace University_Housing_Management_Project.Forms.Home.AboutMe
{
    public partial class CtrlAboutMe : UserControl
    {
        private readonly Color _activeBackgroundColor = Color.FromArgb(30, 60, 90);
        private readonly Color _activeForegroundColor = Color.White;

        public CtrlAboutMe()
        {
            InitializeComponent();
        }
        private void CtrlAboutMe_Load(object sender, EventArgs e)
        {
            ctrlMe1.BringToFront();
            _ChangeButtonBackColorAndForeColor(BtnMe);
        }

        private void _ChangeButtonBackColorAndForeColor(Guna2Button activeBtn)
        {
            if (activeBtn == null) return;

            foreach (Control control in PnFooter.Controls)
            {
                if (control is Guna2Button btn)
                {
                    if (btn.Name == activeBtn.Name)
                    {
                        btn.FillColor = _activeBackgroundColor;
                        btn.ForeColor = _activeForegroundColor;
                    }
                    else
                    {
                        btn.FillColor = _activeForegroundColor;
                        btn.ForeColor = _activeBackgroundColor;
                    }
                }
            }
        }

        private void BtnMe_Click(object sender, EventArgs e)
        {
            ctrlMe1.BringToFront();
            _ChangeButtonBackColorAndForeColor(BtnMe);
        }
        private void BtnTravel_Click(object sender, EventArgs e)
        {
            ctrlMyTravel1.BringToFront();
            _ChangeButtonBackColorAndForeColor(BtnTravel);
        }
        private void BtnGools_Click(object sender, EventArgs e)
        {
            ctrlMyGools1.BringToFront();
            _ChangeButtonBackColorAndForeColor(BtnGools);
        }
        private void BtnWhyProgramming_Click(object sender, EventArgs e)
        {
            ctrlWhyProgramming1.BringToFront();
            _ChangeButtonBackColorAndForeColor(BtnWhyProgramming);
        }
        private void BtnProjects_Click(object sender, EventArgs e)
        {
            ctrlMyProjects1.BringToFront();
            _ChangeButtonBackColorAndForeColor(BtnProjects);
        }

    }
}