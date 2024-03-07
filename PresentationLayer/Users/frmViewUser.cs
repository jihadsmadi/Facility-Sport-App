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
	public partial class frmViewUser : Form
	{
		public frmViewUser(clsUser user)
		{
			InitializeComponent();

			lbUserID.Text = user.UserID.ToString();
			lbPersonID.Text = user.PersonID.ToString();
			lbUsername.Text = user.UserName.ToString();
			lbName.Text = user.GetFullName();

			FillCheckBoxis(user);
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

		private void FillCheckBoxis(clsUser user)
		{
			if (user.isAllowPermession((int)clsUser.enPermessions.All))
			{
				cbAll.Checked = true;
			}
			else
			{
				cbAll.Checked = false;
			}


			if (user.isAllowPermession((int)clsUser.enPermessions.Dashboard))
			{
				cbDashbaord.Checked = true;
			}
			else
			{
				cbDashbaord.Checked = false;
			}

			if (user.isAllowPermession((int)clsUser.enPermessions.Customers))
			{
				cbCustomers.Checked = true;
			}
			else
			{
				cbCustomers.Checked = false;
			}

			if (user.isAllowPermession((int)clsUser.enPermessions.Booking))
			{
				cbBooking.Checked = true;
			}
			else
			{
				cbBooking.Checked = false;
			}

			if (user.isAllowPermession((int)clsUser.enPermessions.Payments))
			{
				cbPayments.Checked = true;
			}
			else
			{
				cbPayments.Checked = false;
			}

			if (user.isAllowPermession((int)clsUser.enPermessions.Users))
			{
				cbUsers.Checked = true;
			}
			else
			{
				cbUsers.Checked = false;
			}
		}

		private void pbClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
