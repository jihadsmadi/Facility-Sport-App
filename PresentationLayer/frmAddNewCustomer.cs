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
	public partial class frmAddNewCustomer : Form
	{
		public frmAddNewCustomer()
		{
			InitializeComponent();
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
					clsPerson Person = clsPerson.Find(PersonID);
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

		private void btnAddNew_Click(object sender, EventArgs e)
		{
			frmAddNewPerson frm = new frmAddNewPerson();
			frm.ShowDialog();
		}

		private void plTopBar_Paint(object sender, PaintEventArgs e)
		{

		}

		


	}
}
