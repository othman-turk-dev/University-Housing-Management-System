using System;
using Common_Library;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using University_Housing_Management_Project.Helpers;
using University_Housing_Management_Project.Services;
using System.Windows.Forms.DataVisualization.Charting;
using University_Housing_Management_Project.Helpers.Pdf;
using University_Housing_Management_Project.Forms.Home.ViolationManagement.Violations;

namespace University_Housing_Management_Project.Forms.Home.ViolationManagement
{
    public partial class CtrlViolationsStatistics : UserControl
    {

        private readonly ViolationService _violationService = new ViolationService();
        private List<ViolationRateDto> _statistics;
        private double _animationStep = 1.0;

        public CtrlViolationsStatistics()
        {
            InitializeComponent();
        }

        // Load data
        private async void CtrlViolationsStatistics_Load(object sender, EventArgs e)
        {

            try
            {
                _statistics = await _violationService.GetViolationStatistics();

                if (_statistics == null || _statistics.Count == 0)
                    return;

                _LoadNameOfViolations();
                timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Failed to load violation statistics: {ex.Message}", "Error", ParentForm);
            }
        }

        // Operations
        private void _LoadNameOfViolations()
        {
            chart1.Titles.Clear();

            Title title = chart1.Titles.Add("Violation Statistics");
            title.Font = new Font("Calibri", 22, FontStyle.Bold);

            chart1.Series["Series1"].Points.Clear();

            foreach (var item in _statistics)
            {
                chart1.Series["Series1"]
                      .Points
                      .AddXY(item.ViolationName, 0);
            }

            // Setting font for labels  
            if (chart1.Legends.Count > 0)
            {
                chart1.Legends[0].Font = new Font("Calibri", 11);
                chart1.Legends[0].Docking = Docking.Left;
                chart1.Legends[0].Alignment = StringAlignment.Near;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            _DrawingAndSettingChart();
        }
        private void _DrawingAndSettingChart()
        {

            if (_statistics == null || _statistics.Count == 0)
            {
                timer1.Enabled = false;
                return;
            }

            bool AllDone = true;

            for (int i = 0; i < _statistics.Count; i++)
            {
                double target = Math.Round(Convert.ToDouble(_statistics[i].ViolationRate), 2);
                double current = chart1.Series["Series1"].Points[i].YValues[0];

                if (current < target)
                {
                    
                    double nextValue = current + _animationStep;

                    if (nextValue >= target)
                        chart1.Series["Series1"].Points[i].YValues[0] = target;
                    else
                        {
                            chart1.Series["Series1"].Points[i].YValues[0] = nextValue;
                            AllDone = false;
                        }
                }
            }

            chart1.Invalidate();

            if (AllDone)
                timer1.Enabled = false;

        }
        private void chart1_MouseClick(object sender, MouseEventArgs e)
        {

            var result = chart1.HitTest(e.X, e.Y);

            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                int index = result.PointIndex;

                if (index >= 0 && index < chart1.Series["Series1"].Points.Count)
                {
                    var point = chart1.Series["Series1"].Points[index];
                    string name = point.AxisLabel;
                    double percentage = point.YValues[0];

                    ShowMessagebox.Information($"Violation: {name}\nPercentage: {percentage}%", "Violation Details", ParentForm);
                }
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {

            UserControlManagement.ShowUserControl(new CtrlViolationManagement());
        }
        private void BtnPrintTheReport_Click(object sender, EventArgs e)
        {

            PdfGenerator.Export(_statistics, "Violation statistics");
        }


    }
}