using BesnissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
	public partial class frmUpdateCustomer : Form
	{
		public clsCoustomer customer;
		public clsPerson Person;
		private DataTable dbMemberShipStatus;

		private void FillCbMemberShipStatus()
		{
			foreach(DataRow dr in dbMemberShipStatus.Rows)
			{
				cbMembershipStatus.Items.Add(dr[1].ToString());
				
			}

			cbMembershipStatus.SelectedIndex = 0;
		}
		public frmUpdateCustomer(ref clsCoustomer customer)
		{
			InitializeComponent();

			this.customer = customer;
			this.Person = clsPerson.Find(this.customer.PersonID);

			dbMemberShipStatus = clsCoustomer.GetMemberShipStatus();

			FillCbMemberShipStatus();

			FillTheFormForUpdateCustomer();

		}

		public frmUpdateCustomer()
		{
			InitializeComponent();

			dbMemberShipStatus = clsCoustomer.GetMemberShipStatus();

			FillCbMemberShipStatus();

			plFindPersonForUpdate.BringToFront();

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
		private void btnFind_Click(object sender, EventArgs e)
		{

			if (string.IsNullOrEmpty(tbFindBy.Text))
			{
				MessageBox.Show("Enter a Customer ID Or Add New Customer ....!");
			}


			else
			{
				int CustomerID = Convert.ToInt32(tbFindBy.Text.Trim());
				if (clsCoustomer.IsCustomerExist(CustomerID))
				{


					customer = clsCoustomer.Find(CustomerID);
					lbCustomerIDINFind.Text = customer.CoustomerID.ToString();
					lbPersonIdInFinding.Text = customer.PersonID.ToString();
					lbNameInfinding.Text = customer.GetFullName();
					lbAddressInFindingPerson.Text = customer.Address;
					lbNationalNoFindingPerson.Text = customer.NID.ToString();
					if (customer.Phone.Count != 0)
					{
						lbPhoneInFindingPerson.Text = customer.Phone.First().ToString();
					}

					lbMemberShipStatus.Text = dbMemberShipStatus.Rows[customer.CoustomerMemberShipStatusID-1].ItemArray[1].ToString();


				}
				else
				{
					MessageBox.Show("Enter a Valied Customer ID ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			if (lbCustomerIDINFind.Text == "???")
			{
				MessageBox.Show("You Have To Select A Person ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			
			plUpdateCustomer.BringToFront();
			Person = clsPerson.Find(customer.PersonID);

			FillTheFormForUpdateCustomer();
		}

		private void FillTheFormForUpdateCustomer()
		{

			
			lbPersonIDInAddNewPerson.Text = Person.PersonID.ToString();

			lbCustomerID.Text = customer.CoustomerID.ToString();


			tbFirstName.Text = Person.FirstName;
			tbLastName.Text = Person.LastName;
			tbNID.Text = Person.NID;
			tbAddress.Text = Person.Address;
			tbPhone.Text = Person.Phone.First().ToString();

			cbMembershipStatus.SelectedIndex = customer.CoustomerMemberShipStatusID - 1;

		}

		

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbFirstName.Text) || string.IsNullOrEmpty(tbLastName.Text) || string.IsNullOrEmpty(tbNID.Text)
				 || string.IsNullOrEmpty(tbAddress.Text) || string.IsNullOrEmpty(tbPhone.Text))

			{
				MessageBox.Show("You Sholud Fill The Form ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}


			Person.FirstName = tbFirstName.Text;
			Person.LastName = tbLastName.Text;
			Person.NID = tbNID.Text;
			Person.Address = tbAddress.Text;
			Person.Phone.Clear();
			Person.Phone.Add(tbPhone.Text.ToString());

			if (Person.Save())
			{
				customer.CoustomerMemberShipStatusID = cbMembershipStatus.SelectedIndex + 1;
				if (customer.Save())
				{

					MessageBox.Show("Customer Updated Successfuly ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

				}
				else
				{
					MessageBox.Show("Customer Updated Faild ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

			}
			else
			{
				 MessageBox.Show("Person Update Faild ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);						
			}

			


		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		
	}
}
