namespace PresentationLayer
{
	partial class frmViewCustomer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewCustomer));
			this.plTopBar = new System.Windows.Forms.Panel();
			this.label17 = new System.Windows.Forms.Label();
			this.pbClose = new System.Windows.Forms.PictureBox();
			this.lbMemberShipStatus = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.lbCustomerID = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.lbPhone = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.lbAddressInPersonalInfo = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.lbNationalNoInPersonalInfo = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lbNameInPersonalInfp = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lbPerosnIDInPersonalInfo = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
			this.button4 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.plTopBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// plTopBar
			// 
			this.plTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(135)))), ((int)(((byte)(33)))));
			this.plTopBar.Controls.Add(this.label17);
			this.plTopBar.Controls.Add(this.pbClose);
			this.plTopBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.plTopBar.Location = new System.Drawing.Point(0, 0);
			this.plTopBar.Margin = new System.Windows.Forms.Padding(4);
			this.plTopBar.Name = "plTopBar";
			this.plTopBar.Size = new System.Drawing.Size(979, 41);
			this.plTopBar.TabIndex = 6;
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
			this.label17.Location = new System.Drawing.Point(405, 9);
			this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(169, 26);
			this.label17.TabIndex = 3;
			this.label17.Text = "View Customer";
			// 
			// pbClose
			// 
			this.pbClose.BackColor = System.Drawing.Color.Transparent;
			this.pbClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
			this.pbClose.Location = new System.Drawing.Point(915, 0);
			this.pbClose.Margin = new System.Windows.Forms.Padding(4);
			this.pbClose.Name = "pbClose";
			this.pbClose.Size = new System.Drawing.Size(64, 41);
			this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbClose.TabIndex = 2;
			this.pbClose.TabStop = false;
			this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// lbMemberShipStatus
			// 
			this.lbMemberShipStatus.AutoSize = true;
			this.lbMemberShipStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMemberShipStatus.ForeColor = System.Drawing.Color.Black;
			this.lbMemberShipStatus.Location = new System.Drawing.Point(856, 154);
			this.lbMemberShipStatus.Name = "lbMemberShipStatus";
			this.lbMemberShipStatus.Size = new System.Drawing.Size(36, 25);
			this.lbMemberShipStatus.TabIndex = 56;
			this.lbMemberShipStatus.Text = "???";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(639, 154);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(184, 25);
			this.label12.TabIndex = 54;
			this.label12.Text = "Member Ship Status:";
			// 
			// lbCustomerID
			// 
			this.lbCustomerID.AutoSize = true;
			this.lbCustomerID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCustomerID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lbCustomerID.Location = new System.Drawing.Point(856, 105);
			this.lbCustomerID.Name = "lbCustomerID";
			this.lbCustomerID.Size = new System.Drawing.Size(36, 25);
			this.lbCustomerID.TabIndex = 53;
			this.lbCustomerID.Text = "???";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(709, 105);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(115, 25);
			this.label16.TabIndex = 51;
			this.label16.Text = "CustomerID:";
			// 
			// lbPhone
			// 
			this.lbPhone.AutoSize = true;
			this.lbPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPhone.ForeColor = System.Drawing.Color.Black;
			this.lbPhone.Location = new System.Drawing.Point(856, 202);
			this.lbPhone.Name = "lbPhone";
			this.lbPhone.Size = new System.Drawing.Size(36, 25);
			this.lbPhone.TabIndex = 49;
			this.lbPhone.Text = "???";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(745, 202);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(70, 25);
			this.label13.TabIndex = 47;
			this.label13.Text = "Phone:";
			// 
			// lbAddressInPersonalInfo
			// 
			this.lbAddressInPersonalInfo.AutoSize = true;
			this.lbAddressInPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAddressInPersonalInfo.ForeColor = System.Drawing.Color.Black;
			this.lbAddressInPersonalInfo.Location = new System.Drawing.Point(460, 255);
			this.lbAddressInPersonalInfo.Name = "lbAddressInPersonalInfo";
			this.lbAddressInPersonalInfo.Size = new System.Drawing.Size(36, 25);
			this.lbAddressInPersonalInfo.TabIndex = 46;
			this.lbAddressInPersonalInfo.Text = "???";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(331, 255);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(83, 25);
			this.label15.TabIndex = 44;
			this.label15.Text = "Address:";
			// 
			// lbNationalNoInPersonalInfo
			// 
			this.lbNationalNoInPersonalInfo.AutoSize = true;
			this.lbNationalNoInPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNationalNoInPersonalInfo.ForeColor = System.Drawing.Color.Black;
			this.lbNationalNoInPersonalInfo.Location = new System.Drawing.Point(460, 202);
			this.lbNationalNoInPersonalInfo.Name = "lbNationalNoInPersonalInfo";
			this.lbNationalNoInPersonalInfo.Size = new System.Drawing.Size(36, 25);
			this.lbNationalNoInPersonalInfo.TabIndex = 43;
			this.lbNationalNoInPersonalInfo.Text = "???";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(300, 202);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(118, 25);
			this.label9.TabIndex = 41;
			this.label9.Text = "National No:";
			// 
			// lbNameInPersonalInfp
			// 
			this.lbNameInPersonalInfp.AutoSize = true;
			this.lbNameInPersonalInfp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNameInPersonalInfp.ForeColor = System.Drawing.Color.Black;
			this.lbNameInPersonalInfp.Location = new System.Drawing.Point(460, 154);
			this.lbNameInPersonalInfp.Name = "lbNameInPersonalInfp";
			this.lbNameInPersonalInfp.Size = new System.Drawing.Size(36, 25);
			this.lbNameInPersonalInfp.TabIndex = 40;
			this.lbNameInPersonalInfp.Text = "???";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(352, 154);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(66, 25);
			this.label7.TabIndex = 38;
			this.label7.Text = "Name:";
			// 
			// lbPerosnIDInPersonalInfo
			// 
			this.lbPerosnIDInPersonalInfo.AutoSize = true;
			this.lbPerosnIDInPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPerosnIDInPersonalInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lbPerosnIDInPersonalInfo.Location = new System.Drawing.Point(460, 105);
			this.lbPerosnIDInPersonalInfo.Name = "lbPerosnIDInPersonalInfo";
			this.lbPerosnIDInPersonalInfo.Size = new System.Drawing.Size(36, 25);
			this.lbPerosnIDInPersonalInfo.TabIndex = 37;
			this.lbPerosnIDInPersonalInfo.Text = "???";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(322, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 25);
			this.label4.TabIndex = 35;
			this.label4.Text = "Person ID:";
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
			this.btnBack.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(135)))), ((int)(((byte)(33)))));
			this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnBack.ForeColor = System.Drawing.Color.White;
			this.btnBack.Image = global::PresentationLayer.Properties.Resources.icons8_close_208px;
			this.btnBack.Location = new System.Drawing.Point(626, 337);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(173, 54);
			this.btnBack.TabIndex = 57;
			this.btnBack.Text = "  Clsoe";
			this.btnBack.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// button4
			// 
			this.button4.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_membership_card;
			this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button4.Location = new System.Drawing.Point(818, 149);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(35, 34);
			this.button4.TabIndex = 55;
			this.button4.TabStop = false;
			this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_id_button;
			this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button7.Location = new System.Drawing.Point(818, 100);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(35, 34);
			this.button7.TabIndex = 52;
			this.button7.TabStop = false;
			this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button7.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_phone;
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button5.Location = new System.Drawing.Point(818, 197);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(35, 34);
			this.button5.TabIndex = 48;
			this.button5.TabStop = false;
			this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_address;
			this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button6.Location = new System.Drawing.Point(417, 248);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(35, 38);
			this.button6.TabIndex = 45;
			this.button6.TabStop = false;
			this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_Mobile_Id_Verification;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button3.Location = new System.Drawing.Point(417, 197);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(35, 34);
			this.button3.TabIndex = 42;
			this.button3.TabStop = false;
			this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_name;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button2.Location = new System.Drawing.Point(417, 149);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(35, 34);
			this.button2.TabIndex = 39;
			this.button2.TabStop = false;
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_id_button;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button1.Location = new System.Drawing.Point(417, 100);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(35, 34);
			this.button1.TabIndex = 36;
			this.button1.TabStop = false;
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// guna2CirclePictureBox1
			// 
			this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.White;
			this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Gray;
			this.guna2CirclePictureBox1.Image = global::PresentationLayer.Properties.Resources.flat_illustration_of_personal_information_concept_vector;
			this.guna2CirclePictureBox1.ImageRotate = 0F;
			this.guna2CirclePictureBox1.Location = new System.Drawing.Point(11, 52);
			this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
			this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CirclePictureBox1.Size = new System.Drawing.Size(318, 354);
			this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2CirclePictureBox1.TabIndex = 7;
			this.guna2CirclePictureBox1.TabStop = false;
			// 
			// frmViewCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(979, 427);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.lbMemberShipStatus);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.lbCustomerID);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.lbPhone);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.lbAddressInPersonalInfo);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.lbNationalNoInPersonalInfo);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.lbNameInPersonalInfp);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lbPerosnIDInPersonalInfo);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.guna2CirclePictureBox1);
			this.Controls.Add(this.plTopBar);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmViewCustomer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmViewCustomer";
			this.plTopBar.ResumeLayout(false);
			this.plTopBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel plTopBar;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.PictureBox pbClose;
		private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
		private Guna.UI2.WinForms.Guna2GradientButton btnBack;
		private System.Windows.Forms.Label lbMemberShipStatus;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label lbCustomerID;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Label label16;
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
	}
}