namespace University_Housing_Management_Project.Forms.Home.ProductManagement.Products
{
    partial class CtrlProductManagement
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
            this.DGVShowProductsInfo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CMStripProducts = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.UpdateProductInfoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddQuantityItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAddNewQuantity = new Guna.UI2.WinForms.Guna2Button();
            this.BtnPrintTheReport = new Guna.UI2.WinForms.Guna2Button();
            this.BtnStatistics = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAddNewProduct = new Guna.UI2.WinForms.Guna2Button();
            this.BtnUpdateProduct = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowProductsInfo)).BeginInit();
            this.CMStripProducts.SuspendLayout();
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
            this.TxtSearch.Location = new System.Drawing.Point(17, 53);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TxtSearch.PlaceholderText = "Searched by product name or ID";
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.Size = new System.Drawing.Size(360, 54);
            this.TxtSearch.TabIndex = 71;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // DGVShowProductsInfo
            // 
            this.DGVShowProductsInfo.AllowUserToAddRows = false;
            this.DGVShowProductsInfo.AllowUserToDeleteRows = false;
            this.DGVShowProductsInfo.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowProductsInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVShowProductsInfo.BackgroundColor = System.Drawing.Color.MintCream;
            this.DGVShowProductsInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DGVShowProductsInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGVShowProductsInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVShowProductsInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVShowProductsInfo.ColumnHeadersHeight = 76;
            this.DGVShowProductsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVShowProductsInfo.ContextMenuStrip = this.CMStripProducts;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVShowProductsInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVShowProductsInfo.GridColor = System.Drawing.Color.Black;
            this.DGVShowProductsInfo.Location = new System.Drawing.Point(17, 124);
            this.DGVShowProductsInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGVShowProductsInfo.MultiSelect = false;
            this.DGVShowProductsInfo.Name = "DGVShowProductsInfo";
            this.DGVShowProductsInfo.ReadOnly = true;
            this.DGVShowProductsInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVShowProductsInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVShowProductsInfo.RowHeadersVisible = false;
            this.DGVShowProductsInfo.RowHeadersWidth = 62;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowProductsInfo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVShowProductsInfo.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVShowProductsInfo.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.DGVShowProductsInfo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateGray;
            this.DGVShowProductsInfo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowProductsInfo.RowTemplate.DividerHeight = 3;
            this.DGVShowProductsInfo.RowTemplate.Height = 35;
            this.DGVShowProductsInfo.RowTemplate.ReadOnly = true;
            this.DGVShowProductsInfo.ShowCellToolTips = false;
            this.DGVShowProductsInfo.Size = new System.Drawing.Size(1223, 520);
            this.DGVShowProductsInfo.TabIndex = 70;
            this.DGVShowProductsInfo.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.DGVShowProductsInfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.DGVShowProductsInfo.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVShowProductsInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.DGVShowProductsInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.SlateGray;
            this.DGVShowProductsInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowProductsInfo.ThemeStyle.BackColor = System.Drawing.Color.MintCream;
            this.DGVShowProductsInfo.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.DGVShowProductsInfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.DGVShowProductsInfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGVShowProductsInfo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVShowProductsInfo.ThemeStyle.HeaderStyle.Height = 76;
            this.DGVShowProductsInfo.ThemeStyle.ReadOnly = true;
            this.DGVShowProductsInfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVShowProductsInfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGVShowProductsInfo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVShowProductsInfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.DGVShowProductsInfo.ThemeStyle.RowsStyle.Height = 35;
            this.DGVShowProductsInfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.DGVShowProductsInfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // CMStripProducts
            // 
            this.CMStripProducts.BackColor = System.Drawing.Color.White;
            this.CMStripProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CMStripProducts.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CMStripProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateProductInfoItem,
            this.AddQuantityItem});
            this.CMStripProducts.Name = "cmStripStudenUserControl";
            this.CMStripProducts.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CMStripProducts.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.CMStripProducts.RenderStyle.ColorTable = null;
            this.CMStripProducts.RenderStyle.RoundedEdges = false;
            this.CMStripProducts.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.CMStripProducts.RenderStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.CMStripProducts.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CMStripProducts.RenderStyle.SeparatorColor = System.Drawing.Color.Black;
            this.CMStripProducts.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CMStripProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CMStripProducts.ShowCheckMargin = true;
            this.CMStripProducts.Size = new System.Drawing.Size(284, 96);
            this.CMStripProducts.Opening += new System.ComponentModel.CancelEventHandler(this.CMStripProducts_Opening);
            // 
            // UpdateProductInfoItem
            // 
            this.UpdateProductInfoItem.Image = global::University_Housing_Management_Project.Properties.Resources.assessment_alt__1_;
            this.UpdateProductInfoItem.Name = "UpdateProductInfoItem";
            this.UpdateProductInfoItem.Size = new System.Drawing.Size(283, 32);
            this.UpdateProductInfoItem.Text = "Update product";
            this.UpdateProductInfoItem.Click += new System.EventHandler(this.UpdateProductInfoItem_Click);
            // 
            // AddQuantityItem
            // 
            this.AddQuantityItem.Image = global::University_Housing_Management_Project.Properties.Resources.square_plus;
            this.AddQuantityItem.Name = "AddQuantityItem";
            this.AddQuantityItem.Size = new System.Drawing.Size(283, 32);
            this.AddQuantityItem.Text = "Add new quantity";
            this.AddQuantityItem.Click += new System.EventHandler(this.AddQuantityItem_Click);
            // 
            // BtnAddNewQuantity
            // 
            this.BtnAddNewQuantity.BorderRadius = 20;
            this.BtnAddNewQuantity.BorderThickness = 1;
            this.BtnAddNewQuantity.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddNewQuantity.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddNewQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddNewQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddNewQuantity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnAddNewQuantity.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddNewQuantity.ForeColor = System.Drawing.Color.White;
            this.BtnAddNewQuantity.Image = global::University_Housing_Management_Project.Properties.Resources.square_plus_10x1;
            this.BtnAddNewQuantity.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnAddNewQuantity.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnAddNewQuantity.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnAddNewQuantity.Location = new System.Drawing.Point(306, 667);
            this.BtnAddNewQuantity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnAddNewQuantity.Name = "BtnAddNewQuantity";
            this.BtnAddNewQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnAddNewQuantity.Size = new System.Drawing.Size(249, 56);
            this.BtnAddNewQuantity.TabIndex = 73;
            this.BtnAddNewQuantity.Text = "Add new quantity";
            this.BtnAddNewQuantity.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnAddNewQuantity.Click += new System.EventHandler(this.BtnAddNewQuantity_Click);
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
            this.BtnPrintTheReport.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintTheReport.ForeColor = System.Drawing.Color.White;
            this.BtnPrintTheReport.Image = global::University_Housing_Management_Project.Properties.Resources.print_10x;
            this.BtnPrintTheReport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnPrintTheReport.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnPrintTheReport.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnPrintTheReport.Location = new System.Drawing.Point(991, 667);
            this.BtnPrintTheReport.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnPrintTheReport.Name = "BtnPrintTheReport";
            this.BtnPrintTheReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnPrintTheReport.Size = new System.Drawing.Size(240, 51);
            this.BtnPrintTheReport.TabIndex = 72;
            this.BtnPrintTheReport.Text = "Print the report";
            this.BtnPrintTheReport.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnPrintTheReport.Click += new System.EventHandler(this.BtnPrintTheReport_Click);
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
            this.BtnStatistics.Location = new System.Drawing.Point(599, 667);
            this.BtnStatistics.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnStatistics.Name = "BtnStatistics";
            this.BtnStatistics.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnStatistics.Size = new System.Drawing.Size(210, 56);
            this.BtnStatistics.TabIndex = 67;
            this.BtnStatistics.Text = "Statistics";
            this.BtnStatistics.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnStatistics.Click += new System.EventHandler(this.BtnStatistics_Click);
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
            this.BtnRefresh.Location = new System.Drawing.Point(1060, 53);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnRefresh.Size = new System.Drawing.Size(171, 56);
            this.BtnRefresh.TabIndex = 69;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnAddNewProduct
            // 
            this.BtnAddNewProduct.BorderRadius = 20;
            this.BtnAddNewProduct.BorderThickness = 1;
            this.BtnAddNewProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddNewProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddNewProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddNewProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddNewProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnAddNewProduct.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddNewProduct.ForeColor = System.Drawing.Color.White;
            this.BtnAddNewProduct.Image = global::University_Housing_Management_Project.Properties.Resources.square_plus_10x1;
            this.BtnAddNewProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnAddNewProduct.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnAddNewProduct.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnAddNewProduct.Location = new System.Drawing.Point(420, 53);
            this.BtnAddNewProduct.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnAddNewProduct.Name = "BtnAddNewProduct";
            this.BtnAddNewProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnAddNewProduct.Size = new System.Drawing.Size(262, 56);
            this.BtnAddNewProduct.TabIndex = 68;
            this.BtnAddNewProduct.Text = "Add new product";
            this.BtnAddNewProduct.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnAddNewProduct.Click += new System.EventHandler(this.BtnAddNewProduct_Click);
            // 
            // BtnUpdateProduct
            // 
            this.BtnUpdateProduct.BorderRadius = 20;
            this.BtnUpdateProduct.BorderThickness = 1;
            this.BtnUpdateProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdateProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdateProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUpdateProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnUpdateProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnUpdateProduct.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateProduct.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateProduct.Image = global::University_Housing_Management_Project.Properties.Resources.assessment_alt;
            this.BtnUpdateProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnUpdateProduct.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnUpdateProduct.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnUpdateProduct.Location = new System.Drawing.Point(31, 667);
            this.BtnUpdateProduct.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnUpdateProduct.Name = "BtnUpdateProduct";
            this.BtnUpdateProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnUpdateProduct.Size = new System.Drawing.Size(236, 56);
            this.BtnUpdateProduct.TabIndex = 66;
            this.BtnUpdateProduct.Text = "Update product";
            this.BtnUpdateProduct.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnUpdateProduct.Click += new System.EventHandler(this.BtnUpdateProduct_Click);
            // 
            // CtrlProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.DGVShowProductsInfo);
            this.Controls.Add(this.BtnAddNewQuantity);
            this.Controls.Add(this.BtnPrintTheReport);
            this.Controls.Add(this.BtnStatistics);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnAddNewProduct);
            this.Controls.Add(this.BtnUpdateProduct);
            this.Name = "CtrlProductManagement";
            this.Size = new System.Drawing.Size(1259, 775);
            this.Load += new System.EventHandler(this.CtrlProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowProductsInfo)).EndInit();
            this.CMStripProducts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox TxtSearch;
        private Guna.UI2.WinForms.Guna2DataGridView DGVShowProductsInfo;
        public Guna.UI2.WinForms.Guna2ContextMenuStrip CMStripProducts;
        private System.Windows.Forms.ToolStripMenuItem UpdateProductInfoItem;
        private System.Windows.Forms.ToolStripMenuItem AddQuantityItem;
        private Guna.UI2.WinForms.Guna2Button BtnAddNewQuantity;
        private Guna.UI2.WinForms.Guna2Button BtnPrintTheReport;
        private Guna.UI2.WinForms.Guna2Button BtnStatistics;
        private Guna.UI2.WinForms.Guna2Button BtnRefresh;
        private Guna.UI2.WinForms.Guna2Button BtnAddNewProduct;
        private Guna.UI2.WinForms.Guna2Button BtnUpdateProduct;
    }
}
