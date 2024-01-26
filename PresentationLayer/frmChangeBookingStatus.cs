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
	public partial class frmChangeBookingStatus : Form
	{
		private void pbClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		public frmChangeBookingStatus(int bookingID)
		{
			InitializeComponent();

			this.booking = clsBooking.Find(bookingID);
			this.Payment = clsPayments.Find(this.booking.PaymentID);
			
			plChangeBookingStatus.BringToFront();

			FillChangeBookingStatusfrm();

		}



	
		private clsBooking booking;

		private clsPayments Payment;

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

		private void btnConfirmed_Click(object sender, EventArgs e)
		{
			// 3 equls in database pending status
			if(this.booking.BookingStatusID != 3)
			{
				MessageBox.Show("You Can Not Confirm Not Pending Booking ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if(this.booking.ConfirmStatus())
			{
				lbBookingStatus.Text = booking.GetStatusName();
				plColorOfStatus.BackColor = Color.Blue;
				lbBookingStatus.ForeColor = Color.Blue;
			
				MessageBox.Show("Reservation At " + booking.DateOfBooking.ToShortDateString() + " Has Been Confirmed ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			else
			{
				
				MessageBox.Show("Reservation Dose Not Confirmed ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void btnCencel_Click(object sender, EventArgs e)
		{
			if (this.booking.Cencel())
			{
				lbBookingStatus.Text = booking.GetStatusName();
				plColorOfStatus.BackColor = Color.Red;
				lbBookingStatus.ForeColor = Color.Red;
				MessageBox.Show("Reservation At " + booking.DateOfBooking.ToShortDateString() + " Has Been Cenceled ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			else
			{
				MessageBox.Show("Reservation Dose Not Cencel ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void btnCheckOut_Click(object sender, EventArgs e)
		{
			// 1 equls in database confirmed status
			if(booking.BookingStatusID != 1)
			{
				MessageBox.Show("You Can Not Complete Not Confirmed Booking ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if(DateTime.Today != this.booking.DateOfBooking)
			{
				MessageBox.Show("You Can Complete The Booking Only At The Booking Day ...!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}


			if(this.booking.IsPaidPayment())
			{
				if(this.booking.Complete())
				{
					MessageBox.Show("Booking Completed Successfully ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
					lbBookingStatus.Text = booking.GetStatusName();
					plColorOfStatus.BackColor = Color.Green;
					return;
				}
			}
			else
			{
				MessageBox.Show("You Have To Complete The Payment With Id [" + this.booking.PaymentID.ToString() + "] To Complete The Booking ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

		}

		private void btnComplete_Click(object sender, EventArgs e)
		{
			if(!this.booking.IsConfirmed())
			{
				MessageBox.Show("You Should To Confirm The Booking Before Complete The Payment ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			frmAddNewPayment frm = new frmAddNewPayment(this.Payment);
			frm.ShowDialog();

			this.Payment = clsPayments.Find(this.Payment.PaymentID);

			if(this.Payment.IsPaid())
			{
				btnComplete.Enabled = false;
				lbPaymentStatus.Text = this.Payment.PaymentStatusName();
			}
		}

		private void btnViewPayment_Click(object sender, EventArgs e)
		{
			frmViewPayment frm = new frmViewPayment(this.Payment);
			frm.ShowDialog();
		}

		private void FillChangeBookingStatusfrm()
		{
			lbDateNow.Text = DateTime.Now.ToString();

			clsCoustomer customer = clsCoustomer.Find(booking.CoustomerID);
			lbCustomerID.Text =  customer.CoustomerID.ToString();
			lbName.Text = customer.GetFullName();
			lbMemberShipStatus.Text = customer.MemberShipstatusName();

			lbPaymentID.Text = this.Payment.PaymentID.ToString();
			lbPaymentStatus.Text = this.Payment.PaymentStatusName();

			lbBookingID.Text = booking.BookingID.ToString();		
			lbBookingStatus.Text = booking.GetStatusName();

			lbFacilityID.Text  = booking.FacilityID.ToString();
			lbFacilityName.Text = clsFacility.GetFieldName(booking.FacilityID);

			lbDateOfIssue.Text = booking.DateOfIssue.ToShortDateString();
			lbDateOfBooking.Text = booking.DateOfBooking.ToShortDateString();

			lbTime.Text = booking.StartTime.ToShortTimeString() + " To " + booking.EndTime.ToShortTimeString();

			if(booking.BookingStatusID == 1)
			{
				plColorOfStatus.BackColor = Color.Blue;
				lbBookingStatus.ForeColor = Color.Blue;
			}
			else if(booking.BookingStatusID == 2)
			{
				plColorOfStatus.BackColor = Color.Red;
				lbBookingStatus.ForeColor = Color.Red;
			}
			else if(booking.BookingStatusID == 3)
			{
				plColorOfStatus.BackColor = Color.Red;
				lbBookingStatus.ForeColor = Color.Red;
			}
			else if (booking.BookingStatusID == 4)
			{
				plColorOfStatus.BackColor = Color.Green;
				lbBookingStatus.ForeColor = Color.Green;
			}

			if(booking.IsPaidPayment())
			{
				btnComplete.Enabled = false;
			}
		}

		
	}
}
