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
			this.lbBasketGames = new System.Windows.Forms.Label();
			this.lbTinusGames = new System.Windows.Forms.Label();
			this.lbFootballGames = new System.Windows.Forms.Label();
			this.pbFootball = new System.Windows.Forms.PictureBox();
			this.pbTinus = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbFootball)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbTinus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lbDay
			// 
			this.lbDay.AutoSize = true;
			this.lbDay.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDay.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.lbDay.Location = new System.Drawing.Point(3, 2);
			this.lbDay.Name = "lbDay";
			this.lbDay.Size = new System.Drawing.Size(28, 21);
			this.lbDay.TabIndex = 0;
			this.lbDay.Text = "00";
			// 
			// lbBasketGames
			// 
			this.lbBasketGames.AutoSize = true;
			this.lbBasketGames.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbBasketGames.Location = new System.Drawing.Point(95, 23);
			this.lbBasketGames.Name = "lbBasketGames";
			this.lbBasketGames.Size = new System.Drawing.Size(15, 17);
			this.lbBasketGames.TabIndex = 4;
			this.lbBasketGames.Text = "2";
			// 
			// lbTinusGames
			// 
			this.lbTinusGames.AutoSize = true;
			this.lbTinusGames.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTinusGames.Location = new System.Drawing.Point(95, 44);
			this.lbTinusGames.Name = "lbTinusGames";
			this.lbTinusGames.Size = new System.Drawing.Size(15, 17);
			this.lbTinusGames.TabIndex = 5;
			this.lbTinusGames.Text = "4";
			// 
			// lbFootballGames
			// 
			this.lbFootballGames.AutoSize = true;
			this.lbFootballGames.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFootballGames.Location = new System.Drawing.Point(95, 2);
			this.lbFootballGames.Name = "lbFootballGames";
			this.lbFootballGames.Size = new System.Drawing.Size(15, 17);
			this.lbFootballGames.TabIndex = 6;
			this.lbFootballGames.Text = "7";
			// 
			// pbFootball
			// 
			this.pbFootball.Image = global::PresentationLayer.Properties.Resources.icons8_soccer_1;
			this.pbFootball.Location = new System.Drawing.Point(69, 4);
			this.pbFootball.Name = "pbFootball";
			this.pbFootball.Size = new System.Drawing.Size(20, 15);
			this.pbFootball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbFootball.TabIndex = 3;
			this.pbFootball.TabStop = false;
			// 
			// pbTinus
			// 
			this.pbTinus.Image = global::PresentationLayer.Properties.Resources.icons8_tennis_player;
			this.pbTinus.Location = new System.Drawing.Point(69, 46);
			this.pbTinus.Name = "pbTinus";
			this.pbTinus.Size = new System.Drawing.Size(20, 15);
			this.pbTinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbTinus.TabIndex = 2;
			this.pbTinus.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.icons8_man_bouncing_ball;
			this.pictureBox1.Location = new System.Drawing.Point(69, 25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(20, 15);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// UserControlDays
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.lbFootballGames);
			this.Controls.Add(this.lbTinusGames);
			this.Controls.Add(this.lbBasketGames);
			this.Controls.Add(this.pbFootball);
			this.Controls.Add(this.pbTinus);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lbDay);
			this.Name = "UserControlDays";
			this.Size = new System.Drawing.Size(112, 66);
			this.Load += new System.EventHandler(this.UserControlDays_Load);
			this.Click += new System.EventHandler(this.UserControlDays_Click);
			((System.ComponentModel.ISupportInitialize)(this.pbFootball)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbTinus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbDay;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pbTinus;
		private System.Windows.Forms.PictureBox pbFootball;
		private System.Windows.Forms.Label lbBasketGames;
		private System.Windows.Forms.Label lbTinusGames;
		private System.Windows.Forms.Label lbFootballGames;
	}
}
