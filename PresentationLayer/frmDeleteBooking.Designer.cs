namespace PresentationLayer
{
	partial class frmDeleteBooking
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteBooking));
			this.plTopBar = new System.Windows.Forms.Panel();
			this.label17 = new System.Windows.Forms.Label();
			this.pbClose = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lbCustomerID = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			this.button7 = new System.Windows.Forms.Button();
			this.label24 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.button11 = new System.Windows.Forms.Button();
			this.lbViewPayment = new System.Windows.Forms.Label();
			this.lbFacilityName = new System.Windows.Forms.Label();
			this.button16 = new System.Windows.Forms.Button();
			this.label29 = new System.Windows.Forms.Label();
			this.lbPaymentID = new System.Windows.Forms.Label();
			this.button13 = new System.Windows.Forms.Button();
			this.label34 = new System.Windows.Forms.Label();
			this.lbDateOfBooking = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.label30 = new System.Windows.Forms.Label();
			this.lbDateOfIssue = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.label27 = new System.Windows.Forms.Label();
			this.lbBookingStatus = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.label28 = new System.Windows.Forms.Label();
			this.lbFacilityID = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label31 = new System.Windows.Forms.Label();
			this.lbBookingID = new System.Windows.Forms.Label();
			this.label39 = new System.Windows.Forms.Label();
			this.button12 = new System.Windows.Forms.Button();
			this.lbTime = new System.Windows.Forms.Label();
			this.button10 = new System.Windows.Forms.Button();
			this.label15 = new System.Windows.Forms.Label();
			this.btnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
			this.plTopBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// plTopBar
			// 
			this.plTopBar.BackColor = System.Drawing.Color.Crimson;
			this.plTopBar.Controls.Add(this.label17);
			this.plTopBar.Controls.Add(this.pbClose);
			this.plTopBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.plTopBar.Location = new System.Drawing.Point(0, 0);
			this.plTopBar.Margin = new System.Windows.Forms.Padding(4);
			this.plTopBar.Name = "plTopBar";
			this.plTopBar.Size = new System.Drawing.Size(1103, 41);
			this.plTopBar.TabIndex = 5;
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
			this.label17.Location = new System.Drawing.Point(13, 5);
			this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(189, 26);
			this.label17.TabIndex = 3;
			this.label17.Text = "Delete A Booking";
			// 
			// pbClose
			// 
			this.pbClose.BackColor = System.Drawing.Color.Transparent;
			this.pbClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
			this.pbClose.Location = new System.Drawing.Point(1039, 0);
			this.pbClose.Margin = new System.Windows.Forms.Padding(4);
			this.pbClose.Name = "pbClose";
			this.pbClose.Size = new System.Drawing.Size(64, 41);
			this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbClose.TabIndex = 2;
			this.pbClose.TabStop = false;
			this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.man_booking_appointment_calendar_23_2148562874;
			this.pictureBox1.Location = new System.Drawing.Point(0, 41);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(489, 579);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// lbCustomerID
			// 
			this.lbCustomerID.AutoSize = true;
			this.lbCustomerID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCustomerID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lbCustomerID.Location = new System.Drawing.Point(992, 80);
			this.lbCustomerID.Name = "lbCustomerID";
			this.lbCustomerID.Size = new System.Drawing.Size(31, 21);
			this.lbCustomerID.TabIndex = 61;
			this.lbCustomerID.Text = "???";
			// 
			// lbName
			// 
			this.lbName.AutoSize = true;
			this.lbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbName.ForeColor = System.Drawing.Color.Black;
			this.lbName.Location = new System.Drawing.Point(685, 132);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(31, 21);
			this.lbName.TabIndex = 64;
			this.lbName.Text = "???";
			// 
			// button7
			// 
			this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
			this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button7.Location = new System.Drawing.Point(644, 125);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(35, 34);
			this.button7.TabIndex = 63;
			this.button7.TabStop = false;
			this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button7.UseVisualStyleBackColor = true;
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(833, 78);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(120, 25);
			this.label24.TabIndex = 59;
			this.label24.Text = "Customer ID:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(582, 130);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(66, 25);
			this.label19.TabIndex = 62;
			this.label19.Text = "Name:";
			// 
			// button11
			// 
			this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
			this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button11.Location = new System.Drawing.Point(950, 73);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(35, 34);
			this.button11.TabIndex = 60;
			this.button11.TabStop = false;
			this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button11.UseVisualStyleBackColor = true;
			// 
			// lbViewPayment
			// 
			this.lbViewPayment.AutoSize = true;
			this.lbViewPayment.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbViewPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbViewPayment.Location = new System.Drawing.Point(718, 188);
			this.lbViewPayment.Name = "lbViewPayment";
			this.lbViewPayment.Size = new System.Drawing.Size(108, 21);
			this.lbViewPayment.TabIndex = 109;
			this.lbViewPayment.Text = "View Payment";
			this.lbViewPayment.Visible = false;
			// 
			// lbFacilityName
			// 
			this.lbFacilityName.AutoSize = true;
			this.lbFacilityName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFacilityName.ForeColor = System.Drawing.Color.Black;
			this.lbFacilityName.Location = new System.Drawing.Point(992, 188);
			this.lbFacilityName.Name = "lbFacilityName";
			this.lbFacilityName.Size = new System.Drawing.Size(31, 21);
			this.lbFacilityName.TabIndex = 108;
			this.lbFacilityName.Text = "???";
			// 
			// button16
			// 
			this.button16.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_token_card_code;
			this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button16.Location = new System.Drawing.Point(950, 179);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(35, 38);
			this.button16.TabIndex = 107;
			this.button16.TabStop = false;
			this.button16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button16.UseVisualStyleBackColor = true;
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label29.Location = new System.Drawing.Point(845, 186);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(111, 25);
			this.label29.TabIndex = 106;
			this.label29.Text = "Field Name:";
			// 
			// lbPaymentID
			// 
			this.lbPaymentID.AutoSize = true;
			this.lbPaymentID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPaymentID.ForeColor = System.Drawing.Color.Black;
			this.lbPaymentID.Location = new System.Drawing.Point(685, 188);
			this.lbPaymentID.Name = "lbPaymentID";
			this.lbPaymentID.Size = new System.Drawing.Size(31, 21);
			this.lbPaymentID.TabIndex = 105;
			this.lbPaymentID.Text = "???";
			// 
			// button13
			// 
			this.button13.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_card_payment;
			this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button13.Location = new System.Drawing.Point(644, 179);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(35, 38);
			this.button13.TabIndex = 104;
			this.button13.TabStop = false;
			this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button13.UseVisualStyleBackColor = true;
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label34.Location = new System.Drawing.Point(537, 186);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(111, 25);
			this.label34.TabIndex = 103;
			this.label34.Text = "Payment ID:";
			// 
			// lbDateOfBooking
			// 
			this.lbDateOfBooking.AutoSize = true;
			this.lbDateOfBooking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDateOfBooking.ForeColor = System.Drawing.Color.Black;
			this.lbDateOfBooking.Location = new System.Drawing.Point(992, 244);
			this.lbDateOfBooking.Name = "lbDateOfBooking";
			this.lbDateOfBooking.Size = new System.Drawing.Size(78, 21);
			this.lbDateOfBooking.TabIndex = 99;
			this.lbDateOfBooking.Text = "1/9/2024";
			// 
			// button5
			// 
			this.button5.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_schedule1;
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button5.Location = new System.Drawing.Point(951, 235);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(35, 38);
			this.button5.TabIndex = 98;
			this.button5.TabStop = false;
			this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button5.UseVisualStyleBackColor = true;
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label30.Location = new System.Drawing.Point(801, 242);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(154, 25);
			this.label30.TabIndex = 97;
			this.label30.Text = "Date Of Booking:";
			// 
			// lbDateOfIssue
			// 
			this.lbDateOfIssue.AutoSize = true;
			this.lbDateOfIssue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDateOfIssue.ForeColor = System.Drawing.Color.Black;
			this.lbDateOfIssue.Location = new System.Drawing.Point(684, 307);
			this.lbDateOfIssue.Name = "lbDateOfIssue";
			this.lbDateOfIssue.Size = new System.Drawing.Size(151, 21);
			this.lbDateOfIssue.TabIndex = 96;
			this.lbDateOfIssue.Text = "1/9/2024 11:48 PM";
			// 
			// button4
			// 
			this.button4.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_schedule;
			this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button4.Location = new System.Drawing.Point(643, 298);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(35, 38);
			this.button4.TabIndex = 95;
			this.button4.TabStop = false;
			this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button4.UseVisualStyleBackColor = true;
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label27.Location = new System.Drawing.Point(520, 305);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(127, 25);
			this.label27.TabIndex = 94;
			this.label27.Text = "Date Of Issue:";
			// 
			// lbBookingStatus
			// 
			this.lbBookingStatus.AutoSize = true;
			this.lbBookingStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbBookingStatus.ForeColor = System.Drawing.Color.Black;
			this.lbBookingStatus.Location = new System.Drawing.Point(692, 244);
			this.lbBookingStatus.Name = "lbBookingStatus";
			this.lbBookingStatus.Size = new System.Drawing.Size(31, 21);
			this.lbBookingStatus.TabIndex = 93;
			this.lbBookingStatus.Text = "???";
			// 
			// button3
			// 
			this.button3.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_autograph_1;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button3.Location = new System.Drawing.Point(643, 237);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(35, 34);
			this.button3.TabIndex = 92;
			this.button3.TabStop = false;
			this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button3.UseVisualStyleBackColor = true;
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label28.Location = new System.Drawing.Point(499, 242);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(140, 25);
			this.label28.TabIndex = 91;
			this.label28.Text = "Booking Status:";
			// 
			// lbFacilityID
			// 
			this.lbFacilityID.AutoSize = true;
			this.lbFacilityID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFacilityID.ForeColor = System.Drawing.Color.Black;
			this.lbFacilityID.Location = new System.Drawing.Point(992, 132);
			this.lbFacilityID.Name = "lbFacilityID";
			this.lbFacilityID.Size = new System.Drawing.Size(31, 21);
			this.lbFacilityID.TabIndex = 87;
			this.lbFacilityID.Text = "???";
			// 
			// button2
			// 
			this.button2.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_token_card_code;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button2.Location = new System.Drawing.Point(950, 123);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(35, 38);
			this.button2.TabIndex = 86;
			this.button2.TabStop = false;
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label31.Location = new System.Drawing.Point(857, 130);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(96, 25);
			this.label31.TabIndex = 85;
			this.label31.Text = "Facility ID:";
			// 
			// lbBookingID
			// 
			this.lbBookingID.AutoSize = true;
			this.lbBookingID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbBookingID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lbBookingID.Location = new System.Drawing.Point(685, 80);
			this.lbBookingID.Name = "lbBookingID";
			this.lbBookingID.Size = new System.Drawing.Size(31, 21);
			this.lbBookingID.TabIndex = 84;
			this.lbBookingID.Text = "???";
			// 
			// label39
			// 
			this.label39.AutoSize = true;
			this.label39.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label39.Location = new System.Drawing.Point(540, 76);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(108, 25);
			this.label39.TabIndex = 82;
			this.label39.Text = "Booking ID:";
			// 
			// button12
			// 
			this.button12.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_booking;
			this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button12.Location = new System.Drawing.Point(644, 71);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(35, 34);
			this.button12.TabIndex = 83;
			this.button12.TabStop = false;
			this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button12.UseVisualStyleBackColor = true;
			// 
			// lbTime
			// 
			this.lbTime.AutoSize = true;
			this.lbTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTime.ForeColor = System.Drawing.Color.Black;
			this.lbTime.Location = new System.Drawing.Point(683, 362);
			this.lbTime.Name = "lbTime";
			this.lbTime.Size = new System.Drawing.Size(36, 25);
			this.lbTime.TabIndex = 112;
			this.lbTime.Text = "???";
			// 
			// button10
			// 
			this.button10.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_time1;
			this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button10.Location = new System.Drawing.Point(644, 356);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(35, 34);
			this.button10.TabIndex = 111;
			this.button10.TabStop = false;
			this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button10.UseVisualStyleBackColor = true;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(588, 362);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(57, 25);
			this.label15.TabIndex = 110;
			this.label15.Text = "Time:";
			// 
			// btnDelete
			// 
			this.btnDelete.Animated = true;
			this.btnDelete.BorderRadius = 18;
			this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnDelete.FillColor = System.Drawing.Color.Silver;
			this.btnDelete.FillColor2 = System.Drawing.Color.DarkRed;
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Image = global::PresentationLayer.Properties.Resources.icons8_cancel;
			this.btnDelete.Location = new System.Drawing.Point(675, 476);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(252, 45);
			this.btnDelete.TabIndex = 113;
			this.btnDelete.Text = "Delete";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// frmDeleteBooking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1103, 620);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.lbTime);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.lbViewPayment);
			this.Controls.Add(this.lbFacilityName);
			this.Controls.Add(this.button16);
			this.Controls.Add(this.label29);
			this.Controls.Add(this.lbPaymentID);
			this.Controls.Add(this.button13);
			this.Controls.Add(this.label34);
			this.Controls.Add(this.lbDateOfBooking);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.label30);
			this.Controls.Add(this.lbDateOfIssue);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label27);
			this.Controls.Add(this.lbBookingStatus);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label28);
			this.Controls.Add(this.lbFacilityID);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label31);
			this.Controls.Add(this.lbBookingID);
			this.Controls.Add(this.label39);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.lbCustomerID);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.plTopBar);
			this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "frmDeleteBooking";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmDeleteBooking";
			this.plTopBar.ResumeLayout(false);
			this.plTopBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel plTopBar;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.PictureBox pbClose;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbCustomerID;
		private System.Windows.Forms.Label lbName;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Label lbViewPayment;
		private System.Windows.Forms.Label lbFacilityName;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label lbPaymentID;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label lbDateOfBooking;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label lbDateOfIssue;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label lbBookingStatus;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label lbFacilityID;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label lbBookingID;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Label lbTime;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Label label15;
		private Guna.UI2.WinForms.Guna2GradientButton btnDelete;
	}
}