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
	public partial class frmViewPayment : Form
	{
		public frmViewPayment(clsPayments Payment)
		{
			InitializeComponent();
			this.payment= Payment;
			FillViewPaymentForm();
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
		private void FillViewPaymentForm()
		{
			lbPaymentID.Text = payment.PaymentID.ToString();
			lbCustomerID.Text = payment.CoustomerID.ToString();
			lbCustomerName.Text = clsCoustomer.Find(payment.CoustomerID).GetFullName();
			lbPaymentStatus.Text = payment.PaymentStatusName();
			lbPaymetnStatusID.Text = payment.PaymentStatusID.ToString();
			lbFinalPaymentDate.Text = payment.DateOfFinalPay.ToShortDateString();
			lbInitialPaymentDate.Text = payment.DateOfInitPay.ToShortDateString();
			lbTotalPayAmount.Text = payment.TotalPay.ToString();
			lbRemainingPay.Text = payment.RemainingPay.ToString();

		}
		private clsPayments payment;

		private void frmViewPayment_Load(object sender, EventArgs e)
		{

		}

		private void pbClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
