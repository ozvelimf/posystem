namespace posystem.Model
{
    partial class formNewUser
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
            this.usernameInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.repasswordInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.HasFormShadow = true;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
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
            this.guna2Panel1.TabIndex = 5;
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
            this.guna2Panel2.TabIndex = 4;
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
            // usernameInput
            // 
            this.usernameInput.AccessibleName = "";
            this.usernameInput.AutoRoundedCorners = true;
            this.usernameInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.usernameInput.BorderRadius = 17;
            this.usernameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameInput.DefaultText = "";
            this.usernameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.usernameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameInput.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.usernameInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameInput.ForeColor = System.Drawing.Color.White;
            this.usernameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameInput.IconRightOffset = new System.Drawing.Point(10, 0);
            this.usernameInput.IconRightSize = new System.Drawing.Size(25, 25);
            this.usernameInput.Location = new System.Drawing.Point(126, 131);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.PasswordChar = '\0';
            this.usernameInput.PlaceholderText = "Username";
            this.usernameInput.SelectedText = "";
            this.usernameInput.Size = new System.Drawing.Size(211, 36);
            this.usernameInput.TabIndex = 0;
            // 
            // emailInput
            // 
            this.emailInput.AccessibleName = "";
            this.emailInput.AutoRoundedCorners = true;
            this.emailInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.emailInput.BorderRadius = 17;
            this.emailInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailInput.DefaultText = "";
            this.emailInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.emailInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailInput.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.emailInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailInput.ForeColor = System.Drawing.Color.White;
            this.emailInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailInput.IconRightOffset = new System.Drawing.Point(10, 0);
            this.emailInput.IconRightSize = new System.Drawing.Size(25, 25);
            this.emailInput.Location = new System.Drawing.Point(432, 131);
            this.emailInput.Name = "emailInput";
            this.emailInput.PasswordChar = '\0';
            this.emailInput.PlaceholderText = "Email";
            this.emailInput.SelectedText = "";
            this.emailInput.Size = new System.Drawing.Size(211, 36);
            this.emailInput.TabIndex = 1;
            // 
            // passwordInput
            // 
            this.passwordInput.AccessibleName = "";
            this.passwordInput.AutoRoundedCorners = true;
            this.passwordInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.passwordInput.BorderRadius = 17;
            this.passwordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordInput.DefaultText = "";
            this.passwordInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.passwordInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordInput.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.passwordInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordInput.ForeColor = System.Drawing.Color.White;
            this.passwordInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordInput.IconRightOffset = new System.Drawing.Point(10, 0);
            this.passwordInput.IconRightSize = new System.Drawing.Size(25, 25);
            this.passwordInput.Location = new System.Drawing.Point(126, 239);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.PlaceholderText = "Password";
            this.passwordInput.SelectedText = "";
            this.passwordInput.Size = new System.Drawing.Size(211, 36);
            this.passwordInput.TabIndex = 2;
            // 
            // repasswordInput
            // 
            this.repasswordInput.AccessibleName = "";
            this.repasswordInput.AutoRoundedCorners = true;
            this.repasswordInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.repasswordInput.BorderRadius = 17;
            this.repasswordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.repasswordInput.DefaultText = "";
            this.repasswordInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.repasswordInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.repasswordInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.repasswordInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.repasswordInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.repasswordInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.repasswordInput.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.repasswordInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.repasswordInput.ForeColor = System.Drawing.Color.White;
            this.repasswordInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.repasswordInput.IconRightOffset = new System.Drawing.Point(10, 0);
            this.repasswordInput.IconRightSize = new System.Drawing.Size(25, 25);
            this.repasswordInput.Location = new System.Drawing.Point(432, 239);
            this.repasswordInput.Name = "repasswordInput";
            this.repasswordInput.PasswordChar = '*';
            this.repasswordInput.PlaceholderText = "Re-password";
            this.repasswordInput.SelectedText = "";
            this.repasswordInput.Size = new System.Drawing.Size(211, 36);
            this.repasswordInput.TabIndex = 3;
            // 
            // formNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.repasswordInput);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "formNewUser";
            this.Text = "formNewUser";
            this.Load += new System.EventHandler(this.formNewUser_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        public System.Windows.Forms.Label dialogTitle;
        public Guna.UI2.WinForms.Guna2TextBox usernameInput;
        public Guna.UI2.WinForms.Guna2TextBox emailInput;
        public Guna.UI2.WinForms.Guna2TextBox passwordInput;
        public Guna.UI2.WinForms.Guna2TextBox repasswordInput;
    }
}