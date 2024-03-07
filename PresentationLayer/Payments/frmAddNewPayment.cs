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
	public partial class frmAddNewPayment : Form
	{
		public frmAddNewPayment(clsBooking Booking)
		{
			InitializeComponent();

			plFirstAddNewPaymentForm.BringToFront();
			lbHeader.Text = "Add New Payment";
			this.Booking = Booking;

			payment = new clsPayments();
			
			frmBooking.SetPaymentID(-1);
			FillAddNewPaymentForm();

		}

		public frmAddNewPayment( clsPayments Payment)
		{
			InitializeComponent();

			this.payment= Payment;

			plUpdatePaymet.BringToFront();
			lbHeader.Text = "Update Payment";

			FillUpdatePaymentForm();

		}
		private clsBooking Booking { get; set; }
		private clsPayments payment { get; set; }

		private int paymentID { get; set; }
		
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

		private void pbClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void plTopBar_MouseMove(object sender, MouseEventArgs e)
		{

			if (isClick)
			{


				this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
			}


		}

		

		private void btnSave_Click(object sender, EventArgs e)
		{
			

			if(nudInitialPayAmount.Value > 0)
			{
				payment.PaymentStatusID = 3;
			}
			else
			{
				payment.PaymentStatusID = 2;
			}

			if(Convert.ToInt32(nudInitialPayAmount.Value) == payment.TotalPay)
			{
				payment.PaymentStatusID = 1;
			}
			

			payment.InitialPay = Convert.ToSingle(nudInitialPayAmount.Value);

			if(payment.Save() == true) 
			{
				MessageBox.Show("Payment Added Successfully ....!","Done ",MessageBoxButtons.OK,MessageBoxIcon.Information);
				lbPaymentID.Text = payment.PaymentID.ToString();
				lbPaymetnStatusID.Text = payment.PaymentStatusID.ToString();
				lbPaymentStatus.Text = payment.PaymentStatusName();
				btnSave.Enabled = false;
				nudInitialPayAmount.Enabled = false;
				frmBooking.SetPaymentID(payment.PaymentID);
				
				return;
			}
			else
			{
				MessageBox.Show("Payment Added Faild ....!", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				frmBooking.SetPaymentID(-1);
				return;
			}
		}

		private void nudInitialPayAmount_ValueChanged(object sender, EventArgs e)
		{
			if (((float)nudInitialPayAmount.Value) > payment.TotalPay)
			{
				MessageBox.Show("You Can't Pay More Than The Total Payment Amount ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			tbRemainingAmount.Text = (payment.TotalPay - ((float)nudInitialPayAmount.Value)).ToString();
		}


		private void FillUpdatePaymentForm()
		{
			lbPaymentIDInUpdate.Text = payment.PaymentID.ToString();
			lbPaymentStatusIdInUpdate.Text = payment.PaymentStatusID.ToString();
			lbPaymentStatusInUpdate.Text = payment.PaymentStatusName().ToString();

			lbCustomerIDInUpdate.Text = payment.CoustomerID.ToString();
			lbFinalPaymentDateInUpdate.Text = payment.DateOfFinalPay.ToShortDateString();
			lbTotalPayAmountInUpdate.Text = payment.TotalPay.ToString();
			tbRemainingInUpdate.Text = payment.RemainingPay.ToString();
			tbTotalPayAmountInUpdate.Text = payment.TotalPay.ToString()+"$";

			lbPayAmountInUpdate.Text = payment.RemainingPay.ToString() + " $";



		}

		private void btnSaveINUpdate_Click(object sender, EventArgs e)
		{
			if(payment.Paid())
			{
				payment = clsPayments.Find(payment.PaymentID);
				MessageBox.Show("Payment Paid Successfully ......!","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
				lbPaymentStatusIdInUpdate.Text = payment.PaymentID.ToString();
				lbPaymentStatusInUpdate.Text = payment.PaymentStatusName();
				lbTextInUpdate.Text = "The Payment Has Been Completed";
				tbRemainingInUpdate.Text = "0";
				lbPayAmountInUpdate.Visible = false;
				btnSaveINUpdate.Enabled = false;
				return;
			}
			else
			{
				MessageBox.Show("Payment Paid Faild ......!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		

		private void FillAddNewPaymentForm()
		{
			payment.Mode = clsPayments.enMode.AddNew;
			payment.CoustomerID = Booking.CoustomerID;
			payment.TotalPay = clsFacility.GetFacilityAmountPerRes(Booking.FacilityID);
			payment.DateOfFinalPay = Booking.DateOfBooking;
			payment.DateOfInitPay = DateTime.Now;

			lbCustomerID.Text = payment.CoustomerID.ToString();
			lbFinalPaymentDate.Text =payment.DateOfFinalPay.ToShortDateString();
			lbTotalPayAmount.Text = payment.TotalPay.ToString();
			tbRemainingAmount.Text = (payment.TotalPay - ((float)nudInitialPayAmount.Value)).ToString();

			nudInitialPayAmount.Minimum = Convert.ToDecimal(payment.TotalPay * 0.4);
			nudInitialPayAmount.Maximum = Convert.ToDecimal(payment.TotalPay);

			tbTotalPayAmount.Text= payment.TotalPay.ToString();

			

			

		}

	}
}
