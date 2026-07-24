namespace University_Housing_Management_Project.Forms.Home.UserManagement
{
    partial class CtrlAddNewUser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.PermissionList = new System.Windows.Forms.CheckedListBox();
            this.BtnReturn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.LbPassword = new System.Windows.Forms.Label();
            this.LbUsername = new System.Windows.Forms.Label();
            this.TxtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.LbTitle = new System.Windows.Forms.Label();
            this.LbNote2 = new System.Windows.Forms.Label();
            this.LbNote1 = new System.Windows.Forms.Label();
            this.LbConfirmPassword = new System.Windows.Forms.Label();
            this.TxtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.Controls.Add(this.PermissionList);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(746, 132);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(322, 338);
            this.guna2GroupBox1.TabIndex = 167;
            this.guna2GroupBox1.Text = "System Permissions";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PermissionList
            // 
            this.PermissionList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PermissionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PermissionList.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PermissionList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.PermissionList.FormattingEnabled = true;
            this.PermissionList.Items.AddRange(new object[] {
            "Student Management",
            "Subscriptions",
            "Room Management",
            "Products",
            "Sales",
            "Violations",
            "Account Management",
            "Bank Management"});
            this.PermissionList.Location = new System.Drawing.Point(0, 40);
            this.PermissionList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PermissionList.Name = "PermissionList";
            this.PermissionList.Size = new System.Drawing.Size(322, 298);
            this.PermissionList.TabIndex = 0;
            // 
            // BtnReturn
            // 
            this.BtnReturn.BorderColor = System.Drawing.Color.White;
            this.BtnReturn.BorderRadius = 20;
            this.BtnReturn.BorderThickness = 2;
            this.BtnReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnReturn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnReturn.FillColor = System.Drawing.Color.Maroon;
            this.BtnReturn.FillColor2 = System.Drawing.Color.MidnightBlue;
            this.BtnReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturn.ForeColor = System.Drawing.Color.White;
            this.BtnReturn.Location = new System.Drawing.Point(639, 647);
            this.BtnReturn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(218, 55);
            this.BtnReturn.TabIndex = 166;
            this.BtnReturn.Text = "Return";
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BorderColor = System.Drawing.Color.White;
            this.BtnSave.BorderRadius = 20;
            this.BtnSave.BorderThickness = 2;
            this.BtnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSave.FillColor = System.Drawing.Color.Maroon;
            this.BtnSave.FillColor2 = System.Drawing.Color.MidnightBlue;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(319, 647);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(218, 55);
            this.BtnSave.TabIndex = 165;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.BackColor = System.Drawing.Color.Transparent;
            this.LbPassword.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.LbPassword.Location = new System.Drawing.Point(84, 268);
            this.LbPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(111, 29);
            this.LbPassword.TabIndex = 164;
            this.LbPassword.Text = "Password";
            // 
            // LbUsername
            // 
            this.LbUsername.AutoSize = true;
            this.LbUsername.BackColor = System.Drawing.Color.Transparent;
            this.LbUsername.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.LbUsername.Location = new System.Drawing.Point(84, 149);
            this.LbUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(117, 29);
            this.LbUsername.TabIndex = 163;
            this.LbUsername.Text = "Username";
            // 
            // TxtPassword
            // 
            this.TxtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TxtPassword.BorderRadius = 10;
            this.TxtPassword.BorderThickness = 2;
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.DefaultText = "";
            this.TxtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.TxtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TxtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPassword.Location = new System.Drawing.Point(91, 302);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TxtPassword.PlaceholderText = "";
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.Size = new System.Drawing.Size(276, 45);
            this.TxtPassword.TabIndex = 162;
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // TxtUserName
            // 
            this.TxtUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TxtUserName.BorderRadius = 10;
            this.TxtUserName.BorderThickness = 2;
            this.TxtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUserName.DefaultText = "";
            this.TxtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUserName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TxtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUserName.Location = new System.Drawing.Point(91, 184);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TxtUserName.PlaceholderText = "";
            this.TxtUserName.SelectedText = "";
            this.TxtUserName.Size = new System.Drawing.Size(276, 45);
            this.TxtUserName.TabIndex = 161;
            this.TxtUserName.Leave += new System.EventHandler(this.TxtUserName_Leave);
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.LbTitle.Location = new System.Drawing.Point(428, 40);
            this.LbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(220, 41);
            this.LbTitle.TabIndex = 160;
            this.LbTitle.Text = "Add New User";
            // 
            // LbNote2
            // 
            this.LbNote2.BackColor = System.Drawing.Color.Transparent;
            this.LbNote2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNote2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.LbNote2.Location = new System.Drawing.Point(152, 483);
            this.LbNote2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbNote2.Name = "LbNote2";
            this.LbNote2.Size = new System.Drawing.Size(431, 116);
            this.LbNote2.TabIndex = 169;
            this.LbNote2.Text = "The password must contain an uppercase letter, a lowercase letter, a number, and " +
    "a special character, and be longer than seven characters.\r\n";
            this.LbNote2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbNote2.Visible = false;
            // 
            // LbNote1
            // 
            this.LbNote1.BackColor = System.Drawing.Color.Transparent;
            this.LbNote1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNote1.ForeColor = System.Drawing.Color.Maroon;
            this.LbNote1.Location = new System.Drawing.Point(86, 444);
            this.LbNote1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbNote1.Name = "LbNote1";
            this.LbNote1.Size = new System.Drawing.Size(147, 39);
            this.LbNote1.TabIndex = 168;
            this.LbNote1.Text = "Note:";
            this.LbNote1.Visible = false;
            // 
            // LbConfirmPassword
            // 
            this.LbConfirmPassword.AutoSize = true;
            this.LbConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.LbConfirmPassword.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.LbConfirmPassword.Location = new System.Drawing.Point(410, 268);
            this.LbConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbConfirmPassword.Name = "LbConfirmPassword";
            this.LbConfirmPassword.Size = new System.Drawing.Size(197, 29);
            this.LbConfirmPassword.TabIndex = 171;
            this.LbConfirmPassword.Text = "Confirm password";
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TxtConfirmPassword.BorderRadius = 10;
            this.TxtConfirmPassword.BorderThickness = 2;
            this.TxtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtConfirmPassword.DefaultText = "";
            this.TxtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtConfirmPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.TxtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TxtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtConfirmPassword.Location = new System.Drawing.Point(418, 302);
            this.TxtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TxtConfirmPassword.PlaceholderText = "";
            this.TxtConfirmPassword.SelectedText = "";
            this.TxtConfirmPassword.Size = new System.Drawing.Size(276, 45);
            this.TxtConfirmPassword.TabIndex = 170;
            // 
            // CtrlAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LbConfirmPassword);
            this.Controls.Add(this.TxtConfirmPassword);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LbPassword);
            this.Controls.Add(this.LbUsername);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.LbTitle);
            this.Controls.Add(this.LbNote2);
            this.Controls.Add(this.LbNote1);
            this.Name = "CtrlAddNewUser";
            this.Size = new System.Drawing.Size(1259, 775);
            this.Load += new System.EventHandler(this.CtrlAddNewUser_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.CheckedListBox PermissionList;
        private Guna.UI2.WinForms.Guna2GradientButton BtnReturn;
        private Guna.UI2.WinForms.Guna2GradientButton BtnSave;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.Label LbUsername;
        private Guna.UI2.WinForms.Guna2TextBox TxtPassword;
        private Guna.UI2.WinForms.Guna2TextBox TxtUserName;
        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.Label LbNote2;
        private System.Windows.Forms.Label LbNote1;
        private System.Windows.Forms.Label LbConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox TxtConfirmPassword;
    }
}
