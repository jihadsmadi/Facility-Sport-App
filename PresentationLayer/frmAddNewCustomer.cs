using BesnissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
	public partial class frmAddNewCustomer : Form
	{
		bool isDatabaseChanged;
		public frmAddNewCustomer(ref bool isDatabaseChange)
		{
			InitializeComponent();

			MemberShipStatus = clsCoustomer.GetMemberShipStatus();
			lbEditPersonInfo.Visible = false;

			this.isDatabaseChanged= isDatabaseChange;

			FillMembershipStatusComboBox();
		}

		public frmAddNewCustomer(ref int CustomerID)
		{
			InitializeComponent();

			MemberShipStatus = clsCoustomer.GetMemberShipStatus();
			lbEditPersonInfo.Visible = false;

			CustomerIDForBack = CustomerID;

			FillMembershipStatusComboBox();
		}



		private void FillMembershipStatusComboBox()
		{
			

			foreach(DataRow dr in MemberShipStatus.Rows)
			{
				cbMembershipStatus.Items.Add(dr[1].ToString());
			}

			cbMembershipStatus.SelectedIndex= 0;
		}

		DataTable MemberShipStatus ;
		clsPerson Person = new clsPerson("","","","",new List<string>());
		clsCoustomer customer;

		private bool isClick = false;
		int x, y;

		int CustomerIDForBack = -1;

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
				MessageBox.Show("Enter a Person ID Or Add New Person ....!");
			}
				
			
			else
			{
				int PersonID = Convert.ToInt32(tbFindBy.Text.Trim());
				if (clsPerson.IsPersonExists(PersonID))
				{
					lbEditPersonInfo.Visible = true;

					 Person = clsPerson.Find(PersonID);
					lbPerosnIDInPersonalInfo.Text = Person.PersonID.ToString();
					lbNameInPersonalInfp.Text = Person.GetFullName();
					lbAddressInPersonalInfo.Text = Person.Address;
					lbNationalNoInPersonalInfo.Text = Person.NID.ToString();
					if(Person.Phone.Count !=0)
					{
						lbPhoneInPersonalInfo.Text = Person.Phone.First().ToString();
					}
					
				}
				else
				{
					MessageBox.Show("Enter a Valied Person ID ....!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
					
		}

		private void FillAddNewCustomerForm()
		{
			if (Person.PersonID != -1)
			{
				lbEditPersonInfo.Visible = true;

				

				tbFindBy.Text = this.Person.PersonID.ToString();
				lbNameInPersonalInfp.Text = this.Person.GetFullName();
				lbPerosnIDInPersonalInfo.Text = this.Person.PersonID.ToString();
				lbNationalNoInPersonalInfo.Text = this.Person.NID.ToString();
				lbAddressInPersonalInfo.Text = this.Person.Address;

				if (this.Person.Phone.Count != 0)
				{
					lbPhoneInPersonalInfo.Text = this.Person.Phone.First().ToString();
				}
			}
				
			

			
		}

		private void btnAddNew_Click(object sender, EventArgs e)
		{
			
			Person.Mode = clsPerson.enMode.AddNew;

			frmAddNewPerson frm = new frmAddNewPerson(ref Person);
			frm.ShowDialog();

			FillAddNewCustomerForm();
			

		}

		

		

		private void btnSave_Click(object sender, EventArgs e)
		{
			this.customer.PersonID = this.Person.PersonID;

			foreach (DataRow row in this.MemberShipStatus.Rows)
			{
				if (cbMembershipStatus.SelectedItem.ToString() == row[1].ToString())
					this.customer.CoustomerMemberShipStatusID = Convert.ToInt32(row[0]);
			}
			if (customer.Save())
			{
				MessageBox.Show("Customer Added Successfuly ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
				lbCustomerID.Text = customer.CoustomerID.ToString();
				btnSave.Enabled = false;
				this.isDatabaseChanged= true;
				frmBooking.SetCustomerIDForAddNewCustomer(customer.CoustomerID);
			}
			else
			{
				MessageBox.Show("Customer Adding Faild  ...!", "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
			}



		}

		

		private void btnNext_Click(object sender, EventArgs e)
		{
			if (Person.Mode == clsPerson.enMode.AddNew)
			{
				MessageBox.Show("You Have To Select Person ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (clsCoustomer.IsCustomerExistByPersonID(this.Person.PersonID))
			{
				MessageBox.Show($"This Person With {this.Person.GetFullName()} Name Is Already A Customer ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			this.customer = new clsCoustomer(this.Person, -1);

			plCustomerInfoTopBar.BackColor = Color.SkyBlue;
			plPersonInfoTopBar.BackColor = Color.Transparent;

			plSecondPage.BringToFront();
			lbNameOfProcess.Text = this.Person.GetFullName()+ " Process";
			lbPersonId.Text = "Person ID: " + this.Person.PersonID.ToString();




		}

		private void lbEditPersonInfo_Click_1(object sender, EventArgs e)
		{
			Person.Mode = clsPerson.enMode.Update;

			frmAddNewPerson frm = new frmAddNewPerson(ref Person);
			frm.ShowDialog();

			FillAddNewCustomerForm();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			plCustomerInfoTopBar.BackColor = Color.Transparent;
			plPersonInfoTopBar.BackColor =  Color.SkyBlue;
			plFirstPage.BringToFront();
		}

		private void guna2Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();

			

		}

	

		


	}
}
