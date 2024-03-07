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
	public partial class frmDeleteCustomer : Form
	{
		public frmDeleteCustomer(clsCoustomer Customer)
		{ 
			InitializeComponent();

			this.customer= Customer;
			
			FillDeleteForm();
		}

		public clsCoustomer customer;
	


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
		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FillDeleteForm()
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

		private void btnFind_Click(object sender, EventArgs e)
		{

			if (string.IsNullOrEmpty(tbFindBy.Text))
			{
				MessageBox.Show("Enter a Customer ID For Finding  ....!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}


			else
			{
				int CustomerID = Convert.ToInt32(tbFindBy.Text.Trim());
				if (clsCoustomer.IsCustomerExist(CustomerID))
				{


					customer = clsCoustomer.Find(CustomerID);

					FillDeleteForm();

					btnDelete.Enabled = true;
					
				}
				else
				{
					MessageBox.Show("Enter a Valied Customer ID ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if(lbCustomerID.Text != "???")
			{ 
				
				if(DialogResult.Yes ==  MessageBox.Show("Do You Agree To Delete "+this.customer.GetFullName(),
						"Delete Customer",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
				{
					//Remove Payment Records
					if(clsCoustomer.Delete(this.customer.CoustomerID))
					{
						MessageBox.Show("Customer Deleted Successfuly ....!","Done",MessageBoxButtons.OK, MessageBoxIcon.Information);
						
				

						lbPerosnIDInPersonalInfo.Text = "???";
						lbNameInPersonalInfp.Text = "???";
						lbAddressInPersonalInfo.Text = "???";
						lbNationalNoInPersonalInfo.Text = "???";
						
						lbPhone.Text = "???";
						

						lbCustomerID.Text = "???";
						lbMemberShipStatus.Text = "???";


						btnDelete.Enabled = false;
					}
					else
					{
						MessageBox.Show("Customer Deleted Faild ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				
			}
			else
			{
				MessageBox.Show("You Should To Select A Customer ....!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		
	}
}
