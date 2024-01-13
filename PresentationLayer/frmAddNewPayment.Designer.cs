﻿namespace PresentationLayer
{
	partial class frmAddNewPayment
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewPayment));
			this.plTopBar = new System.Windows.Forms.Panel();
			this.label17 = new System.Windows.Forms.Label();
			this.pbClose = new System.Windows.Forms.PictureBox();
			this.plContainer = new System.Windows.Forms.Panel();
			this.plFirstAddNewPaymentForm = new System.Windows.Forms.Panel();
			this.plSubContainer = new System.Windows.Forms.Panel();
			this.plFirstPage = new System.Windows.Forms.Panel();
			this.plPersonalInfo = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.tbRemainingAmount = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbTotalPayAmount = new Guna.UI2.WinForms.Guna2TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.nudInitialPayAmount = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
			this.lbPaymentStatus = new System.Windows.Forms.Label();
			this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
			this.button8 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.lbFinalPaymentDate = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.lbCustomerID = new System.Windows.Forms.Label();
			this.button7 = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.lbTotalPayAmount = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.lbPaymetnStatusID = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.lbPaymentID = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.plTopBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
			this.plContainer.SuspendLayout();
			this.plFirstAddNewPaymentForm.SuspendLayout();
			this.plSubContainer.SuspendLayout();
			this.plFirstPage.SuspendLayout();
			this.plPersonalInfo.SuspendLayout();
			this.guna2ShadowPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudInitialPayAmount)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// plTopBar
			// 
			this.plTopBar.BackColor = System.Drawing.Color.DeepPink;
			this.plTopBar.Controls.Add(this.label17);
			this.plTopBar.Controls.Add(this.pbClose);
			this.plTopBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.plTopBar.Location = new System.Drawing.Point(0, 0);
			this.plTopBar.Margin = new System.Windows.Forms.Padding(4);
			this.plTopBar.Name = "plTopBar";
			this.plTopBar.Size = new System.Drawing.Size(898, 41);
			this.plTopBar.TabIndex = 3;
			this.plTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseDown);
			this.plTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseMove);
			this.plTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseUp);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.Color.White;
			this.label17.Location = new System.Drawing.Point(18, 8);
			this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(202, 26);
			this.label17.TabIndex = 3;
			this.label17.Text = "Add New Payment";
			// 
			// pbClose
			// 
			this.pbClose.BackColor = System.Drawing.Color.Transparent;
			this.pbClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
			this.pbClose.Location = new System.Drawing.Point(834, 0);
			this.pbClose.Margin = new System.Windows.Forms.Padding(4);
			this.pbClose.Name = "pbClose";
			this.pbClose.Size = new System.Drawing.Size(64, 41);
			this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbClose.TabIndex = 2;
			this.pbClose.TabStop = false;
			this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// plContainer
			// 
			this.plContainer.Controls.Add(this.plFirstAddNewPaymentForm);
			this.plContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plContainer.Location = new System.Drawing.Point(0, 41);
			this.plContainer.Name = "plContainer";
			this.plContainer.Size = new System.Drawing.Size(898, 619);
			this.plContainer.TabIndex = 4;
			// 
			// plFirstAddNewPaymentForm
			// 
			this.plFirstAddNewPaymentForm.BackColor = System.Drawing.Color.White;
			this.plFirstAddNewPaymentForm.Controls.Add(this.plSubContainer);
			this.plFirstAddNewPaymentForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plFirstAddNewPaymentForm.Location = new System.Drawing.Point(0, 0);
			this.plFirstAddNewPaymentForm.Name = "plFirstAddNewPaymentForm";
			this.plFirstAddNewPaymentForm.Size = new System.Drawing.Size(898, 619);
			this.plFirstAddNewPaymentForm.TabIndex = 0;
			// 
			// plSubContainer
			// 
			this.plSubContainer.Controls.Add(this.plFirstPage);
			this.plSubContainer.Location = new System.Drawing.Point(51, 58);
			this.plSubContainer.Name = "plSubContainer";
			this.plSubContainer.Size = new System.Drawing.Size(796, 502);
			this.plSubContainer.TabIndex = 9;
			// 
			// plFirstPage
			// 
			this.plFirstPage.Controls.Add(this.plPersonalInfo);
			this.plFirstPage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plFirstPage.Location = new System.Drawing.Point(0, 0);
			this.plFirstPage.Name = "plFirstPage";
			this.plFirstPage.Size = new System.Drawing.Size(796, 502);
			this.plFirstPage.TabIndex = 0;
			// 
			// plPersonalInfo
			// 
			this.plPersonalInfo.BackColor = System.Drawing.Color.White;
			this.plPersonalInfo.BorderColor = System.Drawing.Color.Gainsboro;
			this.plPersonalInfo.BorderThickness = 2;
			this.plPersonalInfo.Controls.Add(this.guna2ShadowPanel1);
			this.plPersonalInfo.Controls.Add(this.btnSave);
			this.plPersonalInfo.Controls.Add(this.lbPaymentStatus);
			this.plPersonalInfo.Controls.Add(this.btnBack);
			this.plPersonalInfo.Controls.Add(this.button8);
			this.plPersonalInfo.Controls.Add(this.label2);
			this.plPersonalInfo.Controls.Add(this.lbFinalPaymentDate);
			this.plPersonalInfo.Controls.Add(this.button4);
			this.plPersonalInfo.Controls.Add(this.label12);
			this.plPersonalInfo.Controls.Add(this.lbCustomerID);
			this.plPersonalInfo.Controls.Add(this.button7);
			this.plPersonalInfo.Controls.Add(this.label16);
			this.plPersonalInfo.Controls.Add(this.lbTotalPayAmount);
			this.plPersonalInfo.Controls.Add(this.button3);
			this.plPersonalInfo.Controls.Add(this.label9);
			this.plPersonalInfo.Controls.Add(this.lbPaymetnStatusID);
			this.plPersonalInfo.Controls.Add(this.button2);
			this.plPersonalInfo.Controls.Add(this.label7);
			this.plPersonalInfo.Controls.Add(this.lbPaymentID);
			this.plPersonalInfo.Controls.Add(this.button1);
			this.plPersonalInfo.Controls.Add(this.label4);
			this.plPersonalInfo.Controls.Add(this.panel3);
			this.plPersonalInfo.Location = new System.Drawing.Point(0, 0);
			this.plPersonalInfo.Name = "plPersonalInfo";
			this.plPersonalInfo.Size = new System.Drawing.Size(796, 502);
			this.plPersonalInfo.TabIndex = 10;
			// 
			// guna2ShadowPanel1
			// 
			this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2ShadowPanel1.Controls.Add(this.tbRemainingAmount);
			this.guna2ShadowPanel1.Controls.Add(this.tbTotalPayAmount);
			this.guna2ShadowPanel1.Controls.Add(this.label11);
			this.guna2ShadowPanel1.Controls.Add(this.label10);
			this.guna2ShadowPanel1.Controls.Add(this.label8);
			this.guna2ShadowPanel1.Controls.Add(this.label6);
			this.guna2ShadowPanel1.Controls.Add(this.nudInitialPayAmount);
			this.guna2ShadowPanel1.Controls.Add(this.label3);
			this.guna2ShadowPanel1.Controls.Add(this.label1);
			this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
			this.guna2ShadowPanel1.Location = new System.Drawing.Point(203, 228);
			this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
			this.guna2ShadowPanel1.Radius = 8;
			this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.DimGray;
			this.guna2ShadowPanel1.ShadowDepth = 200;
			this.guna2ShadowPanel1.Size = new System.Drawing.Size(390, 183);
			this.guna2ShadowPanel1.TabIndex = 38;
			// 
			// tbRemainingAmount
			// 
			this.tbRemainingAmount.BorderColor = System.Drawing.Color.DarkGray;
			this.tbRemainingAmount.BorderThickness = 2;
			this.tbRemainingAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbRemainingAmount.DefaultText = "";
			this.tbRemainingAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbRemainingAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbRemainingAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbRemainingAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbRemainingAmount.Enabled = false;
			this.tbRemainingAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbRemainingAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F);
			this.tbRemainingAmount.ForeColor = System.Drawing.Color.Black;
			this.tbRemainingAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbRemainingAmount.Location = new System.Drawing.Point(222, 116);
			this.tbRemainingAmount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.tbRemainingAmount.Name = "tbRemainingAmount";
			this.tbRemainingAmount.PasswordChar = '\0';
			this.tbRemainingAmount.PlaceholderForeColor = System.Drawing.Color.Black;
			this.tbRemainingAmount.PlaceholderText = "0";
			this.tbRemainingAmount.SelectedText = "";
			this.tbRemainingAmount.Size = new System.Drawing.Size(153, 37);
			this.tbRemainingAmount.TabIndex = 42;
			// 
			// tbTotalPayAmount
			// 
			this.tbTotalPayAmount.BorderColor = System.Drawing.Color.DarkGray;
			this.tbTotalPayAmount.BorderThickness = 2;
			this.tbTotalPayAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbTotalPayAmount.DefaultText = "";
			this.tbTotalPayAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbTotalPayAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbTotalPayAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbTotalPayAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbTotalPayAmount.Enabled = false;
			this.tbTotalPayAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbTotalPayAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F);
			this.tbTotalPayAmount.ForeColor = System.Drawing.Color.Black;
			this.tbTotalPayAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbTotalPayAmount.Location = new System.Drawing.Point(222, 12);
			this.tbTotalPayAmount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.tbTotalPayAmount.Name = "tbTotalPayAmount";
			this.tbTotalPayAmount.PasswordChar = '\0';
			this.tbTotalPayAmount.PlaceholderForeColor = System.Drawing.Color.Black;
			this.tbTotalPayAmount.PlaceholderText = "0";
			this.tbTotalPayAmount.SelectedText = "";
			this.tbTotalPayAmount.Size = new System.Drawing.Size(153, 37);
			this.tbTotalPayAmount.TabIndex = 39;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(198, 121);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(23, 25);
			this.label11.TabIndex = 41;
			this.label11.Text = "$";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(197, 70);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(23, 25);
			this.label10.TabIndex = 40;
			this.label10.Text = "$";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(198, 21);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(23, 25);
			this.label8.TabIndex = 39;
			this.label8.Text = "$";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(11, 121);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(190, 25);
			this.label6.TabIndex = 19;
			this.label6.Text = "Remaining Amount:";
			// 
			// nudInitialPayAmount
			// 
			this.nudInitialPayAmount.BackColor = System.Drawing.Color.Transparent;
			this.nudInitialPayAmount.BorderColor = System.Drawing.Color.DarkGray;
			this.nudInitialPayAmount.BorderThickness = 2;
			this.nudInitialPayAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.nudInitialPayAmount.FocusedState.BorderColor = System.Drawing.Color.DeepPink;
			this.nudInitialPayAmount.FocusedState.UpDownButtonFillColor = System.Drawing.Color.DeepPink;
			this.nudInitialPayAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudInitialPayAmount.Location = new System.Drawing.Point(222, 64);
			this.nudInitialPayAmount.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
			this.nudInitialPayAmount.Name = "nudInitialPayAmount";
			this.nudInitialPayAmount.ShadowDecoration.Color = System.Drawing.Color.Gainsboro;
			this.nudInitialPayAmount.Size = new System.Drawing.Size(153, 37);
			this.nudInitialPayAmount.TabIndex = 18;
			this.nudInitialPayAmount.ThousandsSeparator = true;
			this.nudInitialPayAmount.UpDownButtonFillColor = System.Drawing.Color.DarkGray;
			this.nudInitialPayAmount.UpDownButtonForeColor = System.Drawing.Color.White;
			this.nudInitialPayAmount.UseTransparentBackground = true;
			this.nudInitialPayAmount.ValueChanged += new System.EventHandler(this.nudInitialPayAmount_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(26, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(175, 25);
			this.label3.TabIndex = 15;
			this.label3.Text = "Total Pay Amount:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(19, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(182, 25);
			this.label1.TabIndex = 14;
			this.label1.Text = "Initial Pay Amount:";
			// 
			// btnSave
			// 
			this.btnSave.Animated = true;
			this.btnSave.BorderRadius = 18;
			this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Image = global::PresentationLayer.Properties.Resources.icons8_save_1;
			this.btnSave.Location = new System.Drawing.Point(392, 442);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(128, 34);
			this.btnSave.TabIndex = 24;
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lbPaymentStatus
			// 
			this.lbPaymentStatus.AutoSize = true;
			this.lbPaymentStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPaymentStatus.ForeColor = System.Drawing.Color.Black;
			this.lbPaymentStatus.Location = new System.Drawing.Point(647, 111);
			this.lbPaymentStatus.Name = "lbPaymentStatus";
			this.lbPaymentStatus.Size = new System.Drawing.Size(36, 25);
			this.lbPaymentStatus.TabIndex = 37;
			this.lbPaymentStatus.Text = "???";
			// 
			// btnBack
			// 
			this.btnBack.Animated = true;
			this.btnBack.BorderRadius = 18;
			this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnBack.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnBack.ForeColor = System.Drawing.Color.White;
			this.btnBack.Image = global::PresentationLayer.Properties.Resources.icons8_double_left;
			this.btnBack.Location = new System.Drawing.Point(258, 442);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(128, 34);
			this.btnBack.TabIndex = 34;
			this.btnBack.Text = "Back";
			this.btnBack.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// button8
			// 
			this.button8.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_token_card_code;
			this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button8.Location = new System.Drawing.Point(601, 106);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(35, 34);
			this.button8.TabIndex = 36;
			this.button8.TabStop = false;
			this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button8.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(452, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 25);
			this.label2.TabIndex = 35;
			this.label2.Text = "Payment Status:";
			// 
			// lbFinalPaymentDate
			// 
			this.lbFinalPaymentDate.AutoSize = true;
			this.lbFinalPaymentDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFinalPaymentDate.ForeColor = System.Drawing.Color.Black;
			this.lbFinalPaymentDate.Location = new System.Drawing.Point(647, 167);
			this.lbFinalPaymentDate.Name = "lbFinalPaymentDate";
			this.lbFinalPaymentDate.Size = new System.Drawing.Size(36, 25);
			this.lbFinalPaymentDate.TabIndex = 33;
			this.lbFinalPaymentDate.Text = "???";
			// 
			// button4
			// 
			this.button4.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_event_accepted;
			this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button4.Location = new System.Drawing.Point(601, 162);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(35, 34);
			this.button4.TabIndex = 31;
			this.button4.TabStop = false;
			this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button4.UseVisualStyleBackColor = true;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(416, 167);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(177, 25);
			this.label12.TabIndex = 30;
			this.label12.Text = "Final Payment Date:";
			// 
			// lbCustomerID
			// 
			this.lbCustomerID.AutoSize = true;
			this.lbCustomerID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCustomerID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lbCustomerID.Location = new System.Drawing.Point(221, 107);
			this.lbCustomerID.Name = "lbCustomerID";
			this.lbCustomerID.Size = new System.Drawing.Size(36, 25);
			this.lbCustomerID.TabIndex = 29;
			this.lbCustomerID.Text = "???";
			// 
			// button7
			// 
			this.button7.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_id_button;
			this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button7.Location = new System.Drawing.Point(175, 106);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(35, 34);
			this.button7.TabIndex = 28;
			this.button7.TabStop = false;
			this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button7.UseVisualStyleBackColor = true;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(62, 111);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(115, 25);
			this.label16.TabIndex = 27;
			this.label16.Text = "CustomerID:";
			// 
			// lbTotalPayAmount
			// 
			this.lbTotalPayAmount.AutoSize = true;
			this.lbTotalPayAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotalPayAmount.ForeColor = System.Drawing.Color.Black;
			this.lbTotalPayAmount.Location = new System.Drawing.Point(221, 167);
			this.lbTotalPayAmount.Name = "lbTotalPayAmount";
			this.lbTotalPayAmount.Size = new System.Drawing.Size(36, 25);
			this.lbTotalPayAmount.TabIndex = 15;
			this.lbTotalPayAmount.Text = "???";
			// 
			// button3
			// 
			this.button3.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_average;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button3.Location = new System.Drawing.Point(175, 162);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(35, 34);
			this.button3.TabIndex = 14;
			this.button3.TabStop = false;
			this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button3.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(9, 167);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(162, 25);
			this.label9.TabIndex = 13;
			this.label9.Text = "Total Pay Amount:";
			// 
			// lbPaymetnStatusID
			// 
			this.lbPaymetnStatusID.AutoSize = true;
			this.lbPaymetnStatusID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPaymetnStatusID.ForeColor = System.Drawing.Color.Black;
			this.lbPaymetnStatusID.Location = new System.Drawing.Point(647, 54);
			this.lbPaymetnStatusID.Name = "lbPaymetnStatusID";
			this.lbPaymetnStatusID.Size = new System.Drawing.Size(36, 25);
			this.lbPaymetnStatusID.TabIndex = 12;
			this.lbPaymetnStatusID.Text = "???";
			// 
			// button2
			// 
			this.button2.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_card_payment;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button2.Location = new System.Drawing.Point(601, 50);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(35, 34);
			this.button2.TabIndex = 11;
			this.button2.TabStop = false;
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(429, 55);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(166, 25);
			this.label7.TabIndex = 10;
			this.label7.Text = "Payment Status ID:";
			// 
			// lbPaymentID
			// 
			this.lbPaymentID.AutoSize = true;
			this.lbPaymentID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPaymentID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lbPaymentID.Location = new System.Drawing.Point(221, 54);
			this.lbPaymentID.Name = "lbPaymentID";
			this.lbPaymentID.Size = new System.Drawing.Size(36, 25);
			this.lbPaymentID.TabIndex = 9;
			this.lbPaymentID.Text = "???";
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_id_button;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button1.Location = new System.Drawing.Point(175, 50);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(35, 34);
			this.button1.TabIndex = 8;
			this.button1.TabStop = false;
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(63, 55);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 25);
			this.label4.TabIndex = 5;
			this.label4.Text = "Payment ID:";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Gainsboro;
			this.panel3.Controls.Add(this.label5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(796, 35);
			this.panel3.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
			this.label5.Location = new System.Drawing.Point(285, 6);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(226, 27);
			this.label5.TabIndex = 0;
			this.label5.Text = "Payment Information";
			// 
			// frmAddNewPayment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(898, 660);
			this.Controls.Add(this.plContainer);
			this.Controls.Add(this.plTopBar);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmAddNewPayment";
			this.Text = "frmAddNewPayment";
			this.plTopBar.ResumeLayout(false);
			this.plTopBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			this.plContainer.ResumeLayout(false);
			this.plFirstAddNewPaymentForm.ResumeLayout(false);
			this.plSubContainer.ResumeLayout(false);
			this.plFirstPage.ResumeLayout(false);
			this.plPersonalInfo.ResumeLayout(false);
			this.plPersonalInfo.PerformLayout();
			this.guna2ShadowPanel1.ResumeLayout(false);
			this.guna2ShadowPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudInitialPayAmount)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel plTopBar;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.PictureBox pbClose;
		private System.Windows.Forms.Panel plContainer;
		private System.Windows.Forms.Panel plFirstAddNewPaymentForm;
		private System.Windows.Forms.Panel plSubContainer;
		private System.Windows.Forms.Panel plFirstPage;
		private Guna.UI2.WinForms.Guna2Panel plPersonalInfo;
		private Guna.UI2.WinForms.Guna2GradientButton btnBack;
		private System.Windows.Forms.Label lbFinalPaymentDate;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label lbCustomerID;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Label label16;
		private Guna.UI2.WinForms.Guna2GradientButton btnSave;
		private System.Windows.Forms.Label lbTotalPayAmount;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lbPaymetnStatusID;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lbPaymentID;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbPaymentStatus;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
		private System.Windows.Forms.Label label6;
		private Guna.UI2.WinForms.Guna2NumericUpDown nudInitialPayAmount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private Guna.UI2.WinForms.Guna2TextBox tbRemainingAmount;
		private Guna.UI2.WinForms.Guna2TextBox tbTotalPayAmount;
	}
}