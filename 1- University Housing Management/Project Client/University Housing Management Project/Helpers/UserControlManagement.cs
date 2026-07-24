using System.Windows.Forms;

namespace University_Housing_Management_Project.Helpers
{
    internal class UserControlManagement
    {
        private static Panel _panel;

        public static void Initialize(Panel panel)
        {
            _panel = panel;
        }
        public static void ShowUserControl(UserControl control)
        {
            if (control == null || _panel == null)
                return;

            foreach (Control oldControl in _panel.Controls)
            {
                oldControl.Dispose();
            }
            _panel.Controls.Clear();

            control.Dock = DockStyle.Fill;
            _panel.Controls.Add(control);

            control.BringToFront();
        }

    }
}