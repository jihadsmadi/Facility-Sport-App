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
	public partial class frmAddNewPerson : Form
	{
		private clsPerson Person;
		private clsPerson.enMode Mode;

		private clsCoustomer customer;

		private void FillMembershipStatusComboBox()
		{


			foreach (DataRow dr in MemberShipStatus.Rows)
			{
				cbMembershipStatus.Items.Add(dr[1].ToString());
			}

			cbMembershipStatus.SelectedIndex = 0;
		}

		DataTable MemberShipStatus;
		public frmAddNewPerson(ref clsPerson Person)
		{
			InitializeComponent();

			panel1.BringToFront();

			this.Person = Person;
			this.Mode = Person.Mode;

			MemberShipStatus = clsCoustomer.GetMemberShipStatus();

			FillMembershipStatusComboBox();

			FillTheFormForUpdatePerson();
		}

		public frmAddNewPerson()
		{
			InitializeComponent();

			plFindPersonForUpdate.BringToFront();
			
			this.Mode = clsPerson.enMode.AddNew;		

			MemberShipStatus = clsCoustomer.GetMemberShipStatus();

			FillMembershipStatusComboBox();
		}





		//Make the form move
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

		private void FillTheFormForUpdatePerson()
		{
			if (Mode == clsPerson.enMode.Update)
			{
				lbAddOrUpdate.Text = "Update Perosn";
				lbPersonIDInAddNewPerson.Text = Person.PersonID.ToString();

				lbPersonIDInAddNewPerson.Text = Person.PersonID.ToString();
				
				

				tbFirstName.Text = Person.FirstName;
				tbLastName.Text = Person.LastName;
				tbNID.Text = Person.NID;
				tbAddress.Text = Person.Address;
				tbPhone.Text = Person.Phone.First().ToString();

				if(plMemberShipStatus.Visible == true)
				{
				
					customer = clsCoustomer.FindByPersonID(this.Person.PersonID);
					customer.PersonID = this.Person.PersonID;

					lbAddOrUpdate.Text = "Update Customer";

					foreach (DataRow dr in MemberShipStatus.Rows)
					{
						if (Convert.ToInt32(dr[0]) == customer.CoustomerMemberShipStatusID)
						{
							cbMembershipStatus.SelectedItem = cbMembershipStatus.Items[customer.CoustomerMemberShipStatusID - 1]  ;
						}
					}

					
				}
			}
			
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
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
					

					Person = clsPerson.Find(PersonID);
					lbPerosnIDInFindingPerson.Text = Person.PersonID.ToString();
					lbNameInfinding.Text = Person.GetFullName();
					lbAddressInFindingPerson.Text = Person.Address;
					lbNationalNoFindingPerson.Text = Person.NID.ToString();
					if (Person.Phone.Count != 0)
					{
						lbPhoneInFindingPerson.Text = Person.Phone.First().ToString();
					}

				}
				else
				{
					MessageBox.Show("Enter a Valied Person ID ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnFind_Click_1(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void guna2Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void tbFindBy_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			if(lbPerosnIDInFindingPerson.Text == "???")
			{
				MessageBox.Show("You Have To Select A Person ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			plMemberShipStatus.Visible = true;
			Mode = clsPerson.enMode.Update;
			panel1.BringToFront();
			FillTheFormForUpdatePerson();
		}

		private void label14_Click(object sender, EventArgs e)
		{

		}

		private void button12_Click(object sender, EventArgs e)
		{

		}

		private void cbMembershipStatus_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void plPersonalInfo_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbFirstName.Text) || string.IsNullOrEmpty(tbLastName.Text) || string.IsNullOrEmpty(tbNID.Text)
				 || string.IsNullOrEmpty(tbAddress.Text) || string.IsNullOrEmpty(tbPhone.Text))

			{
				MessageBox.Show("You Sholud Fill The Form ...!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}

			
				Person.FirstName = tbFirstName.Text;
				Person.LastName = tbLastName.Text;
				Person.NID = tbNID.Text;
				Person.Address = tbAddress.Text;
				Person.Phone.Add(tbPhone.Text);

			if (Person.Save())
			{
				if(plMemberShipStatus.Visible == true)
				{
					customer.CoustomerMemberShipStatusID = cbMembershipStatus.SelectedIndex + 1;
					if(customer.Save())
					{
						MessageBox.Show("Customer Updated Successfuly ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Customer Updated Faild ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
						
					}
					plMemberShipStatus.Visible = false;
					return;
				}

				if (Mode == clsPerson.enMode.Update)
				{
					MessageBox.Show("Person Updated Successfuly ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Person Added Successfuly ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
					lbPersonIDInAddNewPerson.Text = this.Person.PersonID.ToString();
				}



			}
			else
			{
				if (Mode == clsPerson.enMode.Update)
				{ MessageBox.Show("Person Update Faild ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
				else
				{
					MessageBox.Show("Person Added Faild ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}

			lbPersonIDInAddNewPerson.Text = Person.PersonID.ToString();






		}


		
	}
}
