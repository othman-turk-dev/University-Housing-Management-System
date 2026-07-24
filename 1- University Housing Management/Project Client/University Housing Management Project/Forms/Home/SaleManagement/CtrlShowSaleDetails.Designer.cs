namespace University_Housing_Management_Project.Forms.Home.SaleManagement
{
    partial class CtrlShowSaleDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlShowSaleDetails));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnReturn = new Guna.UI2.WinForms.Guna2Button();
            this.LbTitle = new System.Windows.Forms.Label();
            this.DGVShowSaleDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowSaleDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnReturn
            // 
            this.BtnReturn.BorderRadius = 20;
            this.BtnReturn.BorderThickness = 1;
            this.BtnReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnReturn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnReturn.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturn.ForeColor = System.Drawing.Color.White;
            this.BtnReturn.Image = ((System.Drawing.Image)(resources.GetObject("BtnReturn.Image")));
            this.BtnReturn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnReturn.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnReturn.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnReturn.Location = new System.Drawing.Point(993, 622);
            this.BtnReturn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnReturn.Size = new System.Drawing.Size(147, 56);
            this.BtnReturn.TabIndex = 131;
            this.BtnReturn.Text = "Return";
            this.BtnReturn.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.LbTitle.Location = new System.Drawing.Point(517, 88);
            this.LbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(205, 41);
            this.LbTitle.TabIndex = 130;
            this.LbTitle.Text = "Order Details";
            // 
            // DGVShowSaleDetails
            // 
            this.DGVShowSaleDetails.AllowUserToAddRows = false;
            this.DGVShowSaleDetails.AllowUserToDeleteRows = false;
            this.DGVShowSaleDetails.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowSaleDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVShowSaleDetails.BackgroundColor = System.Drawing.Color.MintCream;
            this.DGVShowSaleDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DGVShowSaleDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGVShowSaleDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVShowSaleDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVShowSaleDetails.ColumnHeadersHeight = 76;
            this.DGVShowSaleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVShowSaleDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVShowSaleDetails.GridColor = System.Drawing.Color.Black;
            this.DGVShowSaleDetails.Location = new System.Drawing.Point(118, 205);
            this.DGVShowSaleDetails.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGVShowSaleDetails.MultiSelect = false;
            this.DGVShowSaleDetails.Name = "DGVShowSaleDetails";
            this.DGVShowSaleDetails.ReadOnly = true;
            this.DGVShowSaleDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVShowSaleDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVShowSaleDetails.RowHeadersVisible = false;
            this.DGVShowSaleDetails.RowHeadersWidth = 62;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowSaleDetails.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVShowSaleDetails.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVShowSaleDetails.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.DGVShowSaleDetails.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateGray;
            this.DGVShowSaleDetails.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowSaleDetails.RowTemplate.DividerHeight = 3;
            this.DGVShowSaleDetails.RowTemplate.Height = 35;
            this.DGVShowSaleDetails.RowTemplate.ReadOnly = true;
            this.DGVShowSaleDetails.ShowCellToolTips = false;
            this.DGVShowSaleDetails.Size = new System.Drawing.Size(1022, 391);
            this.DGVShowSaleDetails.TabIndex = 129;
            this.DGVShowSaleDetails.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.DGVShowSaleDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.DGVShowSaleDetails.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVShowSaleDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.DGVShowSaleDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.SlateGray;
            this.DGVShowSaleDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowSaleDetails.ThemeStyle.BackColor = System.Drawing.Color.MintCream;
            this.DGVShowSaleDetails.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.DGVShowSaleDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.DGVShowSaleDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGVShowSaleDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVShowSaleDetails.ThemeStyle.HeaderStyle.Height = 76;
            this.DGVShowSaleDetails.ThemeStyle.ReadOnly = true;
            this.DGVShowSaleDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVShowSaleDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGVShowSaleDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVShowSaleDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.DGVShowSaleDetails.ThemeStyle.RowsStyle.Height = 35;
            this.DGVShowSaleDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.DGVShowSaleDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // CtrlShowSaleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.LbTitle);
            this.Controls.Add(this.DGVShowSaleDetails);
            this.Name = "CtrlShowSaleDetails";
            this.Size = new System.Drawing.Size(1259, 768);
            this.Load += new System.EventHandler(this.CtrlShowSaleDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowSaleDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnReturn;
        private System.Windows.Forms.Label LbTitle;
        private Guna.UI2.WinForms.Guna2DataGridView DGVShowSaleDetails;
    }
}
