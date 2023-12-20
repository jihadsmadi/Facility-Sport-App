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
		public frmAddNewCustomer()
		{
			InitializeComponent();
			MemberShipStatus = clsCoustomer.GetMemberShipStatus();
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

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmAddNewCustomer_Load(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			int PersonID = Convert.ToInt32(tbFindBy.Text.Trim());
			if (string.IsNullOrEmpty(tbFindBy.Text))
				MessageBox.Show("Enter a Person ID Or Add New Person ....!");

			else
			{
				
				if(clsPerson.IsPersonExists(PersonID))
				{
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
			tbFindBy.Text = this.Person.PersonID.ToString();
			lbNameInPersonalInfp.Text = this.Person.GetFullName();
			lbPerosnIDInPersonalInfo.Text = this.Person.PersonID.ToString();
			lbNationalNoInPersonalInfo.Text = this.Person.NID.ToString();
			lbAddressInPersonalInfo.Text = this.Person.Address;
			lbPhoneInPersonalInfo.Text = this.Person.Phone.First().ToString();
		}
		private void btnAddNew_Click(object sender, EventArgs e)
		{
			frmAddNewPerson frm = new frmAddNewPerson(ref Person);
			frm.ShowDialog();
			FillAddNewCustomerForm();

		}

		private void lbEditPersonInfo_Click(object sender, EventArgs e)
		{
			lbEditPersonInfo.ForeColor = Color.Red;
			frmAddNewPerson frm = new frmAddNewPerson(ref this.Person);
			frm.ShowDialog();
			FillAddNewCustomerForm();
		}

		private void plSubContainer_Paint(object sender, PaintEventArgs e)
		{

		}

		private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

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

			}
			else
			{
				MessageBox.Show("Customer Adding Faild  ...!", "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
			}



		}

		private void plContaner_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			if(Person.Mode == clsPerson.enMode.AddNew)
			{
				MessageBox.Show("You Have To Select Person ....!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}

			this.customer = new clsCoustomer(this.Person, -1);

			plSecondPage.BringToFront();
			lbNameOfProcess.Text = this.Person.GetFullName();
			lbPersonId.Text = "Person ID: " + this.Person.PersonID.ToString();




		}

		private void plTopBar_Paint(object sender, PaintEventArgs e)
		{

		}

		


	}
}
