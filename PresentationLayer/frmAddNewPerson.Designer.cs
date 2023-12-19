namespace PresentationLayer
{
	partial class frmAddNewPerson
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.plPersonalInfo = new Guna.UI2.WinForms.Guna2Panel();
			this.plPersonGroub = new System.Windows.Forms.Panel();
			this.lbPersonIDInAddNewPerson = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.tbPhone = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbAddress = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbNID = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbLastName = new Guna.UI2.WinForms.Guna2TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbFirstName = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
			this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.button5 = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			this.label15 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.lbAddOrUpdate = new System.Windows.Forms.Label();
			this.plTopBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.plPersonalInfo.SuspendLayout();
			this.plPersonGroub.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.panel3.SuspendLayout();
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
			this.plTopBar.TabIndex = 1;
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
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.plPersonalInfo);
			this.panel1.Controls.Add(this.lbAddOrUpdate);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 28);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(898, 632);
			this.panel1.TabIndex = 2;
			// 
			// plPersonalInfo
			// 
			this.plPersonalInfo.BackColor = System.Drawing.Color.White;
			this.plPersonalInfo.BorderColor = System.Drawing.Color.Gainsboro;
			this.plPersonalInfo.BorderThickness = 2;
			this.plPersonalInfo.Controls.Add(this.plPersonGroub);
			this.plPersonalInfo.Controls.Add(this.tbPhone);
			this.plPersonalInfo.Controls.Add(this.tbAddress);
			this.plPersonalInfo.Controls.Add(this.tbNID);
			this.plPersonalInfo.Controls.Add(this.tbLastName);
			this.plPersonalInfo.Controls.Add(this.button1);
			this.plPersonalInfo.Controls.Add(this.label1);
			this.plPersonalInfo.Controls.Add(this.tbFirstName);
			this.plPersonalInfo.Controls.Add(this.btnClose);
			this.plPersonalInfo.Controls.Add(this.btnSave);
			this.plPersonalInfo.Controls.Add(this.guna2PictureBox1);
			this.plPersonalInfo.Controls.Add(this.button5);
			this.plPersonalInfo.Controls.Add(this.label13);
			this.plPersonalInfo.Controls.Add(this.button6);
			this.plPersonalInfo.Controls.Add(this.label15);
			this.plPersonalInfo.Controls.Add(this.button3);
			this.plPersonalInfo.Controls.Add(this.label9);
			this.plPersonalInfo.Controls.Add(this.button2);
			this.plPersonalInfo.Controls.Add(this.label7);
			this.plPersonalInfo.Controls.Add(this.panel3);
			this.plPersonalInfo.ForeColor = System.Drawing.Color.Black;
			this.plPersonalInfo.Location = new System.Drawing.Point(51, 127);
			this.plPersonalInfo.Name = "plPersonalInfo";
			this.plPersonalInfo.Size = new System.Drawing.Size(796, 379);
			this.plPersonalInfo.TabIndex = 7;
			// 
			// plPersonGroub
			// 
			this.plPersonGroub.Controls.Add(this.lbPersonIDInAddNewPerson);
			this.plPersonGroub.Controls.Add(this.button4);
			this.plPersonGroub.Controls.Add(this.label4);
			this.plPersonGroub.Location = new System.Drawing.Point(36, 54);
			this.plPersonGroub.Name = "plPersonGroub";
			this.plPersonGroub.Size = new System.Drawing.Size(244, 37);
			this.plPersonGroub.TabIndex = 33;
			// 
			// lbPersonIDInAddNewPerson
			// 
			this.lbPersonIDInAddNewPerson.AutoSize = true;
			this.lbPersonIDInAddNewPerson.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPersonIDInAddNewPerson.Location = new System.Drawing.Point(184, 5);
			this.lbPersonIDInAddNewPerson.Name = "lbPersonIDInAddNewPerson";
			this.lbPersonIDInAddNewPerson.Size = new System.Drawing.Size(39, 25);
			this.lbPersonIDInAddNewPerson.TabIndex = 35;
			this.lbPersonIDInAddNewPerson.Text = "???";
			// 
			// button4
			// 
			this.button4.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_id_button;
			this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button4.Location = new System.Drawing.Point(136, 1);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(35, 34);
			this.button4.TabIndex = 34;
			this.button4.TabStop = false;
			this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button4.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(21, 5);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 25);
			this.label4.TabIndex = 33;
			this.label4.Text = "Person ID:";
			// 
			// tbPhone
			// 
			this.tbPhone.BackColor = System.Drawing.Color.Transparent;
			this.tbPhone.BorderColor = System.Drawing.SystemColors.ControlDark;
			this.tbPhone.BorderRadius = 8;
			this.tbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbPhone.DefaultText = "";
			this.tbPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbPhone.ForeColor = System.Drawing.Color.Black;
			this.tbPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbPhone.Location = new System.Drawing.Point(225, 275);
			this.tbPhone.Name = "tbPhone";
			this.tbPhone.PasswordChar = '\0';
			this.tbPhone.PlaceholderText = "Enter Your Phone Number";
			this.tbPhone.SelectedText = "";
			this.tbPhone.Size = new System.Drawing.Size(232, 36);
			this.tbPhone.TabIndex = 5;
			// 
			// tbAddress
			// 
			this.tbAddress.Animated = true;
			this.tbAddress.BackColor = System.Drawing.Color.Transparent;
			this.tbAddress.BorderColor = System.Drawing.SystemColors.ControlDark;
			this.tbAddress.BorderRadius = 8;
			this.tbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbAddress.DefaultText = "";
			this.tbAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbAddress.ForeColor = System.Drawing.Color.Black;
			this.tbAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbAddress.Location = new System.Drawing.Point(225, 230);
			this.tbAddress.Name = "tbAddress";
			this.tbAddress.PasswordChar = '\0';
			this.tbAddress.PlaceholderText = "Enter your address";
			this.tbAddress.SelectedText = "";
			this.tbAddress.Size = new System.Drawing.Size(232, 36);
			this.tbAddress.TabIndex = 4;
			// 
			// tbNID
			// 
			this.tbNID.Animated = true;
			this.tbNID.BackColor = System.Drawing.Color.Transparent;
			this.tbNID.BorderColor = System.Drawing.SystemColors.ControlDark;
			this.tbNID.BorderRadius = 8;
			this.tbNID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbNID.DefaultText = "";
			this.tbNID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbNID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbNID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbNID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbNID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbNID.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbNID.ForeColor = System.Drawing.Color.Black;
			this.tbNID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbNID.Location = new System.Drawing.Point(225, 185);
			this.tbNID.Name = "tbNID";
			this.tbNID.PasswordChar = '\0';
			this.tbNID.PlaceholderText = "National Identification";
			this.tbNID.SelectedText = "";
			this.tbNID.Size = new System.Drawing.Size(232, 36);
			this.tbNID.TabIndex = 3;
			// 
			// tbLastName
			// 
			this.tbLastName.Animated = true;
			this.tbLastName.BackColor = System.Drawing.Color.Transparent;
			this.tbLastName.BorderColor = System.Drawing.SystemColors.ControlDark;
			this.tbLastName.BorderRadius = 8;
			this.tbLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbLastName.DefaultText = "";
			this.tbLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbLastName.ForeColor = System.Drawing.Color.Black;
			this.tbLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbLastName.Location = new System.Drawing.Point(225, 140);
			this.tbLastName.Name = "tbLastName";
			this.tbLastName.PasswordChar = '\0';
			this.tbLastName.PlaceholderText = "Enter your LastName";
			this.tbLastName.SelectedText = "";
			this.tbLastName.Size = new System.Drawing.Size(232, 36);
			this.tbLastName.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_name;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button1.Location = new System.Drawing.Point(172, 142);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(35, 34);
			this.button1.TabIndex = 29;
			this.button1.TabStop = false;
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(52, 151);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 25);
			this.label1.TabIndex = 28;
			this.label1.Text = "Last Name:";
			// 
			// tbFirstName
			// 
			this.tbFirstName.Animated = true;
			this.tbFirstName.BackColor = System.Drawing.Color.Transparent;
			this.tbFirstName.BorderColor = System.Drawing.SystemColors.ControlDark;
			this.tbFirstName.BorderRadius = 8;
			this.tbFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbFirstName.DefaultText = "";
			this.tbFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbFirstName.ForeColor = System.Drawing.Color.Black;
			this.tbFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbFirstName.Location = new System.Drawing.Point(225, 95);
			this.tbFirstName.Name = "tbFirstName";
			this.tbFirstName.PasswordChar = '\0';
			this.tbFirstName.PlaceholderText = "Enter your First Name";
			this.tbFirstName.SelectedText = "";
			this.tbFirstName.Size = new System.Drawing.Size(232, 36);
			this.tbFirstName.TabIndex = 1;
			// 
			// btnClose
			// 
			this.btnClose.Animated = true;
			this.btnClose.BorderRadius = 18;
			this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnClose.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Image = global::PresentationLayer.Properties.Resources.icons8_cancel;
			this.btnClose.Location = new System.Drawing.Point(480, 315);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(128, 34);
			this.btnClose.TabIndex = 7;
			this.btnClose.Text = "Close";
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
			this.btnSave.Image = global::PresentationLayer.Properties.Resources.icons8_save_3;
			this.btnSave.Location = new System.Drawing.Point(626, 315);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(128, 34);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "  Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.Image = global::PresentationLayer.Properties.Resources.comvecteezy362094;
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Location = new System.Drawing.Point(472, 87);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new System.Drawing.Size(300, 178);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox1.TabIndex = 22;
			this.guna2PictureBox1.TabStop = false;
			// 
			// button5
			// 
			this.button5.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_phone;
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button5.Location = new System.Drawing.Point(172, 277);
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
			this.label13.Location = new System.Drawing.Point(83, 286);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(70, 25);
			this.label13.TabIndex = 19;
			this.label13.Text = "Phone:";
			// 
			// button6
			// 
			this.button6.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_address;
			this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button6.Location = new System.Drawing.Point(172, 228);
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
			this.label15.Location = new System.Drawing.Point(70, 241);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(83, 25);
			this.label15.TabIndex = 16;
			this.label15.Text = "Address:";
			// 
			// button3
			// 
			this.button3.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_Mobile_Id_Verification;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button3.Location = new System.Drawing.Point(172, 187);
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
			this.label9.Location = new System.Drawing.Point(35, 196);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(118, 25);
			this.label9.TabIndex = 13;
			this.label9.Text = "National No:";
			// 
			// button2
			// 
			this.button2.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_name;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button2.Location = new System.Drawing.Point(172, 97);
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
			this.label7.Location = new System.Drawing.Point(47, 106);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(106, 25);
			this.label7.TabIndex = 10;
			this.label7.Text = "First Name:";
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
			// lbAddOrUpdate
			// 
			this.lbAddOrUpdate.AutoSize = true;
			this.lbAddOrUpdate.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAddOrUpdate.ForeColor = System.Drawing.Color.Black;
			this.lbAddOrUpdate.Location = new System.Drawing.Point(307, 29);
			this.lbAddOrUpdate.Name = "lbAddOrUpdate";
			this.lbAddOrUpdate.Size = new System.Drawing.Size(244, 36);
			this.lbAddOrUpdate.TabIndex = 3;
			this.lbAddOrUpdate.Text = "Add New Person";
			// 
			// frmAddNewPerson
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(898, 660);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.plTopBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmAddNewPerson";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmAddNewPerson";
			this.plTopBar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.plPersonalInfo.ResumeLayout(false);
			this.plPersonalInfo.PerformLayout();
			this.plPersonGroub.ResumeLayout(false);
			this.plPersonGroub.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel plTopBar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbAddOrUpdate;
		private Guna.UI2.WinForms.Guna2Panel plPersonalInfo;
		private Guna.UI2.WinForms.Guna2TextBox tbPhone;
		private Guna.UI2.WinForms.Guna2TextBox tbAddress;
		private Guna.UI2.WinForms.Guna2TextBox tbNID;
		private Guna.UI2.WinForms.Guna2TextBox tbLastName;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2TextBox tbFirstName;
		private Guna.UI2.WinForms.Guna2GradientButton btnClose;
		private Guna.UI2.WinForms.Guna2GradientButton btnSave;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel plPersonGroub;
		private System.Windows.Forms.Label lbPersonIDInAddNewPerson;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label4;
	}
}