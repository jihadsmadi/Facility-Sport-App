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
using System.Web.UI.WebControls;
using System.Web.WebSockets;
using System.Windows.Forms;

namespace PresentationLayer
{
	public partial class frmMain : Form
	{
		public frmMain(clsUser User)
		{
			InitializeComponent();

			ProgramUser = User;
			LoadProgram();
		}

		public clsUser ProgramUser { get; set; }


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


		//Filter Tabels
		public enum enBookingFilterByItems { BookingID = 0, BookingStatus = 1, CustomerID = 2, DateOfBooking = 3, FacilityName = 4, PaymentID = 5 }
		public enum enCustomerFilterByItems { CoustomerID = 0, Status = 1 }
		public enum enPaymentFilterByItems { CoustomerID = 0, PaymentID = 1, Status = 2 }


		//btn Methodes
		private void LoadProgram()
		{
			lbUserNameDashboard.Text = ProgramUser.UserName;
			lbTodayDateDashboard.Text = DateTime.Now.ToString();
			lbUserFullNameDashboard.Text = ProgramUser.GetFullName();
			lbUsernam.Text = ProgramUser.GetFullName();

			btnDashboard.PerformClick();
		}
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		private void btn_Enter(object sender, EventArgs e)
		{
			((Guna2Button)(sender)).BorderColor = Color.Teal;
		}
		private void btn_Leave(object sender, EventArgs e)
		{
			((Guna2Button)(sender)).BorderColor = Color.SkyBlue;
		}
		private void ReturnToDefultBtnStyle()
		{
			btnDashboard.FillColor = Color.SkyBlue;
			btnCoustomers.FillColor = Color.SkyBlue;
			btnApointments.FillColor = Color.SkyBlue;
			btnPayments.FillColor = Color.SkyBlue;
			btnUsers.FillColor = Color.SkyBlue;
			btnAbout.FillColor = Color.SkyBlue;
			btnLogOut.FillColor = Color.SkyBlue;
		}
		private void ChangeSideBarBtn(object sender)
		{
			ReturnToDefultBtnStyle();
			((Guna2Button)sender).FillColor = Color.FromArgb(126, 200, 193);
		}
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		//Side Bar Buttons
		
		private void btnDashboard_Click(object sender, EventArgs e)
		{
			ChangeSideBarBtn(sender);

			if(!this.ProgramUser.isAllowPermession((int)clsUser.enPermessions.Dashboard))
			{
				plAccessDenied.BringToFront();
				return;
			}

			FillDashboard();
			plDashboard.BringToFront();
		}
		private void btnCoustomers_Click(object sender, EventArgs e)
		{
			ChangeSideBarBtn(sender);

			if (!this.ProgramUser.isAllowPermession((int)clsUser.enPermessions.Customers))
			{
				plAccessDenied.BringToFront();
				return;
			}

			plCustomers.BringToFront();
			gvCustomers.DataSource = clsCoustomer.CoustomersList();
			FillFilterByComboBoxForCustomer();


		}
		private void btnApointments_Click(object sender, EventArgs e)
		{
			ChangeSideBarBtn(sender);

			if (!this.ProgramUser.isAllowPermession((int)clsUser.enPermessions.Booking))
			{
				plAccessDenied.BringToFront();
				return;
			}

			plAppointements.BringToFront();
			plFilterContaner.Visible = false;
			gvBooking.DataSource = clsBooking.GetBookingList().DefaultView;
			FillFilterByComboBoxForBooking();

		}
		private void btnPayments_Click(object sender, EventArgs e)
		{
			ChangeSideBarBtn(sender);

			if (!this.ProgramUser.isAllowPermession((int)clsUser.enPermessions.Payments))
			{
				plAccessDenied.BringToFront();
				return;
			}

			plPayments.BringToFront();
			FillFilterByComboBoxForPayments();
			gvPayments.DataSource = clsPayments.GetPaymentsList();
		}
		private void btnUsers_Click(object sender, EventArgs e)
		{
			ChangeSideBarBtn(sender);
			if (!this.ProgramUser.isAllowPermession((int)clsUser.enPermessions.Users))
			{
				plAccessDenied.BringToFront();
				return;
			}
			plUsers.BringToFront();
			gvUsersList.DataSource = clsUser.GetUsersList();
		}
		private void btnAbout_Click(object sender, EventArgs e)
		{
			ChangeSideBarBtn(sender);
			plAboutUs.BringToFront();
			btnEnglishLan.PerformClick();

		}
		private void btnLogOut_Click(object sender, EventArgs e)
		{
			frmLogin frm = new frmLogin();
			frm.Show();
			this.Hide();
			this.Close();
		}

