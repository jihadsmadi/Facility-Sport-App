namespace PresentationLayer
{
	partial class frmChangeUserPassword
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeUserPassword));
			this.label17 = new System.Windows.Forms.Label();
			this.pbClose = new System.Windows.Forms.PictureBox();
			this.plPersonGroub = new System.Windows.Forms.Panel();
			this.lbUsername = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.tbConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
			this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
			this.plPersonGroub.SuspendLayout();
			this.guna2CustomGradientPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.Color.White;
			this.label17.Location = new System.Drawing.Point(3, 5);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(158, 23);
			this.label17.TabIndex = 3;
			this.label17.Text = "Change Password";
			// 
			// pbClose
			// 
			this.pbClose.BackColor = System.Drawing.Color.Transparent;
			this.pbClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
			this.pbClose.Location = new System.Drawing.Point(413, 0);
			this.pbClose.Name = "pbClose";
			this.pbClose.Size = new System.Drawing.Size(43, 36);
			this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbClose.TabIndex = 2;
			this.pbClose.TabStop = false;
			this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// plPersonGroub
			// 
			this.plPersonGroub.Controls.Add(this.lbUsername);
			this.plPersonGroub.Controls.Add(this.label4);
			this.plPersonGroub.Controls.Add(this.button2);
			this.plPersonGroub.Location = new System.Drawing.Point(89, 56);
			this.plPersonGroub.Name = "plPersonGroub";
			this.plPersonGroub.Size = new System.Drawing.Size(244, 37);
			this.plPersonGroub.TabIndex = 41;
			// 
			// lbUsername
			// 
			this.lbUsername.AutoSize = true;
			this.lbUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbUsername.Location = new System.Drawing.Point(184, 5);
			this.lbUsername.Name = "lbUsername";
			this.lbUsername.Size = new System.Drawing.Size(39, 25);
			this.lbUsername.TabIndex = 35;
			this.lbUsername.Text = "???";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(21, 5);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(109, 25);
			this.label4.TabIndex = 33;
			this.label4.Text = "User Name:";
			// 
			// button2
			// 
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button2.Location = new System.Drawing.Point(131, 1);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(35, 34);
			this.button2.TabIndex = 38;
			this.button2.TabStop = false;
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// tbConfirmPassword
			// 
			this.tbConfirmPassword.Animated = true;
			this.tbConfirmPassword.BackColor = System.Drawing.Color.Transparent;
			this.tbConfirmPassword.BorderColor = System.Drawing.SystemColors.ControlDark;
			this.tbConfirmPassword.BorderRadius = 8;
			this.tbConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbConfirmPassword.DefaultText = "";
			this.tbConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbConfirmPassword.ForeColor = System.Drawing.Color.Black;
			this.tbConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbConfirmPassword.Location = new System.Drawing.Point(198, 190);
			this.tbConfirmPassword.Name = "tbConfirmPassword";
			this.tbConfirmPassword.PasswordChar = '\0';
			this.tbConfirmPassword.PlaceholderText = "confirm password";
			this.tbConfirmPassword.SelectedText = "";
			this.tbConfirmPassword.Size = new System.Drawing.Size(162, 36);
			this.tbConfirmPassword.TabIndex = 36;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(28, 196);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 25);
			this.label1.TabIndex = 39;
			this.label1.Text = "Confirm Password:";
			// 
			// tbPassword
			// 
			this.tbPassword.Animated = true;
			this.tbPassword.BackColor = System.Drawing.Color.Transparent;
			this.tbPassword.BorderColor = System.Drawing.SystemColors.ControlDark;
			this.tbPassword.BorderRadius = 8;
			this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbPassword.DefaultText = "";
			this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbPassword.ForeColor = System.Drawing.Color.Black;
			this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbPassword.Location = new System.Drawing.Point(198, 139);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '\0';
			this.tbPassword.PlaceholderText = "password";
			this.tbPassword.SelectedText = "";
			this.tbPassword.Size = new System.Drawing.Size(162, 36);
			this.tbPassword.TabIndex = 35;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(55, 145);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(138, 25);
			this.label7.TabIndex = 37;
			this.label7.Text = "New Password:";
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
			this.btnSave.FillColor = System.Drawing.Color.CadetBlue;
			this.btnSave.FillColor2 = System.Drawing.Color.DarkBlue;
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Image = global::PresentationLayer.Properties.Resources.icons8_save_1;
			this.btnSave.Location = new System.Drawing.Point(157, 275);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(128, 41);
			this.btnSave.TabIndex = 145;
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// guna2CustomGradientPanel1
			// 
			this.guna2CustomGradientPanel1.Controls.Add(this.pbClose);
			this.guna2CustomGradientPanel1.Controls.Add(this.label17);
			this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.CadetBlue;
			this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.DarkBlue;
			this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.CadetBlue;
			this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.DarkBlue;
			this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
			this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
			this.guna2CustomGradientPanel1.Quality = 20;
			this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(456, 36);
			this.guna2CustomGradientPanel1.TabIndex = 146;
			this.guna2CustomGradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseDown);
			this.guna2CustomGradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseMove);
			this.guna2CustomGradientPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseUp);
			// 
			// frmChangeUserPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(456, 368);
			this.Controls.Add(this.guna2CustomGradientPanel1);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.plPersonGroub);
			this.Controls.Add(this.tbConfirmPassword);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.label7);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmChangeUserPassword";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmChangeUserPassword";
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			this.plPersonGroub.ResumeLayout(false);
			this.plPersonGroub.PerformLayout();
			this.guna2CustomGradientPanel1.ResumeLayout(false);
			this.guna2CustomGradientPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.PictureBox pbClose;
		private System.Windows.Forms.Panel plPersonGroub;
		private System.Windows.Forms.Label lbUsername;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button2;
		private Guna.UI2.WinForms.Guna2TextBox tbConfirmPassword;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2TextBox tbPassword;
		private System.Windows.Forms.Label label7;
		private Guna.UI2.WinForms.Guna2GradientButton btnSave;
		private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
	}
}