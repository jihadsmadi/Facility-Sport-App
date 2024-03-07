namespace PresentationLayer
{
	partial class frmViewUser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewUser));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label17 = new System.Windows.Forms.Label();
			this.pbClose = new System.Windows.Forms.PictureBox();
			this.lbUserID = new System.Windows.Forms.Label();
			this.label39 = new System.Windows.Forms.Label();
			this.lbPersonID = new System.Windows.Forms.Label();
			this.lbUsername = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.cbAll = new Guna.UI2.WinForms.Guna2CheckBox();
			this.cbUsers = new Guna.UI2.WinForms.Guna2CheckBox();
			this.cbPayments = new Guna.UI2.WinForms.Guna2CheckBox();
			this.cbBooking = new Guna.UI2.WinForms.Guna2CheckBox();
			this.cbCustomers = new Guna.UI2.WinForms.Guna2CheckBox();
			this.cbDashbaord = new Guna.UI2.WinForms.Guna2CheckBox();
			this.label26 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button12 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
			this.lbName = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.label17);
			this.panel1.Controls.Add(this.pbClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(774, 43);
			this.panel1.TabIndex = 0;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseDown);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseMove);
			this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseUp);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.Color.White;
			this.label17.Location = new System.Drawing.Point(283, 8);
			this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(117, 26);
			this.label17.TabIndex = 5;
			this.label17.Text = "View User";
			// 
			// pbClose
			// 
			this.pbClose.BackColor = System.Drawing.Color.Transparent;
			this.pbClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
			this.pbClose.Location = new System.Drawing.Point(710, 0);
			this.pbClose.Margin = new System.Windows.Forms.Padding(4);
			this.pbClose.Name = "pbClose";
			this.pbClose.Size = new System.Drawing.Size(64, 43);
			this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbClose.TabIndex = 4;
			this.pbClose.TabStop = false;
			this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// lbUserID
			// 
			this.lbUserID.AutoSize = true;
			this.lbUserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbUserID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lbUserID.Location = new System.Drawing.Point(431, 73);
			this.lbUserID.Name = "lbUserID";
			this.lbUserID.Size = new System.Drawing.Size(31, 21);
			this.lbUserID.TabIndex = 133;
			this.lbUserID.Text = "???";
			// 
			// label39
			// 
			this.label39.AutoSize = true;
			this.label39.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label39.Location = new System.Drawing.Point(314, 71);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(77, 25);
			this.label39.TabIndex = 131;
			this.label39.Text = "User ID:";
			// 
			// lbPersonID
			// 
			this.lbPersonID.AutoSize = true;
			this.lbPersonID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPersonID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lbPersonID.Location = new System.Drawing.Point(658, 73);
			this.lbPersonID.Name = "lbPersonID";
			this.lbPersonID.Size = new System.Drawing.Size(31, 21);
			this.lbPersonID.TabIndex = 127;
			this.lbPersonID.Text = "???";
			// 
			// lbUsername
			// 
			this.lbUsername.AutoSize = true;
			this.lbUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbUsername.ForeColor = System.Drawing.Color.Black;
			this.lbUsername.Location = new System.Drawing.Point(431, 120);
			this.lbUsername.Name = "lbUsername";
			this.lbUsername.Size = new System.Drawing.Size(31, 21);
			this.lbUsername.TabIndex = 130;
			this.lbUsername.Text = "???";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(520, 71);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(96, 25);
			this.label24.TabIndex = 125;
			this.label24.Text = "Person ID:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(282, 118);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(109, 25);
			this.label19.TabIndex = 128;
			this.label19.Text = "User Name:";
			// 
			// cbAll
			// 
			this.cbAll.Animated = true;
			this.cbAll.AutoSize = true;
			this.cbAll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbAll.CheckedState.BorderRadius = 2;
			this.cbAll.CheckedState.BorderThickness = 0;
			this.cbAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbAll.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbAll.Enabled = false;
			this.cbAll.Font = new System.Drawing.Font("Tahoma", 14.25F);
			this.cbAll.Location = new System.Drawing.Point(660, 301);
			this.cbAll.Name = "cbAll";
			this.cbAll.Size = new System.Drawing.Size(48, 27);
			this.cbAll.TabIndex = 140;
			this.cbAll.Text = "All";
			this.cbAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbAll.UncheckedState.BorderRadius = 2;
			this.cbAll.UncheckedState.BorderThickness = 0;
			this.cbAll.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			// 
			// cbUsers
			// 
			this.cbUsers.Animated = true;
			this.cbUsers.AutoSize = true;
			this.cbUsers.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbUsers.CheckedState.BorderRadius = 2;
			this.cbUsers.CheckedState.BorderThickness = 0;
			this.cbUsers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbUsers.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbUsers.Enabled = false;
			this.cbUsers.Font = new System.Drawing.Font("Tahoma", 14.25F);
			this.cbUsers.Location = new System.Drawing.Point(660, 252);
			this.cbUsers.Name = "cbUsers";
			this.cbUsers.Size = new System.Drawing.Size(74, 27);
			this.cbUsers.TabIndex = 139;
			this.cbUsers.Text = "Users";
			this.cbUsers.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbUsers.UncheckedState.BorderRadius = 2;
			this.cbUsers.UncheckedState.BorderThickness = 0;
			this.cbUsers.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			// 
			// cbPayments
			// 
			this.cbPayments.Animated = true;
			this.cbPayments.AutoSize = true;
			this.cbPayments.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbPayments.CheckedState.BorderRadius = 2;
			this.cbPayments.CheckedState.BorderThickness = 0;
			this.cbPayments.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbPayments.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbPayments.Enabled = false;
			this.cbPayments.Font = new System.Drawing.Font("Tahoma", 14.25F);
			this.cbPayments.Location = new System.Drawing.Point(660, 203);
			this.cbPayments.Name = "cbPayments";
			this.cbPayments.Size = new System.Drawing.Size(109, 27);
			this.cbPayments.TabIndex = 138;
			this.cbPayments.Text = "Payments";
			this.cbPayments.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbPayments.UncheckedState.BorderRadius = 2;
			this.cbPayments.UncheckedState.BorderThickness = 0;
			this.cbPayments.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			// 
			// cbBooking
			// 
			this.cbBooking.Animated = true;
			this.cbBooking.AutoSize = true;
			this.cbBooking.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbBooking.CheckedState.BorderRadius = 2;
			this.cbBooking.CheckedState.BorderThickness = 0;
			this.cbBooking.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbBooking.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbBooking.Enabled = false;
			this.cbBooking.Font = new System.Drawing.Font("Tahoma", 14.25F);
			this.cbBooking.Location = new System.Drawing.Point(490, 301);
			this.cbBooking.Name = "cbBooking";
			this.cbBooking.Size = new System.Drawing.Size(95, 27);
			this.cbBooking.TabIndex = 137;
			this.cbBooking.Text = "Booking";
			this.cbBooking.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbBooking.UncheckedState.BorderRadius = 2;
			this.cbBooking.UncheckedState.BorderThickness = 0;
			this.cbBooking.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			// 
			// cbCustomers
			// 
			this.cbCustomers.Animated = true;
			this.cbCustomers.AutoSize = true;
			this.cbCustomers.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbCustomers.CheckedState.BorderRadius = 2;
			this.cbCustomers.CheckedState.BorderThickness = 0;
			this.cbCustomers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbCustomers.Enabled = false;
			this.cbCustomers.Font = new System.Drawing.Font("Tahoma", 14.25F);
			this.cbCustomers.Location = new System.Drawing.Point(490, 252);
			this.cbCustomers.Name = "cbCustomers";
			this.cbCustomers.Size = new System.Drawing.Size(116, 27);
			this.cbCustomers.TabIndex = 136;
			this.cbCustomers.Text = "Customers";
			this.cbCustomers.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbCustomers.UncheckedState.BorderRadius = 2;
			this.cbCustomers.UncheckedState.BorderThickness = 0;
			this.cbCustomers.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			// 
			// cbDashbaord
			// 
			this.cbDashbaord.Animated = true;
			this.cbDashbaord.AutoSize = true;
			this.cbDashbaord.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbDashbaord.CheckedState.BorderRadius = 2;
			this.cbDashbaord.CheckedState.BorderThickness = 0;
			this.cbDashbaord.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbDashbaord.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbDashbaord.Enabled = false;
			this.cbDashbaord.Font = new System.Drawing.Font("Tahoma", 14.25F);
			this.cbDashbaord.Location = new System.Drawing.Point(490, 203);
			this.cbDashbaord.Name = "cbDashbaord";
			this.cbDashbaord.Size = new System.Drawing.Size(120, 27);
			this.cbDashbaord.TabIndex = 135;
			this.cbDashbaord.Text = "Dashboard";
			this.cbDashbaord.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbDashbaord.UncheckedState.BorderRadius = 2;
			this.cbDashbaord.UncheckedState.BorderThickness = 0;
			this.cbDashbaord.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.Location = new System.Drawing.Point(294, 256);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(137, 23);
			this.label26.TabIndex = 134;
			this.label26.Text = "Permessions:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pictureBox1.BackgroundImage = global::PresentationLayer.Properties.Resources.dsfsdf1;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Location = new System.Drawing.Point(0, 43);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(276, 404);
			this.pictureBox1.TabIndex = 141;
			this.pictureBox1.TabStop = false;
			// 
			// button12
			// 
			this.button12.BackgroundImage = global::PresentationLayer.Properties.Resources.person_icon_blue_181;
			this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button12.Location = new System.Drawing.Point(390, 67);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(35, 34);
			this.button12.TabIndex = 132;
			this.button12.TabStop = false;
			this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button12.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_autograph_1;
			this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button7.Location = new System.Drawing.Point(390, 113);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(35, 34);
			this.button7.TabIndex = 129;
			this.button7.TabStop = false;
			this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button7.UseVisualStyleBackColor = true;
			// 
			// button11
			// 
			this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
			this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button11.Location = new System.Drawing.Point(615, 66);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(35, 34);
			this.button11.TabIndex = 126;
			this.button11.TabStop = false;
			this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button11.UseVisualStyleBackColor = true;
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
			this.btnClose.FillColor = System.Drawing.Color.Moccasin;
			this.btnClose.FillColor2 = System.Drawing.Color.DarkBlue;
			this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
			this.btnClose.Image = global::PresentationLayer.Properties.Resources.icons8_close_208px;
			this.btnClose.Location = new System.Drawing.Point(456, 380);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(150, 42);
			this.btnClose.TabIndex = 145;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// lbName
			// 
			this.lbName.AutoSize = true;
			this.lbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbName.ForeColor = System.Drawing.Color.Black;
			this.lbName.Location = new System.Drawing.Point(656, 124);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(31, 21);
			this.lbName.TabIndex = 148;
			this.lbName.Text = "???";
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::PresentationLayer.Properties.Resources.icons8_name;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button1.Location = new System.Drawing.Point(615, 117);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(35, 34);
			this.button1.TabIndex = 147;
			this.button1.TabStop = false;
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(550, 122);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 25);
			this.label2.TabIndex = 146;
			this.label2.Text = "Name:";
			// 
			// frmViewUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(774, 447);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.cbAll);
			this.Controls.Add(this.cbUsers);
			this.Controls.Add(this.cbPayments);
			this.Controls.Add(this.cbBooking);
			this.Controls.Add(this.cbCustomers);
			this.Controls.Add(this.cbDashbaord);
			this.Controls.Add(this.label26);
			this.Controls.Add(this.lbUserID);
			this.Controls.Add(this.label39);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.lbPersonID);
			this.Controls.Add(this.lbUsername);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmViewUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmViewUser";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.PictureBox pbClose;
		private System.Windows.Forms.Label lbUserID;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Label lbPersonID;
		private System.Windows.Forms.Label lbUsername;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Button button11;
		private Guna.UI2.WinForms.Guna2CheckBox cbAll;
		private Guna.UI2.WinForms.Guna2CheckBox cbUsers;
		private Guna.UI2.WinForms.Guna2CheckBox cbPayments;
		private Guna.UI2.WinForms.Guna2CheckBox cbBooking;
		private Guna.UI2.WinForms.Guna2CheckBox cbCustomers;
		private Guna.UI2.WinForms.Guna2CheckBox cbDashbaord;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Guna.UI2.WinForms.Guna2GradientButton btnClose;
		private System.Windows.Forms.Label lbName;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
	}
}