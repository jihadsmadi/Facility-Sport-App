using BesnissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
			
		}

	
		//For Make The Form Move
		private bool isClick = false;
		int x, y;

		private void plTopBar_MouseDown(object sender, MouseEventArgs e)
		{
			isClick = true;
			x = e.X;
			y = e.Y;
		}
		private void plTopBar_MouseUp(object sender, MouseEventArgs e)
		{
			isClick = false;
		}
		private void plTopBar_MouseMove(object sender, MouseEventArgs e)
		{

			if (isClick)
			{


				this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
			}


		}

		private void tbPassword_IconRightClick(object sender, EventArgs e)
		{
			string img = "";
			if (tbPassword.PasswordChar == '*')
			{
				tbPassword.PasswordChar = '\0';
				 img = "icons8_blind";
			}
			else
			{
				tbPassword.PasswordChar = '*';
				img = "icons8_eye";
			}

			
			tbPassword.IconRight = Image.FromFile(@"D:\Work Space\Programming\Programming Advice\.NET Freamwork And C#\Facility Sport App\Images\" + img + ".ico");

			

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrWhiteSpace(tbUserName.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
			{
				MessageBox.Show("Enter A Valid Username And Password ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}

			// Add Find By UserName & is User Exist
			
			if (clsUser.isUserExistByUserName(tbUserName.Text.Trim(),tbPassword.Text.Trim()))
			{
				clsUser user = clsUser.Find(tbUserName.Text.Trim(), tbPassword.Text.Trim());

				if(user != null)
				{
					frmMain frm = new frmMain(user);
					this.Hide();
					frm.Show();
									
					
				
				}
				else
				{
					MessageBox.Show("Enter A Valid Username And Password ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
					return;
				}
				
			}
			else
			{
				MessageBox.Show("Enter A Valid Username And Password ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}

		}

		private void btnLogin_Enter(object sender, EventArgs e)
		{
			btnLogin.BorderColor = Color.White;
		}

		private void btnLogin_Leave(object sender, EventArgs e)
		{
			btnLogin.BorderColor = Color.SteelBlue;
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		
		}



	}
}