		//Dashboard
		private void FillDashboard()
		{
			FillProdactivityPrograssBars();
			FillTodaysAppointements();
			LoadTop3ProdactivityCustomers();
			CheckIfThereIsTodayApp();
		}
		private void btnBookNowAtDashboard_Click(object sender, EventArgs e)
		{
			frmBooking frm = new frmBooking();
			frm.ShowDialog();

			gvTodaysAppointements.DataSource = clsBooking.GetTodaysAppointementsList();

			CheckIfThereIsTodayApp();
		}
		private void btnBookNowAtDashboard_Enter(object sender, EventArgs e)
		{
			btnBookNowAtDashboard.BorderColor = Color.White;
		}
		private void btnViewProfile_Click(object sender, EventArgs e)
		{
			frmViewUser frm = new frmViewUser(this.ProgramUser);
			frm.ShowDialog();
		}
		private void btnChangePassword_Enter(object sender, EventArgs e)
		{
			((Guna2Button)(sender)).BorderColor = Color.White;
		}
		private void btnChangePassword_Leave(object sender, EventArgs e)
		{
			((Guna2Button)(sender)).BorderColor = Color.Teal;
		}
		private void btnBookNowAtDashboard_Leave(object sender, EventArgs e)
		{
			btnBookNowAtDashboard.BorderColor = Color.CadetBlue;
		}
		private void btnChangePassword_Click(object sender, EventArgs e)
		{
			frmChangeUserPassword frm = new frmChangeUserPassword(this.ProgramUser);
			frm.ShowDialog();
		}
		private void tsmViewBookingInTodaysApp_Click(object sender, EventArgs e)
		{
			frmViewBooking frm;

			if (gvTodaysAppointements.SelectedRows.Count > 1)
			{
				frm = new frmViewBooking(Convert.ToInt32(gvTodaysAppointements.SelectedRows[gvTodaysAppointements.SelectedRows.Count - 1].Cells[0].Value));
			}
			else
			{
				frm = new frmViewBooking(Convert.ToInt32(gvTodaysAppointements.SelectedRows[0].Cells[0].Value));
			}

			frm.ShowDialog();
		}
		private void tsmCheckStatusInTodaysAppMenuItem4_Click(object sender, EventArgs e)
		{
			if (gvTodaysAppointements.SelectedRows.Count == 0)
			{
				MessageBox.Show("You Have To Select A Booking For Do Changing ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				frmChangeBookingStatus frm;

				if (gvTodaysAppointements.SelectedRows.Count > 1)
				{
					frm = new frmChangeBookingStatus(Convert.ToInt32(gvTodaysAppointements.SelectedRows[gvTodaysAppointements.SelectedRows.Count - 1].Cells[0].Value));
				}
				else
				{
					frm = new frmChangeBookingStatus(Convert.ToInt32(gvTodaysAppointements.SelectedRows[0].Cells[0].Value));
				}

				frm.ShowDialog();
				gvTodaysAppointements.DataSource = clsBooking.GetTodaysAppointementsList();

			}
		}
		private void tsmCompleteInTodaysApp_Click(object sender, EventArgs e)
		{
			int bookingID = -1;
			clsBooking booking;
			clsPayments payment;
			if (gvTodaysAppointements.SelectedRows.Count > 1)
			{
				bookingID = Convert.ToInt32(gvTodaysAppointements.SelectedRows[gvBooking.SelectedRows.Count - 1].Cells[0].Value);
			}
			else
			{
				bookingID = Convert.ToInt32(gvTodaysAppointements.SelectedRows[0].Cells[0].Value);
			}
			booking = clsBooking.Find(bookingID);

			if (!booking.IsConfirmed())
			{
				MessageBox.Show("You Should To Confirm The Booking Before Complete It ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (DateTime.Today != booking.DateOfBooking)
			{
				MessageBox.Show("You Can Complete The Booking Only At The Booking Day ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			payment = clsPayments.Find(booking.PaymentID);

			if (payment.IsPaid())
			{
				if (booking.Complete())
				{
					MessageBox.Show("Booking Completed Successfully ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
					gvTodaysAppointements.DataSource = clsBooking.GetTodaysAppointementsList();
					return;
				}
			}

			frmAddNewPayment frm = new frmAddNewPayment(payment);
			frm.ShowDialog();

			payment = clsPayments.Find(payment.PaymentID);

			if (payment.IsPaid())
			{
				if (booking.Complete())
				{
					MessageBox.Show("Booking Completed Successfully ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
					gvTodaysAppointements.DataSource = clsBooking.GetTodaysAppointementsList();
					return;
				}
			}
			else
			{
				MessageBox.Show("You Have To Complete The Payment With Id [" + booking.PaymentID.ToString() + "] To Complete The Booking ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}


		}
		private void tsmViewPaymentInTodaysApp_Click(object sender, EventArgs e)
		{
			if (gvTodaysAppointements.SelectedRows.Count == 0)
			{
				MessageBox.Show("You Have To Select A Payment For View ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				frmViewPayment frm;

				if (gvTodaysAppointements.SelectedRows.Count > 1)
				{
					frm = new frmViewPayment(clsPayments.Find(Convert.ToInt32(gvBooking.SelectedRows[gvTodaysAppointements.SelectedRows.Count - 1].Cells[5].Value)));
				}
				else
				{
					frm = new frmViewPayment(clsPayments.Find(Convert.ToInt32(gvTodaysAppointements.SelectedRows[0].Cells[5].Value)));
				}

				frm.ShowDialog();

			}
		}
		private void tsmViewCustomerTodaysApp_Click(object sender, EventArgs e)
		{
			if (gvTodaysAppointements.SelectedRows.Count == 0)
			{
				MessageBox.Show("You Have To Select A Booking For View Customer ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				frmViewCustomer frm = new frmViewCustomer(clsCoustomer.Find(clsBooking.Find(Convert.ToInt32(gvTodaysAppointements.SelectedRows[0].Cells[0].Value)).CoustomerID));
				frm.ShowDialog();
			}
		}
		private void tsmDelete_Click(object sender, EventArgs e)
		{
			if (gvTodaysAppointements.SelectedRows.Count == 0)
			{
				MessageBox.Show("You Have To Select A Booking For Delete ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				frmDeleteBooking frm;

				if (gvTodaysAppointements.SelectedRows.Count > 1)
				{
					frm = new frmDeleteBooking(Convert.ToInt32(gvTodaysAppointements.SelectedRows[gvTodaysAppointements.SelectedRows.Count - 1].Cells[0].Value));
				}
				else
				{
					frm = new frmDeleteBooking(Convert.ToInt32(gvTodaysAppointements.SelectedRows[0].Cells[0].Value));
				}

				frm.ShowDialog();
				gvTodaysAppointements.DataSource = clsBooking.GetTodaysAppointementsList();
				CheckIfThereIsTodayApp();
			}
		}
		private void tsmConfirmTodaysApp_Click(object sender, EventArgs e)
		{
			int bookingID = -1;
			clsBooking booking;
			if (gvTodaysAppointements.SelectedRows.Count > 1)
			{
				bookingID = Convert.ToInt32(gvTodaysAppointements.SelectedRows[gvTodaysAppointements.SelectedRows.Count - 1].Cells[0].Value);
			}
			else
			{
				bookingID = Convert.ToInt32(gvTodaysAppointements.SelectedRows[0].Cells[0].Value);
			}
			booking = clsBooking.Find(bookingID);
			// 3 equls in database pending status
			if (booking.BookingStatusID != 3)
			{
				MessageBox.Show("You Can Not Confirm Not Pending Booking ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (booking.ConfirmStatus())
			{
				MessageBox.Show("Reservation At " + booking.DateOfBooking.ToShortDateString() + " Has Been Confirmed ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
				gvTodaysAppointements.DataSource = clsBooking.GetTodaysAppointementsList();
				return;
			}
			else
			{
				MessageBox.Show("Reservation Dose Not Confirmed ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}
		private void tsmCencelInTodaysApp_Click(object sender, EventArgs e)
		{
			int bookingID = -1;
			clsBooking booking;
			if (gvTodaysAppointements.SelectedRows.Count > 1)
			{
				bookingID = Convert.ToInt32(gvTodaysAppointements.SelectedRows[gvTodaysAppointements.SelectedRows.Count - 1].Cells[0].Value);
			}
			else
			{
				bookingID = Convert.ToInt32(gvTodaysAppointements.SelectedRows[0].Cells[0].Value);
			}
			booking = clsBooking.Find(bookingID);

			// 4 equls in database Completed status
			if (booking.BookingStatusID == 4)
			{
				MessageBox.Show("You Can Not Cencel Completed Booking ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (booking.Cencel())
			{
				MessageBox.Show("Reservation At " + booking.DateOfBooking.ToShortDateString() + " Has Been Canceled ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
				gvTodaysAppointements.DataSource = clsBooking.GetTodaysAppointementsList();
				return;
			}
			else
			{
				MessageBox.Show("Reservation Dose Not Confirmed ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

		}
		private void LoadTop3ProdactivityCustomers()
		{
			DataTable db = clsCoustomer.GetTop3ProdactivityCustomers();

			Random r = new Random();

			for (int j = 0; j < db.Rows.Count; j++)
			{
				UserControlTopProdactivityItem item = new UserControlTopProdactivityItem();

				item.SetName(db.Rows[j]["Name"].ToString());
				item.SetNumberOfReservatio(Convert.ToInt32(db.Rows[j]["NumOfReservation"]));
				item.CustomerID = Convert.ToInt32(db.Rows[j]["CoustomerID"]);

				int i = r.Next(1, 27);
				if (i >= 1 && i <= 3)
				{
					item.SetImage(Properties.Resources.man1);
				}
				else if (i >= 4 && i <= 6)
				{
					item.SetImage(Properties.Resources.man2);
				}
				else if (i >= 7 && i <= 9)
				{
					item.SetImage(Properties.Resources.girl);
				}
				else if (i >= 10 && i <= 14)
				{
					item.SetImage(Properties.Resources.girl2);
				}
				else if (i >= 15 && i <= 18)
				{
					item.SetImage(Properties.Resources.girl3);
				}
				else if (i >= 19 && i <= 23)
				{
					item.SetImage(Properties.Resources.girl4);
				}
				else if (i >= 24 && i <= 28)
				{
					item.SetImage(Properties.Resources.man3);
				}
				else
				{
					item.SetImage(Properties.Resources.man4);
				}

				flpTop3ProdactivityCustomer.Controls.Add(item);
			}
		}
		private void FillProdactivityPrograssBars()
		{
			DataTable facilityProductivity = clsFacility.GetFacilitysProductivity();

			prograssbarFootball.Value = Convert.ToInt32(facilityProductivity.Rows[0].ItemArray[1]);
			prograssbarTinnes.Value = Convert.ToInt32(facilityProductivity.Rows[1].ItemArray[1]);
			PrograssbarBasket.Value = Convert.ToInt32(facilityProductivity.Rows[2].ItemArray[1]);

			lbProductivityFootball.Text = prograssbarFootball.Value.ToString() + "%";
			lbProductivityTinnes.Text = prograssbarTinnes.Value.ToString() + "%";
			lbProductivityBasketball.Text = PrograssbarBasket.Value.ToString() + "%";

		}
		private void FillTodaysAppointements()
		{
			gvTodaysAppointements.DataSource = clsBooking.GetTodaysAppointementsList();
		}
		private void CheckIfThereIsTodayApp()
		{
			if (gvTodaysAppointements.Rows.Count == 0)
			{
				plThereIsNoTodaysApp.BringToFront();
			}
			else
			{
				plTodaysDataGridView.BringToFront();
			}
		}

		// Booking
		private void FillFilterByComboBoxForBooking()
		{
			cbFilterBy.Items.Clear();
			string[] cbBookingItems = { "BookingID", "BookingStatus", "CustomerID", "DateOfBooking", "FacilityName", "PaymentID" };

			foreach (string item in cbBookingItems)
			{
				cbFilterBy.Items.Add(item);
			}
		}
		private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbResultForFilterBy.Items.Clear();
			tbFilterByIDAtBooking.Clear();
			enBookingFilterByItems enSelectedFilter = ((enBookingFilterByItems)cbFilterBy.SelectedIndex);
			plFilterContaner.Visible = true;

			if (enSelectedFilter == enBookingFilterByItems.CustomerID || enSelectedFilter == enBookingFilterByItems.PaymentID || enSelectedFilter == enBookingFilterByItems.BookingID)
			{
				plTextBoxFiiterBooking.BringToFront();
				return;
			}
			else if (enSelectedFilter == enBookingFilterByItems.DateOfBooking)
			{
				plFilterByDateOfBooking.BringToFront();
				return;
			}
			else
			{
				if (enSelectedFilter == enBookingFilterByItems.FacilityName)
				{
					string[] FacilityNames = { "Football1", "Football2", "Football3", "Football4", "Tennis1", "Tennis2", "Basketball1" };

					foreach (string s in FacilityNames)
					{
						cbResultForFilterBy.Items.Add(s);
					}

				}
				else if (enSelectedFilter == enBookingFilterByItems.BookingStatus)
				{
					string[] BookingStatus = { "Confirmed", "Canceled", "Pending", "Completed" };
					foreach (string s in BookingStatus)
					{
						cbResultForFilterBy.Items.Add(s);
					}
				}
				plComboBoxForFilter.BringToFront();
			}
		}
		private void tbFilterBooking_TextChanged(object sender, EventArgs e)
		{
			DataTable db = clsBooking.GetBookingList();
			if (string.IsNullOrEmpty(tbFilterByIDAtBooking.Text))
			{
				gvBooking.DataSource = db;
				return;
			}
			int ID = -1;
			if (!int.TryParse(tbFilterByIDAtBooking.Text, out ID) || string.IsNullOrWhiteSpace(tbFilterByIDAtBooking.Text))
			{
				return;
			}

			enBookingFilterByItems enSelectedFilter = ((enBookingFilterByItems)cbFilterBy.SelectedIndex);
			DataView dv = db.DefaultView;

			if (enSelectedFilter == enBookingFilterByItems.CustomerID)
			{
				dv.RowFilter = "CoustomerID  = " + ID;
				gvBooking.DataSource = dv;
				return;
			}

			dv.RowFilter = enSelectedFilter + "  = " + ID;
			gvBooking.DataSource = dv;
		}
		private void ClearFilterBooking_Click(object sender, EventArgs e)
		{
			tbFilterByIDAtBooking.Clear();
			cbFilterBy.SelectedIndex = -1;
			plFilterContaner.Visible = false;
			gvBooking.DataSource = clsBooking.GetBookingList();
		}
		private void cbResultForFilterBy_SelectedIndexChanged(object sender, EventArgs e)
		{

			enBookingFilterByItems enSelectedFilter = ((enBookingFilterByItems)cbFilterBy.SelectedIndex);
			DataView dv = clsBooking.GetBookingList().DefaultView;

			dv.RowFilter = enSelectedFilter + " = '" + cbResultForFilterBy.SelectedItem.ToString() + "'";
			gvBooking.DataSource = dv;
		}
		private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			DataView dv = clsBooking.GetBookingList().DefaultView;
			dv.RowFilter = "DateOfBooking = " + "'" + dtBookingDateForFilterInBooking.Value.ToShortDateString() + "'";
			gvBooking.DataSource = dv;
		}
		private void viewBooking_Click(object sender, EventArgs e)
		{
			frmViewBooking frm;

			if (gvBooking.SelectedRows.Count > 1)
			{
				frm = new frmViewBooking(Convert.ToInt32(gvBooking.SelectedRows[gvBooking.SelectedRows.Count - 1].Cells[0].Value));
			}
			else
			{
				frm = new frmViewBooking(Convert.ToInt32(gvBooking.SelectedRows[0].Cells[0].Value));
			}

			frm.ShowDialog();
			return;

		}
		private void tsmViewPayment_Click(object sender, EventArgs e)
		{
			if (gvBooking.SelectedRows.Count == 0)
			{
				MessageBox.Show("You Have To Select A Booking For Delete ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				frmViewPayment frm;

				if (gvBooking.SelectedRows.Count > 1)
				{
					frm = new frmViewPayment(clsPayments.Find(Convert.ToInt32(gvBooking.SelectedRows[gvBooking.SelectedRows.Count - 1].Cells[8].Value)));
				}
				else
				{
					frm = new frmViewPayment(clsPayments.Find(Convert.ToInt32(gvBooking.SelectedRows[0].Cells[8].Value)));
				}

				frm.ShowDialog();
			}


		}
		private void tsmCencel_Click(object sender, EventArgs e)
		{


			int bookingID = -1;
			clsBooking booking;
			if (gvBooking.SelectedRows.Count > 1)
			{
				bookingID = Convert.ToInt32(gvBooking.SelectedRows[gvBooking.SelectedRows.Count - 1].Cells[0].Value);
			}
			else
			{
				bookingID = Convert.ToInt32(gvBooking.SelectedRows[0].Cells[0].Value);
			}
			booking = clsBooking.Find(bookingID);

			// 4 equls in database Completed status
			if (booking.BookingStatusID == 4)
			{
				MessageBox.Show("You Can Not Cencel Completed Booking ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (booking.Cencel())
			{
				MessageBox.Show("Reservation At " + booking.DateOfBooking.ToShortDateString() + " Has Been Canceled ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
				gvBooking.DataSource = clsBooking.GetBookingList();
				return;
			}
			else
			{
				MessageBox.Show("Reservation Dose Not Confirmed ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}
		private void tsmComplete_Click(object sender, EventArgs e)
		{
			int bookingID = -1;
			clsBooking booking;
			clsPayments payment;
			if (gvBooking.SelectedRows.Count > 1)
			{
				bookingID = Convert.ToInt32(gvBooking.SelectedRows[gvBooking.SelectedRows.Count - 1].Cells[0].Value);
			}
			else
			{
				bookingID = Convert.ToInt32(gvBooking.SelectedRows[0].Cells[0].Value);
			}
			booking = clsBooking.Find(bookingID);

			if (!booking.IsConfirmed())
			{
				MessageBox.Show("You Should To Confirm The Booking Before Complete It ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (DateTime.Today != booking.DateOfBooking)
			{
				MessageBox.Show("You Can Complete The Booking Only At The Booking Day ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			payment = clsPayments.Find(booking.PaymentID);

			frmAddNewPayment frm = new frmAddNewPayment(payment);
			frm.ShowDialog();

			payment = clsPayments.Find(payment.PaymentID);

			if (payment.IsPaid())
			{
				if (booking.Complete())
				{
					MessageBox.Show("Booking Completed Successfully ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
					gvBooking.DataSource = clsBooking.GetBookingList();
					return;
				}
			}
			else
			{
				MessageBox.Show("You Have To Complete The Payment With Id [" + booking.PaymentID.ToString() + "] To Complete The Booking ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

		}
		private void tsmViewCustomerInfo_Click(object sender, EventArgs e)
		{

			if (gvCustomers.SelectedRows.Count == 0 || gvCustomers.SelectedRows[0].DataBoundItem == null)
			{
				MessageBox.Show("You Have To Select A Row For Do The Action ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				clsCoustomer customer = clsCoustomer.Find(Convert.ToInt32(gvCustomers.SelectedRows[gvCustomers.SelectedRows.Count - 1].Cells[0].Value));

				frmViewCustomer frm = new frmViewCustomer(customer);

				frm.ShowDialog();

			}


		}
		private void tsmViewCustomer_Click(object sender, EventArgs e)
		{
			if (gvBooking.SelectedRows.Count == 0)
			{
				MessageBox.Show("You Have To Select A Booking For View Customer ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				frmViewCustomer frm = new frmViewCustomer(clsCoustomer.Find(Convert.ToInt32(gvBooking.SelectedRows[0].Cells[1].Value)));
				frm.ShowDialog();
			}
		}
		private void btnBook_Click(object sender, EventArgs e)
		{
			frmBooking frm = new frmBooking();
			frm.ShowDialog();

			gvBooking.DataSource = clsBooking.GetBookingList();
		}
		private void btnChangeStatus_Click(object sender, EventArgs e)
		{

			if (gvBooking.SelectedRows.Count == 0)
			{
				MessageBox.Show("You Have To Select A Booking For Do Changing ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			int bookingID = -1;
			clsBooking booking;
			if (gvBooking.SelectedRows.Count > 1)
			{
				bookingID = Convert.ToInt32(gvBooking.SelectedRows[gvBooking.SelectedRows.Count - 1].Cells[0].Value);
			}
			else
			{
				bookingID = Convert.ToInt32(gvBooking.SelectedRows[0].Cells[0].Value);
			}
			booking = clsBooking.Find(bookingID);
			// 3 equls in database pending status
			if (booking.BookingStatusID != 3)
			{
				MessageBox.Show("You Can Not Confirm Not Pending Booking ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (booking.ConfirmStatus())
			{
				MessageBox.Show("Reservation At " + booking.DateOfBooking.ToShortDateString() + " Has Been Confirmed ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
				gvBooking.DataSource = clsBooking.GetBookingList();
				return;
			}
			else
			{
				MessageBox.Show("Reservation Dose Not Confirmed ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		//Customers

		private void FillFilterByComboBoxForCustomer()
		{
			cbFilterByInCustomer.Items.Clear();
			string[] cbBookingItems = { "CustomerID", "Status" };

			foreach (string item in cbBookingItems)
			{
				cbFilterByInCustomer.Items.Add(item);
			}
		}
		private void btnAddCustomer_Click(object sender, EventArgs e)
		{
			bool isDatabaseChange = false;

			Form frm = new frmAddNewCustomer(ref isDatabaseChange);

			frm.ShowDialog();

			gvCustomers.DataSource = clsCoustomer.CoustomersList();

		}
		private void cbFilterByInCustomer_SelectedIndexChanged(object sender, EventArgs e)
		{

			tbFilterByIDInCustomer.Clear();
			enCustomerFilterByItems enSelectedFilter = ((enCustomerFilterByItems)cbFilterByInCustomer.SelectedIndex);
			plFilterResultInCustomer.Visible = true;

			if (enSelectedFilter == enCustomerFilterByItems.CoustomerID)
			{
				plFilterByIDInCustomer.BringToFront();
				return;
			}
			else
			{
				plFilterByComboBoxInCustomer.BringToFront();
			}
		}
		private void tbFilterByIDInCustomer_TextChanged(object sender, EventArgs e)
		{
			DataTable db = clsCoustomer.CoustomersList();
			if (string.IsNullOrEmpty(tbFilterByIDInCustomer.Text))
			{
				gvCustomers.DataSource = db;
				return;
			}
			int ID = -1;
			if (!int.TryParse(tbFilterByIDInCustomer.Text, out ID) || string.IsNullOrWhiteSpace(tbFilterByIDInCustomer.Text))
			{
				return;
			}

			enCustomerFilterByItems enSelectedFilter = ((enCustomerFilterByItems)cbFilterByInCustomer.SelectedIndex);
			DataView dv = db.DefaultView;

			dv.RowFilter = enSelectedFilter + "  = " + ID;
			gvCustomers.DataSource = dv;
		}
		private void btnClearCustomer_gv_Click(object sender, EventArgs e)
		{
			tbFilterByIDInCustomer.Clear();
			cbFilterByInCustomer.SelectedIndex = -1;
			plFilterResultInCustomer.Visible = false;

			gvCustomers.DataSource = clsCoustomer.CoustomersList();
		}
		private void cbFilterByMemberShipStatusInCustomer_SelectedIndexChanged(object sender, EventArgs e)
		{
			enCustomerFilterByItems enSelectedFilter = ((enCustomerFilterByItems)cbFilterByInCustomer.SelectedIndex);
			DataView dv = clsCoustomer.CoustomersList().DefaultView;

			dv.RowFilter = enSelectedFilter + " = '" + cbFilterByMemberShipStatusInCustomer.SelectedItem.ToString() + "'";
			gvCustomers.DataSource = dv;
		}
		private void btnUpdateCustomer_Click(object sender, EventArgs e)
		{
			if (gvCustomers.SelectedRows.Count == 0 || gvCustomers.SelectedRows[0].DataBoundItem == null)
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

		//Payments

		private void FillFilterByComboBoxForPayments()
		{
			cbFilterByAtPayments.Items.Clear();
			string[] cbPaymentFilterItems = { "PaymentID", "CustomerID", "Status" };

			foreach (string item in cbPaymentFilterItems)
			{
				cbFilterByAtPayments.Items.Add(item);
			}
		}
		private void cbFilterByAtPayments_SelectedIndexChanged(object sender, EventArgs e)
		{
			tbFilterResultAtPayment.Clear();
			enPaymentFilterByItems enSelectedFilter = ((enPaymentFilterByItems)cbFilterByAtPayments.SelectedIndex);
			plFilterContainerAtPayment.Visible = true;

			if (enSelectedFilter == enPaymentFilterByItems.PaymentID || enSelectedFilter == enPaymentFilterByItems.CoustomerID)
			{
				plTextBoxFilterResultAtPayment.BringToFront();
				return;
			}
			else
			{
				if (enSelectedFilter == enPaymentFilterByItems.Status)
				{
					cbFilterResultAtPayments.Items.Clear();
					string[] PaymentStatus = { "Paid", "UnPaid", "partiallyPaid" };
					foreach (string s in PaymentStatus)
					{
						cbFilterResultAtPayments.Items.Add(s);
					}
				}

				plCoboBoxFilterAtPayment.BringToFront();


			}
		}
		private void tbFilterResultAtPayment_TextChanged(object sender, EventArgs e)
		{
			DataTable db = clsPayments.GetPaymentsList();
			if (string.IsNullOrEmpty(tbFilterResultAtPayment.Text))
			{
				gvPayments.DataSource = db;
				return;
			}
			int ID = -1;
			if (!int.TryParse(tbFilterResultAtPayment.Text, out ID) || string.IsNullOrWhiteSpace(tbFilterResultAtPayment.Text))
			{
				return;
			}

			enPaymentFilterByItems enSelectedFilter = ((enPaymentFilterByItems)cbFilterByAtPayments.SelectedIndex);
			DataView dv = db.DefaultView;


			dv.RowFilter = enSelectedFilter + "  = " + ID;


			gvPayments.DataSource = dv;
		}
		private void cbFilterResultAtPayments_SelectedIndexChanged(object sender, EventArgs e)
		{
			enPaymentFilterByItems enSelectedFilter = ((enPaymentFilterByItems)cbFilterByAtPayments.SelectedIndex);
			DataView dv = clsPayments.GetPaymentsList().DefaultView;


			dv.RowFilter = enSelectedFilter + " = '" + cbFilterResultAtPayments.SelectedItem.ToString() + "'";
			gvPayments.DataSource = dv;
		}
		private void tsmPaid_Click(object sender, EventArgs e)
		{
			int paymentID = -1;
			if (gvPayments.SelectedRows.Count > 1)
			{
				paymentID = Convert.ToInt32(gvPayments.SelectedRows[gvPayments.SelectedRows.Count - 1].Cells[0].Value);

			}
			else
			{
				paymentID = Convert.ToInt32(gvPayments.SelectedRows[0].Cells[0].Value);

			}



			if (!clsBooking.FindByPaymentID(paymentID).IsConfirmed())
			{
				MessageBox.Show("You Should To Confirm The Booking Before Complete The Payment ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}


			frmAddNewPayment frm = new frmAddNewPayment(clsPayments.Find(paymentID));
			frm.ShowDialog();

			gvPayments.DataSource = clsPayments.GetPaymentsList();

		}
		private void tsmViewPaymentInPayment_Click(object sender, EventArgs e)
		{

			if (gvPayments.SelectedRows.Count == 0)
			{
				MessageBox.Show("You Have To Select A Payment For View ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				frmViewPayment frm;

				if (gvPayments.SelectedRows.Count > 1)
				{
					frm = new frmViewPayment(clsPayments.Find(Convert.ToInt32(gvPayments.SelectedRows[0].Cells[0].Value)));

				}
				else
				{
					frm = new frmViewPayment(clsPayments.Find(Convert.ToInt32(gvPayments.SelectedRows[0].Cells[0].Value)));

				}

				frm.ShowDialog();
				Clipboard.SetText(gvPayments.SelectedRows[0].Cells[0].Value.ToString());


			}
		}
		private void tsmViewCustomerAtPayment_Click(object sender, EventArgs e)
		{
			if (gvPayments.SelectedRows.Count == 0 || gvPayments.SelectedRows[0].DataBoundItem == null)
			{
				MessageBox.Show("You Have To Select A Row For Do The Action ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{


				clsCoustomer customer = clsCoustomer.Find(Convert.ToInt32(gvPayments.SelectedRows[gvPayments.SelectedRows.Count - 1].Cells[1].Value));

				frmViewCustomer frm = new frmViewCustomer(customer);

				frm.ShowDialog();

			}
		}
		private void btnResetFilter_Click(object sender, EventArgs e)
		{
			tbFilterResultAtPayment.Clear();
			cbFilterByAtPayments.SelectedIndex = -1;
			plFilterContainerAtPayment.Visible = false;

			gvPayments.DataSource = clsPayments.GetPaymentsList();
		}
		private void tsmCopyPaymentID_Click(object sender, EventArgs e)
		{
			if (gvPayments.SelectedRows.Count == 0)
			{
				MessageBox.Show("You Have To Select A Payment For View ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				Clipboard.SetText(gvPayments.SelectedRows[0].Cells[0].Value.ToString());
			}
		}

		//Users
		private void viewUserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (gvUsersList.SelectedRows.Count < 1)
				return;


			int UserID = -1;

			if (gvUsersList.SelectedRows.Count > 1)
			{
				UserID = Convert.ToInt32(gvUsersList.SelectedRows[gvUsersList.SelectedRows.Count - 1].Cells[0].Value);

			}
			else
			{
				UserID = Convert.ToInt32(gvUsersList.SelectedRows[0].Cells[0].Value);

			}

			frmViewUser frm = new frmViewUser(clsUser.Find(UserID));
			frm.ShowDialog();
		}
		private void tsmUpdateUser_Click(object sender, EventArgs e)
		{
			if (gvUsersList.SelectedRows.Count < 1)
				return;


			int UserID = -1;

			if (gvUsersList.SelectedRows.Count > 1)
			{
				UserID = Convert.ToInt32(gvUsersList.SelectedRows[gvUsersList.SelectedRows.Count - 1].Cells[0].Value);

			}
			else
			{
				UserID = Convert.ToInt32(gvUsersList.SelectedRows[0].Cells[0].Value);

			}

			btnUpdateUser.PerformClick();
			tbUserIDForUpdate.Text = UserID.ToString();
			btnSearchForUpdateUser.PerformClick();


		}
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbUserIDForUpdate.Text) || lbUserIDForUpdate.Text == "???")
			{
				MessageBox.Show("You Should To Enter A User ID ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			clsUser user = clsUser.Find(Convert.ToInt32(lbUserIDForUpdate.Text.Trim()));

			if (string.IsNullOrWhiteSpace(tbUserNameInUpdateUser.Text))
			{
				MessageBox.Show("Username text box is required ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				user.UserName = tbUserNameInUpdateUser.Text;
			}

			if (string.IsNullOrWhiteSpace(tbPasswordInUpdateUser.Text))
			{
				MessageBox.Show("Password text box is required ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				user.Password = tbPasswordInUpdateUser.Text;
			}

			user.Permissions = CalculatePermessionForUpdateUser();

			if (user.Save())
			{
				MessageBox.Show($"User Updated Succussfully ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClearUpdateUserFrm();
				gvUsersList.DataSource = clsUser.GetUsersList();
				return;
			}
			else
			{
				MessageBox.Show($"User Updated Faild ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}
		private void btnSearchForUpdateUser_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbUserIDForUpdate.Text) || !int.TryParse(tbUserIDForUpdate.Text, out _))
			{
				MessageBox.Show("You Should To Enter A User ID ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!clsUser.isUserExist(Convert.ToInt32(tbUserIDForUpdate.Text)))
			{

				MessageBox.Show($"There Is No User With ID:{tbUserIDForUpdate.Text},You Should To Enter A Valid User ID ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			clsUser user = clsUser.Find(Convert.ToInt32(tbUserIDForUpdate.Text));

			lbUserIDForUpdate.Text = user.UserID.ToString();
			lbPersonIDInUserUpdate.Text = user.PersonID.ToString();
			tbUserNameInUpdateUser.Text = user.UserName;
			tbPasswordInUpdateUser.Text = user.Password;

			FillCheckBoxisForUpdateUser(user);
		}
		private void tsmDeleteUser_Click(object sender, EventArgs e)
		{
			if (gvUsersList.SelectedRows.Count < 1)
				return;


			int UserID = -1;

			if (gvUsersList.SelectedRows.Count > 1)
			{
				UserID = Convert.ToInt32(gvUsersList.SelectedRows[gvUsersList.SelectedRows.Count - 1].Cells[0].Value);

			}
			else
			{
				UserID = Convert.ToInt32(gvUsersList.SelectedRows[0].Cells[0].Value);

			}

			btnDeleteUser.PerformClick();
			tbUserIDForDeleteUser.Text = UserID.ToString();
			btnSearchForDeleteUser.PerformClick();
		}
		private void btnSearchForDeleteUser_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbUserIDForDeleteUser.Text) || !int.TryParse(tbUserIDForDeleteUser.Text, out _))
			{
				MessageBox.Show("You Should To Enter A User ID ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!clsUser.isUserExist(Convert.ToInt32(tbUserIDForDeleteUser.Text)))
			{

				MessageBox.Show($"There Is No User With ID:{tbUserIDForDeleteUser.Text},You Should To Enter A Valid User ID ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			clsUser user = clsUser.Find(Convert.ToInt32(tbUserIDForDeleteUser.Text));

			lbUserIDForDelete.Text = user.UserID.ToString();
			lbPersonIDForDeleteUser.Text = user.PersonID.ToString();
			lbUserNameForDelete.Text = user.UserName;
			lbPasswordForDeleteUser.Text = user.Password;

			FillCheckBoxisForDeleteUser(user);
		}
		private void btnAddNewUserInAddNewUser_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbUserNameForAddNewUser.Text) || string.IsNullOrWhiteSpace(tbUserNameForAddNewUser.Text) || tbUserNameForAddNewUser.Text == "???")
			{
				MessageBox.Show("You Should To Enter A User Name ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (string.IsNullOrEmpty(tbPasswordForAddNewUser.Text) || string.IsNullOrWhiteSpace(tbPasswordForAddNewUser.Text) || tbPasswordForAddNewUser.Text == "???")
			{
				MessageBox.Show("You Should To Enter A Password ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (comboboxPersonIDForAddNewUser.SelectedItem == null || string.IsNullOrEmpty(comboboxPersonIDForAddNewUser.SelectedItem.ToString()))
			{
				MessageBox.Show("You Should To Select A Person ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (cbAllInAddNewUser.Checked == false && cbDashbaordInAddNewUser.Checked == false && cbCustomersInAddNewUser.Checked == false && cbBookingInAddNewUser.Checked == false &&
				cbPaymentsInAddNewUser.Checked == false && cbUsersInAddNewUser.Checked == false)
			{

				MessageBox.Show("You Should To Give The User At Least One Permissions  ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;

			}

			int permession = CalculatePermessionForAddNewUser();
			clsUser user = new clsUser(tbUserNameForAddNewUser.Text, tbPasswordForAddNewUser.Text, permession, clsPerson.Find(Convert.ToInt32(comboboxPersonIDForAddNewUser.SelectedItem.ToString())));

			if (user.Save())
			{
				MessageBox.Show($"User With {user.UserID} Added Successfully  ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

				OffAllAddNewUserComponents();

				lbUserIDForAddNewUser.Text = user.UserID.ToString();

				gvUsersList.DataSource = clsUser.GetUsersList();
			}
			else
			{
				MessageBox.Show($"User With {lbNameInAddNewUser.Text} Added Faild  ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}


		}
		private void OffAllAddNewUserComponents()
		{
			tbUserNameForAddNewUser.Enabled = false;
			tbPasswordForAddNewUser.Enabled = false;
			comboboxPersonIDForAddNewUser.Enabled = false;

			cbDashbaordInAddNewUser.Enabled = false;
			cbAllInAddNewUser.Enabled = false;
			cbCustomersInAddNewUser.Enabled = false;
			cbBookingInAddNewUser.Enabled = false;
			cbPaymentsInAddNewUser.Enabled = false;
			cbUsersInAddNewUser.Enabled = false;
		}
		private void OnAllAddNewUserComponents()
		{
			comboboxPersonIDForAddNewUser.SelectedIndex = -1;
			tbUserNameForAddNewUser.Clear();
			tbPasswordForAddNewUser.Clear();

			tbUserNameForAddNewUser.Enabled = true;
			tbPasswordForAddNewUser.Enabled = true;
			comboboxPersonIDForAddNewUser.Enabled = true;

			cbDashbaordInAddNewUser.Enabled = true;
			cbAllInAddNewUser.Enabled = true;
			cbCustomersInAddNewUser.Enabled = true;
			cbBookingInAddNewUser.Enabled = true;
			cbPaymentsInAddNewUser.Enabled = true;
			cbUsersInAddNewUser.Enabled = true;

			cbDashbaordInAddNewUser.Checked = false;
			cbAllInAddNewUser.Checked = false;
			cbCustomersInAddNewUser.Checked = false;
			cbBookingInAddNewUser.Checked = false;
			cbPaymentsInAddNewUser.Checked = false;
			cbUsersInAddNewUser.Checked = false;
		}
		private void ClearUpdateUserFrm()
		{
			tbUserIDForUpdate.Clear();

			lbUserIDForUpdate.Text = "???";
			lbPersonIDInUserUpdate.Text = "???";
			tbUserNameInUpdateUser.Clear();
			tbPasswordInUpdateUser.Clear();

			cbAllForUpdateUser.Checked = false;
			cbDashboardForUpdateUser.Checked = false;
			cbCustomersForUpdateUser.Checked = false;
			cbBookingForUpdateUser.Checked = false;
			cbPaymentsForUpdateUser.Checked = false;
			cbUsersForUpdateUser.Checked = false;
		}
		private void ClearDeleteUserFrm()
		{
			tbUserIDForDeleteUser.Clear();

			lbUserIDForDelete.Text = "???";
			lbPersonIDForDeleteUser.Text = "???";
			lbUserNameForDelete.Text = "???";
			lbPasswordForDeleteUser.Text = "???";

			cbAllForDeleteUser.Checked = false;
			cbDashboardForDeleteUser.Checked = false;
			cbCustomersForDeleteUser.Checked = false;
			cbBookingForDeleteUser.Checked = false;
			cbPaymentsForDeleteUser.Checked = false;
			cbUsersForDeleteUser.Checked = false;


		}
		private void UnderLineUsersButtonsChanges(object sender)
		{
			plFocuseLineUnderUsersButtons.Location = ((Control)(sender)).Location;
			plFocuseLineUnderUsersButtons.Visible = true;
		}
		private void FillPersonsIDForComboBoxInAddNewUser()
		{

			DataTable dt = new DataTable();
			dt = clsPerson.PersonsIDList();

			if (dt.Rows.Count > 0)
			{
				comboboxPersonIDForAddNewUser.Items.Clear();
				foreach (DataRow dr in dt.Rows)
				{
					comboboxPersonIDForAddNewUser.Items.Add(dr[0].ToString());
				}
			}
		}
		private void btnAddNewUser_Click(object sender, EventArgs e)
		{
			UnderLineUsersButtonsChanges(sender);
			plAddNewUser.BringToFront();

			OnAllAddNewUserComponents();

			FillPersonsIDForComboBoxInAddNewUser();


		}
		private void btnUpdateUser_Click(object sender, EventArgs e)
		{
			UnderLineUsersButtonsChanges(sender);
			ClearUpdateUserFrm();
			plUpdateUser.BringToFront();
		}
		private void btnDeleteUser_Click(object sender, EventArgs e)
		{
			UnderLineUsersButtonsChanges(sender);
			ClearDeleteUserFrm();
			plDeleteUser.BringToFront();
		}
		private void cbAllInAddNewUser_CheckedChanged(object sender, EventArgs e)
		{
			if (cbAllInAddNewUser.Checked == true)
			{
				cbDashbaordInAddNewUser.Checked = true;
				cbCustomersInAddNewUser.Checked = true;
				cbBookingInAddNewUser.Checked = true;
				cbPaymentsInAddNewUser.Checked = true;
				cbUsersInAddNewUser.Checked = true;

			}
			else
			{
				cbDashbaordInAddNewUser.Checked = false;
				cbCustomersInAddNewUser.Checked = false;
				cbBookingInAddNewUser.Checked = false;
				cbPaymentsInAddNewUser.Checked = false;
				cbUsersInAddNewUser.Checked = false;
			}
		}
		private void cbAllForUpdateUser_CheckedChanged(object sender, EventArgs e)
		{
			if (cbAllForUpdateUser.Checked == true)
			{
				cbDashboardForUpdateUser.Checked = true;
				cbCustomersForUpdateUser.Checked = true;
				cbBookingForUpdateUser.Checked = true;
				cbPaymentsForUpdateUser.Checked = true;
				cbUsersForUpdateUser.Checked = true;

			}
			else
			{
				cbDashboardForUpdateUser.Checked = false;
				cbCustomersForUpdateUser.Checked = false;
				cbBookingForUpdateUser.Checked = false;
				cbPaymentsForUpdateUser.Checked = false;
				cbUsersForUpdateUser.Checked = false;
			}
		}
		private void comboboxPersonIDForAddNewUser_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboboxPersonIDForAddNewUser.SelectedItem == null || string.IsNullOrEmpty(comboboxPersonIDForAddNewUser.SelectedItem.ToString()))
			{
				return;
			}
			else
			{
				lbNameInAddNewUser.Text = clsPerson.Find(Convert.ToInt32(comboboxPersonIDForAddNewUser.SelectedItem.ToString())).GetFullName();
			}
		}
		private int CalculatePermessionForAddNewUser()
		{


			if (cbAllInAddNewUser.Checked == true)
			{
				return Convert.ToInt32(clsUser.enPermessions.All);
			}
			else
			{
				int permession = 0;
				if (cbCustomersInAddNewUser.Checked == true)
				{
					permession += Convert.ToInt32(clsUser.enPermessions.Customers);

				}

				if (cbDashbaordInAddNewUser.Checked == true)
				{
					permession += Convert.ToInt32(clsUser.enPermessions.Dashboard);
				}

				if (cbBookingInAddNewUser.Checked == true)
				{
					permession += Convert.ToInt32(clsUser.enPermessions.Booking);
				}

				if (cbPaymentsInAddNewUser.Checked == true)
				{
					permession += Convert.ToInt32(clsUser.enPermessions.Payments);
				}

				if (cbUsersInAddNewUser.Checked == true)
				{
					permession += Convert.ToInt32(clsUser.enPermessions.Users);
				}


				return permession;
			}
		}
		private int CalculatePermessionForUpdateUser()
		{


			if (cbAllForUpdateUser.Checked == true)
			{
				return Convert.ToInt32(clsUser.enPermessions.All);
			}
			else
			{
				int permession = 0;
				if (cbCustomersForUpdateUser.Checked == true)
				{
					permession += Convert.ToInt32(clsUser.enPermessions.Customers);

				}

				if (cbDashboardForUpdateUser.Checked == true)
				{
					permession += Convert.ToInt32(clsUser.enPermessions.Dashboard);
				}

				if (cbBookingForUpdateUser.Checked == true)
				{
					permession += Convert.ToInt32(clsUser.enPermessions.Booking);
				}

				if (cbPaymentsForUpdateUser.Checked == true)
				{
					permession += Convert.ToInt32(clsUser.enPermessions.Payments);
				}

				if (cbUsersForUpdateUser.Checked == true)
				{
					permession += Convert.ToInt32(clsUser.enPermessions.Users);
				}


				return permession;
			}
		}
		private void FillCheckBoxisForDeleteUser(clsUser user)
		{

			if (user.isAllowPermession((int)clsUser.enPermessions.All))
			{
				cbAllForDeleteUser.Checked = true;
			}
			else
			{
				cbAllForDeleteUser.Checked = false;
			}


			if (user.isAllowPermession((int)clsUser.enPermessions.Dashboard))
			{
				cbDashboardForDeleteUser.Checked = true;
			}
			else
			{
				cbDashboardForDeleteUser.Checked = false;
			}

			if (user.isAllowPermession((int)clsUser.enPermessions.Customers))
			{
				cbCustomersForDeleteUser.Checked = true;
			}
			else
			{
				cbCustomersForDeleteUser.Checked = false;
			}

			if (user.isAllowPermession((int)clsUser.enPermessions.Booking))
			{
				cbBookingForDeleteUser.Checked = true;
			}
			else
			{
				cbBookingForDeleteUser.Checked = false;
			}

			if (user.isAllowPermession((int)clsUser.enPermessions.Payments))
			{
				cbPaymentsForDeleteUser.Checked = true;
			}
			else
			{
				cbPaymentsForDeleteUser.Checked = false;
			}

			if (user.isAllowPermession((int)clsUser.enPermessions.Users))
			{
				cbUsersForDeleteUser.Checked = true;
			}
			else
			{
				cbUsersForDeleteUser.Checked = false;
			}
		}
		private void FillCheckBoxisForUpdateUser(clsUser user)
		{

			if (user.isAllowPermession((int)clsUser.enPermessions.All))
			{
				cbAllForUpdateUser.Checked = true;
			}
			else
			{
				cbAllForUpdateUser.Checked = false;
			}


			if (user.isAllowPermession((int)clsUser.enPermessions.Dashboard))
			{
				cbDashboardForUpdateUser.Checked = true;
			}
			else
			{
				cbDashboardForUpdateUser.Checked = false;
			}

			if (user.isAllowPermession((int)clsUser.enPermessions.Customers))
			{
				cbCustomersForUpdateUser.Checked = true;
			}
			else
			{
				cbCustomersForUpdateUser.Checked = false;
			}

			if (user.isAllowPermession((int)clsUser.enPermessions.Booking))
			{
				cbBookingForUpdateUser.Checked = true;
			}
			else
			{
				cbBookingForUpdateUser.Checked = false;
			}

			if (user.isAllowPermession((int)clsUser.enPermessions.Payments))
			{
				cbPaymentsForUpdateUser.Checked = true;
			}
			else
			{
				cbPaymentsForUpdateUser.Checked = false;
			}

			if (user.isAllowPermession((int)clsUser.enPermessions.Users))
			{
				cbUsersForUpdateUser.Checked = true;
			}
			else
			{
				cbUsersForUpdateUser.Checked = false;
			}
		}
		private void pbAddNewPersonInAddNewUser_Click(object sender, EventArgs e)
		{
			clsPerson person = new clsPerson("", "", "", "", new List<string>() { });
			frmAddNewPerson frm = new frmAddNewPerson(ref person);
			frm.ShowDialog();

			if (person.PersonID != -1)
			{
				FillPersonsIDForComboBoxInAddNewUser();
			}
			else
			{
				person = null;
			}

		}
		private void btnDeleteUserForDeleteUser_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbUserIDForDeleteUser.Text) || lbUserIDForDelete.Text == "???")
			{
				MessageBox.Show("You Should To Enter A User ID ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (clsUser.Delete(Convert.ToInt32(lbUserIDForDelete.Text.Trim())))
			{
				MessageBox.Show($"User Deleted Succussfully ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClearDeleteUserFrm();
				gvUsersList.DataSource = clsUser.GetUsersList();
				return;
			}
			else
			{
				MessageBox.Show($"User Deleted Faild ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		// About Us
		private void btnEnglishLan_Click(object sender, EventArgs e)
		{
			string eng = "I am a development behind a sports facility booking application.\r\nMy  goal is to facilitate the process of reserving sports venues for users.\r\n\r\n Here's an overview of the application features:\r\n\r\n1. Booking and Invoicing:\r\n   - Users can create reservations for clients in sports facilities such as five-a-side football fields, tennis courts,\r\n       and basketball courts.\r\n   - Invoices are generated for reservations and stored in the database.\r\n\r\n2. User Permissions:\r\n   - Different user roles can be assigned when creating new accounts.\r\n\r\n3. Dashboard:\r\n   - The dashboard displays current-day reservations and a list of the most active clients.\r\n   - It also provides statistics on the most active sports facilities.\r\n\r\n4. Customers:\r\n   - Ability to add,update and delete a customer.\r\n\r\n5. Password Security:\r\n   - User passwords are encrypted using hashing algorithms to ensure security.\r\n\r\nI am here to meet your sports-related needs and make the reservation process seamless.\r\n If you need further information, feel free to reach out! 🏀⚽🎾\r\n\r\n📞 Mobile: +963 937793120 \r\n📧 Email  : jihadsmadi41@gmail.com";

			btnEnglishLan.FillColor = Color.SkyBlue;
			btnArabic.FillColor = Color.SlateGray;

			lbAboutUsText.Text = eng;
			lbAboutUsText.RightToLeft = RightToLeft.No;
		}

		

		private void btnArabic_Click(object sender, EventArgs e)
		{
			string arabic = "\r\nمن نحن:\r\n\r\nنحن فريق تطوير تطبيق حجز المنشآت الرياضية. \r\nيهدف تطبيقنا إلى تسهيل عملية حجز الملاعب والمرافق الرياضية للمستخدمين. إليك نظرة عامة على الميزات:\r\n\r\n1. الحجز والفواتير:\r\n   - يمكن للمستخدمين إنشاء حجوزات للعملاء في المنشآت الرياضية مثل ملاعب كرة القدم الخماسية، ملاعب التنس، وملاعب كرة السلة.\r\n   - يتم إصدار فواتير للحجوزات وتخزينها في قاعدة البيانات.\r\n\r\n2. صلاحيات المستخدمين:\r\n   - يمكن تعيين صلاحيات مختلفة للمستخدمين عند إنشاء حسابات جديدة.\r\n\r\n3. لوحة المعلومات:\r\n   - تحتوي على حجوزات اليوم الحالي وقائمة العملاء الأكثر نشاطًا.\r\n   - تعرض إحصائيات المنشآت الرياضية الأكثر نشاطًا.\r\n\r\n4. العملاء:\r\n   - القدرة على إضافة، تحديث وحذف عميل.\r\n\r\n5. تأمين كلمات المرور:\r\n   - يتم تشفير كلمات المرور باستخدام خوارزميات التجزئة (Hashing) لضمان الأمان.\r\n\r\nنحن هنا لتلبية احتياجاتك الرياضية وجعل عملية الحجز سهلة. إذا كنت بحاجة إلى مزيد من المعلومات، فلا تتردد في الاتصال بنا! 🏀⚽🎾\r\n\r\n📞 رقم الهاتف: 0937793120\r\n📧 البريد الإلكتروني: jihadsmadi41@gmail.com";

			btnArabic.FillColor = Color.SkyBlue;
			btnEnglishLan.FillColor = Color.SlateGray;

			lbAboutUsText.Text = arabic;
			lbAboutUsText.RightToLeft = RightToLeft.Yes;
		}





	}
}
