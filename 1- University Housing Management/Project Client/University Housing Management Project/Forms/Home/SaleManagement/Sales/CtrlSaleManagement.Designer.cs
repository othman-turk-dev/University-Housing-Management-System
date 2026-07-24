namespace University_Housing_Management_Project.Forms.Home.SaleManagement.Sales
{
    partial class CtrlSaleManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnShowSaleDetails = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SalesDateTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.BtnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAddNewSale = new Guna.UI2.WinForms.Guna2Button();
            this.BtnPrintTheReport = new Guna.UI2.WinForms.Guna2Button();
            this.TxtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.DGVShowAllSales = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowAllSales)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnShowSaleDetails
            // 
            this.BtnShowSaleDetails.BorderRadius = 20;
            this.BtnShowSaleDetails.BorderThickness = 1;
            this.BtnShowSaleDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnShowSaleDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnShowSaleDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnShowSaleDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnShowSaleDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnShowSaleDetails.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowSaleDetails.ForeColor = System.Drawing.Color.White;
            this.BtnShowSaleDetails.Image = global::University_Housing_Management_Project.Properties.Resources.overview;
            this.BtnShowSaleDetails.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnShowSaleDetails.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnShowSaleDetails.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnShowSaleDetails.Location = new System.Drawing.Point(277, 645);
            this.BtnShowSaleDetails.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnShowSaleDetails.Name = "BtnShowSaleDetails";
            this.BtnShowSaleDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnShowSaleDetails.Size = new System.Drawing.Size(240, 56);
            this.BtnShowSaleDetails.TabIndex = 72;
            this.BtnShowSaleDetails.Text = "Show details";
            this.BtnShowSaleDetails.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnShowSaleDetails.Click += new System.EventHandler(this.BtnShowSaleDetails_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 71;
            this.label2.Text = "Search by date:";
            // 
            // SalesDateTime
            // 
            this.SalesDateTime.BorderColor = System.Drawing.Color.Transparent;
            this.SalesDateTime.BorderRadius = 20;
            this.SalesDateTime.Checked = true;
            this.SalesDateTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.SalesDateTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesDateTime.ForeColor = System.Drawing.Color.White;
            this.SalesDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SalesDateTime.Location = new System.Drawing.Point(33, 133);
            this.SalesDateTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SalesDateTime.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.SalesDateTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.SalesDateTime.Name = "SalesDateTime";
            this.SalesDateTime.Size = new System.Drawing.Size(257, 57);
            this.SalesDateTime.TabIndex = 70;
            this.SalesDateTime.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.SalesDateTime.CloseUp += new System.EventHandler(this.SalesDateTime_CloseUp);
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
            this.BtnRefresh.Location = new System.Drawing.Point(1060, 122);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnRefresh.Size = new System.Drawing.Size(171, 56);
            this.BtnRefresh.TabIndex = 69;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnAddNewSale
            // 
            this.BtnAddNewSale.BorderRadius = 20;
            this.BtnAddNewSale.BorderThickness = 1;
            this.BtnAddNewSale.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddNewSale.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddNewSale.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddNewSale.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddNewSale.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnAddNewSale.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddNewSale.ForeColor = System.Drawing.Color.White;
            this.BtnAddNewSale.Image = global::University_Housing_Management_Project.Properties.Resources.square_plus_10x1;
            this.BtnAddNewSale.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnAddNewSale.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnAddNewSale.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnAddNewSale.Location = new System.Drawing.Point(33, 645);
            this.BtnAddNewSale.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnAddNewSale.Name = "BtnAddNewSale";
            this.BtnAddNewSale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnAddNewSale.Size = new System.Drawing.Size(210, 56);
            this.BtnAddNewSale.TabIndex = 65;
            this.BtnAddNewSale.Text = "New sale";
            this.BtnAddNewSale.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnAddNewSale.Click += new System.EventHandler(this.BtnAddNewSale_Click);
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
            this.BtnPrintTheReport.Location = new System.Drawing.Point(877, 650);
            this.BtnPrintTheReport.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnPrintTheReport.Name = "BtnPrintTheReport";
            this.BtnPrintTheReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnPrintTheReport.Size = new System.Drawing.Size(341, 51);
            this.BtnPrintTheReport.TabIndex = 68;
            this.BtnPrintTheReport.Text = "Print current month\'s sales";
            this.BtnPrintTheReport.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnPrintTheReport.Click += new System.EventHandler(this.BtnPrintTheReport_Click);
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
            this.TxtSearch.Location = new System.Drawing.Point(321, 133);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TxtSearch.PlaceholderText = "Username";
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.Size = new System.Drawing.Size(281, 54);
            this.TxtSearch.TabIndex = 67;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // DGVShowAllSales
            // 
            this.DGVShowAllSales.AllowUserToAddRows = false;
            this.DGVShowAllSales.AllowUserToDeleteRows = false;
            this.DGVShowAllSales.AllowUserToOrderColumns = true;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowAllSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.DGVShowAllSales.BackgroundColor = System.Drawing.Color.MintCream;
            this.DGVShowAllSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DGVShowAllSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGVShowAllSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVShowAllSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.DGVShowAllSales.ColumnHeadersHeight = 76;
            this.DGVShowAllSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVShowAllSales.DefaultCellStyle = dataGridViewCellStyle33;
            this.DGVShowAllSales.GridColor = System.Drawing.Color.Black;
            this.DGVShowAllSales.Location = new System.Drawing.Point(18, 196);
            this.DGVShowAllSales.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGVShowAllSales.MultiSelect = false;
            this.DGVShowAllSales.Name = "DGVShowAllSales";
            this.DGVShowAllSales.ReadOnly = true;
            this.DGVShowAllSales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVShowAllSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.DGVShowAllSales.RowHeadersVisible = false;
            this.DGVShowAllSales.RowHeadersWidth = 62;
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowAllSales.RowsDefaultCellStyle = dataGridViewCellStyle35;
            this.DGVShowAllSales.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVShowAllSales.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.DGVShowAllSales.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateGray;
            this.DGVShowAllSales.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowAllSales.RowTemplate.DividerHeight = 3;
            this.DGVShowAllSales.RowTemplate.Height = 35;
            this.DGVShowAllSales.RowTemplate.ReadOnly = true;
            this.DGVShowAllSales.ShowCellToolTips = false;
            this.DGVShowAllSales.Size = new System.Drawing.Size(1223, 434);
            this.DGVShowAllSales.TabIndex = 66;
            this.DGVShowAllSales.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.DGVShowAllSales.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.DGVShowAllSales.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVShowAllSales.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.DGVShowAllSales.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.SlateGray;
            this.DGVShowAllSales.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowAllSales.ThemeStyle.BackColor = System.Drawing.Color.MintCream;
            this.DGVShowAllSales.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.DGVShowAllSales.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.DGVShowAllSales.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGVShowAllSales.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVShowAllSales.ThemeStyle.HeaderStyle.Height = 76;
            this.DGVShowAllSales.ThemeStyle.ReadOnly = true;
            this.DGVShowAllSales.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVShowAllSales.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGVShowAllSales.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVShowAllSales.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.DGVShowAllSales.ThemeStyle.RowsStyle.Height = 35;
            this.DGVShowAllSales.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.DGVShowAllSales.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // CtrlSaleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnShowSaleDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SalesDateTime);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnAddNewSale);
            this.Controls.Add(this.BtnPrintTheReport);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.DGVShowAllSales);
            this.Name = "CtrlSaleManagement";
            this.Size = new System.Drawing.Size(1259, 768);
            this.Load += new System.EventHandler(this.CtrlSaleManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowAllSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnShowSaleDetails;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker SalesDateTime;
        private Guna.UI2.WinForms.Guna2Button BtnRefresh;
        private Guna.UI2.WinForms.Guna2Button BtnAddNewSale;
        private Guna.UI2.WinForms.Guna2Button BtnPrintTheReport;
        private Guna.UI2.WinForms.Guna2TextBox TxtSearch;
        private Guna.UI2.WinForms.Guna2DataGridView DGVShowAllSales;
    }
}
