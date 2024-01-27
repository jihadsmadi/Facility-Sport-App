using BesnissLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;

namespace PresentationLayer
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		//For Make The Form Move
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
		

		//btn Methodes

		private void ReturnToDefultBtnStyle()
		{
			btnDashboard.FillColor = Color.SkyBlue;
			btnCoustomers.FillColor = Color.SkyBlue;
			btnApointments.FillColor = Color.SkyBlue;
		}
		
		private void ChangeSideBarBtn(object sender)
		{
			ReturnToDefultBtnStyle();
			

			((Guna2Button)sender).FillColor = Color.FromArgb(126, 200, 193);
		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			ChangeSideBarBtn(sender);

			plDashboard.BringToFront();

			
		}

		private void btnApointments_Click(object sender, EventArgs e)
		{
			ChangeSideBarBtn(sender);

			plAppointements.BringToFront();

			gvBooking.DataSource = clsBooking.GetBookingList();
			
		}

		private void btnAddCustomer_Click(object sender, EventArgs e)
		{
			bool isDatabaseChange = false;

			Form frm = new frmAddNewCustomer(ref isDatabaseChange);

			frm.ShowDialog();




			if (isDatabaseChange)
			{
				gvCustomers.DataSource = clsCoustomer.CoustomersList();
			}
			gvCustomers.DataSource = clsCoustomer.CoustomersList();


		}

		private void btnUpdateCustomer_Click(object sender, EventArgs e)
		{
			if (gvCustomers.SelectedRows.Count == 0  || gvCustomers.SelectedRows[0].DataBoundItem == null)
			{
				frmUpdateCustomer frm = new frmUpdateCustomer();
				frm.ShowDialog();
			} 
			else
			{


				clsCoustomer customer = clsCoustomer.Find(Convert.ToInt32(gvCustomers.SelectedRows[gvCustomers.SelectedRows.Count - 1].Cells[0].Value));

				frmUpdateCustomer frm = new frmUpdateCustomer(ref customer);

				frm.ShowDialog();

			}

			gvCustomers.DataSource = clsCoustomer.CoustomersList();


		}

		private void btnDeleteCustomer_Click(object sender, EventArgs e)
		{
			if (gvCustomers.SelectedRows.Count == 0 || gvCustomers.SelectedRows[0].DataBoundItem == null)
			{
				MessageBox.Show("You Should To Select A Customer ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{


				frmDeleteCustomer frm = new frmDeleteCustomer(clsCoustomer.Find(Convert.ToInt32(gvCustomers.SelectedRows[gvCustomers.SelectedRows.Count - 1].Cells[0].Value)));
				frm.ShowDialog();
				
					gvCustomers.DataSource = clsCoustomer.CoustomersList();
				

			}
		}

		private void btnBook_Click(object sender, EventArgs e)
		{
			frmBooking frm = new frmBooking();
			frm.ShowDialog();

			gvBooking.DataSource = clsBooking.GetBookingList();
		}

		private void plAppointements_Paint(object sender, PaintEventArgs e)
		{

		}

		private void gvBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnChangeStatus_Click(object sender, EventArgs e)
		{
			
			if(gvBooking.SelectedRows.Count == 0)
			{
				MessageBox.Show("You Have To Select A Booking For Do Changing ...!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			else
			{
				frmChangeBookingStatus frm;

				if (gvBooking.SelectedRows.Count > 1)
				{
					 frm = new frmChangeBookingStatus(Convert.ToInt32(gvBooking.SelectedRows[gvBooking.SelectedRows.Count - 1].Cells[0].Value));

				}
				else
				{
					frm = new frmChangeBookingStatus(Convert.ToInt32(gvBooking.SelectedRows[0].Cells[0].Value));

				}

				frm.ShowDialog();			
				gvBooking.DataSource = clsBooking.GetBookingList();

				
			}
		}

		private void btmDeleteBooking_Click(object sender, EventArgs e)
		{
			if (gvBooking.SelectedRows.Count == 0)
			{
				MessageBox.Show("You Have To Select A Booking For Delete ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				frmDeleteBooking frm;

				if (gvBooking.SelectedRows.Count > 1)
				{
					frm = new frmDeleteBooking(Convert.ToInt32(gvBooking.SelectedRows[gvBooking.SelectedRows.Count - 1].Cells[0].Value));

				}
				else
				{
					frm = new frmDeleteBooking(Convert.ToInt32(gvBooking.SelectedRows[0].Cells[0].Value));

				}

				frm.ShowDialog();
				gvBooking.DataSource = clsBooking.GetBookingList();


			}
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{

		}

		private void btnCoustomers_Click(object sender, EventArgs e)
		{
			ChangeSideBarBtn(sender);

			plCustomers.BringToFront();

			gvCustomers.DataSource = clsCoustomer.CoustomersList();




		}

	
	}
}
