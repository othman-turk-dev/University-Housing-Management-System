namespace University_Housing_Management_Project.Forms.Home.SubscriptionManagement.StudentSubscriptions
{
    partial class CtrlSubscriptionManagement
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
            this.CbExpiryDate = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CbSubscriptionStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DGVShowSubscriptionsInfo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CMStripSubscriptions = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.RenewSubscriptionInfoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.CbSubscriptionTypes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BtnPrintTheReport = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAddNewSubscription = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRenewSubscription = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowSubscriptionsInfo)).BeginInit();
            this.CMStripSubscriptions.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
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
            this.TxtSearch.Location = new System.Drawing.Point(28, 35);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TxtSearch.PlaceholderText = "Search by name";
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.Size = new System.Drawing.Size(264, 54);
            this.TxtSearch.TabIndex = 50;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // CbExpiryDate
            // 
            this.CbExpiryDate.BackColor = System.Drawing.Color.Transparent;
            this.CbExpiryDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.CbExpiryDate.BorderThickness = 2;
            this.CbExpiryDate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbExpiryDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbExpiryDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbExpiryDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbExpiryDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbExpiryDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbExpiryDate.ItemHeight = 40;
            this.CbExpiryDate.Items.AddRange(new object[] {
            "All",
            "Nearest Expiry Date",
            "Furthest from subscription expiration"});
            this.CbExpiryDate.Location = new System.Drawing.Point(634, 163);
            this.CbExpiryDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CbExpiryDate.Name = "CbExpiryDate";
            this.CbExpiryDate.Size = new System.Drawing.Size(286, 46);
            this.CbExpiryDate.TabIndex = 47;
            this.CbExpiryDate.SelectedIndexChanged += new System.EventHandler(this.CbExpiryDate_SelectedIndexChanged);
            // 
            // CbSubscriptionStatus
            // 
            this.CbSubscriptionStatus.BackColor = System.Drawing.Color.Transparent;
            this.CbSubscriptionStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.CbSubscriptionStatus.BorderThickness = 2;
            this.CbSubscriptionStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbSubscriptionStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSubscriptionStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbSubscriptionStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbSubscriptionStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbSubscriptionStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbSubscriptionStatus.ItemHeight = 40;
            this.CbSubscriptionStatus.Items.AddRange(new object[] {
            "All",
            "Active",
            "Unactive"});
            this.CbSubscriptionStatus.Location = new System.Drawing.Point(333, 163);
            this.CbSubscriptionStatus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CbSubscriptionStatus.Name = "CbSubscriptionStatus";
            this.CbSubscriptionStatus.Size = new System.Drawing.Size(242, 46);
            this.CbSubscriptionStatus.TabIndex = 44;
            this.CbSubscriptionStatus.SelectedIndexChanged += new System.EventHandler(this.CbSubscriptionStatus_SelectedIndexChanged);
            // 
            // DGVShowSubscriptionsInfo
            // 
            this.DGVShowSubscriptionsInfo.AllowUserToAddRows = false;
            this.DGVShowSubscriptionsInfo.AllowUserToDeleteRows = false;
            this.DGVShowSubscriptionsInfo.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowSubscriptionsInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVShowSubscriptionsInfo.BackgroundColor = System.Drawing.Color.MintCream;
            this.DGVShowSubscriptionsInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DGVShowSubscriptionsInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGVShowSubscriptionsInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVShowSubscriptionsInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVShowSubscriptionsInfo.ColumnHeadersHeight = 76;
            this.DGVShowSubscriptionsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVShowSubscriptionsInfo.ContextMenuStrip = this.CMStripSubscriptions;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVShowSubscriptionsInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVShowSubscriptionsInfo.GridColor = System.Drawing.Color.Black;
            this.DGVShowSubscriptionsInfo.Location = new System.Drawing.Point(18, 234);
            this.DGVShowSubscriptionsInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGVShowSubscriptionsInfo.MultiSelect = false;
            this.DGVShowSubscriptionsInfo.Name = "DGVShowSubscriptionsInfo";
            this.DGVShowSubscriptionsInfo.ReadOnly = true;
            this.DGVShowSubscriptionsInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVShowSubscriptionsInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVShowSubscriptionsInfo.RowHeadersVisible = false;
            this.DGVShowSubscriptionsInfo.RowHeadersWidth = 62;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowSubscriptionsInfo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVShowSubscriptionsInfo.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVShowSubscriptionsInfo.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.DGVShowSubscriptionsInfo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateGray;
            this.DGVShowSubscriptionsInfo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowSubscriptionsInfo.RowTemplate.DividerHeight = 3;
            this.DGVShowSubscriptionsInfo.RowTemplate.Height = 35;
            this.DGVShowSubscriptionsInfo.RowTemplate.ReadOnly = true;
            this.DGVShowSubscriptionsInfo.ShowCellToolTips = false;
            this.DGVShowSubscriptionsInfo.Size = new System.Drawing.Size(1223, 434);
            this.DGVShowSubscriptionsInfo.TabIndex = 48;
            this.DGVShowSubscriptionsInfo.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.DGVShowSubscriptionsInfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.DGVShowSubscriptionsInfo.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVShowSubscriptionsInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.DGVShowSubscriptionsInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.SlateGray;
            this.DGVShowSubscriptionsInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowSubscriptionsInfo.ThemeStyle.BackColor = System.Drawing.Color.MintCream;
            this.DGVShowSubscriptionsInfo.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.DGVShowSubscriptionsInfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.DGVShowSubscriptionsInfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGVShowSubscriptionsInfo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVShowSubscriptionsInfo.ThemeStyle.HeaderStyle.Height = 76;
            this.DGVShowSubscriptionsInfo.ThemeStyle.ReadOnly = true;
            this.DGVShowSubscriptionsInfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVShowSubscriptionsInfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGVShowSubscriptionsInfo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVShowSubscriptionsInfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.DGVShowSubscriptionsInfo.ThemeStyle.RowsStyle.Height = 35;
            this.DGVShowSubscriptionsInfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.DGVShowSubscriptionsInfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // CMStripSubscriptions
            // 
            this.CMStripSubscriptions.BackColor = System.Drawing.Color.White;
            this.CMStripSubscriptions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CMStripSubscriptions.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CMStripSubscriptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RenewSubscriptionInfoItem});
            this.CMStripSubscriptions.Name = "cmStripStudenUserControl";
            this.CMStripSubscriptions.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CMStripSubscriptions.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.CMStripSubscriptions.RenderStyle.ColorTable = null;
            this.CMStripSubscriptions.RenderStyle.RoundedEdges = false;
            this.CMStripSubscriptions.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.CMStripSubscriptions.RenderStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.CMStripSubscriptions.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CMStripSubscriptions.RenderStyle.SeparatorColor = System.Drawing.Color.Black;
            this.CMStripSubscriptions.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CMStripSubscriptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CMStripSubscriptions.ShowCheckMargin = true;
            this.CMStripSubscriptions.Size = new System.Drawing.Size(300, 36);
            this.CMStripSubscriptions.Opening += new System.ComponentModel.CancelEventHandler(this.CMStripSubscriptions_Opening);
            // 
            // RenewSubscriptionInfoItem
            // 
            this.RenewSubscriptionInfoItem.Image = global::University_Housing_Management_Project.Properties.Resources.calendar_update__1_;
            this.RenewSubscriptionInfoItem.Name = "RenewSubscriptionInfoItem";
            this.RenewSubscriptionInfoItem.Size = new System.Drawing.Size(299, 32);
            this.RenewSubscriptionInfoItem.Text = "Renew subscription";
            this.RenewSubscriptionInfoItem.Click += new System.EventHandler(this.RenewSubscriptionInfoItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(81, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Expiry date";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Panel2.Location = new System.Drawing.Point(634, 119);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(286, 45);
            this.guna2Panel2.TabIndex = 49;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Panel1.Location = new System.Drawing.Point(333, 119);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(244, 45);
            this.guna2Panel1.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Subscription status";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderThickness = 2;
            this.guna2Panel4.Controls.Add(this.label4);
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Panel4.Location = new System.Drawing.Point(28, 119);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(253, 45);
            this.guna2Panel4.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Subscription type";
            // 
            // CbSubscriptionTypes
            // 
            this.CbSubscriptionTypes.BackColor = System.Drawing.Color.Transparent;
            this.CbSubscriptionTypes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.CbSubscriptionTypes.BorderThickness = 2;
            this.CbSubscriptionTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbSubscriptionTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSubscriptionTypes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbSubscriptionTypes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbSubscriptionTypes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbSubscriptionTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbSubscriptionTypes.ItemHeight = 40;
            this.CbSubscriptionTypes.Items.AddRange(new object[] {
            "All"});
            this.CbSubscriptionTypes.Location = new System.Drawing.Point(28, 163);
            this.CbSubscriptionTypes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CbSubscriptionTypes.Name = "CbSubscriptionTypes";
            this.CbSubscriptionTypes.Size = new System.Drawing.Size(251, 46);
            this.CbSubscriptionTypes.TabIndex = 42;
            this.CbSubscriptionTypes.SelectedIndexChanged += new System.EventHandler(this.CbSubscriptionTypes_SelectedIndexChanged);
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
            this.BtnPrintTheReport.Location = new System.Drawing.Point(1001, 696);
            this.BtnPrintTheReport.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnPrintTheReport.Name = "BtnPrintTheReport";
            this.BtnPrintTheReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnPrintTheReport.Size = new System.Drawing.Size(240, 51);
            this.BtnPrintTheReport.TabIndex = 51;
            this.BtnPrintTheReport.Text = "Print the report";
            this.BtnPrintTheReport.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnPrintTheReport.Click += new System.EventHandler(this.BtnPrintTheReport_Click);
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
            this.BtnRefresh.Location = new System.Drawing.Point(1057, 163);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnRefresh.Size = new System.Drawing.Size(171, 56);
            this.BtnRefresh.TabIndex = 45;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnAddNewSubscription
            // 
            this.BtnAddNewSubscription.BorderRadius = 20;
            this.BtnAddNewSubscription.BorderThickness = 1;
            this.BtnAddNewSubscription.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddNewSubscription.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddNewSubscription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddNewSubscription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddNewSubscription.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnAddNewSubscription.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddNewSubscription.ForeColor = System.Drawing.Color.White;
            this.BtnAddNewSubscription.Image = global::University_Housing_Management_Project.Properties.Resources.square_plus_10x1;
            this.BtnAddNewSubscription.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnAddNewSubscription.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnAddNewSubscription.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnAddNewSubscription.Location = new System.Drawing.Point(28, 691);
            this.BtnAddNewSubscription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnAddNewSubscription.Name = "BtnAddNewSubscription";
            this.BtnAddNewSubscription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnAddNewSubscription.Size = new System.Drawing.Size(289, 56);
            this.BtnAddNewSubscription.TabIndex = 41;
            this.BtnAddNewSubscription.Text = "Add new subscription";
            this.BtnAddNewSubscription.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnAddNewSubscription.Click += new System.EventHandler(this.BtnAddNewSubscription_Click);
            // 
            // BtnRenewSubscription
            // 
            this.BtnRenewSubscription.BorderRadius = 20;
            this.BtnRenewSubscription.BorderThickness = 1;
            this.BtnRenewSubscription.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRenewSubscription.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRenewSubscription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRenewSubscription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRenewSubscription.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnRenewSubscription.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRenewSubscription.ForeColor = System.Drawing.Color.White;
            this.BtnRenewSubscription.Image = global::University_Housing_Management_Project.Properties.Resources.calendar_update;
            this.BtnRenewSubscription.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnRenewSubscription.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnRenewSubscription.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnRenewSubscription.Location = new System.Drawing.Point(357, 691);
            this.BtnRenewSubscription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnRenewSubscription.Name = "BtnRenewSubscription";
            this.BtnRenewSubscription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnRenewSubscription.Size = new System.Drawing.Size(274, 56);
            this.BtnRenewSubscription.TabIndex = 39;
            this.BtnRenewSubscription.Text = "Renew subscription";
            this.BtnRenewSubscription.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnRenewSubscription.Click += new System.EventHandler(this.BtnRenewSubscription_Click);
            // 
            // CtrlSubscriptionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnPrintTheReport);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.CbExpiryDate);
            this.Controls.Add(this.CbSubscriptionStatus);
            this.Controls.Add(this.DGVShowSubscriptionsInfo);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.CbSubscriptionTypes);
            this.Controls.Add(this.BtnAddNewSubscription);
            this.Controls.Add(this.BtnRenewSubscription);
            this.Name = "CtrlSubscriptionManagement";
            this.Size = new System.Drawing.Size(1259, 775);
            this.Load += new System.EventHandler(this.CtrlSubscriptionManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowSubscriptionsInfo)).EndInit();
            this.CMStripSubscriptions.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnPrintTheReport;
        private Guna.UI2.WinForms.Guna2TextBox TxtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox CbExpiryDate;
        private Guna.UI2.WinForms.Guna2ComboBox CbSubscriptionStatus;
        private Guna.UI2.WinForms.Guna2DataGridView DGVShowSubscriptionsInfo;
        public Guna.UI2.WinForms.Guna2ContextMenuStrip CMStripSubscriptions;
        private System.Windows.Forms.ToolStripMenuItem RenewSubscriptionInfoItem;
        private Guna.UI2.WinForms.Guna2Button BtnRefresh;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox CbSubscriptionTypes;
        private Guna.UI2.WinForms.Guna2Button BtnAddNewSubscription;
        private Guna.UI2.WinForms.Guna2Button BtnRenewSubscription;
    }
}
