namespace University_Housing_Management_Project.Forms.Home.UserManagement.Users
{
    partial class CtrlUserManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.DGVShowAllUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BtnActive = new Guna.UI2.WinForms.Guna2Button();
            this.BtnUpdateUser = new Guna.UI2.WinForms.Guna2Button();
            this.BtnInActiveUser = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAddNewUser = new Guna.UI2.WinForms.Guna2Button();
            this.CMStripUsers = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.ChangePasswordItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowAllUsers)).BeginInit();
            this.CMStripUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtSearch
            // 
            this.TxtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TxtSearch.BorderRadius = 10;
            this.TxtSearch.BorderThickness = 2;
            this.TxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSearch.DefaultText = "";
            this.TxtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearch.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TxtSearch.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearch.HoverState.PlaceholderForeColor = System.Drawing.Color.White;
            this.TxtSearch.Location = new System.Drawing.Point(46, 103);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TxtSearch.PlaceholderText = "Search by user name";
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.Size = new System.Drawing.Size(339, 54);
            this.TxtSearch.TabIndex = 54;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // DGVShowAllUsers
            // 
            this.DGVShowAllUsers.AllowUserToAddRows = false;
            this.DGVShowAllUsers.AllowUserToDeleteRows = false;
            this.DGVShowAllUsers.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowAllUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVShowAllUsers.BackgroundColor = System.Drawing.Color.MintCream;
            this.DGVShowAllUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DGVShowAllUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGVShowAllUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVShowAllUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVShowAllUsers.ColumnHeadersHeight = 76;
            this.DGVShowAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVShowAllUsers.ContextMenuStrip = this.CMStripUsers;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVShowAllUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVShowAllUsers.GridColor = System.Drawing.Color.Black;
            this.DGVShowAllUsers.Location = new System.Drawing.Point(18, 165);
            this.DGVShowAllUsers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGVShowAllUsers.MultiSelect = false;
            this.DGVShowAllUsers.Name = "DGVShowAllUsers";
            this.DGVShowAllUsers.ReadOnly = true;
            this.DGVShowAllUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGVShowAllUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVShowAllUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVShowAllUsers.RowHeadersVisible = false;
            this.DGVShowAllUsers.RowHeadersWidth = 62;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowAllUsers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVShowAllUsers.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVShowAllUsers.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.DGVShowAllUsers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateGray;
            this.DGVShowAllUsers.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowAllUsers.RowTemplate.DividerHeight = 3;
            this.DGVShowAllUsers.RowTemplate.Height = 35;
            this.DGVShowAllUsers.RowTemplate.ReadOnly = true;
            this.DGVShowAllUsers.ShowCellToolTips = false;
            this.DGVShowAllUsers.Size = new System.Drawing.Size(1223, 434);
            this.DGVShowAllUsers.TabIndex = 53;
            this.DGVShowAllUsers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.DGVShowAllUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.DGVShowAllUsers.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVShowAllUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.DGVShowAllUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.SlateGray;
            this.DGVShowAllUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowAllUsers.ThemeStyle.BackColor = System.Drawing.Color.MintCream;
            this.DGVShowAllUsers.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.DGVShowAllUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.DGVShowAllUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGVShowAllUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVShowAllUsers.ThemeStyle.HeaderStyle.Height = 76;
            this.DGVShowAllUsers.ThemeStyle.ReadOnly = true;
            this.DGVShowAllUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVShowAllUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGVShowAllUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVShowAllUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.DGVShowAllUsers.ThemeStyle.RowsStyle.Height = 35;
            this.DGVShowAllUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.DGVShowAllUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // BtnActive
            // 
            this.BtnActive.BorderRadius = 20;
            this.BtnActive.BorderThickness = 1;
            this.BtnActive.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnActive.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnActive.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnActive.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnActive.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnActive.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActive.ForeColor = System.Drawing.Color.White;
            this.BtnActive.Image = global::University_Housing_Management_Project.Properties.Resources.check;
            this.BtnActive.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnActive.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnActive.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnActive.Location = new System.Drawing.Point(351, 625);
            this.BtnActive.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnActive.Name = "BtnActive";
            this.BtnActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnActive.Size = new System.Drawing.Size(228, 56);
            this.BtnActive.TabIndex = 58;
            this.BtnActive.Text = "Activate user";
            this.BtnActive.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnActive.Click += new System.EventHandler(this.BtnActive_Click);
            // 
            // BtnUpdateUser
            // 
            this.BtnUpdateUser.BorderRadius = 20;
            this.BtnUpdateUser.BorderThickness = 1;
            this.BtnUpdateUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdateUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdateUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUpdateUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnUpdateUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnUpdateUser.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateUser.Image = global::University_Housing_Management_Project.Properties.Resources.assessment_alt;
            this.BtnUpdateUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnUpdateUser.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnUpdateUser.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnUpdateUser.Location = new System.Drawing.Point(694, 625);
            this.BtnUpdateUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnUpdateUser.Name = "BtnUpdateUser";
            this.BtnUpdateUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnUpdateUser.Size = new System.Drawing.Size(229, 56);
            this.BtnUpdateUser.TabIndex = 57;
            this.BtnUpdateUser.Text = "Update user";
            this.BtnUpdateUser.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnUpdateUser.Click += new System.EventHandler(this.BtnUpdateUser_Click);
            // 
            // BtnInActiveUser
            // 
            this.BtnInActiveUser.BorderRadius = 20;
            this.BtnInActiveUser.BorderThickness = 1;
            this.BtnInActiveUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnInActiveUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnInActiveUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnInActiveUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnInActiveUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnInActiveUser.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInActiveUser.ForeColor = System.Drawing.Color.White;
            this.BtnInActiveUser.Image = global::University_Housing_Management_Project.Properties.Resources.ban;
            this.BtnInActiveUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnInActiveUser.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnInActiveUser.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnInActiveUser.Location = new System.Drawing.Point(94, 625);
            this.BtnInActiveUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnInActiveUser.Name = "BtnInActiveUser";
            this.BtnInActiveUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnInActiveUser.Size = new System.Drawing.Size(228, 56);
            this.BtnInActiveUser.TabIndex = 56;
            this.BtnInActiveUser.Text = "Deactivate user";
            this.BtnInActiveUser.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnInActiveUser.Click += new System.EventHandler(this.BtnInActiveUser_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BorderRadius = 20;
            this.BtnRefresh.BorderThickness = 1;
            this.BtnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnRefresh.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.ForeColor = System.Drawing.Color.White;
            this.BtnRefresh.Image = global::University_Housing_Management_Project.Properties.Resources.arrow_dotted_rotate_anticlockwise_10x1;
            this.BtnRefresh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnRefresh.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnRefresh.Location = new System.Drawing.Point(1036, 101);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnRefresh.Size = new System.Drawing.Size(171, 56);
            this.BtnRefresh.TabIndex = 55;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnAddNewUser
            // 
            this.BtnAddNewUser.BorderRadius = 20;
            this.BtnAddNewUser.BorderThickness = 1;
            this.BtnAddNewUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddNewUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddNewUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddNewUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddNewUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnAddNewUser.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddNewUser.ForeColor = System.Drawing.Color.White;
            this.BtnAddNewUser.Image = global::University_Housing_Management_Project.Properties.Resources.square_plus_10x1;
            this.BtnAddNewUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnAddNewUser.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnAddNewUser.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnAddNewUser.Location = new System.Drawing.Point(953, 625);
            this.BtnAddNewUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnAddNewUser.Name = "BtnAddNewUser";
            this.BtnAddNewUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnAddNewUser.Size = new System.Drawing.Size(254, 56);
            this.BtnAddNewUser.TabIndex = 52;
            this.BtnAddNewUser.Text = "Add new user";
            this.BtnAddNewUser.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnAddNewUser.Click += new System.EventHandler(this.BtnAddNewUser_Click);
            // 
            // CMStripUsers
            // 
            this.CMStripUsers.BackColor = System.Drawing.Color.White;
            this.CMStripUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CMStripUsers.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CMStripUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangePasswordItem});
            this.CMStripUsers.Name = "cmStripStudenUserControl";
            this.CMStripUsers.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CMStripUsers.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.CMStripUsers.RenderStyle.ColorTable = null;
            this.CMStripUsers.RenderStyle.RoundedEdges = false;
            this.CMStripUsers.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.CMStripUsers.RenderStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.CMStripUsers.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CMStripUsers.RenderStyle.SeparatorColor = System.Drawing.Color.Black;
            this.CMStripUsers.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CMStripUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CMStripUsers.ShowCheckMargin = true;
            this.CMStripUsers.Size = new System.Drawing.Size(280, 36);
            // 
            // ChangePasswordItem
            // 
            this.ChangePasswordItem.Image = global::University_Housing_Management_Project.Properties.Resources.assessment_alt__1_;
            this.ChangePasswordItem.Name = "ChangePasswordItem";
            this.ChangePasswordItem.Size = new System.Drawing.Size(279, 32);
            this.ChangePasswordItem.Text = "Change password";
            this.ChangePasswordItem.Click += new System.EventHandler(this.ChangePasswordItem_Click);
            // 
            // CtrlUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnActive);
            this.Controls.Add(this.BtnUpdateUser);
            this.Controls.Add(this.BtnInActiveUser);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.BtnAddNewUser);
            this.Controls.Add(this.DGVShowAllUsers);
            this.Name = "CtrlUserManagement";
            this.Size = new System.Drawing.Size(1259, 775);
            this.Load += new System.EventHandler(this.CtrlUserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowAllUsers)).EndInit();
            this.CMStripUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnActive;
        private Guna.UI2.WinForms.Guna2Button BtnUpdateUser;
        private Guna.UI2.WinForms.Guna2Button BtnInActiveUser;
        private Guna.UI2.WinForms.Guna2Button BtnRefresh;
        private Guna.UI2.WinForms.Guna2TextBox TxtSearch;
        private Guna.UI2.WinForms.Guna2Button BtnAddNewUser;
        private Guna.UI2.WinForms.Guna2DataGridView DGVShowAllUsers;
        public Guna.UI2.WinForms.Guna2ContextMenuStrip CMStripUsers;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordItem;
    }
}
