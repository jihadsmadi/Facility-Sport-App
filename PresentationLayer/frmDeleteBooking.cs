using BesnissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging.Design;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
	public partial class frmDeleteBooking : Form
	{
		public frmDeleteBooking(int bookingID)
		{
			InitializeComponent();

			this.booking = clsBooking.Find(bookingID);

			FillDeleteForm();
		}

		private clsBooking booking;

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

		private void pbClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FillDeleteForm()
		{
			clsCoustomer customer = clsCoustomer.Find(booking.CoustomerID);
			lbCustomerID.Text = customer.CoustomerID.ToString();
			lbName.Text = customer.GetFullName();


			lbPaymentID.Text = this.booking.PaymentID.ToString();


			lbBookingID.Text = booking.BookingID.ToString();
			lbBookingStatus.Text = booking.GetStatusName();

			lbFacilityID.Text = booking.FacilityID.ToString();
			lbFacilityName.Text = clsFacility.GetFieldName(booking.FacilityID);

			lbDateOfIssue.Text = booking.DateOfIssue.ToShortDateString();
			lbDateOfBooking.Text = booking.DateOfBooking.ToShortDateString();

			lbTime.Text = booking.StartTime.ToShortTimeString() + " To " + booking.EndTime.ToShortTimeString();
		}

		private void EmptyTheContent()
		{
			lbCustomerID.Text = "???";
			lbName.Text = "???";
			lbPaymentID.Text = "???";
			lbBookingID.Text = "???";
			lbBookingStatus.Text = "???";
			lbFacilityID.Text = "???";
			lbFacilityName.Text = "???";
			lbDateOfIssue.Text = "???";
			lbDateOfBooking.Text = "???";
			lbTime.Text = "???";

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Are You Sure You Want To Delete The Booking With ID["+ booking.BookingID.ToString() +" .....!","Qustion",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (clsBooking.Delete(booking.BookingID))
				{
					EmptyTheContent();
					MessageBox.Show("Booking Deleted Successfully ....!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				else
				{
					MessageBox.Show("Booking Deleted Faield ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			else
			{
				return;
			}

			
		}

	}
}
