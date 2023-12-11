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
			this.plTopBar = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.plSideBar = new System.Windows.Forms.FlowLayoutPanel();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.plTopSideBar = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
			this.btnHome = new Guna.UI2.WinForms.Guna2Button();
			this.btnApointments = new Guna.UI2.WinForms.Guna2Button();
			this.btnUser = new Guna.UI2.WinForms.Guna2Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.plTopBar.SuspendLayout();
			this.plSideBar.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// plTopBar
			// 
			this.plTopBar.BackColor = System.Drawing.Color.LightBlue;
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
			this.label1.ForeColor = System.Drawing.Color.DarkBlue;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 34);
			this.label1.TabIndex = 1;
			this.label1.Text = "  Sport Space";
			// 
			// plSideBar
			// 
			this.plSideBar.BackColor = System.Drawing.Color.White;
			this.plSideBar.Controls.Add(this.plTopSideBar);
			this.plSideBar.Controls.Add(this.btnDashboard);
			this.plSideBar.Controls.Add(this.btnHome);
			this.plSideBar.Controls.Add(this.btnApointments);
			this.plSideBar.Controls.Add(this.panel1);
			this.plSideBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.plSideBar.Location = new System.Drawing.Point(0, 39);
			this.plSideBar.Name = "plSideBar";
			this.plSideBar.Size = new System.Drawing.Size(200, 765);
			this.plSideBar.TabIndex = 1;
			this.plSideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.plSideBar_Paint);
			// 
			// plTopSideBar
			// 
			this.plTopSideBar.BackColor = System.Drawing.Color.Transparent;
			this.plTopSideBar.Location = new System.Drawing.Point(3, 3);
			this.plTopSideBar.Name = "plTopSideBar";
			this.plTopSideBar.Size = new System.Drawing.Size(197, 136);
			this.plTopSideBar.TabIndex = 2;
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
			// btnDashboard
			// 
			this.btnDashboard.Animated = true;
			this.btnDashboard.AutoRoundedCorners = true;
			this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
			this.btnDashboard.BorderColor = System.Drawing.Color.Transparent;
			this.btnDashboard.BorderRadius = 30;
			this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDashboard.ForeColor = System.Drawing.Color.White;
			this.btnDashboard.Image = global::PresentationLayer.Properties.Resources.icons8_dashboard_layout_2;
			this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnDashboard.ImageOffset = new System.Drawing.Point(10, 0);
			this.btnDashboard.ImageSize = new System.Drawing.Size(30, 30);
			this.btnDashboard.Location = new System.Drawing.Point(3, 145);
			this.btnDashboard.Name = "btnDashboard";
			this.btnDashboard.Size = new System.Drawing.Size(190, 62);
			this.btnDashboard.TabIndex = 2;
			this.btnDashboard.Text = "     Dashboard";
			this.btnDashboard.Click += new System.EventHandler(this.guna2Button1_Click);
			// 
			// btnHome
			// 
			this.btnHome.Animated = true;
			this.btnHome.AutoRoundedCorners = true;
			this.btnHome.BackColor = System.Drawing.Color.Transparent;
			this.btnHome.BorderColor = System.Drawing.Color.Transparent;
			this.btnHome.BorderRadius = 30;
			this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnHome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHome.ForeColor = System.Drawing.Color.White;
			this.btnHome.Image = global::PresentationLayer.Properties.Resources.icons8_home_2;
			this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnHome.ImageOffset = new System.Drawing.Point(10, 0);
			this.btnHome.ImageSize = new System.Drawing.Size(30, 30);
			this.btnHome.Location = new System.Drawing.Point(3, 213);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(190, 62);
			this.btnHome.TabIndex = 3;
			this.btnHome.Text = "Home";
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
			this.btnApointments.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnApointments.ForeColor = System.Drawing.Color.White;
			this.btnApointments.Image = global::PresentationLayer.Properties.Resources.icons8_reservation;
			this.btnApointments.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnApointments.ImageOffset = new System.Drawing.Point(10, 0);
			this.btnApointments.ImageSize = new System.Drawing.Size(30, 30);
			this.btnApointments.Location = new System.Drawing.Point(3, 281);
			this.btnApointments.Name = "btnApointments";
			this.btnApointments.Size = new System.Drawing.Size(190, 62);
			this.btnApointments.TabIndex = 4;
			this.btnApointments.Text = "        Apoitmentes";
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
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1434, 804);
			this.Controls.Add(this.plSideBar);
			this.Controls.Add(this.plTopBar);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FACILITY SPORT";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.plTopBar.ResumeLayout(false);
			this.plTopBar.PerformLayout();
			this.plSideBar.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel plTopBar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel plSideBar;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Panel plTopSideBar;
		private Guna.UI2.WinForms.Guna2Button btnDashboard;
		private Guna.UI2.WinForms.Guna2Button btnHome;
		private Guna.UI2.WinForms.Guna2Button btnApointments;
		private System.Windows.Forms.Panel panel1;
		private Guna.UI2.WinForms.Guna2Button btnUser;
	}
}

