namespace posystem.Model
{
    partial class fromNewProduct
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dialogTitle = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.nameInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.priceInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.guna2Panel1.Controls.Add(this.btnClose);
            this.guna2Panel1.Controls.Add(this.dialogTitle);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(800, 100);
            this.guna2Panel1.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(752, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dialogTitle
            // 
            this.dialogTitle.AutoSize = true;
            this.dialogTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialogTitle.ForeColor = System.Drawing.Color.White;
            this.dialogTitle.Location = new System.Drawing.Point(53, 28);
            this.dialogTitle.Name = "dialogTitle";
            this.dialogTitle.Size = new System.Drawing.Size(147, 37);
            this.dialogTitle.TabIndex = 1;
            this.dialogTitle.Text = "User Detail";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btnDel);
            this.guna2Panel2.Controls.Add(this.btnSave);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 350);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(800, 100);
            this.guna2Panel2.TabIndex = 7;
            // 
            // btnDel
            // 
            this.btnDel.AutoRoundedCorners = true;
            this.btnDel.BorderRadius = 18;
            this.btnDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDel.FillColor = System.Drawing.Color.Red;
            this.btnDel.FocusedColor = System.Drawing.Color.DarkRed;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Image = global::posystem.Properties.Resources.icons8_trash_26;
            this.btnDel.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDel.Location = new System.Drawing.Point(592, 32);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(51, 38);
            this.btnDel.TabIndex = 1;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 18;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(112)))), ((int)(((byte)(248)))));
            this.btnSave.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(661, 32);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 38);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nameInput
            // 
            this.nameInput.AccessibleName = "";
            this.nameInput.AutoRoundedCorners = true;
            this.nameInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.nameInput.BorderRadius = 17;
            this.nameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameInput.DefaultText = "";
            this.nameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.nameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameInput.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.nameInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameInput.ForeColor = System.Drawing.Color.White;
            this.nameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameInput.IconRightOffset = new System.Drawing.Point(10, 0);
            this.nameInput.IconRightSize = new System.Drawing.Size(25, 25);
            this.nameInput.Location = new System.Drawing.Point(80, 183);
            this.nameInput.Name = "nameInput";
            this.nameInput.PasswordChar = '\0';
            this.nameInput.PlaceholderText = "Name";
            this.nameInput.SelectedText = "";
            this.nameInput.Size = new System.Drawing.Size(211, 36);
            this.nameInput.TabIndex = 8;
            // 
            // priceInput
            // 
            this.priceInput.AccessibleName = "";
            this.priceInput.AutoRoundedCorners = true;
            this.priceInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.priceInput.BorderRadius = 17;
            this.priceInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceInput.DefaultText = "";
            this.priceInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.priceInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceInput.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.priceInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.priceInput.ForeColor = System.Drawing.Color.White;
            this.priceInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceInput.IconRightOffset = new System.Drawing.Point(10, 0);
            this.priceInput.IconRightSize = new System.Drawing.Size(25, 25);
            this.priceInput.Location = new System.Drawing.Point(416, 183);
            this.priceInput.Name = "priceInput";
            this.priceInput.PasswordChar = '\0';
            this.priceInput.PlaceholderText = "Price";
            this.priceInput.SelectedText = "";
            this.priceInput.Size = new System.Drawing.Size(211, 36);
            this.priceInput.TabIndex = 9;
            // 
            // fromNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "fromNewProduct";
            this.Text = "fromNewProduct";
            this.Load += new System.EventHandler(this.fromNewProduct_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        public System.Windows.Forms.Label dialogTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        public Guna.UI2.WinForms.Guna2TextBox nameInput;
        public Guna.UI2.WinForms.Guna2TextBox priceInput;
    }
}