namespace posystem.Model
{
    partial class formPayment
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
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.amount = new Guna.UI2.WinForms.Guna2TextBox();
            this.totalInput = new System.Windows.Forms.Label();
            this.cardNameLabel = new System.Windows.Forms.Label();
            this.cardName = new Guna.UI2.WinForms.Guna2TextBox();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.cardNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.cardYear = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cardCCV = new Guna.UI2.WinForms.Guna2TextBox();
            this.cardMonth = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.discount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalAmountPay = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
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
            this.guna2Panel1.TabIndex = 7;
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
            this.dialogTitle.Size = new System.Drawing.Size(119, 37);
            this.dialogTitle.TabIndex = 1;
            this.dialogTitle.Text = "Payment";
            // 
            // btnPay
            // 
            this.btnPay.AutoRoundedCorners = true;
            this.btnPay.BorderRadius = 17;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(112)))), ((int)(((byte)(248)))));
            this.btnPay.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(676, 378);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(112, 36);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Pay";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // amount
            // 
            this.amount.AccessibleName = "";
            this.amount.AutoRoundedCorners = true;
            this.amount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.amount.BorderRadius = 17;
            this.amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amount.DefaultText = "";
            this.amount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.amount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.amount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.amount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.amount.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.amount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.amount.ForeColor = System.Drawing.Color.White;
            this.amount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.amount.Location = new System.Drawing.Point(60, 212);
            this.amount.Name = "amount";
            this.amount.PasswordChar = '\0';
            this.amount.PlaceholderText = "";
            this.amount.ReadOnly = true;
            this.amount.SelectedText = "";
            this.amount.Size = new System.Drawing.Size(200, 36);
            this.amount.TabIndex = 10;
            // 
            // totalInput
            // 
            this.totalInput.AutoSize = true;
            this.totalInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalInput.ForeColor = System.Drawing.Color.Silver;
            this.totalInput.Location = new System.Drawing.Point(73, 354);
            this.totalInput.Name = "totalInput";
            this.totalInput.Size = new System.Drawing.Size(102, 21);
            this.totalInput.TabIndex = 9;
            this.totalInput.Text = "Total Amount";
            // 
            // cardNameLabel
            // 
            this.cardNameLabel.AutoSize = true;
            this.cardNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cardNameLabel.ForeColor = System.Drawing.Color.Silver;
            this.cardNameLabel.Location = new System.Drawing.Point(398, 114);
            this.cardNameLabel.Name = "cardNameLabel";
            this.cardNameLabel.Size = new System.Drawing.Size(134, 21);
            this.cardNameLabel.TabIndex = 9;
            this.cardNameLabel.Text = "Cardholder Name";
            // 
            // cardName
            // 
            this.cardName.AccessibleName = "";
            this.cardName.AutoRoundedCorners = true;
            this.cardName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.cardName.BorderRadius = 17;
            this.cardName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cardName.DefaultText = "";
            this.cardName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cardName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cardName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cardName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cardName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.cardName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cardName.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.cardName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cardName.ForeColor = System.Drawing.Color.White;
            this.cardName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cardName.Location = new System.Drawing.Point(385, 138);
            this.cardName.Name = "cardName";
            this.cardName.PasswordChar = '\0';
            this.cardName.PlaceholderText = "";
            this.cardName.SelectedText = "";
            this.cardName.Size = new System.Drawing.Size(403, 36);
            this.cardName.TabIndex = 10;
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cardNumberLabel.ForeColor = System.Drawing.Color.Silver;
            this.cardNumberLabel.Location = new System.Drawing.Point(398, 188);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(105, 21);
            this.cardNumberLabel.TabIndex = 9;
            this.cardNumberLabel.Text = "Card Number";
            // 
            // cardNumber
            // 
            this.cardNumber.AccessibleName = "";
            this.cardNumber.AutoRoundedCorners = true;
            this.cardNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.cardNumber.BorderRadius = 17;
            this.cardNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cardNumber.DefaultText = "";
            this.cardNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cardNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cardNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cardNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cardNumber.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.cardNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cardNumber.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.cardNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cardNumber.ForeColor = System.Drawing.Color.White;
            this.cardNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cardNumber.Location = new System.Drawing.Point(385, 212);
            this.cardNumber.Name = "cardNumber";
            this.cardNumber.PasswordChar = '\0';
            this.cardNumber.PlaceholderText = "";
            this.cardNumber.SelectedText = "";
            this.cardNumber.Size = new System.Drawing.Size(403, 36);
            this.cardNumber.TabIndex = 10;
            // 
            // cardYear
            // 
            this.cardYear.AutoRoundedCorners = true;
            this.cardYear.BackColor = System.Drawing.Color.Transparent;
            this.cardYear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.cardYear.BorderRadius = 17;
            this.cardYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cardYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cardYear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.cardYear.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cardYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cardYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cardYear.ForeColor = System.Drawing.Color.Silver;
            this.cardYear.ItemHeight = 30;
            this.cardYear.Location = new System.Drawing.Point(500, 293);
            this.cardYear.Name = "cardYear";
            this.cardYear.Size = new System.Drawing.Size(122, 36);
            this.cardYear.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(398, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Year/Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(398, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "CCV";
            // 
            // cardCCV
            // 
            this.cardCCV.AccessibleName = "";
            this.cardCCV.AutoRoundedCorners = true;
            this.cardCCV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.cardCCV.BorderRadius = 17;
            this.cardCCV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cardCCV.DefaultText = "";
            this.cardCCV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cardCCV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cardCCV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cardCCV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cardCCV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.cardCCV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cardCCV.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.cardCCV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cardCCV.ForeColor = System.Drawing.Color.White;
            this.cardCCV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cardCCV.Location = new System.Drawing.Point(385, 378);
            this.cardCCV.Name = "cardCCV";
            this.cardCCV.PasswordChar = '\0';
            this.cardCCV.PlaceholderText = "";
            this.cardCCV.SelectedText = "";
            this.cardCCV.Size = new System.Drawing.Size(200, 36);
            this.cardCCV.TabIndex = 10;
            // 
            // cardMonth
            // 
            this.cardMonth.AutoRoundedCorners = true;
            this.cardMonth.BackColor = System.Drawing.Color.Transparent;
            this.cardMonth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.cardMonth.BorderRadius = 17;
            this.cardMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cardMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cardMonth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.cardMonth.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cardMonth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cardMonth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cardMonth.ForeColor = System.Drawing.Color.Silver;
            this.cardMonth.ItemHeight = 30;
            this.cardMonth.Location = new System.Drawing.Point(647, 293);
            this.cardMonth.Name = "cardMonth";
            this.cardMonth.Size = new System.Drawing.Size(122, 36);
            this.cardMonth.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(73, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Discount";
            // 
            // discount
            // 
            this.discount.AccessibleName = "";
            this.discount.AutoRoundedCorners = true;
            this.discount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.discount.BorderRadius = 17;
            this.discount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.discount.DefaultText = "";
            this.discount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.discount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.discount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.discount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.discount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.discount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.discount.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.discount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.discount.ForeColor = System.Drawing.Color.White;
            this.discount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.discount.Location = new System.Drawing.Point(60, 298);
            this.discount.Name = "discount";
            this.discount.PasswordChar = '\0';
            this.discount.PlaceholderText = "";
            this.discount.SelectedText = "";
            this.discount.Size = new System.Drawing.Size(200, 36);
            this.discount.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(73, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Subtotal";
            // 
            // totalAmountPay
            // 
            this.totalAmountPay.AccessibleName = "";
            this.totalAmountPay.AutoRoundedCorners = true;
            this.totalAmountPay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.totalAmountPay.BorderRadius = 17;
            this.totalAmountPay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalAmountPay.DefaultText = "";
            this.totalAmountPay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totalAmountPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totalAmountPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalAmountPay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalAmountPay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.totalAmountPay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalAmountPay.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.totalAmountPay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.totalAmountPay.ForeColor = System.Drawing.Color.White;
            this.totalAmountPay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalAmountPay.Location = new System.Drawing.Point(60, 378);
            this.totalAmountPay.Name = "totalAmountPay";
            this.totalAmountPay.PasswordChar = '\0';
            this.totalAmountPay.PlaceholderText = "";
            this.totalAmountPay.ReadOnly = true;
            this.totalAmountPay.SelectedText = "";
            this.totalAmountPay.Size = new System.Drawing.Size(200, 36);
            this.totalAmountPay.TabIndex = 10;
            // 
            // formPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.cardMonth);
            this.Controls.Add(this.totalAmountPay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.totalInput);
            this.Controls.Add(this.cardYear);
            this.Controls.Add(this.cardNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardNumberLabel);
            this.Controls.Add(this.cardName);
            this.Controls.Add(this.cardNameLabel);
            this.Controls.Add(this.cardCCV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "formPayment";
            this.Text = "formPayment";
            this.Load += new System.EventHandler(this.formPayment_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        public System.Windows.Forms.Label dialogTitle;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private Guna.UI2.WinForms.Guna2TextBox amount;
        private System.Windows.Forms.Label totalInput;
        private System.Windows.Forms.Label cardNameLabel;
        private Guna.UI2.WinForms.Guna2TextBox cardName;
        private System.Windows.Forms.Label cardNumberLabel;
        private Guna.UI2.WinForms.Guna2TextBox cardNumber;
        private Guna.UI2.WinForms.Guna2ComboBox cardYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox cardCCV;
        private Guna.UI2.WinForms.Guna2ComboBox cardMonth;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox discount;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox totalAmountPay;
    }
}