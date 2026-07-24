namespace University_Housing_Management_Project.Forms.Home.RoomManagement
{
    partial class CtrlShowStudentInRoom
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
            this.DGVShowStudentsInfo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CMStripConnections = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.CallItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SendMessageItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LbTitle = new System.Windows.Forms.Label();
            this.BtnReturn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowStudentsInfo)).BeginInit();
            this.CMStripConnections.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVShowStudentsInfo
            // 
            this.DGVShowStudentsInfo.AllowUserToAddRows = false;
            this.DGVShowStudentsInfo.AllowUserToDeleteRows = false;
            this.DGVShowStudentsInfo.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowStudentsInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVShowStudentsInfo.BackgroundColor = System.Drawing.Color.MintCream;
            this.DGVShowStudentsInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DGVShowStudentsInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGVShowStudentsInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVShowStudentsInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVShowStudentsInfo.ColumnHeadersHeight = 76;
            this.DGVShowStudentsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVShowStudentsInfo.ContextMenuStrip = this.CMStripConnections;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVShowStudentsInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVShowStudentsInfo.GridColor = System.Drawing.Color.Black;
            this.DGVShowStudentsInfo.Location = new System.Drawing.Point(37, 168);
            this.DGVShowStudentsInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGVShowStudentsInfo.MultiSelect = false;
            this.DGVShowStudentsInfo.Name = "DGVShowStudentsInfo";
            this.DGVShowStudentsInfo.ReadOnly = true;
            this.DGVShowStudentsInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVShowStudentsInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVShowStudentsInfo.RowHeadersVisible = false;
            this.DGVShowStudentsInfo.RowHeadersWidth = 62;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowStudentsInfo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVShowStudentsInfo.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVShowStudentsInfo.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.DGVShowStudentsInfo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateGray;
            this.DGVShowStudentsInfo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowStudentsInfo.RowTemplate.DividerHeight = 3;
            this.DGVShowStudentsInfo.RowTemplate.Height = 35;
            this.DGVShowStudentsInfo.RowTemplate.ReadOnly = true;
            this.DGVShowStudentsInfo.ShowCellToolTips = false;
            this.DGVShowStudentsInfo.Size = new System.Drawing.Size(1154, 420);
            this.DGVShowStudentsInfo.TabIndex = 116;
            this.DGVShowStudentsInfo.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.DGVShowStudentsInfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.DGVShowStudentsInfo.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVShowStudentsInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.DGVShowStudentsInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.SlateGray;
            this.DGVShowStudentsInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVShowStudentsInfo.ThemeStyle.BackColor = System.Drawing.Color.MintCream;
            this.DGVShowStudentsInfo.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.DGVShowStudentsInfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.DGVShowStudentsInfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGVShowStudentsInfo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVShowStudentsInfo.ThemeStyle.HeaderStyle.Height = 76;
            this.DGVShowStudentsInfo.ThemeStyle.ReadOnly = true;
            this.DGVShowStudentsInfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVShowStudentsInfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGVShowStudentsInfo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVShowStudentsInfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.DGVShowStudentsInfo.ThemeStyle.RowsStyle.Height = 35;
            this.DGVShowStudentsInfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.DGVShowStudentsInfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // CMStripConnections
            // 
            this.CMStripConnections.BackColor = System.Drawing.Color.White;
            this.CMStripConnections.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CMStripConnections.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CMStripConnections.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CallItem,
            this.SendMessageItem});
            this.CMStripConnections.Name = "cmStripStudenUserControl";
            this.CMStripConnections.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CMStripConnections.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.CMStripConnections.RenderStyle.ColorTable = null;
            this.CMStripConnections.RenderStyle.RoundedEdges = false;
            this.CMStripConnections.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.CMStripConnections.RenderStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.CMStripConnections.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CMStripConnections.RenderStyle.SeparatorColor = System.Drawing.Color.Black;
            this.CMStripConnections.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CMStripConnections.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CMStripConnections.ShowCheckMargin = true;
            this.CMStripConnections.Size = new System.Drawing.Size(248, 68);
            // 
            // CallItem
            // 
            this.CallItem.Image = global::University_Housing_Management_Project.Properties.Resources.circle_phone_flip;
            this.CallItem.Name = "CallItem";
            this.CallItem.Size = new System.Drawing.Size(247, 32);
            this.CallItem.Text = "Call";
            this.CallItem.Click += new System.EventHandler(this.CallItem_Click);
            // 
            // SendMessageItem
            // 
            this.SendMessageItem.Image = global::University_Housing_Management_Project.Properties.Resources.message_sms;
            this.SendMessageItem.Name = "SendMessageItem";
            this.SendMessageItem.Size = new System.Drawing.Size(247, 32);
            this.SendMessageItem.Text = "Send message";
            this.SendMessageItem.Click += new System.EventHandler(this.SendMessageItem_Click);
            // 
            // LbTitle
            // 
            this.LbTitle.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.LbTitle.Location = new System.Drawing.Point(386, 31);
            this.LbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(437, 67);
            this.LbTitle.TabIndex = 118;
            this.LbTitle.Text = "All Student in ";
            this.LbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.BtnReturn.Image = global::University_Housing_Management_Project.Properties.Resources.undo;
            this.BtnReturn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnReturn.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnReturn.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnReturn.Location = new System.Drawing.Point(1044, 631);
            this.BtnReturn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnReturn.Size = new System.Drawing.Size(147, 56);
            this.BtnReturn.TabIndex = 117;
            this.BtnReturn.Text = "Return";
            this.BtnReturn.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // CtrlShowStudentInRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DGVShowStudentsInfo);
            this.Controls.Add(this.LbTitle);
            this.Controls.Add(this.BtnReturn);
            this.Name = "CtrlShowStudentInRoom";
            this.Size = new System.Drawing.Size(1259, 775);
            this.Load += new System.EventHandler(this.CtrlShowStudentInRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowStudentsInfo)).EndInit();
            this.CMStripConnections.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DGVShowStudentsInfo;
        public Guna.UI2.WinForms.Guna2ContextMenuStrip CMStripConnections;
        private System.Windows.Forms.ToolStripMenuItem CallItem;
        private System.Windows.Forms.ToolStripMenuItem SendMessageItem;
        private System.Windows.Forms.Label LbTitle;
        private Guna.UI2.WinForms.Guna2Button BtnReturn;
    }
}
