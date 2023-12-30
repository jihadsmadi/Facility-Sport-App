namespace PresentationLayer
{
	partial class frmDeleteCustomer
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.plContiner = new System.Windows.Forms.Panel();
			this.plDeleteCustomer = new System.Windows.Forms.Panel();
			this.plSubContainer = new System.Windows.Forms.Panel();
			this.plFirstPage = new System.Windows.Forms.Panel();
			this.plPersonalInfo = new Guna.UI2.WinForms.Guna2Panel();
			this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
			this.lbMemberShipStatus = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.lbCustomerID = new System.Windows.Forms.Label();
			this.button7 = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.btnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
			this.lbPhone = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.lbAddressInPersonalInfo = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			this.label15 = new System.Windows.Forms.Label();
			this.lbNationalNoInPersonalInfo = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.lbNameInPersonalInfp = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.lbPerosnIDInPersonalInfo = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.btnFind = new System.Windows.Forms.Button();
			this.tbFindBy = new Guna.UI2.WinForms.Guna2TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.plTopBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.plContiner.SuspendLayout();
			this.plDeleteCustomer.SuspendLayout();
			this.plSubContainer.SuspendLayout();
			this.plFirstPage.SuspendLayout();
			this.plPersonalInfo.SuspendLayout();
			this.panel3.SuspendLayout();
			this.guna2Panel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// plTopBar
			// 
			this.plTopBar.BackColor = System.Drawing.Color.DeepPink;
			this.plTopBar.Controls.Add(this.label1);
			this.plTopBar.Controls.Add(this.pictureBox1);
			this.plTopBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.plTopBar.Location = new System.Drawing.Point(0, 0);
			this.plTopBar.Name = "plTopBar";
			this.plTopBar.Size = new System.Drawing.Size(898, 47);
			this.plTopBar.TabIndex = 2;
			this.plTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseDown);
			this.plTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseMove);
			this.plTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseUp);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(222, 31);
			this.label1.TabIndex = 3;
			this.label1.Text = "Delete a customer";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.icons8_close_208px;
			this.pictureBox1.Location = new System.Drawing.Point(855, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(43, 47);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// plContiner
			// 
			this.plContiner.Controls.Add(this.plDeleteCustomer);
			this.plContiner.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plContiner.Location = new System.Drawing.Point(0, 47);
			this.plContiner.Name = "plContiner";
			this.plContiner.Size = new System.Drawing.Size(898, 613);
			this.plContiner.TabIndex = 3;
			// 
			// plDeleteCustomer
			// 
			this.plDeleteCustomer.BackColor = System.Drawing.Color.White;
			this.plDeleteCustomer.Controls.Add(this.plSubContainer);
			this.plDeleteCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plDeleteCustomer.Location = new System.Drawing.Point(0, 0);
			this.plDeleteCustomer.Name = "plDeleteCustomer";
			this.plDeleteCustomer.Size = new System.Drawing.Size(898, 613);
			this.plDeleteCustomer.TabIndex = 0;
			// 
			// plSubContainer
			// 
			this.plSubContainer.Controls.Add(this.plFirstPage);
			this.plSubContainer.Location = new System.Drawing.Point(51, 55);
			this.plSubContainer.Name = "plSubContainer";
			this.plSubContainer.Size = new System.Drawing.Size(796, 502);
			this.plSubContainer.TabIndex = 8;
			// 
			// plFirstPage
			// 
			this.plFirstPage.Controls.Add(this.plPersonalInfo);
			this.plFirstPage.Controls.Add(this.guna2Panel1);
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
			this.plPersonalInfo.Controls.Add(this.btnBack);
			this.plPersonalInfo.Controls.Add(this.lbMemberShipStatus);
			this.plPersonalInfo.Controls.Add(this.button4);
			this.plPersonalInfo.Controls.Add(this.label12);
			this.plPersonalInfo.Controls.Add(this.lbCustomerID);
			this.plPersonalInfo.Controls.Add(this.button7);
			this.plPersonalInfo.Controls.Add(this.label16);
			this.plPersonalInfo.Controls.Add(this.btnDelete);
			this.plPersonalInfo.Controls.Add(this.lbPhone);
			this.plPersonalInfo.Controls.Add(this.button5);
			this.plPersonalInfo.Controls.Add(this.label13);
			this.plPersonalInfo.Controls.Add(this.lbAddressInPersonalInfo);
			this.plPersonalInfo.Controls.Add(this.button6);
			this.plPersonalInfo.Controls.Add(this.label15);
			this.plPersonalInfo.Controls.Add(this.lbNationalNoInPersonalInfo);
			this.plPersonalInfo.Controls.Add(this.button3);
			this.plPersonalInfo.Controls.Add(this.label9);
			this.plPersonalInfo.Controls.Add(this.lbNameInPersonalInfp);
			this.plPersonalInfo.Controls.Add(this.button2);
			this.plPersonalInfo.Controls.Add(this.label7);
			this.plPersonalInfo.Controls.Add(this.lbPerosnIDInPersonalInfo);
			this.plPersonalInfo.Controls.Add(this.button1);
			this.plPersonalInfo.Controls.Add(this.label4);
			this.plPersonalInfo.Controls.Add(this.panel3);
			this.plPersonalInfo.Location = new System.Drawing.Point(0, 143);
			this.plPersonalInfo.Name = "plPersonalInfo";
			this.plPersonalInfo.Size = new System.Drawing.Size(796, 359);
			this.plPersonalInfo.TabIndex = 10;
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
			this.btnBack.Location = new System.Drawing.Point(248, 257);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(128, 34);
			this.btnBack.TabIndex = 34;
			this.btnBack.Text = "Back";
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// lbMemberShipStatus
			// 
			this.lbMemberShipStatus.AutoSize = true;
			this.lbMemberShipStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMemberShipStatus.ForeColor = System.Drawing.Color.Black;
			this.lbMemberShipStatus.Location = new System.Drawing.Point(646, 99);
			this.lbMemberShipStatus.Name = "lbMemberShipStatus";
			this.lbMemberShipStatus.Size = new System.Drawing.Size(36, 25);
			this.lbMemberShipStatus.TabIndex = 33;
			this.lbMemberShipStatus.Text = "???";
			// 
			// button4
			// 
			this.button4.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_membership_card;
			this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button4.Location = new System.Drawing.Point(594, 93);
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
			this.label12.Location = new System.Drawing.Point(404, 97);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(184, 25);
			this.label12.TabIndex = 30;
			this.label12.Text = "Member Ship Status:";
			// 
			// lbCustomerID
			// 
			this.lbCustomerID.AutoSize = true;
			this.lbCustomerID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCustomerID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lbCustomerID.Location = new System.Drawing.Point(646, 55);
			this.lbCustomerID.Name = "lbCustomerID";
			this.lbCustomerID.Size = new System.Drawing.Size(36, 25);
			this.lbCustomerID.TabIndex = 29;
			this.lbCustomerID.Text = "???";
			// 
			// button7
			// 
			this.button7.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_id_button;
			this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button7.Location = new System.Drawing.Point(594, 51);
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
			this.label16.Location = new System.Drawing.Point(481, 55);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(115, 25);
			this.label16.TabIndex = 27;
			this.label16.Text = "CustomerID:";
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
			this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Image = global::PresentationLayer.Properties.Resources.icons8_remove;
			this.btnDelete.Location = new System.Drawing.Point(401, 257);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(128, 34);
			this.btnDelete.TabIndex = 24;
			this.btnDelete.Text = "Delete";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// lbPhone
			// 
			this.lbPhone.AutoSize = true;
			this.lbPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPhone.ForeColor = System.Drawing.Color.Black;
			this.lbPhone.Location = new System.Drawing.Point(646, 148);
			this.lbPhone.Name = "lbPhone";
			this.lbPhone.Size = new System.Drawing.Size(36, 25);
			this.lbPhone.TabIndex = 21;
			this.lbPhone.Text = "???";
			// 
			// button5
			// 
			this.button5.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_phone;
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button5.Location = new System.Drawing.Point(594, 145);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(35, 34);
			this.button5.TabIndex = 20;
			this.button5.TabStop = false;
			this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button5.UseVisualStyleBackColor = true;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(505, 148);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(70, 25);
			this.label13.TabIndex = 19;
			this.label13.Text = "Phone:";
			// 
			// lbAddressInPersonalInfo
			// 
			this.lbAddressInPersonalInfo.AutoSize = true;
			this.lbAddressInPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAddressInPersonalInfo.ForeColor = System.Drawing.Color.Black;
			this.lbAddressInPersonalInfo.Location = new System.Drawing.Point(185, 182);
			this.lbAddressInPersonalInfo.Name = "lbAddressInPersonalInfo";
			this.lbAddressInPersonalInfo.Size = new System.Drawing.Size(36, 25);
			this.lbAddressInPersonalInfo.TabIndex = 18;
			this.lbAddressInPersonalInfo.Text = "???";
			// 
			// button6
			// 
			this.button6.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_address;
			this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button6.Location = new System.Drawing.Point(133, 178);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(35, 38);
			this.button6.TabIndex = 17;
			this.button6.TabStop = false;
			this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button6.UseVisualStyleBackColor = true;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(31, 182);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(83, 25);
			this.label15.TabIndex = 16;
			this.label15.Text = "Address:";
			// 
			// lbNationalNoInPersonalInfo
			// 
			this.lbNationalNoInPersonalInfo.AutoSize = true;
			this.lbNationalNoInPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNationalNoInPersonalInfo.ForeColor = System.Drawing.Color.Black;
			this.lbNationalNoInPersonalInfo.Location = new System.Drawing.Point(185, 135);
			this.lbNationalNoInPersonalInfo.Name = "lbNationalNoInPersonalInfo";
			this.lbNationalNoInPersonalInfo.Size = new System.Drawing.Size(36, 25);
			this.lbNationalNoInPersonalInfo.TabIndex = 15;
			this.lbNationalNoInPersonalInfo.Text = "???";
			// 
			// button3
			// 
			this.button3.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_Mobile_Id_Verification;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button3.Location = new System.Drawing.Point(133, 135);
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
			this.label9.Location = new System.Drawing.Point(9, 134);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(118, 25);
			this.label9.TabIndex = 13;
			this.label9.Text = "National No:";
			// 
			// lbNameInPersonalInfp
			// 
			this.lbNameInPersonalInfp.AutoSize = true;
			this.lbNameInPersonalInfp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNameInPersonalInfp.ForeColor = System.Drawing.Color.Black;
			this.lbNameInPersonalInfp.Location = new System.Drawing.Point(185, 95);
			this.lbNameInPersonalInfp.Name = "lbNameInPersonalInfp";
			this.lbNameInPersonalInfp.Size = new System.Drawing.Size(36, 25);
			this.lbNameInPersonalInfp.TabIndex = 12;
			this.lbNameInPersonalInfp.Text = "???";
			// 
			// button2
			// 
			this.button2.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_name;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button2.Location = new System.Drawing.Point(133, 90);
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
			this.label7.Location = new System.Drawing.Point(61, 97);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(66, 25);
			this.label7.TabIndex = 10;
			this.label7.Text = "Name:";
			// 
			// lbPerosnIDInPersonalInfo
			// 
			this.lbPerosnIDInPersonalInfo.AutoSize = true;
			this.lbPerosnIDInPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPerosnIDInPersonalInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lbPerosnIDInPersonalInfo.Location = new System.Drawing.Point(185, 55);
			this.lbPerosnIDInPersonalInfo.Name = "lbPerosnIDInPersonalInfo";
			this.lbPerosnIDInPersonalInfo.Size = new System.Drawing.Size(36, 25);
			this.lbPerosnIDInPersonalInfo.TabIndex = 9;
			this.lbPerosnIDInPersonalInfo.Text = "???";
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_id_button;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button1.Location = new System.Drawing.Point(133, 51);
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
			this.label4.Location = new System.Drawing.Point(31, 55);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 25);
			this.label4.TabIndex = 5;
			this.label4.Text = "Person ID:";
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
			this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(14, 6);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(196, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "Customer information";
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BackColor = System.Drawing.Color.White;
			this.guna2Panel1.BorderColor = System.Drawing.Color.Gainsboro;
			this.guna2Panel1.BorderThickness = 2;
			this.guna2Panel1.Controls.Add(this.btnFind);
			this.guna2Panel1.Controls.Add(this.tbFindBy);
			this.guna2Panel1.Controls.Add(this.label3);
			this.guna2Panel1.Controls.Add(this.panel1);
			this.guna2Panel1.Location = new System.Drawing.Point(0, 2);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(796, 114);
			this.guna2Panel1.TabIndex = 11;
			// 
			// btnFind
			// 
			this.btnFind.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_find_user_male_skin_type_7;
			this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnFind.Location = new System.Drawing.Point(593, 54);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(44, 36);
			this.btnFind.TabIndex = 7;
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// tbFindBy
			// 
			this.tbFindBy.BorderRadius = 15;
			this.tbFindBy.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbFindBy.DefaultText = "";
			this.tbFindBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbFindBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbFindBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbFindBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbFindBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbFindBy.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbFindBy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbFindBy.Location = new System.Drawing.Point(327, 54);
			this.tbFindBy.Name = "tbFindBy";
			this.tbFindBy.PasswordChar = '\0';
			this.tbFindBy.PlaceholderText = "";
			this.tbFindBy.SelectedText = "";
			this.tbFindBy.Size = new System.Drawing.Size(230, 36);
			this.tbFindBy.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(126, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(186, 25);
			this.label3.TabIndex = 5;
			this.label3.Text = "Find By Customer ID:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gainsboro;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(796, 35);
			this.panel1.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(14, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Filter";
			// 
			// frmDeleteCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(898, 660);
			this.Controls.Add(this.plContiner);
			this.Controls.Add(this.plTopBar);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmDeleteCustomer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmDeleteCustomer";
			this.plTopBar.ResumeLayout(false);
			this.plTopBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.plContiner.ResumeLayout(false);
			this.plDeleteCustomer.ResumeLayout(false);
			this.plSubContainer.ResumeLayout(false);
			this.plFirstPage.ResumeLayout(false);
			this.plPersonalInfo.ResumeLayout(false);
			this.plPersonalInfo.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel plTopBar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel plContiner;
		private System.Windows.Forms.Panel plDeleteCustomer;
		private System.Windows.Forms.Panel plSubContainer;
		private System.Windows.Forms.Panel plFirstPage;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private System.Windows.Forms.Button btnFind;
		private Guna.UI2.WinForms.Guna2TextBox tbFindBy;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2Panel plPersonalInfo;
		private System.Windows.Forms.Label lbMemberShipStatus;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label lbCustomerID;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Label label16;
		private Guna.UI2.WinForms.Guna2GradientButton btnDelete;
		private System.Windows.Forms.Label lbPhone;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label lbAddressInPersonalInfo;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label lbNationalNoInPersonalInfo;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lbNameInPersonalInfp;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lbPerosnIDInPersonalInfo;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private Guna.UI2.WinForms.Guna2GradientButton btnBack;
	}
}