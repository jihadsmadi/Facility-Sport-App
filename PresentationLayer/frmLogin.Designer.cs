namespace PresentationLayer
{
	partial class frmLogin
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.tbUserName = new Guna.UI2.WinForms.Guna2TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pbClose = new System.Windows.Forms.PictureBox();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
			this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.panel1.SuspendLayout();
			this.guna2Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SkyBlue;
			this.panel1.Controls.Add(this.pbClose);
			this.panel1.Controls.Add(this.guna2Panel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(924, 527);
			this.panel1.TabIndex = 0;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseDown);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseMove);
			this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseUp);
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2Panel1.BorderRadius = 40;
			this.guna2Panel1.BorderThickness = 2;
			this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
			this.guna2Panel1.Controls.Add(this.btnLogin);
			this.guna2Panel1.Controls.Add(this.tbPassword);
			this.guna2Panel1.Controls.Add(this.tbUserName);
			this.guna2Panel1.Controls.Add(this.label1);
			this.guna2Panel1.FillColor = System.Drawing.Color.White;
			this.guna2Panel1.Location = new System.Drawing.Point(12, 40);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(900, 451);
			this.guna2Panel1.TabIndex = 0;
			// 
			// tbUserName
			// 
			this.tbUserName.Animated = true;
			this.tbUserName.BorderColor = System.Drawing.Color.SkyBlue;
			this.tbUserName.BorderRadius = 5;
			this.tbUserName.BorderThickness = 2;
			this.tbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbUserName.DefaultText = "";
			this.tbUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbUserName.FocusedState.BorderColor = System.Drawing.Color.Black;
			this.tbUserName.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.tbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tbUserName.HoverState.BorderColor = System.Drawing.Color.Black;
			this.tbUserName.Location = new System.Drawing.Point(519, 152);
			this.tbUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbUserName.Name = "tbUserName";
			this.tbUserName.PasswordChar = '\0';
			this.tbUserName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.tbUserName.PlaceholderText = "Username";
			this.tbUserName.SelectedText = "";
			this.tbUserName.Size = new System.Drawing.Size(276, 50);
			this.tbUserName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.SkyBlue;
			this.label1.Location = new System.Drawing.Point(558, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(223, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "Welcome Back";
			// 
			// pbClose
			// 
			this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbClose.Image = global::PresentationLayer.Properties.Resources.icons8_cancel_1;
			this.pbClose.Location = new System.Drawing.Point(877, 5);
			this.pbClose.Name = "pbClose";
			this.pbClose.Size = new System.Drawing.Size(44, 33);
			this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbClose.TabIndex = 1;
			this.pbClose.TabStop = false;
			this.pbClose.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox1.Image = global::PresentationLayer.Properties.Resources.logo1;
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Location = new System.Drawing.Point(3, 27);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new System.Drawing.Size(477, 360);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2PictureBox1.TabIndex = 4;
			this.guna2PictureBox1.TabStop = false;
			this.guna2PictureBox1.UseTransparentBackground = true;
			// 
			// btnLogin
			// 
			this.btnLogin.Animated = true;
			this.btnLogin.BorderColor = System.Drawing.Color.SkyBlue;
			this.btnLogin.BorderRadius = 5;
			this.btnLogin.BorderThickness = 2;
			this.btnLogin.CheckedState.BorderColor = System.Drawing.Color.White;
			this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnLogin.FillColor = System.Drawing.Color.SkyBlue;
			this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.HoverState.BorderColor = System.Drawing.Color.White;
			this.btnLogin.Image = global::PresentationLayer.Properties.Resources.icons8_next1;
			this.btnLogin.Location = new System.Drawing.Point(565, 342);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(180, 45);
			this.btnLogin.TabIndex = 3;
			this.btnLogin.Text = "   Login";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			this.btnLogin.Enter += new System.EventHandler(this.btnLogin_Enter);
			this.btnLogin.Leave += new System.EventHandler(this.btnLogin_Leave);
			// 
			// tbPassword
			// 
			this.tbPassword.Animated = true;
			this.tbPassword.BorderColor = System.Drawing.Color.SkyBlue;
			this.tbPassword.BorderThickness = 2;
			this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbPassword.DefaultText = "";
			this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.Black;
			this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tbPassword.HoverState.BorderColor = System.Drawing.Color.Black;
			this.tbPassword.IconRight = global::PresentationLayer.Properties.Resources.icons8_eye;
			this.tbPassword.IconRightCursor = System.Windows.Forms.Cursors.Hand;
			this.tbPassword.IconRightSize = new System.Drawing.Size(30, 30);
			this.tbPassword.Location = new System.Drawing.Point(519, 231);
			this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.tbPassword.PlaceholderText = "Password";
			this.tbPassword.SelectedText = "";
			this.tbPassword.Size = new System.Drawing.Size(276, 50);
			this.tbPassword.TabIndex = 2;
			this.tbPassword.IconRightClick += new System.EventHandler(this.tbPassword_IconRightClick);
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(924, 527);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmLogin";
			this.panel1.ResumeLayout(false);
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2TextBox tbUserName;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2TextBox tbPassword;
		public System.Windows.Forms.PictureBox pbClose;
		private Guna.UI2.WinForms.Guna2Button btnLogin;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
	}
}