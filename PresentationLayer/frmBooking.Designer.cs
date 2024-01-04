namespace PresentationLayer
{
	partial class frmBooking
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
			this.plContainer = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.plFacility = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.plCalender = new System.Windows.Forms.Panel();
			this.fpContainer = new System.Windows.Forms.FlowLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lbMonthData = new System.Windows.Forms.Label();
			this.btnPrevMonth = new Guna.UI2.WinForms.Guna2GradientButton();
			this.btnNextMonth = new Guna.UI2.WinForms.Guna2GradientButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pbClose = new System.Windows.Forms.PictureBox();
			this.plTopBar.SuspendLayout();
			this.plContainer.SuspendLayout();
			this.plFacility.SuspendLayout();
			this.panel1.SuspendLayout();
			this.plCalender.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
			this.SuspendLayout();
			// 
			// plTopBar
			// 
			this.plTopBar.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.plTopBar.Controls.Add(this.pictureBox1);
			this.plTopBar.Controls.Add(this.label1);
			this.plTopBar.Controls.Add(this.pbClose);
			this.plTopBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.plTopBar.Location = new System.Drawing.Point(0, 0);
			this.plTopBar.Name = "plTopBar";
			this.plTopBar.Size = new System.Drawing.Size(1464, 49);
			this.plTopBar.TabIndex = 2;
			this.plTopBar.Paint += new System.Windows.Forms.PaintEventHandler(this.plTopBar_Paint);
			// 
			// plContainer
			// 
			this.plContainer.Controls.Add(this.btnPrevMonth);
			this.plContainer.Controls.Add(this.btnNextMonth);
			this.plContainer.Controls.Add(this.plFacility);
			this.plContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plContainer.Location = new System.Drawing.Point(0, 49);
			this.plContainer.Name = "plContainer";
			this.plContainer.Size = new System.Drawing.Size(1464, 935);
			this.plContainer.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(16, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(203, 30);
			this.label1.TabIndex = 3;
			this.label1.Text = "Make A Reservation";
			// 
			// plFacility
			// 
			this.plFacility.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.plFacility.Controls.Add(this.plCalender);
			this.plFacility.Controls.Add(this.panel1);
			this.plFacility.Location = new System.Drawing.Point(36, 12);
			this.plFacility.Name = "plFacility";
			this.plFacility.Size = new System.Drawing.Size(1384, 860);
			this.plFacility.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkOrchid;
			this.panel1.Controls.Add(this.lbMonthData);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1382, 36);
			this.panel1.TabIndex = 0;
			// 
			// plCalender
			// 
			this.plCalender.Controls.Add(this.label9);
			this.plCalender.Controls.Add(this.label7);
			this.plCalender.Controls.Add(this.label8);
			this.plCalender.Controls.Add(this.label5);
			this.plCalender.Controls.Add(this.label6);
			this.plCalender.Controls.Add(this.label4);
			this.plCalender.Controls.Add(this.label3);
			this.plCalender.Controls.Add(this.fpContainer);
			this.plCalender.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plCalender.Location = new System.Drawing.Point(0, 36);
			this.plCalender.Name = "plCalender";
			this.plCalender.Size = new System.Drawing.Size(1382, 822);
			this.plCalender.TabIndex = 1;
			// 
			// fpContainer
			// 
			this.fpContainer.BackColor = System.Drawing.Color.WhiteSmoke;
			this.fpContainer.Location = new System.Drawing.Point(3, 44);
			this.fpContainer.Name = "fpContainer";
			this.fpContainer.Size = new System.Drawing.Size(1380, 776);
			this.fpContainer.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label3.Location = new System.Drawing.Point(58, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 25);
			this.label3.TabIndex = 1;
			this.label3.Text = "Sunday";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label4.Location = new System.Drawing.Point(253, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 25);
			this.label4.TabIndex = 2;
			this.label4.Text = "Monday";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label5.Location = new System.Drawing.Point(630, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(119, 25);
			this.label5.TabIndex = 4;
			this.label5.Text = "Wednesday";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label6.Location = new System.Drawing.Point(448, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(89, 25);
			this.label6.TabIndex = 3;
			this.label6.Text = "Tuesday";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label7.Location = new System.Drawing.Point(1049, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(69, 25);
			this.label7.TabIndex = 6;
			this.label7.Text = "Friday";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label8.Location = new System.Drawing.Point(841, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(91, 25);
			this.label8.TabIndex = 5;
			this.label8.Text = "Thirsday";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label9.Location = new System.Drawing.Point(1233, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(94, 25);
			this.label9.TabIndex = 7;
			this.label9.Text = "Satarday";
			// 
			// lbMonthData
			// 
			this.lbMonthData.AutoSize = true;
			this.lbMonthData.BackColor = System.Drawing.Color.Transparent;
			this.lbMonthData.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMonthData.ForeColor = System.Drawing.Color.White;
			this.lbMonthData.Location = new System.Drawing.Point(643, 3);
			this.lbMonthData.Name = "lbMonthData";
			this.lbMonthData.Size = new System.Drawing.Size(126, 30);
			this.lbMonthData.TabIndex = 3;
			this.lbMonthData.Text = "Month/Year";
			this.lbMonthData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbMonthData.Click += new System.EventHandler(this.lbMonthData_Click);
			// 
			// btnPrevMonth
			// 
			this.btnPrevMonth.BorderRadius = 12;
			this.btnPrevMonth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnPrevMonth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnPrevMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnPrevMonth.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnPrevMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnPrevMonth.FillColor = System.Drawing.Color.DarkSlateBlue;
			this.btnPrevMonth.FillColor2 = System.Drawing.Color.DarkOrchid;
			this.btnPrevMonth.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
			this.btnPrevMonth.ForeColor = System.Drawing.SystemColors.Window;
			this.btnPrevMonth.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.btnPrevMonth.Image = global::PresentationLayer.Properties.Resources.icons8_prev_1;
			this.btnPrevMonth.Location = new System.Drawing.Point(1039, 882);
			this.btnPrevMonth.Name = "btnPrevMonth";
			this.btnPrevMonth.Size = new System.Drawing.Size(180, 45);
			this.btnPrevMonth.TabIndex = 1;
			this.btnPrevMonth.Text = "Preveous Month";
			this.btnPrevMonth.Click += new System.EventHandler(this.btnPrevMonth_Click);
			// 
			// btnNextMonth
			// 
			this.btnNextMonth.Animated = true;
			this.btnNextMonth.BorderRadius = 12;
			this.btnNextMonth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnNextMonth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnNextMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnNextMonth.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnNextMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnNextMonth.FillColor = System.Drawing.Color.DarkSlateBlue;
			this.btnNextMonth.FillColor2 = System.Drawing.Color.DarkOrchid;
			this.btnNextMonth.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
			this.btnNextMonth.ForeColor = System.Drawing.Color.White;
			this.btnNextMonth.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.btnNextMonth.Image = global::PresentationLayer.Properties.Resources.icons8_next;
			this.btnNextMonth.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.btnNextMonth.Location = new System.Drawing.Point(1225, 882);
			this.btnNextMonth.Name = "btnNextMonth";
			this.btnNextMonth.Size = new System.Drawing.Size(180, 45);
			this.btnNextMonth.TabIndex = 1;
			this.btnNextMonth.Text = "Next Month";
			this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.icons8_Calendar_1;
			this.pictureBox1.Location = new System.Drawing.Point(230, 1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(75, 48);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// pbClose
			// 
			this.pbClose.BackColor = System.Drawing.Color.Transparent;
			this.pbClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.pbClose.Image = global::PresentationLayer.Properties.Resources.icons8_close_208px;
			this.pbClose.Location = new System.Drawing.Point(1421, 0);
			this.pbClose.Name = "pbClose";
			this.pbClose.Size = new System.Drawing.Size(43, 49);
			this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbClose.TabIndex = 2;
			this.pbClose.TabStop = false;
			this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// frmBooking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1464, 984);
			this.Controls.Add(this.plContainer);
			this.Controls.Add(this.plTopBar);
			this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Name = "frmBooking";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmBooking";
			this.Load += new System.EventHandler(this.frmBooking_Load);
			this.plTopBar.ResumeLayout(false);
			this.plTopBar.PerformLayout();
			this.plContainer.ResumeLayout(false);
			this.plFacility.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.plCalender.ResumeLayout(false);
			this.plCalender.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel plTopBar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pbClose;
		private System.Windows.Forms.Panel plContainer;
		private System.Windows.Forms.Panel plFacility;
		private System.Windows.Forms.Panel plCalender;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.FlowLayoutPanel fpContainer;
		private System.Windows.Forms.Panel panel1;
		private Guna.UI2.WinForms.Guna2GradientButton btnPrevMonth;
		private Guna.UI2.WinForms.Guna2GradientButton btnNextMonth;
		private System.Windows.Forms.Label lbMonthData;
	}
}