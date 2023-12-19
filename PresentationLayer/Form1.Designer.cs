﻿namespace PresentationLayer
{
	partial class frmMain
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
			this.plTopBar = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.plSideBar = new System.Windows.Forms.FlowLayoutPanel();
			this.plTopSideBar = new System.Windows.Forms.Panel();
			this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
			this.btnCoustomers = new Guna.UI2.WinForms.Guna2Button();
			this.btnApointments = new Guna.UI2.WinForms.Guna2Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnUser = new Guna.UI2.WinForms.Guna2Button();
			this.plContener = new System.Windows.Forms.Panel();
			this.plCustomers = new System.Windows.Forms.Panel();
			this.plCRUD = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.btnDeleteCustomer = new System.Windows.Forms.Button();
			this.btnUpdateCustomer = new System.Windows.Forms.Button();
			this.btnAddCustomer = new System.Windows.Forms.Button();
			this.gvCutomers = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.plAppointements = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.plDashboard = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.plTopBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.plSideBar.SuspendLayout();
			this.panel1.SuspendLayout();
			this.plContener.SuspendLayout();
			this.plCustomers.SuspendLayout();
			this.plCRUD.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvCutomers)).BeginInit();
			this.plAppointements.SuspendLayout();
			this.plDashboard.SuspendLayout();
			this.SuspendLayout();
			// 
			// plTopBar
			// 
			this.plTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(193)))));
			this.plTopBar.Controls.Add(this.label1);
			this.plTopBar.Controls.Add(this.pictureBox2);
			this.plTopBar.Controls.Add(this.pictureBox1);
			this.plTopBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.plTopBar.Location = new System.Drawing.Point(0, 0);
			this.plTopBar.Name = "plTopBar";
			this.plTopBar.Size = new System.Drawing.Size(1434, 39);
			this.plTopBar.TabIndex = 0;
			this.plTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseDown);
			this.plTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseMove);
			this.plTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseUp);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 34);
			this.label1.TabIndex = 1;
			this.label1.Text = "  Sport Space";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox2.Image = global::PresentationLayer.Properties.Resources.icons8_minus;
			this.pictureBox2.Location = new System.Drawing.Point(1348, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(43, 39);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.icons8_close_208px;
			this.pictureBox1.Location = new System.Drawing.Point(1391, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(43, 39);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// plSideBar
			// 
			this.plSideBar.BackColor = System.Drawing.Color.White;
			this.plSideBar.Controls.Add(this.plTopSideBar);
			this.plSideBar.Controls.Add(this.btnDashboard);
			this.plSideBar.Controls.Add(this.btnCoustomers);
			this.plSideBar.Controls.Add(this.btnApointments);
			this.plSideBar.Controls.Add(this.panel1);
			this.plSideBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.plSideBar.Location = new System.Drawing.Point(0, 39);
			this.plSideBar.Name = "plSideBar";
			this.plSideBar.Size = new System.Drawing.Size(200, 765);
			this.plSideBar.TabIndex = 1;
			// 
			// plTopSideBar
			// 
			this.plTopSideBar.BackColor = System.Drawing.Color.Transparent;
			this.plTopSideBar.Location = new System.Drawing.Point(3, 3);
			this.plTopSideBar.Name = "plTopSideBar";
			this.plTopSideBar.Size = new System.Drawing.Size(197, 136);
			this.plTopSideBar.TabIndex = 2;
			// 
			// btnDashboard
			// 
			this.btnDashboard.Animated = true;
			this.btnDashboard.AutoRoundedCorners = true;
			this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
			this.btnDashboard.BorderColor = System.Drawing.Color.Transparent;
			this.btnDashboard.BorderRadius = 30;
			this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnDashboard.FillColor = System.Drawing.Color.SkyBlue;
			this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDashboard.ForeColor = System.Drawing.Color.White;
			this.btnDashboard.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(193)))));
			this.btnDashboard.Image = global::PresentationLayer.Properties.Resources.icons8_dashboard_layout_2;
			this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnDashboard.ImageOffset = new System.Drawing.Point(10, 0);
			this.btnDashboard.ImageSize = new System.Drawing.Size(30, 30);
			this.btnDashboard.Location = new System.Drawing.Point(3, 145);
			this.btnDashboard.Name = "btnDashboard";
			this.btnDashboard.Size = new System.Drawing.Size(190, 62);
			this.btnDashboard.TabIndex = 2;
			this.btnDashboard.Text = "     Dashboard";
			this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
			// 
			// btnCoustomers
			// 
			this.btnCoustomers.Animated = true;
			this.btnCoustomers.AutoRoundedCorners = true;
			this.btnCoustomers.BackColor = System.Drawing.Color.Transparent;
			this.btnCoustomers.BorderColor = System.Drawing.Color.Transparent;
			this.btnCoustomers.BorderRadius = 30;
			this.btnCoustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCoustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnCoustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnCoustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnCoustomers.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnCoustomers.FillColor = System.Drawing.Color.SkyBlue;
			this.btnCoustomers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCoustomers.ForeColor = System.Drawing.Color.White;
			this.btnCoustomers.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(193)))));
			this.btnCoustomers.Image = global::PresentationLayer.Properties.Resources.icons8_customer;
			this.btnCoustomers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnCoustomers.ImageOffset = new System.Drawing.Point(10, 0);
			this.btnCoustomers.ImageSize = new System.Drawing.Size(30, 30);
			this.btnCoustomers.Location = new System.Drawing.Point(3, 213);
			this.btnCoustomers.Name = "btnCoustomers";
			this.btnCoustomers.Size = new System.Drawing.Size(190, 62);
			this.btnCoustomers.TabIndex = 3;
			this.btnCoustomers.Text = "    Customers";
			this.btnCoustomers.Click += new System.EventHandler(this.btnCoustomers_Click);
			// 
			// btnApointments
			// 
			this.btnApointments.Animated = true;
			this.btnApointments.AutoRoundedCorners = true;
			this.btnApointments.BackColor = System.Drawing.Color.Transparent;
			this.btnApointments.BorderColor = System.Drawing.Color.Transparent;
			this.btnApointments.BorderRadius = 30;
			this.btnApointments.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnApointments.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnApointments.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnApointments.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnApointments.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnApointments.FillColor = System.Drawing.Color.SkyBlue;
			this.btnApointments.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnApointments.ForeColor = System.Drawing.Color.White;
			this.btnApointments.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(193)))));
			this.btnApointments.Image = global::PresentationLayer.Properties.Resources.icons8_reservation;
			this.btnApointments.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnApointments.ImageOffset = new System.Drawing.Point(10, 0);
			this.btnApointments.ImageSize = new System.Drawing.Size(30, 30);
			this.btnApointments.Location = new System.Drawing.Point(3, 281);
			this.btnApointments.Name = "btnApointments";
			this.btnApointments.Size = new System.Drawing.Size(190, 62);
			this.btnApointments.TabIndex = 4;
			this.btnApointments.Text = "        Apoitmentes";
			this.btnApointments.Click += new System.EventHandler(this.btnApointments_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.btnUser);
			this.panel1.Location = new System.Drawing.Point(3, 349);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(197, 406);
			this.panel1.TabIndex = 5;
			// 
			// btnUser
			// 
			this.btnUser.Animated = true;
			this.btnUser.AutoRoundedCorners = true;
			this.btnUser.BackColor = System.Drawing.Color.Transparent;
			this.btnUser.BorderColor = System.Drawing.Color.Transparent;
			this.btnUser.BorderRadius = 24;
			this.btnUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnUser.FillColor = System.Drawing.Color.SkyBlue;
			this.btnUser.Font = new System.Drawing.Font("Segoe UI", 14.25F);
			this.btnUser.ForeColor = System.Drawing.Color.White;
			this.btnUser.Image = global::PresentationLayer.Properties.Resources.icons8_minus;
			this.btnUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnUser.ImageOffset = new System.Drawing.Point(10, 0);
			this.btnUser.ImageSize = new System.Drawing.Size(30, 30);
			this.btnUser.Location = new System.Drawing.Point(59, 254);
			this.btnUser.Name = "btnUser";
			this.btnUser.Size = new System.Drawing.Size(75, 50);
			this.btnUser.TabIndex = 8;
			// 
			// plContener
			// 
			this.plContener.Controls.Add(this.plCustomers);
			this.plContener.Controls.Add(this.plAppointements);
			this.plContener.Controls.Add(this.plDashboard);
			this.plContener.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plContener.Location = new System.Drawing.Point(200, 39);
			this.plContener.Name = "plContener";
			this.plContener.Size = new System.Drawing.Size(1234, 765);
			this.plContener.TabIndex = 2;
			// 
			// plCustomers
			// 
			this.plCustomers.BackColor = System.Drawing.Color.White;
			this.plCustomers.Controls.Add(this.plCRUD);
			this.plCustomers.Controls.Add(this.gvCutomers);
			this.plCustomers.Controls.Add(this.label3);
			this.plCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plCustomers.Location = new System.Drawing.Point(0, 0);
			this.plCustomers.Name = "plCustomers";
			this.plCustomers.Size = new System.Drawing.Size(1234, 765);
			this.plCustomers.TabIndex = 1;
			this.plCustomers.Paint += new System.Windows.Forms.PaintEventHandler(this.plCustomers_Paint);
			// 
			// plCRUD
			// 
			this.plCRUD.BorderRadius = 30;
			this.plCRUD.Controls.Add(this.btnDeleteCustomer);
			this.plCRUD.Controls.Add(this.btnUpdateCustomer);
			this.plCRUD.Controls.Add(this.btnAddCustomer);
			this.plCRUD.FillColor = System.Drawing.Color.SkyBlue;
			this.plCRUD.FillColor2 = System.Drawing.Color.MediumSeaGreen;
			this.plCRUD.Location = new System.Drawing.Point(422, 648);
			this.plCRUD.Name = "plCRUD";
			this.plCRUD.Size = new System.Drawing.Size(390, 67);
			this.plCRUD.TabIndex = 7;
			// 
			// btnDeleteCustomer
			// 
			this.btnDeleteCustomer.BackColor = System.Drawing.Color.Transparent;
			this.btnDeleteCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDeleteCustomer.FlatAppearance.BorderSize = 0;
			this.btnDeleteCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnDeleteCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteCustomer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteCustomer.ForeColor = System.Drawing.Color.White;
			this.btnDeleteCustomer.Image = global::PresentationLayer.Properties.Resources.icons8_delete_1;
			this.btnDeleteCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnDeleteCustomer.Location = new System.Drawing.Point(272, 2);
			this.btnDeleteCustomer.Name = "btnDeleteCustomer";
			this.btnDeleteCustomer.Size = new System.Drawing.Size(90, 64);
			this.btnDeleteCustomer.TabIndex = 2;
			this.btnDeleteCustomer.Tag = "";
			this.btnDeleteCustomer.Text = "Delete";
			this.btnDeleteCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnDeleteCustomer.UseVisualStyleBackColor = false;
			this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
			// 
			// btnUpdateCustomer
			// 
			this.btnUpdateCustomer.BackColor = System.Drawing.Color.Transparent;
			this.btnUpdateCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnUpdateCustomer.FlatAppearance.BorderSize = 0;
			this.btnUpdateCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnUpdateCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnUpdateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdateCustomer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateCustomer.ForeColor = System.Drawing.Color.White;
			this.btnUpdateCustomer.Image = global::PresentationLayer.Properties.Resources.icons8_update_left_rotation;
			this.btnUpdateCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnUpdateCustomer.Location = new System.Drawing.Point(147, 2);
			this.btnUpdateCustomer.Name = "btnUpdateCustomer";
			this.btnUpdateCustomer.Size = new System.Drawing.Size(86, 64);
			this.btnUpdateCustomer.TabIndex = 1;
			this.btnUpdateCustomer.Tag = "";
			this.btnUpdateCustomer.Text = "Update";
			this.btnUpdateCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnUpdateCustomer.UseVisualStyleBackColor = false;
			this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
			// 
			// btnAddCustomer
			// 
			this.btnAddCustomer.BackColor = System.Drawing.Color.Transparent;
			this.btnAddCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnAddCustomer.FlatAppearance.BorderSize = 0;
			this.btnAddCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnAddCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddCustomer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
			this.btnAddCustomer.Image = global::PresentationLayer.Properties.Resources.icons8_add_1;
			this.btnAddCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnAddCustomer.Location = new System.Drawing.Point(44, 2);
			this.btnAddCustomer.Name = "btnAddCustomer";
			this.btnAddCustomer.Size = new System.Drawing.Size(55, 64);
			this.btnAddCustomer.TabIndex = 0;
			this.btnAddCustomer.Tag = "";
			this.btnAddCustomer.Text = "Add";
			this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAddCustomer.UseVisualStyleBackColor = false;
			this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
			// 
			// gvCutomers
			// 
			this.gvCutomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.gvCutomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
			this.gvCutomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gvCutomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvCutomers.GridColor = System.Drawing.Color.Black;
			this.gvCutomers.Location = new System.Drawing.Point(122, 145);
			this.gvCutomers.Name = "gvCutomers";
			this.gvCutomers.RowHeadersWidth = 62;
			this.gvCutomers.Size = new System.Drawing.Size(990, 439);
			this.gvCutomers.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.SkyBlue;
			this.label3.Location = new System.Drawing.Point(397, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(441, 58);
			this.label3.TabIndex = 1;
			this.label3.Text = "Customers Space";
			// 
			// plAppointements
			// 
			this.plAppointements.Controls.Add(this.label4);
			this.plAppointements.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plAppointements.Location = new System.Drawing.Point(0, 0);
			this.plAppointements.Name = "plAppointements";
			this.plAppointements.Size = new System.Drawing.Size(1234, 765);
			this.plAppointements.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(501, 50);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(237, 35);
			this.label4.TabIndex = 1;
			this.label4.Text = "Appointements";
			// 
			// plDashboard
			// 
			this.plDashboard.Controls.Add(this.label2);
			this.plDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plDashboard.Location = new System.Drawing.Point(0, 0);
			this.plDashboard.Name = "plDashboard";
			this.plDashboard.Size = new System.Drawing.Size(1234, 765);
			this.plDashboard.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(491, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(172, 35);
			this.label2.TabIndex = 0;
			this.label2.Text = "Dashboard";
			// 
			// frmMain
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.ClientSize = new System.Drawing.Size(1434, 804);
			this.Controls.Add(this.plContener);
			this.Controls.Add(this.plSideBar);
			this.Controls.Add(this.plTopBar);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FACILITY SPORT";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.plTopBar.ResumeLayout(false);
			this.plTopBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.plSideBar.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.plContener.ResumeLayout(false);
			this.plCustomers.ResumeLayout(false);
			this.plCustomers.PerformLayout();
			this.plCRUD.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvCutomers)).EndInit();
			this.plAppointements.ResumeLayout(false);
			this.plAppointements.PerformLayout();
			this.plDashboard.ResumeLayout(false);
			this.plDashboard.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel plTopBar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel plSideBar;
		private System.Windows.Forms.Panel plTopSideBar;
		private Guna.UI2.WinForms.Guna2Button btnDashboard;
		private Guna.UI2.WinForms.Guna2Button btnCoustomers;
		private Guna.UI2.WinForms.Guna2Button btnApointments;
		private System.Windows.Forms.Panel panel1;
		private Guna.UI2.WinForms.Guna2Button btnUser;
		private System.Windows.Forms.Panel plContener;
		private System.Windows.Forms.Panel plCustomers;
		private System.Windows.Forms.DataGridView gvCutomers;
		private System.Windows.Forms.Panel plAppointements;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel plDashboard;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2GradientPanel plCRUD;
		private System.Windows.Forms.Button btnDeleteCustomer;
		private System.Windows.Forms.Button btnUpdateCustomer;
		private System.Windows.Forms.Button btnAddCustomer;
		private System.Windows.Forms.Label label3;
	}
}

