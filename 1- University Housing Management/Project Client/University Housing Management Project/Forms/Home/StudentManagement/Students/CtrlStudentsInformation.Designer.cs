namespace University_Housing_Management_Project.Forms.Home.StudentManagement.Students
{
    partial class CtrlStudentsInformation
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
            this.BtnDeleteStudent = new Guna.UI2.WinForms.Guna2Button();
            this.CbRoomLocationFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.CbAcademiclLevelFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CbSpecilizationFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CMStripStudents = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.ShowStudentInfoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentInfoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnShowStudentInfo = new Guna.UI2.WinForms.Guna2Button();
            this.BtnUpdateStudentInfo = new Guna.UI2.WinForms.Guna2Button();
            this.DGVShowAllStudents = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAddNewStudent = new Guna.UI2.WinForms.Guna2Button();
            this.BtnPrintTheReport = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.CMStripStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowAllStudents)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnDeleteStudent
            // 
            this.BtnDeleteStudent.BorderRadius = 20;
            this.BtnDeleteStudent.BorderThickness = 1;
            this.BtnDeleteStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeleteStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeleteStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDeleteStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDeleteStudent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnDeleteStudent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteStudent.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteStudent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnDeleteStudent.HoverState.FillColor = System.Drawing.Color.White;
            this.BtnDeleteStudent.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnDeleteStudent.Location = new System.Drawing.Point(599, 695);
            this.BtnDeleteStudent.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnDeleteStudent.Name = "BtnDeleteStudent";
            this.BtnDeleteStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnDeleteStudent.Size = new System.Drawing.Size(228, 51);
            this.BtnDeleteStudent.TabIndex = 59;
            this.BtnDeleteStudent.Text = "Delete student";
            this.BtnDeleteStudent.TextOffset = new System.Drawing.Point(15, 0);
            this.BtnDeleteStudent.Click += new System.EventHandler(this.BtnDeleteStudent_Click);
            // 
            // CbRoomLocationFilter
            // 
            this.CbRoomLocationFilter.BackColor = System.Drawing.Color.Transparent;
            this.CbRoomLocationFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.CbRoomLocationFilter.BorderThickness = 2;
            this.CbRoomLocationFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbRoomLocationFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRoomLocationFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbRoomLocationFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbRoomLocationFilter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbRoomLocationFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbRoomLocationFilter.ItemHeight = 40;
            this.CbRoomLocationFilter.Items.AddRange(new object[] {
            "All",
            "Floor 1",
            "Floor 2",
            "Floor 3"});
            this.CbRoomLocationFilter.Location = new System.Drawing.Point(629, 165);
            this.CbRoomLocationFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CbRoomLocationFilter.Name = "CbRoomLocationFilter";
            this.CbRoomLocationFilter.Size = new System.Drawing.Size(218, 46);
            this.CbRoomLocationFilter.TabIndex = 57;
            this.CbRoomLocationFilter.SelectedIndexChanged += new System.EventHandler(this.CbRoomLocationFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Room location";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Panel1.Location = new System.Drawing.Point(629, 121);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(218, 45);
            this.guna2Panel1.TabIndex = 58;
            // 
            // CbAcademiclLevelFilter
            // 
            this.CbAcademiclLevelFilter.BackColor = System.Drawing.Color.Transparent;
            this.CbAcademiclLevelFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.CbAcademiclLevelFilter.BorderThickness = 2;
            this.CbAcademiclLevelFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbAcademiclLevelFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAcademiclLevelFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbAcademiclLevelFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbAcademiclLevelFilter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.CbAcademiclLevelFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbAcademiclLevelFilter.ItemHeight = 40;
            this.CbAcademiclLevelFilter.Items.AddRange(new object[] {
            "All",
            "First year",
            "Second year",
            "Third year",
            "Fourth year",
            "Fifth year",
            "Sixth year"});
            this.CbAcademiclLevelFilter.Location = new System.Drawing.Point(349, 165);
            this.CbAcademiclLevelFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CbAcademiclLevelFilter.Name = "CbAcademiclLevelFilter";
            this.CbAcademiclLevelFilter.Size = new System.Drawing.Size(210, 46);
            this.CbAcademiclLevelFilter.TabIndex = 50;
            this.CbAcademiclLevelFilter.SelectedIndexChanged += new System.EventHandler(this.CbAcademiclLevelFilter_SelectedIndexChanged);
            // 
            // CbSpecilizationFilter
            // 
            this.CbSpecilizationFilter.BackColor = System.Drawing.Color.Transparent;
            this.CbSpecilizationFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.CbSpecilizationFilter.BorderThickness = 2;
            this.CbSpecilizationFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbSpecilizationFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSpecilizationFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbSpecilizationFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbSpecilizationFilter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbSpecilizationFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbSpecilizationFilter.ItemHeight = 40;
            this.CbSpecilizationFilter.Items.AddRange(new object[] {
            "All"});
            this.CbSpecilizationFilter.Location = new System.Drawing.Point(30, 165);
            this.CbSpecilizationFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CbSpecilizationFilter.Name = "CbSpecilizationFilter";
            this.CbSpecilizationFilter.Size = new System.Drawing.Size(268, 46);
            this.CbSpecilizationFilter.TabIndex = 49;
            this.CbSpecilizationFilter.SelectedIndexChanged += new System.EventHandler(this.CbSpecilizationFilter_SelectedIndexChanged);
            // 
            // CMStripStudents
            // 
            this.CMStripStudents.BackColor = System.Drawing.Color.White;
            this.CMStripStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CMStripStudents.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CMStripStudents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowStudentInfoItem,
            this.updateStudentInfoItem,
            this.deleteStudentItem});
            this.CMStripStudents.Name = "cmStripStudenUserControl";
            this.CMStripStudents.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CMStripStudents.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.CMStripStudents.RenderStyle.ColorTable = null;
            this.CMStripStudents.RenderStyle.RoundedEdges = false;
            this.CMStripStudents.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.CMStripStudents.RenderStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.CMStripStudents.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CMStripStudents.RenderStyle.SeparatorColor = System.Drawing.Color.Black;
            this.CMStripStudents.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CMStripStudents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CMStripStudents.ShowCheckMargin = true;
            this.CMStripStudents.Size = new System.Drawing.Size(305, 100);
            this.CMStripStudents.Opening += new System.ComponentModel.CancelEventHandler(this.CMStripStudents_Opening);
            // 
            // ShowStudentInfoItem
            // 
            this.ShowStudentInfoItem.Image = global::University_Housing_Management_Project.Properties.Resources.overview__1_;
            this.ShowStudentInfoItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ShowStudentInfoItem.Name = "ShowStudentInfoItem";
            this.ShowStudentInfoItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowStudentInfoItem.Size = new System.Drawing.Size(304, 32);
            this.ShowStudentInfoItem.Text = "Show student";
            this.ShowStudentInfoItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowStudentInfoItem.Click += new System.EventHandler(this.ShowStudentInfoItem_Click);
            // 
            // updateStudentInfoItem
            // 
            this.updateStudentInfoItem.Image = global::University_Housing_Management_Project.Properties.Resources.assessment_alt__1_;
            this.updateStudentInfoItem.Name = "updateStudentInfoItem";
            this.updateStudentInfoItem.Size = new System.Drawing.Size(304, 32);
            this.updateStudentInfoItem.Text = "Update student info";
            this.updateStudentInfoItem.Click += new System.EventHandler(this.updateStudentInfoItem_Click);
            // 
            // deleteStudentItem
            // 
            this.deleteStudentItem.Image = global::University_Housing_Management_Project.Properties.Resources.ban__2_;
            this.deleteStudentItem.Name = "deleteStudentItem";
            this.deleteStudentItem.Size = new System.Drawing.Size(304, 32);
            this.deleteStudentItem.Text = "Delete student";
            this.deleteStudentItem.Click += new System.EventHandler(this.deleteStudentItem_Click);
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
            this.TxtSearch.Location = new System.Drawing.Point(28, 32);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TxtSearch.PlaceholderText = "Search by Uni. Number";
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.Size = new System.Drawing.Size(272, 54);
            this.TxtSearch.TabIndex = 54;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // BtnShowStudentInfo
            // 
            this.BtnShowStudentInfo.BorderRadius = 20;
            this.BtnShowStudentInfo.BorderThickness = 1;
            this.BtnShowStudentInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnShowStudentInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnShowStudentInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnShowStudentInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnShowStudentInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnShowStudentInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowStudentInfo.ForeColor = System.Drawing.Color.White;
            this.BtnShowStudentInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnShowStudentInfo.HoverState.FillColor = System.Drawing.Color.White;
            this.BtnShowStudentInfo.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnShowStudentInfo.Location = new System.Drawing.Point(338, 695);
            this.BtnShowStudentInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnShowStudentInfo.Name = "BtnShowStudentInfo";
            this.BtnShowStudentInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnShowStudentInfo.Size = new System.Drawing.Size(209, 51);
            this.BtnShowStudentInfo.TabIndex = 53;
            this.BtnShowStudentInfo.Text = "Show student";
            this.BtnShowStudentInfo.TextOffset = new System.Drawing.Point(15, 0);
            this.BtnShowStudentInfo.Click += new System.EventHandler(this.BtnShowStudentInfo_Click);
            // 
            // BtnUpdateStudentInfo
            // 
            this.BtnUpdateStudentInfo.BorderRadius = 20;
            this.BtnUpdateStudentInfo.BorderThickness = 1;
            this.BtnUpdateStudentInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdateStudentInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdateStudentInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUpdateStudentInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnUpdateStudentInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnUpdateStudentInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateStudentInfo.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateStudentInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnUpdateStudentInfo.HoverState.FillColor = System.Drawing.Color.White;
            this.BtnUpdateStudentInfo.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnUpdateStudentInfo.Location = new System.Drawing.Point(28, 695);
            this.BtnUpdateStudentInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnUpdateStudentInfo.Name = "BtnUpdateStudentInfo";
            this.BtnUpdateStudentInfo.Size = new System.Drawing.Size(257, 51);
            this.BtnUpdateStudentInfo.TabIndex = 52;
            this.BtnUpdateStudentInfo.Text = "Update student info";
            this.BtnUpdateStudentInfo.TextOffset = new System.Drawing.Point(15, 0);
            this.BtnUpdateStudentInfo.Click += new System.EventHandler(this.BtnUpdateStudentInfo_Click);
            // 
            // DGVShowAllStudents
            // 
            this.DGVShowAllStudents.AllowUserToAddRows = false;
            this.DGVShowAllStudents.AllowUserToDeleteRows = false;
            this.DGVShowAllStudents.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowAllStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVShowAllStudents.BackgroundColor = System.Drawing.Color.MintCream;
            this.DGVShowAllStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DGVShowAllStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGVShowAllStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVShowAllStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVShowAllStudents.ColumnHeadersHeight = 76;
            this.DGVShowAllStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVShowAllStudents.ContextMenuStrip = this.CMStripStudents;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVShowAllStudents.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVShowAllStudents.GridColor = System.Drawing.Color.Black;
            this.DGVShowAllStudents.Location = new System.Drawing.Point(18, 236);
            this.DGVShowAllStudents.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGVShowAllStudents.MultiSelect = false;
            this.DGVShowAllStudents.Name = "DGVShowAllStudents";
            this.DGVShowAllStudents.ReadOnly = true;
            this.DGVShowAllStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVShowAllStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVShowAllStudents.RowHeadersVisible = false;
            this.DGVShowAllStudents.RowHeadersWidth = 62;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowAllStudents.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVShowAllStudents.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVShowAllStudents.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.DGVShowAllStudents.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateGray;
            this.DGVShowAllStudents.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowAllStudents.RowTemplate.DividerHeight = 3;
            this.DGVShowAllStudents.RowTemplate.Height = 35;
            this.DGVShowAllStudents.RowTemplate.ReadOnly = true;
            this.DGVShowAllStudents.ShowCellToolTips = false;
            this.DGVShowAllStudents.Size = new System.Drawing.Size(1223, 434);
            this.DGVShowAllStudents.TabIndex = 51;
            this.DGVShowAllStudents.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.DGVShowAllStudents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.DGVShowAllStudents.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVShowAllStudents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.DGVShowAllStudents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.SlateGray;
            this.DGVShowAllStudents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowAllStudents.ThemeStyle.BackColor = System.Drawing.Color.MintCream;
            this.DGVShowAllStudents.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.DGVShowAllStudents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.DGVShowAllStudents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGVShowAllStudents.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVShowAllStudents.ThemeStyle.HeaderStyle.Height = 76;
            this.DGVShowAllStudents.ThemeStyle.ReadOnly = true;
            this.DGVShowAllStudents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVShowAllStudents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGVShowAllStudents.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVShowAllStudents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.DGVShowAllStudents.ThemeStyle.RowsStyle.Height = 35;
            this.DGVShowAllStudents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.DGVShowAllStudents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Specialization";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderThickness = 2;
            this.guna2Panel4.Controls.Add(this.label4);
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Panel4.Location = new System.Drawing.Point(349, 121);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(212, 45);
            this.guna2Panel4.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "Academic year";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Panel3.Location = new System.Drawing.Point(28, 121);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(272, 45);
            this.guna2Panel3.TabIndex = 55;
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
            this.BtnRefresh.Location = new System.Drawing.Point(1057, 155);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnRefresh.Size = new System.Drawing.Size(171, 56);
            this.BtnRefresh.TabIndex = 61;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnAddNewStudent
            // 
            this.BtnAddNewStudent.BorderRadius = 20;
            this.BtnAddNewStudent.BorderThickness = 1;
            this.BtnAddNewStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddNewStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddNewStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddNewStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddNewStudent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnAddNewStudent.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddNewStudent.ForeColor = System.Drawing.Color.White;
            this.BtnAddNewStudent.Image = global::University_Housing_Management_Project.Properties.Resources.square_plus_10x1;
            this.BtnAddNewStudent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnAddNewStudent.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnAddNewStudent.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnAddNewStudent.Location = new System.Drawing.Point(349, 32);
            this.BtnAddNewStudent.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnAddNewStudent.Name = "BtnAddNewStudent";
            this.BtnAddNewStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnAddNewStudent.Size = new System.Drawing.Size(255, 56);
            this.BtnAddNewStudent.TabIndex = 48;
            this.BtnAddNewStudent.Text = "Add new student";
            this.BtnAddNewStudent.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnAddNewStudent.Click += new System.EventHandler(this.BtnAddNewStudent_Click);
            // 
            // BtnPrintTheReport
            // 
            this.BtnPrintTheReport.BorderRadius = 20;
            this.BtnPrintTheReport.BorderThickness = 1;
            this.BtnPrintTheReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPrintTheReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPrintTheReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPrintTheReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPrintTheReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnPrintTheReport.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.BtnPrintTheReport.ForeColor = System.Drawing.Color.White;
            this.BtnPrintTheReport.Image = global::University_Housing_Management_Project.Properties.Resources.print_10x;
            this.BtnPrintTheReport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnPrintTheReport.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnPrintTheReport.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnPrintTheReport.Location = new System.Drawing.Point(973, 695);
            this.BtnPrintTheReport.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnPrintTheReport.Name = "BtnPrintTheReport";
            this.BtnPrintTheReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnPrintTheReport.Size = new System.Drawing.Size(255, 51);
            this.BtnPrintTheReport.TabIndex = 60;
            this.BtnPrintTheReport.Text = "Print the report";
            this.BtnPrintTheReport.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnPrintTheReport.Click += new System.EventHandler(this.BtnPrintTheReport_Click);
            // 
            // CtrlStudentsInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnDeleteStudent);
            this.Controls.Add(this.CbRoomLocationFilter);
            this.Controls.Add(this.BtnAddNewStudent);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.CbAcademiclLevelFilter);
            this.Controls.Add(this.CbSpecilizationFilter);
            this.Controls.Add(this.BtnPrintTheReport);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.BtnShowStudentInfo);
            this.Controls.Add(this.BtnUpdateStudentInfo);
            this.Controls.Add(this.DGVShowAllStudents);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Name = "CtrlStudentsInformation";
            this.Size = new System.Drawing.Size(1259, 775);
            this.Load += new System.EventHandler(this.CtrlStudentsInformation_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.CMStripStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowAllStudents)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnRefresh;
        private Guna.UI2.WinForms.Guna2Button BtnDeleteStudent;
        private Guna.UI2.WinForms.Guna2ComboBox CbRoomLocationFilter;
        private Guna.UI2.WinForms.Guna2Button BtnAddNewStudent;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox CbAcademiclLevelFilter;
        private Guna.UI2.WinForms.Guna2ComboBox CbSpecilizationFilter;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentItem;
        private Guna.UI2.WinForms.Guna2Button BtnPrintTheReport;
        private System.Windows.Forms.ToolStripMenuItem updateStudentInfoItem;
        public Guna.UI2.WinForms.Guna2ContextMenuStrip CMStripStudents;
        private System.Windows.Forms.ToolStripMenuItem ShowStudentInfoItem;
        private Guna.UI2.WinForms.Guna2TextBox TxtSearch;
        private Guna.UI2.WinForms.Guna2Button BtnShowStudentInfo;
        private Guna.UI2.WinForms.Guna2Button BtnUpdateStudentInfo;
        private Guna.UI2.WinForms.Guna2DataGridView DGVShowAllStudents;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
    }
}
