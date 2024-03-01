using BesnissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
	public partial class frmChangeUserPassword : Form
	{
		public frmChangeUserPassword(clsUser user)
		{
			InitializeComponent();
			this.User = user;
			lbUsername.Text = User.UserName.ToString();
			
		}

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

		public clsUser User { get; set; }

		private void pbClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if(tbPassword.Text != tbConfirmPassword.Text)
			{
				MessageBox.Show("Passwords Are Not The Same ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				tbPassword.Clear();
				tbConfirmPassword.Clear();
				return;
			}
			else
			{
				User.Password = tbPassword.Text;
				if(User.Save())
				{
					MessageBox.Show("Passwords Changed Successfuly ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
					tbPassword.Clear();
					tbConfirmPassword.Clear();
					return;
				}
			}
		}
	}
}
