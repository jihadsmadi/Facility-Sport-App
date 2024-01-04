namespace PresentationLayer
{
	partial class UserControlDays
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbDay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbDay
			// 
			this.lbDay.AutoSize = true;
			this.lbDay.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDay.Location = new System.Drawing.Point(12, 11);
			this.lbDay.Name = "lbDay";
			this.lbDay.Size = new System.Drawing.Size(28, 21);
			this.lbDay.TabIndex = 0;
			this.lbDay.Text = "00";
			// 
			// UserControlDays
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.lbDay);
			this.Name = "UserControlDays";
			this.Size = new System.Drawing.Size(112, 66);
			this.Load += new System.EventHandler(this.UserControlDays_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbDay;
	}
}
