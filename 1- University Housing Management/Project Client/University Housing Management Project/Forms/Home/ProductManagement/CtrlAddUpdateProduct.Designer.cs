namespace University_Housing_Management_Project.Forms.Home.ProductManagement
{
    partial class CtrlAddUpdateProduct
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
            this.TxtPurchasePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LbNote2 = new System.Windows.Forms.Label();
            this.LbNote1 = new System.Windows.Forms.Label();
            this.BtnSave = new Guna.UI2.WinForms.Guna2Button();
            this.BtnReturn = new Guna.UI2.WinForms.Guna2Button();
            this.LbTitle = new System.Windows.Forms.Label();
            this.TxtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtProductID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtPurchasePrice
            // 
            this.TxtPurchasePrice.BorderColor = System.Drawing.Color.Black;
            this.TxtPurchasePrice.BorderRadius = 10;
            this.TxtPurchasePrice.BorderThickness = 2;
            this.TxtPurchasePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPurchasePrice.DefaultText = "";
            this.TxtPurchasePrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPurchasePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPurchasePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPurchasePrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPurchasePrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPurchasePrice.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.TxtPurchasePrice.ForeColor = System.Drawing.Color.Black;
            this.TxtPurchasePrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPurchasePrice.Location = new System.Drawing.Point(226, 379);
            this.TxtPurchasePrice.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtPurchasePrice.Name = "TxtPurchasePrice";
            this.TxtPurchasePrice.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TxtPurchasePrice.PlaceholderText = "";
            this.TxtPurchasePrice.SelectedText = "";
            this.TxtPurchasePrice.Size = new System.Drawing.Size(271, 52);
            this.TxtPurchasePrice.TabIndex = 179;
            this.TxtPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersAndDot);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.label5.Location = new System.Drawing.Point(221, 345);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 29);
            this.label5.TabIndex = 180;
            this.label5.Text = "Purchase price per unit";
            // 
            // LbNote2
            // 
            this.LbNote2.BackColor = System.Drawing.Color.Transparent;
            this.LbNote2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNote2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.LbNote2.Location = new System.Drawing.Point(786, 96);
            this.LbNote2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbNote2.Name = "LbNote2";
            this.LbNote2.Size = new System.Drawing.Size(421, 78);
            this.LbNote2.TabIndex = 178;
            this.LbNote2.Text = "You can only edit the product name and the selling price per unit.";
            this.LbNote2.Visible = false;
            // 
            // LbNote1
            // 
            this.LbNote1.BackColor = System.Drawing.Color.Transparent;
            this.LbNote1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNote1.ForeColor = System.Drawing.Color.Maroon;
            this.LbNote1.Location = new System.Drawing.Point(760, 66);
            this.LbNote1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbNote1.Name = "LbNote1";
            this.LbNote1.Size = new System.Drawing.Size(147, 39);
            this.LbNote1.TabIndex = 177;
            this.LbNote1.Text = "Note:";
            this.LbNote1.Visible = false;
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
            this.BtnSave.Location = new System.Drawing.Point(768, 636);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnSave.Size = new System.Drawing.Size(147, 56);
            this.BtnSave.TabIndex = 176;
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
            this.BtnReturn.Location = new System.Drawing.Point(951, 636);
            this.BtnReturn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnReturn.Size = new System.Drawing.Size(147, 56);
            this.BtnReturn.TabIndex = 174;
            this.BtnReturn.Text = "Return";
            this.BtnReturn.TextOffset = new System.Drawing.Point(30, 0);
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // LbTitle
            // 
            this.LbTitle.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.LbTitle.Location = new System.Drawing.Point(322, 57);
            this.LbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(383, 67);
            this.LbTitle.TabIndex = 175;
            this.LbTitle.Text = "Add New Product";
            // 
            // TxtPrice
            // 
            this.TxtPrice.BorderColor = System.Drawing.Color.Black;
            this.TxtPrice.BorderRadius = 10;
            this.TxtPrice.BorderThickness = 2;
            this.TxtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPrice.DefaultText = "";
            this.TxtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPrice.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.TxtPrice.ForeColor = System.Drawing.Color.Black;
            this.TxtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPrice.Location = new System.Drawing.Point(395, 515);
            this.TxtPrice.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TxtPrice.PlaceholderText = "";
            this.TxtPrice.SelectedText = "";
            this.TxtPrice.Size = new System.Drawing.Size(271, 52);
            this.TxtPrice.TabIndex = 172;
            this.TxtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbersAndDot);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.label3.Location = new System.Drawing.Point(387, 481);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 29);
            this.label3.TabIndex = 173;
            this.label3.Text = "Selling price per unit";
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.BorderColor = System.Drawing.Color.Black;
            this.TxtQuantity.BorderRadius = 10;
            this.TxtQuantity.BorderThickness = 2;
            this.TxtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtQuantity.DefaultText = "";
            this.TxtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtQuantity.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.TxtQuantity.ForeColor = System.Drawing.Color.Black;
            this.TxtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtQuantity.Location = new System.Drawing.Point(622, 379);
            this.TxtQuantity.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TxtQuantity.PlaceholderText = "";
            this.TxtQuantity.SelectedText = "";
            this.TxtQuantity.Size = new System.Drawing.Size(271, 52);
            this.TxtQuantity.TabIndex = 170;
            this.TxtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(617, 345);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 171;
            this.label2.Text = "Quantity";
            // 
            // TxtProductName
            // 
            this.TxtProductName.BorderColor = System.Drawing.Color.Black;
            this.TxtProductName.BorderRadius = 10;
            this.TxtProductName.BorderThickness = 2;
            this.TxtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtProductName.DefaultText = "";
            this.TxtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtProductName.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.TxtProductName.ForeColor = System.Drawing.Color.Black;
            this.TxtProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtProductName.Location = new System.Drawing.Point(622, 254);
            this.TxtProductName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TxtProductName.PlaceholderText = "";
            this.TxtProductName.SelectedText = "";
            this.TxtProductName.Size = new System.Drawing.Size(340, 52);
            this.TxtProductName.TabIndex = 168;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(613, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 169;
            this.label1.Text = "Product name";
            // 
            // TxtProductID
            // 
            this.TxtProductID.BorderColor = System.Drawing.Color.Black;
            this.TxtProductID.BorderRadius = 10;
            this.TxtProductID.BorderThickness = 2;
            this.TxtProductID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtProductID.DefaultText = "";
            this.TxtProductID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtProductID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtProductID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtProductID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtProductID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtProductID.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.TxtProductID.ForeColor = System.Drawing.Color.Black;
            this.TxtProductID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtProductID.Location = new System.Drawing.Point(226, 254);
            this.TxtProductID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtProductID.Name = "TxtProductID";
            this.TxtProductID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.TxtProductID.PlaceholderText = "";
            this.TxtProductID.SelectedText = "";
            this.TxtProductID.Size = new System.Drawing.Size(271, 52);
            this.TxtProductID.TabIndex = 166;
            this.TxtProductID.Leave += new System.EventHandler(this.TxtProductID_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.label4.Location = new System.Drawing.Point(217, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 167;
            this.label4.Text = "Product Id";
            // 
            // CtrlAddUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TxtPurchasePrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LbNote2);
            this.Controls.Add(this.LbNote1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.LbTitle);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtProductID);
            this.Controls.Add(this.label4);
            this.Name = "CtrlAddUpdateProduct";
            this.Size = new System.Drawing.Size(1259, 775);
            this.Load += new System.EventHandler(this.CtrlAddUpdateProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox TxtPurchasePrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LbNote2;
        private System.Windows.Forms.Label LbNote1;
        private Guna.UI2.WinForms.Guna2Button BtnSave;
        private Guna.UI2.WinForms.Guna2Button BtnReturn;
        private System.Windows.Forms.Label LbTitle;
        private Guna.UI2.WinForms.Guna2TextBox TxtPrice;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TxtQuantity;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TxtProductName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TxtProductID;
        private System.Windows.Forms.Label label4;
    }
}
