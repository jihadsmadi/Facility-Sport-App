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
	public partial class frmViewCustomer : Form
	{
		public frmViewCustomer(clsCoustomer customer)
		{
			InitializeComponent();

			this.customer = customer;

			FillViewCustomer();
		}

		private clsCoustomer customer;

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

		
		private void pbClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FillViewCustomer()
		{
			lbPerosnIDInPersonalInfo.Text = this.customer.PersonID.ToString();
			lbNameInPersonalInfp.Text = this.customer.GetFullName();
			lbAddressInPersonalInfo.Text = this.customer.Address;
			lbNationalNoInPersonalInfo.Text = this.customer.NID.ToString();
			if (this.customer.Phone.Count != 0)
			{
				lbPhone.Text = this.customer.Phone.First().ToString();
			}

			lbCustomerID.Text = this.customer.CoustomerID.ToString();
			lbMemberShipStatus.Text = this.customer.MemberShipstatusName();
		}
	}
}
