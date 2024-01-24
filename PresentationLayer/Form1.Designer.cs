namespace PresentationLayer
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
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
			this.plAppointements = new System.Windows.Forms.Panel();
			this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.btnChangeStatus = new System.Windows.Forms.Button();
			this.btnBook = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.gvBooking = new Guna.UI2.WinForms.Guna2DataGridView();
			this.plDashboard = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.plCustomers = new System.Windows.Forms.Panel();
			this.plCRUD = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.btnDeleteCustomer = new System.Windows.Forms.Button();
			this.btnUpdateCustomer = new System.Windows.Forms.Button();
			this.btnAddCustomer = new System.Windows.Forms.Button();
			this.gvCutomers = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.plTopBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.plSideBar.SuspendLayout();
			this.panel1.SuspendLayout();
			this.plContener.SuspendLayout();
			this.plAppointements.SuspendLayout();
			this.guna2GradientPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvBooking)).BeginInit();
			this.plDashboard.SuspendLayout();
			this.plCustomers.SuspendLayout();
			this.plCRUD.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvCutomers)).BeginInit();
			this.SuspendLayout();
			// 
			// plTopBar
			// 
			this.plTopBar.BackColor = System.Drawing.Color.SkyBlue;
			this.plTopBar.Controls.Add(this.label1);
			this.plTopBar.Controls.Add(this.pictureBox2);
			this.plTopBar.Controls.Add(this.pictureBox1);
			this.plTopBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.plTopBar.Location = new System.Drawing.Point(0, 0);
			this.plTopBar.Name = "plTopBar";
			this.plTopBar.Size = new System.Drawing.Size(1502, 46);
			this.plTopBar.TabIndex = 0;
			this.plTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseDown);
			this.plTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseMove);
			this.plTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseUp);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(191, 44);
			this.label1.TabIndex = 1;
			this.label1.Text = "  Sport Space";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox2.Image = global::PresentationLayer.Properties.Resources.icons8_minus;
			this.pictureBox2.Location = new System.Drawing.Point(1416, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(43, 46);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.icons8_close_208px;
			this.pictureBox1.Location = new System.Drawing.Point(1459, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(43, 46);
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
			this.plSideBar.Location = new System.Drawing.Point(0, 46);
			this.plSideBar.Name = "plSideBar";
			this.plSideBar.Size = new System.Drawing.Size(194, 906);
			this.plSideBar.TabIndex = 1;
			// 
			// plTopSideBar
			// 
			this.plTopSideBar.BackColor = System.Drawing.Color.Transparent;
			this.plTopSideBar.Location = new System.Drawing.Point(3, 3);
			this.plTopSideBar.Name = "plTopSideBar";
			this.plTopSideBar.Size = new System.Drawing.Size(190, 136);
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
			this.btnApointments.Text = "  Booking";
			this.btnApointments.Click += new System.EventHandler(this.btnApointments_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.btnUser);
			this.panel1.Location = new System.Drawing.Point(3, 349);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(190, 596);
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
			this.btnUser.Location = new System.Drawing.Point(53, 447);
			this.btnUser.Name = "btnUser";
			this.btnUser.Size = new System.Drawing.Size(75, 50);
			this.btnUser.TabIndex = 8;
			// 
			// plContener
			// 
			this.plContener.Controls.Add(this.plAppointements);
			this.plContener.Controls.Add(this.plDashboard);
			this.plContener.Controls.Add(this.plCustomers);
			this.plContener.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plContener.Location = new System.Drawing.Point(194, 46);
			this.plContener.Name = "plContener";
			this.plContener.Size = new System.Drawing.Size(1308, 906);
			this.plContener.TabIndex = 2;
			// 
			// plAppointements
			// 
			this.plAppointements.BackColor = System.Drawing.Color.White;
			this.plAppointements.Controls.Add(this.guna2GradientPanel1);
			this.plAppointements.Controls.Add(this.label4);
			this.plAppointements.Controls.Add(this.gvBooking);
			this.plAppointements.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plAppointements.Location = new System.Drawing.Point(0, 0);
			this.plAppointements.Name = "plAppointements";
			this.plAppointements.Size = new System.Drawing.Size(1308, 906);
			this.plAppointements.TabIndex = 1;
			this.plAppointements.Paint += new System.Windows.Forms.PaintEventHandler(this.plAppointements_Paint);
			// 
			// guna2GradientPanel1
			// 
			this.guna2GradientPanel1.BorderRadius = 30;
			this.guna2GradientPanel1.Controls.Add(this.button1);
			this.guna2GradientPanel1.Controls.Add(this.btnChangeStatus);
			this.guna2GradientPanel1.Controls.Add(this.btnBook);
			this.guna2GradientPanel1.FillColor = System.Drawing.Color.SkyBlue;
			this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.MediumSeaGreen;
			this.guna2GradientPanel1.Location = new System.Drawing.Point(412, 785);
			this.guna2GradientPanel1.Name = "guna2GradientPanel1";
			this.guna2GradientPanel1.Size = new System.Drawing.Size(486, 67);
			this.guna2GradientPanel1.TabIndex = 8;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Image = global::PresentationLayer.Properties.Resources.icons8_delete_1;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button1.Location = new System.Drawing.Point(341, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 64);
			this.button1.TabIndex = 2;
			this.button1.Tag = "";
			this.button1.Text = "Delete";
			this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// btnChangeStatus
			// 
			this.btnChangeStatus.BackColor = System.Drawing.Color.Transparent;
			this.btnChangeStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnChangeStatus.FlatAppearance.BorderSize = 0;
			this.btnChangeStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnChangeStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnChangeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChangeStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChangeStatus.ForeColor = System.Drawing.Color.White;
			this.btnChangeStatus.Image = global::PresentationLayer.Properties.Resources.icons8_update_left_rotation;
			this.btnChangeStatus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnChangeStatus.Location = new System.Drawing.Point(157, 2);
			this.btnChangeStatus.Name = "btnChangeStatus";
			this.btnChangeStatus.Size = new System.Drawing.Size(147, 64);
			this.btnChangeStatus.TabIndex = 1;
			this.btnChangeStatus.Tag = "";
			this.btnChangeStatus.Text = "Change Status";
			this.btnChangeStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnChangeStatus.UseVisualStyleBackColor = false;
			this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
			// 
			// btnBook
			// 
			this.btnBook.BackColor = System.Drawing.Color.Transparent;
			this.btnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnBook.FlatAppearance.BorderSize = 0;
			this.btnBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBook.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBook.ForeColor = System.Drawing.Color.White;
			this.btnBook.Image = global::PresentationLayer.Properties.Resources.icons8_add_1;
			this.btnBook.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnBook.Location = new System.Drawing.Point(44, 2);
			this.btnBook.Name = "btnBook";
			this.btnBook.Size = new System.Drawing.Size(97, 64);
			this.btnBook.TabIndex = 0;
			this.btnBook.Tag = "";
			this.btnBook.Text = "Book";
			this.btnBook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnBook.UseVisualStyleBackColor = false;
			this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.SkyBlue;
			this.label4.Location = new System.Drawing.Point(465, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(379, 58);
			this.label4.TabIndex = 3;
			this.label4.Text = "Booking Space";
			// 
			// gvBooking
			// 
			this.gvBooking.AllowUserToAddRows = false;
			this.gvBooking.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.gvBooking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.gvBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.gvBooking.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.gvBooking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gvBooking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gvBooking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.gvBooking.ColumnHeadersHeight = 80;
			this.gvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gvBooking.DefaultCellStyle = dataGridViewCellStyle3;
			this.gvBooking.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.gvBooking.GridColor = System.Drawing.Color.DarkGray;
			this.gvBooking.Location = new System.Drawing.Point(44, 107);
			this.gvBooking.Name = "gvBooking";
			this.gvBooking.ReadOnly = true;
			this.gvBooking.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gvBooking.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.gvBooking.RowHeadersVisible = false;
			this.gvBooking.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.gvBooking.RowTemplate.Height = 60;
			this.gvBooking.Size = new System.Drawing.Size(1210, 622);
			this.gvBooking.TabIndex = 2;
			this.gvBooking.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.gvBooking.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.gvBooking.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
			this.gvBooking.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.gvBooking.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.gvBooking.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
			this.gvBooking.ThemeStyle.GridColor = System.Drawing.Color.DarkGray;
			this.gvBooking.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.gvBooking.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.gvBooking.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gvBooking.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.gvBooking.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.gvBooking.ThemeStyle.HeaderStyle.Height = 80;
			this.gvBooking.ThemeStyle.ReadOnly = true;
			this.gvBooking.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.gvBooking.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.gvBooking.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gvBooking.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.gvBooking.ThemeStyle.RowsStyle.Height = 60;
			this.gvBooking.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.gvBooking.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.gvBooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvBooking_CellContentClick);
			// 
			// plDashboard
			// 
			this.plDashboard.Controls.Add(this.label2);
			this.plDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plDashboard.Location = new System.Drawing.Point(0, 0);
			this.plDashboard.Name = "plDashboard";
			this.plDashboard.Size = new System.Drawing.Size(1308, 906);
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
			// plCustomers
			// 
			this.plCustomers.BackColor = System.Drawing.Color.White;
			this.plCustomers.Controls.Add(this.plCRUD);
			this.plCustomers.Controls.Add(this.gvCutomers);
			this.plCustomers.Controls.Add(this.label3);
			this.plCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plCustomers.Location = new System.Drawing.Point(0, 0);
			this.plCustomers.Name = "plCustomers";
			this.plCustomers.Size = new System.Drawing.Size(1308, 906);
			this.plCustomers.TabIndex = 1;
			// 
			// plCRUD
			// 
			this.plCRUD.BorderRadius = 30;
			this.plCRUD.Controls.Add(this.btnDeleteCustomer);
			this.plCRUD.Controls.Add(this.btnUpdateCustomer);
			this.plCRUD.Controls.Add(this.btnAddCustomer);
			this.plCRUD.FillColor = System.Drawing.Color.SkyBlue;
			this.plCRUD.FillColor2 = System.Drawing.Color.MediumSeaGreen;
			this.plCRUD.Location = new System.Drawing.Point(422, 662);
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
			this.gvCutomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gvCutomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gvCutomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.gvCutomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvCutomers.Cursor = System.Windows.Forms.Cursors.Default;
			this.gvCutomers.EnableHeadersVisualStyles = false;
			this.gvCutomers.GridColor = System.Drawing.Color.Black;
			this.gvCutomers.Location = new System.Drawing.Point(44, 118);
			this.gvCutomers.Name = "gvCutomers";
			this.gvCutomers.ReadOnly = true;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gvCutomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.gvCutomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SkyBlue;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
			this.gvCutomers.RowsDefaultCellStyle = dataGridViewCellStyle7;
			this.gvCutomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvCutomers.Size = new System.Drawing.Size(1146, 508);
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
			// frmMain
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.ClientSize = new System.Drawing.Size(1502, 952);
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
			this.plAppointements.ResumeLayout(false);
			this.plAppointements.PerformLayout();
			this.guna2GradientPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvBooking)).EndInit();
			this.plDashboard.ResumeLayout(false);
			this.plDashboard.PerformLayout();
			this.plCustomers.ResumeLayout(false);
			this.plCustomers.PerformLayout();
			this.plCRUD.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvCutomers)).EndInit();
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
		private System.Windows.Forms.Panel plDashboard;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2GradientPanel plCRUD;
		private System.Windows.Forms.Button btnDeleteCustomer;
		private System.Windows.Forms.Button btnUpdateCustomer;
		private System.Windows.Forms.Button btnAddCustomer;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2DataGridView gvBooking;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnChangeStatus;
		private System.Windows.Forms.Button btnBook;
	}
}

