namespace University_Housing_Management_Project.Forms.Home.RoomManagement
{
    partial class CtrlAddUpdateRoom
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
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSave = new Guna.UI2.WinForms.Guna2Button();
            this.BtnReturn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtRoomNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtRoomID = new Guna.UI2.WinForms.Guna2TextBox();
            this.LbTitle = new System.Windows.Forms.Label();
            this.CbRoomLocationFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.guna2Panel3.Location = new System.Drawing.Point(783, 210);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(199, 45);
            this.guna2Panel3.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Room location";
            // 
            // BtnSave
            // 
            this.BtnSave.BorderRadius = 20;
            this.BtnSave.BorderThickness = 1;
            this.BtnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.BtnSave.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Image = global::University_Housing_Management_Project.Properties.Resources.bookmark;
            this.BtnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnSave.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnSave.Location = new System.Drawing.Point(471, 539);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnSave.Size = new System.Drawing.Size(147, 56);
            this.BtnSave.TabIndex = 100;
            this.BtnSave.Text = "Save";
            this.BtnSave.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            this.BtnReturn.Location = new System.Drawing.Point(680, 539);
            this.BtnReturn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnReturn.Size = new System.Drawing.Size(147, 56);
            this.BtnReturn.TabIndex = 99;
            this.BtnReturn.Text = "Return";
            this.BtnReturn.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.label3.Location = new System.Drawing.Point(263, 324);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 29);
            this.label3.TabIndex = 98;
            this.label3.Text = "Room number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.label6.Location = new System.Drawing.Point(263, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 29);
            this.label6.TabIndex = 97;
            this.label6.Text = "Room id:";
            // 
            // TxtRoomNumber
            // 
            this.TxtRoomNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TxtRoomNumber.BorderRadius = 10;
            this.TxtRoomNumber.BorderThickness = 2;
            this.TxtRoomNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRoomNumber.DefaultText = "";
            this.TxtRoomNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtRoomNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtRoomNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRoomNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRoomNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtRoomNumber.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TxtRoomNumber.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRoomNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TxtRoomNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtRoomNumber.HoverState.PlaceholderForeColor = System.Drawing.Color.White;
            this.TxtRoomNumber.Location = new System.Drawing.Point(281, 367);
            this.TxtRoomNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRoomNumber.Name = "TxtRoomNumber";
            this.TxtRoomNumber.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TxtRoomNumber.PlaceholderText = "Enter room number";
            this.TxtRoomNumber.SelectedText = "";
            this.TxtRoomNumber.Size = new System.Drawing.Size(289, 49);
            this.TxtRoomNumber.TabIndex = 96;
            this.TxtRoomNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRoomNumber_KeyPress);
            // 
            // TxtRoomID
            // 
            this.TxtRoomID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TxtRoomID.BorderRadius = 10;
            this.TxtRoomID.BorderThickness = 2;
            this.TxtRoomID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRoomID.DefaultText = "";
            this.TxtRoomID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtRoomID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtRoomID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRoomID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRoomID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtRoomID.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TxtRoomID.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRoomID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TxtRoomID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtRoomID.HoverState.PlaceholderForeColor = System.Drawing.Color.White;
            this.TxtRoomID.Location = new System.Drawing.Point(281, 251);
            this.TxtRoomID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRoomID.Name = "TxtRoomID";
            this.TxtRoomID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TxtRoomID.PlaceholderText = "It appears after adding process";
            this.TxtRoomID.ReadOnly = true;
            this.TxtRoomID.SelectedText = "";
            this.TxtRoomID.Size = new System.Drawing.Size(362, 49);
            this.TxtRoomID.TabIndex = 95;
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.LbTitle.Location = new System.Drawing.Point(495, 81);
            this.LbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(237, 41);
            this.LbTitle.TabIndex = 94;
            this.LbTitle.Text = "Add New Room";
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
            "Floor 1",
            "Floor 2",
            "Floor 3"});
            this.CbRoomLocationFilter.Location = new System.Drawing.Point(783, 254);
            this.CbRoomLocationFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CbRoomLocationFilter.Name = "CbRoomLocationFilter";
            this.CbRoomLocationFilter.Size = new System.Drawing.Size(198, 46);
            this.CbRoomLocationFilter.TabIndex = 101;
            // 
            // CtrlAddUpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtRoomNumber);
            this.Controls.Add(this.TxtRoomID);
            this.Controls.Add(this.LbTitle);
            this.Controls.Add(this.CbRoomLocationFilter);
            this.Name = "CtrlAddUpdateRoom";
            this.Size = new System.Drawing.Size(1259, 775);
            this.Load += new System.EventHandler(this.CtrlAddUpdateRoom_Load_1);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button BtnSave;
        private Guna.UI2.WinForms.Guna2Button BtnReturn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox TxtRoomNumber;
        private Guna.UI2.WinForms.Guna2TextBox TxtRoomID;
        private System.Windows.Forms.Label LbTitle;
        private Guna.UI2.WinForms.Guna2ComboBox CbRoomLocationFilter;
    }
}
