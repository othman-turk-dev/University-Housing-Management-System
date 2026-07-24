using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace Common_Library
{
    public static class ShowMessagebox
    {
        private static DialogResult Show(string text, string title, MessageDialogIcon icon, Form parent = null)
        {

            Guna2MessageDialog messageDialog = new Guna2MessageDialog
            {
                Caption = title,
                Text = text,
                Icon = icon,
                Parent = parent,
                Style = MessageDialogStyle.Light
            };


            if (icon == MessageDialogIcon.Question)
                messageDialog.Buttons = MessageDialogButtons.OKCancel;
            else
                messageDialog.Buttons = MessageDialogButtons.OK;

            //messageDialog.Show();

            return messageDialog.Show();
        }

        public static void Error(string text, string title, Form parent = null)
        {
            Show(text, title, MessageDialogIcon.Error, parent);
        }
        public static void Information(string text, string title, Form parent = null)
        {
            Show(text, title, MessageDialogIcon.Information, parent);
        }
        public static DialogResult Question(string text, string title, Form parent = null)
        {
            return Show(text, title, MessageDialogIcon.Question, parent);
        }

    }
}
