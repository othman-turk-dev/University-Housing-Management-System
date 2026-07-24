using System;
using Common_Library;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using University_Housing_Management_Project.DTOs;
using System.Windows.Forms.DataVisualization.Charting;
using University_Housing_Management_Project.Services;

namespace University_Housing_Management_Project.Forms.Home
{
    public partial class CtrlSpecializationStatistics : UserControl
    {
        private readonly SpecializationService _specialization = new SpecializationService();
        private List<SpecializationStatisticsDto> _statistics;
        private double _animationStep = 1.0;

        public CtrlSpecializationStatistics()
        {
            InitializeComponent();
        }

        private async void CtrlSpecializationStatistics_Load(object sender, EventArgs e)
        {
            try
            {
                _statistics = await _specialization.GetSpecializationStatistics();

                if (_statistics == null || _statistics.Count == 0)
                {
                    return;
                }

                _LoadNameOfSpecializations();
                timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                ShowMessagebox.Error($"Failed to load specialization statistics: {ex.Message}", "Error", ParentForm);
            }
        }

        private void _LoadNameOfSpecializations()
        {
            chart1.Series["Series1"].Points.Clear();

            foreach (var item in _statistics)
            {
                chart1.Series["Series1"]
                      .Points
                      .AddXY(item.SpecializationName, 0);
            }

            chart1.Legends[0].Font = new Font("Calibri", 11);
            chart1.Legends[0].Docking = Docking.Left;
            chart1.Legends[0].Alignment = StringAlignment.Near;

            chart1.ChartAreas[0].Position = new ElementPosition(36, -10, 65, 96);
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

            bool allDone = true;

            for (int i = 0; i < _statistics.Count; i++)
            {
                double target = Math.Round(_statistics[i].Percentage, 2);
                double current = chart1.Series["Series1"].Points[i].YValues[0];

                if (current < target)
                {
                    double nextValue = current + _animationStep;

                    if (nextValue >= target)
                    {
                        chart1.Series["Series1"].Points[i].YValues[0] = target;
                    }
                    else
                    {
                        chart1.Series["Series1"].Points[i].YValues[0] = nextValue;
                        allDone = false;
                    }
                }
            }

            chart1.Invalidate();

            if (allDone)
            {
                timer1.Enabled = false;
            }
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

                    ShowMessagebox.Information($"Specialty: {name}\nPercentage: {percentage}%", "Specialization Details", ParentForm);
                }
            }
        }

    }
}