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
		public frmAddNewPerson(clsPerson Person)
		{
			InitializeComponent();
			this.Person = Person;
			this.Mode = Person.Mode;

			FillTheFormForUpdatePerson();
		}

		public frmAddNewPerson()
		{
			InitializeComponent();

			this.Person = new clsPerson("", "", "","", new List<string>());
			
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


			}
			
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
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
				if (Mode == clsPerson.enMode.Update)
				{
					MessageBox.Show("Person Updated Successfuly ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Person Added Successfuly ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
