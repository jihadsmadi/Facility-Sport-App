namespace PresentationLayer
{
	partial class frmAddNewCustomer
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.plContaner = new System.Windows.Forms.Panel();
			this.plSubContainer = new System.Windows.Forms.Panel();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.btnFind = new System.Windows.Forms.Button();
			this.tbFindBy = new Guna.UI2.WinForms.Guna2TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.plPersonalInfo = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
			this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
			this.btnNext = new Guna.UI2.WinForms.Guna2GradientButton();
			this.label6 = new System.Windows.Forms.Label();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.lbPhoneInPersonalInfo = new System.Windows.Forms.Label();
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
			this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.plCustomerInfoTopBar = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.plPersonInfoTopBar = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.plTopBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.plContaner.SuspendLayout();
			this.plSubContainer.SuspendLayout();
			this.guna2Panel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.plPersonalInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.panel3.SuspendLayout();
			this.guna2GradientPanel1.SuspendLayout();
			this.plCustomerInfoTopBar.SuspendLayout();
			this.plPersonInfoTopBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// plTopBar
			// 
			this.plTopBar.BackColor = System.Drawing.Color.SkyBlue;
			this.plTopBar.Controls.Add(this.pictureBox1);
			this.plTopBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.plTopBar.Location = new System.Drawing.Point(0, 0);
			this.plTopBar.Name = "plTopBar";
			this.plTopBar.Size = new System.Drawing.Size(898, 28);
			this.plTopBar.TabIndex = 0;
			this.plTopBar.Paint += new System.Windows.Forms.PaintEventHandler(this.plTopBar_Paint);
			this.plTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseDown);
			this.plTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseMove);
			this.plTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseUp);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.icons8_close_208px;
			this.pictureBox1.Location = new System.Drawing.Point(855, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(43, 28);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(330, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(285, 36);
			this.label1.TabIndex = 1;
			this.label1.Text = "Add New Customer";
			// 
			// plContaner
			// 
			this.plContaner.BackColor = System.Drawing.Color.White;
			this.plContaner.Controls.Add(this.plSubContainer);
			this.plContaner.Controls.Add(this.guna2GradientPanel1);
			this.plContaner.Controls.Add(this.label1);
			this.plContaner.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plContaner.Location = new System.Drawing.Point(0, 28);
			this.plContaner.Name = "plContaner";
			this.plContaner.Size = new System.Drawing.Size(898, 660);
			this.plContaner.TabIndex = 1;
			// 
			// plSubContainer
			// 
			this.plSubContainer.Controls.Add(this.guna2Panel1);
			this.plSubContainer.Controls.Add(this.plPersonalInfo);
			this.plSubContainer.Location = new System.Drawing.Point(42, 146);
			this.plSubContainer.Name = "plSubContainer";
			this.plSubContainer.Size = new System.Drawing.Size(796, 502);
			this.plSubContainer.TabIndex = 7;
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BackColor = System.Drawing.Color.White;
			this.guna2Panel1.BorderColor = System.Drawing.Color.Gainsboro;
			this.guna2Panel1.BorderThickness = 2;
			this.guna2Panel1.Controls.Add(this.btnAddNew);
			this.guna2Panel1.Controls.Add(this.btnFind);
			this.guna2Panel1.Controls.Add(this.tbFindBy);
			this.guna2Panel1.Controls.Add(this.label3);
			this.guna2Panel1.Controls.Add(this.panel1);
			this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(796, 114);
			this.guna2Panel1.TabIndex = 7;
			// 
			// btnAddNew
			// 
			this.btnAddNew.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_add_user_male_skin_type_7;
			this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnAddNew.Location = new System.Drawing.Point(581, 55);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(44, 36);
			this.btnAddNew.TabIndex = 8;
			this.btnAddNew.TabStop = false;
			this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAddNew.UseVisualStyleBackColor = true;
			this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
			// 
			// btnFind
			// 
			this.btnFind.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_find_user_male_skin_type_7;
			this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnFind.Location = new System.Drawing.Point(520, 54);
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
			this.tbFindBy.Location = new System.Drawing.Point(254, 54);
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
			this.label3.Location = new System.Drawing.Point(70, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(162, 25);
			this.label3.TabIndex = 5;
			this.label3.Text = "Find By Person ID:";
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
			// plPersonalInfo
			// 
			this.plPersonalInfo.BackColor = System.Drawing.Color.White;
			this.plPersonalInfo.BorderColor = System.Drawing.Color.Gainsboro;
			this.plPersonalInfo.BorderThickness = 2;
			this.plPersonalInfo.Controls.Add(this.guna2GradientButton3);
			this.plPersonalInfo.Controls.Add(this.guna2GradientButton2);
			this.plPersonalInfo.Controls.Add(this.btnNext);
			this.plPersonalInfo.Controls.Add(this.label6);
			this.plPersonalInfo.Controls.Add(this.guna2PictureBox1);
			this.plPersonalInfo.Controls.Add(this.lbPhoneInPersonalInfo);
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
			this.plPersonalInfo.Location = new System.Drawing.Point(0, 120);
			this.plPersonalInfo.Name = "plPersonalInfo";
			this.plPersonalInfo.Size = new System.Drawing.Size(796, 379);
			this.plPersonalInfo.TabIndex = 6;
			// 
			// guna2GradientButton3
			// 
			this.guna2GradientButton3.Animated = true;
			this.guna2GradientButton3.BorderRadius = 18;
			this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
			this.guna2GradientButton3.Image = global::PresentationLayer.Properties.Resources.icons8_cancel;
			this.guna2GradientButton3.Location = new System.Drawing.Point(458, 320);
			this.guna2GradientButton3.Name = "guna2GradientButton3";
			this.guna2GradientButton3.Size = new System.Drawing.Size(128, 34);
			this.guna2GradientButton3.TabIndex = 26;
			this.guna2GradientButton3.Text = "Close";
			// 
			// guna2GradientButton2
			// 
			this.guna2GradientButton2.Animated = true;
			this.guna2GradientButton2.BorderRadius = 18;
			this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2GradientButton2.Enabled = false;
			this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
			this.guna2GradientButton2.Image = global::PresentationLayer.Properties.Resources.icons8_save_3;
			this.guna2GradientButton2.Location = new System.Drawing.Point(611, 320);
			this.guna2GradientButton2.Name = "guna2GradientButton2";
			this.guna2GradientButton2.Size = new System.Drawing.Size(128, 34);
			this.guna2GradientButton2.TabIndex = 25;
			this.guna2GradientButton2.Text = "  Save";
			// 
			// btnNext
			// 
			this.btnNext.Animated = true;
			this.btnNext.BorderRadius = 18;
			this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnNext.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnNext.ForeColor = System.Drawing.Color.White;
			this.btnNext.Image = global::PresentationLayer.Properties.Resources.icons8_double_right;
			this.btnNext.Location = new System.Drawing.Point(611, 271);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(128, 34);
			this.btnNext.TabIndex = 24;
			this.btnNext.Text = "Next";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label6.Location = new System.Drawing.Point(545, 50);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(154, 25);
			this.label6.TabIndex = 23;
			this.label6.Text = "Edit Person Info";
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.Image = global::PresentationLayer.Properties.Resources.run_icon_27088_163;
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Location = new System.Drawing.Point(472, 87);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new System.Drawing.Size(300, 200);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox1.TabIndex = 22;
			this.guna2PictureBox1.TabStop = false;
			// 
			// lbPhoneInPersonalInfo
			// 
			this.lbPhoneInPersonalInfo.AutoSize = true;
			this.lbPhoneInPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPhoneInPersonalInfo.ForeColor = System.Drawing.Color.Black;
			this.lbPhoneInPersonalInfo.Location = new System.Drawing.Point(224, 240);
			this.lbPhoneInPersonalInfo.Name = "lbPhoneInPersonalInfo";
			this.lbPhoneInPersonalInfo.Size = new System.Drawing.Size(39, 25);
			this.lbPhoneInPersonalInfo.TabIndex = 21;
			this.lbPhoneInPersonalInfo.Text = "???";
			// 
			// button5
			// 
			this.button5.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_phone;
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button5.Location = new System.Drawing.Point(172, 240);
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
			this.label13.Location = new System.Drawing.Point(83, 237);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(70, 25);
			this.label13.TabIndex = 19;
			this.label13.Text = "Phone:";
			// 
			// lbAddressInPersonalInfo
			// 
			this.lbAddressInPersonalInfo.AutoSize = true;
			this.lbAddressInPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAddressInPersonalInfo.Location = new System.Drawing.Point(224, 200);
			this.lbAddressInPersonalInfo.Name = "lbAddressInPersonalInfo";
			this.lbAddressInPersonalInfo.Size = new System.Drawing.Size(39, 25);
			this.lbAddressInPersonalInfo.TabIndex = 18;
			this.lbAddressInPersonalInfo.Text = "???";
			// 
			// button6
			// 
			this.button6.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_address;
			this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button6.Location = new System.Drawing.Point(172, 196);
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
			this.label15.Location = new System.Drawing.Point(70, 200);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(83, 25);
			this.label15.TabIndex = 16;
			this.label15.Text = "Address:";
			// 
			// lbNationalNoInPersonalInfo
			// 
			this.lbNationalNoInPersonalInfo.AutoSize = true;
			this.lbNationalNoInPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNationalNoInPersonalInfo.Location = new System.Drawing.Point(224, 153);
			this.lbNationalNoInPersonalInfo.Name = "lbNationalNoInPersonalInfo";
			this.lbNationalNoInPersonalInfo.Size = new System.Drawing.Size(39, 25);
			this.lbNationalNoInPersonalInfo.TabIndex = 15;
			this.lbNationalNoInPersonalInfo.Text = "???";
			// 
			// button3
			// 
			this.button3.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_Mobile_Id_Verification;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button3.Location = new System.Drawing.Point(172, 153);
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
			this.label9.Location = new System.Drawing.Point(48, 152);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(118, 25);
			this.label9.TabIndex = 13;
			this.label9.Text = "National No:";
			// 
			// lbNameInPersonalInfp
			// 
			this.lbNameInPersonalInfp.AutoSize = true;
			this.lbNameInPersonalInfp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNameInPersonalInfp.ForeColor = System.Drawing.Color.IndianRed;
			this.lbNameInPersonalInfp.Location = new System.Drawing.Point(224, 113);
			this.lbNameInPersonalInfp.Name = "lbNameInPersonalInfp";
			this.lbNameInPersonalInfp.Size = new System.Drawing.Size(36, 25);
			this.lbNameInPersonalInfp.TabIndex = 12;
			this.lbNameInPersonalInfp.Text = "???";
			// 
			// button2
			// 
			this.button2.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_name;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button2.Location = new System.Drawing.Point(172, 108);
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
			this.label7.Location = new System.Drawing.Point(100, 110);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(66, 25);
			this.label7.TabIndex = 10;
			this.label7.Text = "Name:";
			// 
			// lbPerosnIDInPersonalInfo
			// 
			this.lbPerosnIDInPersonalInfo.AutoSize = true;
			this.lbPerosnIDInPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPerosnIDInPersonalInfo.Location = new System.Drawing.Point(224, 73);
			this.lbPerosnIDInPersonalInfo.Name = "lbPerosnIDInPersonalInfo";
			this.lbPerosnIDInPersonalInfo.Size = new System.Drawing.Size(39, 25);
			this.lbPerosnIDInPersonalInfo.TabIndex = 9;
			this.lbPerosnIDInPersonalInfo.Text = "???";
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_id_button;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button1.Location = new System.Drawing.Point(172, 69);
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
			this.label4.Location = new System.Drawing.Point(70, 73);
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
			this.label5.Size = new System.Drawing.Size(194, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "Personal Inforamtions";
			// 
			// guna2GradientPanel1
			// 
			this.guna2GradientPanel1.Controls.Add(this.plCustomerInfoTopBar);
			this.guna2GradientPanel1.Controls.Add(this.plPersonInfoTopBar);
			this.guna2GradientPanel1.FillColor = System.Drawing.Color.WhiteSmoke;
			this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Gray;
			this.guna2GradientPanel1.Location = new System.Drawing.Point(21, 73);
			this.guna2GradientPanel1.Name = "guna2GradientPanel1";
			this.guna2GradientPanel1.Size = new System.Drawing.Size(842, 46);
			this.guna2GradientPanel1.TabIndex = 6;
			// 
			// plCustomerInfoTopBar
			// 
			this.plCustomerInfoTopBar.BackColor = System.Drawing.Color.Transparent;
			this.plCustomerInfoTopBar.Controls.Add(this.label10);
			this.plCustomerInfoTopBar.Location = new System.Drawing.Point(232, 0);
			this.plCustomerInfoTopBar.Name = "plCustomerInfoTopBar";
			this.plCustomerInfoTopBar.Size = new System.Drawing.Size(232, 43);
			this.plCustomerInfoTopBar.TabIndex = 1;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(49, 8);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(146, 25);
			this.label10.TabIndex = 0;
			this.label10.Text = "Customer Info";
			// 
			// plPersonInfoTopBar
			// 
			this.plPersonInfoTopBar.BackColor = System.Drawing.Color.SkyBlue;
			this.plPersonInfoTopBar.Controls.Add(this.label8);
			this.plPersonInfoTopBar.Location = new System.Drawing.Point(0, 0);
			this.plPersonInfoTopBar.Name = "plPersonInfoTopBar";
			this.plPersonInfoTopBar.Size = new System.Drawing.Size(232, 43);
			this.plPersonInfoTopBar.TabIndex = 0;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(56, 7);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(120, 25);
			this.label8.TabIndex = 0;
			this.label8.Text = "Person Info";
			// 
			// frmAddNewCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(898, 688);
			this.Controls.Add(this.plContaner);
			this.Controls.Add(this.plTopBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmAddNewCustomer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmAddNewCustomer";
			this.Load += new System.EventHandler(this.frmAddNewCustomer_Load);
			this.plTopBar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.plContaner.ResumeLayout(false);
			this.plContaner.PerformLayout();
			this.plSubContainer.ResumeLayout(false);
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.plPersonalInfo.ResumeLayout(false);
			this.plPersonalInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.guna2GradientPanel1.ResumeLayout(false);
			this.plCustomerInfoTopBar.ResumeLayout(false);
			this.plCustomerInfoTopBar.PerformLayout();
			this.plPersonInfoTopBar.ResumeLayout(false);
			this.plPersonInfoTopBar.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel plTopBar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel plContaner;
		private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
		private System.Windows.Forms.Panel plPersonInfoTopBar;
		private System.Windows.Forms.Panel plCustomerInfoTopBar;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel plSubContainer;
		private Guna.UI2.WinForms.Guna2Panel plPersonalInfo;
		private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
		private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
		private Guna.UI2.WinForms.Guna2GradientButton btnNext;
		private System.Windows.Forms.Label label6;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private System.Windows.Forms.Label lbPhoneInPersonalInfo;
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
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private System.Windows.Forms.Button btnAddNew;
		private System.Windows.Forms.Button btnFind;
		private Guna.UI2.WinForms.Guna2TextBox tbFindBy;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
	}
}