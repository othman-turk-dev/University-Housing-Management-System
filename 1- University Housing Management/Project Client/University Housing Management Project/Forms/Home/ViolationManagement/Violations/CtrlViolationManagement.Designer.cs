namespace University_Housing_Management_Project.Forms.Home.ViolationManagement.Violations
{
    partial class CtrlViolationManagement
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
            this.ChBDateFilter = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.CbIsPaidFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CbViolationTypesFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TxtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.DateTimeViolation = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.CMStripViolations = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.PaidFineItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteViolationItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGVShowAllViolations = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BtnStatistics = new Guna.UI2.WinForms.Guna2Button();
            this.BtnPrintTheReport = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAddNewViolation = new Guna.UI2.WinForms.Guna2Button();
            this.BtnShowViolations = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.CMStripViolations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowAllViolations)).BeginInit();
            this.SuspendLayout();
            // 
            // ChBDateFilter
            // 
            this.ChBDateFilter.AutoSize = true;
            this.ChBDateFilter.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.ChBDateFilter.CheckedState.BorderRadius = 0;
            this.ChBDateFilter.CheckedState.BorderThickness = 0;
            this.ChBDateFilter.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.ChBDateFilter.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChBDateFilter.Location = new System.Drawing.Point(656, 118);
            this.ChBDateFilter.Name = "ChBDateFilter";
            this.ChBDateFilter.Size = new System.Drawing.Size(245, 29);
            this.ChBDateFilter.TabIndex = 82;
            this.ChBDateFilter.Text = ":Search by violation date";
            this.ChBDateFilter.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ChBDateFilter.UncheckedState.BorderRadius = 0;
            this.ChBDateFilter.UncheckedState.BorderThickness = 0;
            this.ChBDateFilter.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ChBDateFilter.CheckedChanged += new System.EventHandler(this.ChBDateFilter_CheckedChanged);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Panel2.Location = new System.Drawing.Point(329, 114);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(210, 51);
            this.guna2Panel2.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Payment status";
            // 
            // CbIsPaidFilter
            // 
            this.CbIsPaidFilter.BackColor = System.Drawing.Color.Transparent;
            this.CbIsPaidFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.CbIsPaidFilter.BorderThickness = 2;
            this.CbIsPaidFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbIsPaidFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbIsPaidFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbIsPaidFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbIsPaidFilter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbIsPaidFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbIsPaidFilter.ItemHeight = 40;
            this.CbIsPaidFilter.Items.AddRange(new object[] {
            "All",
            "Paid",
            "Unpaid"});
            this.CbIsPaidFilter.Location = new System.Drawing.Point(329, 164);
            this.CbIsPaidFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CbIsPaidFilter.Name = "CbIsPaidFilter";
            this.CbIsPaidFilter.Size = new System.Drawing.Size(208, 46);
            this.CbIsPaidFilter.TabIndex = 75;
            this.CbIsPaidFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CbIsPaidFilter.SelectedIndexChanged += new System.EventHandler(this.CbIsPaidFilter_SelectedIndexChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Panel1.Location = new System.Drawing.Point(23, 114);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(259, 51);
            this.guna2Panel1.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Violation type";
            // 
            // CbViolationTypesFilter
            // 
            this.CbViolationTypesFilter.BackColor = System.Drawing.Color.Transparent;
            this.CbViolationTypesFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.CbViolationTypesFilter.BorderThickness = 2;
            this.CbViolationTypesFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbViolationTypesFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbViolationTypesFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbViolationTypesFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbViolationTypesFilter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbViolationTypesFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbViolationTypesFilter.ItemHeight = 40;
            this.CbViolationTypesFilter.Items.AddRange(new object[] {
            "All"});
            this.CbViolationTypesFilter.Location = new System.Drawing.Point(25, 164);
            this.CbViolationTypesFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CbViolationTypesFilter.Name = "CbViolationTypesFilter";
            this.CbViolationTypesFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CbViolationTypesFilter.Size = new System.Drawing.Size(255, 46);
            this.CbViolationTypesFilter.TabIndex = 73;
            this.CbViolationTypesFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CbViolationTypesFilter.SelectedIndexChanged += new System.EventHandler(this.CbViolationTypesFilter_SelectedIndexChanged);
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
            this.TxtSearch.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearch.HoverState.PlaceholderForeColor = System.Drawing.Color.White;
            this.TxtSearch.Location = new System.Drawing.Point(23, 33);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TxtSearch.PlaceholderText = "Student name";
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.Size = new System.Drawing.Size(264, 47);
            this.TxtSearch.TabIndex = 72;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // DateTimeViolation
            // 
            this.DateTimeViolation.BorderColor = System.Drawing.Color.Transparent;
            this.DateTimeViolation.BorderRadius = 20;
            this.DateTimeViolation.Checked = true;
            this.DateTimeViolation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.DateTimeViolation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeViolation.ForeColor = System.Drawing.Color.White;
            this.DateTimeViolation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeViolation.Location = new System.Drawing.Point(621, 153);
            this.DateTimeViolation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DateTimeViolation.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.DateTimeViolation.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DateTimeViolation.Name = "DateTimeViolation";
            this.DateTimeViolation.Size = new System.Drawing.Size(257, 57);
            this.DateTimeViolation.TabIndex = 71;
            this.DateTimeViolation.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.DateTimeViolation.CloseUp += new System.EventHandler(this.DateTimeViolation_CloseUp);
            // 
            // CMStripViolations
            // 
            this.CMStripViolations.BackColor = System.Drawing.Color.White;
            this.CMStripViolations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CMStripViolations.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CMStripViolations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PaidFineItem,
            this.DeleteViolationItem});
            this.CMStripViolations.Name = "cmStripStudenUserControl";
            this.CMStripViolations.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CMStripViolations.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.CMStripViolations.RenderStyle.ColorTable = null;
            this.CMStripViolations.RenderStyle.RoundedEdges = false;
            this.CMStripViolations.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.CMStripViolations.RenderStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.CMStripViolations.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CMStripViolations.RenderStyle.SeparatorColor = System.Drawing.Color.Black;
            this.CMStripViolations.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CMStripViolations.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CMStripViolations.ShowCheckMargin = true;
            this.CMStripViolations.Size = new System.Drawing.Size(267, 68);
            this.CMStripViolations.Opening += new System.ComponentModel.CancelEventHandler(this.CMStripViolations_Opening);
            // 
            // PaidFineItem
            // 
            this.PaidFineItem.Image = global::University_Housing_Management_Project.Properties.Resources.dollar_symbol;
            this.PaidFineItem.Name = "PaidFineItem";
            this.PaidFineItem.Size = new System.Drawing.Size(266, 32);
            this.PaidFineItem.Text = "Paid fine";
            this.PaidFineItem.Click += new System.EventHandler(this.PaidFineItem_Click);
            // 
            // DeleteViolationItem
            // 
            this.DeleteViolationItem.Image = global::University_Housing_Management_Project.Properties.Resources.ban__2_;
            this.DeleteViolationItem.Name = "DeleteViolationItem";
            this.DeleteViolationItem.Size = new System.Drawing.Size(266, 32);
            this.DeleteViolationItem.Text = "Delete violation";
            this.DeleteViolationItem.Click += new System.EventHandler(this.DeleteViolationItem_Click);
            // 
            // DGVShowAllViolations
            // 
            this.DGVShowAllViolations.AllowUserToAddRows = false;
            this.DGVShowAllViolations.AllowUserToDeleteRows = false;
            this.DGVShowAllViolations.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowAllViolations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVShowAllViolations.BackgroundColor = System.Drawing.Color.MintCream;
            this.DGVShowAllViolations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DGVShowAllViolations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGVShowAllViolations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVShowAllViolations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVShowAllViolations.ColumnHeadersHeight = 76;
            this.DGVShowAllViolations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVShowAllViolations.ContextMenuStrip = this.CMStripViolations;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVShowAllViolations.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVShowAllViolations.GridColor = System.Drawing.Color.Black;
            this.DGVShowAllViolations.Location = new System.Drawing.Point(14, 227);
            this.DGVShowAllViolations.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGVShowAllViolations.MultiSelect = false;
            this.DGVShowAllViolations.Name = "DGVShowAllViolations";
            this.DGVShowAllViolations.ReadOnly = true;
            this.DGVShowAllViolations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVShowAllViolations.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVShowAllViolations.RowHeadersVisible = false;
            this.DGVShowAllViolations.RowHeadersWidth = 62;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowAllViolations.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVShowAllViolations.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVShowAllViolations.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.DGVShowAllViolations.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateGray;
            this.DGVShowAllViolations.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowAllViolations.RowTemplate.DividerHeight = 3;
            this.DGVShowAllViolations.RowTemplate.Height = 35;
            this.DGVShowAllViolations.RowTemplate.ReadOnly = true;
            this.DGVShowAllViolations.ShowCellToolTips = false;
            this.DGVShowAllViolations.Size = new System.Drawing.Size(1223, 434);
            this.DGVShowAllViolations.TabIndex = 70;
            this.DGVShowAllViolations.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.DGVShowAllViolations.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.DGVShowAllViolations.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVShowAllViolations.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.DGVShowAllViolations.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.SlateGray;
            this.DGVShowAllViolations.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowAllViolations.ThemeStyle.BackColor = System.Drawing.Color.MintCream;
            this.DGVShowAllViolations.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.DGVShowAllViolations.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.DGVShowAllViolations.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGVShowAllViolations.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVShowAllViolations.ThemeStyle.HeaderStyle.Height = 76;
            this.DGVShowAllViolations.ThemeStyle.ReadOnly = true;
            this.DGVShowAllViolations.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVShowAllViolations.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGVShowAllViolations.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVShowAllViolations.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.DGVShowAllViolations.ThemeStyle.RowsStyle.Height = 35;
            this.DGVShowAllViolations.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.DGVShowAllViolations.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // BtnStatistics
            // 
            this.BtnStatistics.BorderRadius = 20;
            this.BtnStatistics.BorderThickness = 1;
            this.BtnStatistics.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnStatistics.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnStatistics.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnStatistics.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnStatistics.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnStatistics.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStatistics.ForeColor = System.Drawing.Color.White;
            this.BtnStatistics.Image = global::University_Housing_Management_Project.Properties.Resources.trend;
            this.BtnStatistics.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnStatistics.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnStatistics.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnStatistics.Location = new System.Drawing.Point(632, 681);
            this.BtnStatistics.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnStatistics.Name = "BtnStatistics";
            this.BtnStatistics.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnStatistics.Size = new System.Drawing.Size(172, 56);
            this.BtnStatistics.TabIndex = 81;
            this.BtnStatistics.Text = "Statistics";
            this.BtnStatistics.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnStatistics.Click += new System.EventHandler(this.BtnStatistics_Click);
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
            this.BtnPrintTheReport.Location = new System.Drawing.Point(897, 681);
            this.BtnPrintTheReport.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnPrintTheReport.Name = "BtnPrintTheReport";
            this.BtnPrintTheReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnPrintTheReport.Size = new System.Drawing.Size(329, 56);
            this.BtnPrintTheReport.TabIndex = 80;
            this.BtnPrintTheReport.Text = "Printing the annual report";
            this.BtnPrintTheReport.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnPrintTheReport.Click += new System.EventHandler(this.BtnPrintTheReport_Click);
            // 
            // BtnAddNewViolation
            // 
            this.BtnAddNewViolation.BorderRadius = 20;
            this.BtnAddNewViolation.BorderThickness = 1;
            this.BtnAddNewViolation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddNewViolation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddNewViolation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddNewViolation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddNewViolation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnAddNewViolation.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddNewViolation.ForeColor = System.Drawing.Color.White;
            this.BtnAddNewViolation.Image = global::University_Housing_Management_Project.Properties.Resources.square_plus_10x1;
            this.BtnAddNewViolation.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnAddNewViolation.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnAddNewViolation.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnAddNewViolation.Location = new System.Drawing.Point(14, 681);
            this.BtnAddNewViolation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnAddNewViolation.Name = "BtnAddNewViolation";
            this.BtnAddNewViolation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnAddNewViolation.Size = new System.Drawing.Size(266, 56);
            this.BtnAddNewViolation.TabIndex = 79;
            this.BtnAddNewViolation.Text = "Add new violation";
            this.BtnAddNewViolation.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnAddNewViolation.Click += new System.EventHandler(this.BtnAddNewViolation_Click);
            // 
            // BtnShowViolations
            // 
            this.BtnShowViolations.BorderRadius = 20;
            this.BtnShowViolations.BorderThickness = 1;
            this.BtnShowViolations.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnShowViolations.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnShowViolations.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnShowViolations.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnShowViolations.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnShowViolations.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowViolations.ForeColor = System.Drawing.Color.White;
            this.BtnShowViolations.Image = global::University_Housing_Management_Project.Properties.Resources.overview;
            this.BtnShowViolations.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnShowViolations.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnShowViolations.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnShowViolations.Location = new System.Drawing.Point(303, 681);
            this.BtnShowViolations.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnShowViolations.Name = "BtnShowViolations";
            this.BtnShowViolations.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnShowViolations.Size = new System.Drawing.Size(304, 56);
            this.BtnShowViolations.TabIndex = 78;
            this.BtnShowViolations.Text = "Show student violation";
            this.BtnShowViolations.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnShowViolations.Click += new System.EventHandler(this.BtnShowViolations_Click);
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
            this.BtnRefresh.Location = new System.Drawing.Point(1055, 153);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnRefresh.Size = new System.Drawing.Size(171, 56);
            this.BtnRefresh.TabIndex = 77;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // CtrlViolationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ChBDateFilter);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.CbIsPaidFilter);
            this.Controls.Add(this.BtnStatistics);
            this.Controls.Add(this.BtnPrintTheReport);
            this.Controls.Add(this.BtnAddNewViolation);
            this.Controls.Add(this.BtnShowViolations);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.CbViolationTypesFilter);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.DateTimeViolation);
            this.Controls.Add(this.DGVShowAllViolations);
            this.Name = "CtrlViolationManagement";
            this.Size = new System.Drawing.Size(1259, 775);
            this.Load += new System.EventHandler(this.CtrlViolationManagement_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.CMStripViolations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowAllViolations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CheckBox ChBDateFilter;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox CbIsPaidFilter;
        private Guna.UI2.WinForms.Guna2Button BtnStatistics;
        private Guna.UI2.WinForms.Guna2Button BtnPrintTheReport;
        private Guna.UI2.WinForms.Guna2Button BtnAddNewViolation;
        private Guna.UI2.WinForms.Guna2Button BtnShowViolations;
        private Guna.UI2.WinForms.Guna2Button BtnRefresh;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox CbViolationTypesFilter;
        private Guna.UI2.WinForms.Guna2TextBox TxtSearch;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimeViolation;
        private System.Windows.Forms.ToolStripMenuItem DeleteViolationItem;
        private System.Windows.Forms.ToolStripMenuItem PaidFineItem;
        public Guna.UI2.WinForms.Guna2ContextMenuStrip CMStripViolations;
        private Guna.UI2.WinForms.Guna2DataGridView DGVShowAllViolations;
    }
}
