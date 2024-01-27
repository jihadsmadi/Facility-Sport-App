using BesnissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
	public partial class frmBooking : Form
	{
		public frmBooking()
		{
			InitializeComponent();

			frmBooking.PaymentID = 0;


			DateTime now = DateTime.Now;
			day = now.Day;
			month = now.Month;
			year = now.Year;

			monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

			enSportChose = enSports.Football;

			Booking = new clsBooking();
			Booking.Mode = clsBooking.enMode.AddNew;
		}

		private clsCoustomer Customer;

		static private int customerID = -1;

		static private int PaymentID = -1;

		static private short selectDay = 0;

		int day, month, year;
		string monthName;
		//for code
		private enum enSports { Football = 1, Tinnes = 2, BasketBall = 3 }
		private enSports enSportChose;

		private short StadumChecked = 0;



		public clsBooking Booking { get; set; }

		static public void SetDay(short day)
		{
			selectDay = day;
		}


		private void frmBooking_Load(object sender, EventArgs e)
		{

			DisplayDays(day, month, year);
		}

		private void DisplayDays(int _day, int _month, int _year)
		{
			fpContainer.Controls.Clear();

			day = _day;
			month = _month;
			year = _year;

			DateTime FirstDayOnNowMonth = new DateTime(year, month, 1);

			string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
			lbMonthData.Text = MonthName + " " + year;

			int NumOfDaysInNowMonth = Convert.ToInt32(DateTime.DaysInMonth(year, month));

			int dayOfTheWeek = Convert.ToInt32(FirstDayOnNowMonth.DayOfWeek.ToString("d")) + 1;

			for (int i = 1; i < dayOfTheWeek; i++)
			{
				UserControlDayBox userControl = new UserControlDayBox();
				fpContainer.Controls.Add(userControl);
			}



			for (int i = 1; i <= NumOfDaysInNowMonth; i++)
			{
				UserControlDays userControlDays = new UserControlDays();
				userControlDays.SetDay(i);

				if (MonthName == this.monthName && day == i)
				{
					userControlDays.SetBackColor(Color.DarkOrchid);
					userControlDays.SetForColor(Color.White);

				}


				fpContainer.Controls.Add(userControlDays);
			}

		}

		private void btnPrevMonth_Click(object sender, EventArgs e)
		{
			if (month == 1)
			{
				month = 12;
				year--;
				DisplayDays(day, month, year);
			}
			else
			{
				DisplayDays(day, --month, year);
			}
		}

		private void pbClose_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(lbPaymentID.Text) && btnSave.Enabled == true)
			{
				if (MessageBox.Show("Do You Sure You Want To Delete The Payment ....?", "Qustion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (clsPayments.Delete(PaymentID))
					{
						MessageBox.Show("Payment Deleted Successfully ....!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
				{
					return;
				}
			}
			this.Close();
		}



		private void btnBookNow_Click(object sender, EventArgs e)
		{


			if (selectDay != 0)
			{
				if (new DateTime(year, month, selectDay) < DateTime.Today)
				{
					MessageBox.Show("You Can't Reserve In The Past  ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				Booking.DateOfBooking = new DateTime(year, month, selectDay);
				Booking.BookingStatusID = 3;
				Booking.DateOfIssue = DateTime.Now;
				Booking.CoustomerID = -1;

				plChoseFacility.BringToFront();
			}
			else
			{
				MessageBox.Show("You Should To Select A Day  ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void UnCheckFootballFieldsAndBorders()
		{
			pbCheckOnFirstFootballField.Visible = false;
			pbCheckOnSecondFootballField.Visible = false;
			pbCheckOnThierdFootballField.Visible = false;

			pbFirstField.BorderStyle = BorderStyle.None;
			pbSecondFootballField.BorderStyle = BorderStyle.None;
			pbThierdFootballField.BorderStyle = BorderStyle.None;
		}

		private void UnCheckTinnesFieldsAndBorders()
		{
			pbCheckFirstTinnesField.Visible = false;
			pbCheckSecondTinnesField.Visible = false;


			pbFirstTinnesField.BorderStyle = BorderStyle.None;
			pbSecondTinnesField.BorderStyle = BorderStyle.None;

		}
		private void pbFirstField_Click(object sender, EventArgs e)
		{
			if (pbCheckOnFirstFootballField.Visible == false)
			{
				UnCheckFootballFieldsAndBorders();
				pbFirstField.BorderStyle = BorderStyle.FixedSingle;
				pbCheckOnFirstFootballField.Visible = true;
				StadumChecked = 1;
			}
			else
			{
				UnCheckFootballFieldsAndBorders();

				pbCheckOnFirstFootballField.Visible = false;
				StadumChecked = 0;

			}



		}

		private void pbSecondFootballField_Click(object sender, EventArgs e)
		{
			if (pbCheckOnSecondFootballField.Visible == false)
			{
				UnCheckFootballFieldsAndBorders();
				pbSecondFootballField.BorderStyle = BorderStyle.FixedSingle;
				pbCheckOnSecondFootballField.Visible = true;
				StadumChecked = 2;
			}
			else
			{
				UnCheckFootballFieldsAndBorders();

				pbCheckOnSecondFootballField.Visible = false;
				StadumChecked = 0;
			}
		}

		private void pbThierdFootballField_Click(object sender, EventArgs e)
		{
			if (pbCheckOnThierdFootballField.Visible == false)
			{
				UnCheckFootballFieldsAndBorders();
				pbThierdFootballField.BorderStyle = BorderStyle.FixedSingle;
				pbCheckOnThierdFootballField.Visible = true;
				StadumChecked = 3;
			}
			else
			{
				UnCheckFootballFieldsAndBorders();

				pbCheckOnThierdFootballField.Visible = false;
				StadumChecked = 0;
			}

		}

		private void lbGoBack_Click(object sender, EventArgs e)
		{
			plFirstFootballForm.BringToFront();
			lbAllOfThem.Visible = true;
			lbGoBack.Visible = false;
		}

		private void pbFourthFootballField_Click(object sender, EventArgs e)
		{
			if (pbCheckFourthFootballField.Visible == false)
			{
				UnCheckFootballFieldsAndBorders();
				pbFourthFootballField.BorderStyle = BorderStyle.FixedSingle;
				pbCheckFourthFootballField.Visible = true;
				StadumChecked = 4;
			}
			else
			{
				pbCheckFourthFootballField.Visible = false;
				StadumChecked = 0;
			}
		}

		private void NoneBorderStyle()
		{
			pbFootball.BorderStyle = BorderStyle.None;
			pbTinnes.BorderStyle = BorderStyle.None;
			pbBasketball.BorderStyle = BorderStyle.None;

		}

		private void HideAllOfThem()
		{
			lbAllOfThem.Visible = false;
			lbGoBack.Visible = false;
		}
		private void pbFootball_Click(object sender, EventArgs e)
		{
			NoneBorderStyle();
			plFootballStad.BringToFront();
			plFirstFootballForm.BringToFront();
			pbFootball.BorderStyle = BorderStyle.FixedSingle;
			enSportChose = enSports.Football;
			lbAllOfThem.Visible = true;
			lbGoBack.Visible = false;
			lbFieldsName.Text = ((PictureBox)(sender)).Tag.ToString();

		}

		private void pbTinnes_Click(object sender, EventArgs e)
		{
			NoneBorderStyle();
			plTinnesStad.BringToFront();
			pbTinnes.BorderStyle = BorderStyle.FixedSingle;
			enSportChose = enSports.Tinnes;
			HideAllOfThem();
			lbFieldsName.Text = ((PictureBox)(sender)).Tag.ToString();
		}

		private void pbBasketball_Click(object sender, EventArgs e)
		{
			NoneBorderStyle();
			plBasketStad.BringToFront();
			pbBasketball.BorderStyle = BorderStyle.FixedSingle;
			enSportChose = enSports.BasketBall;
			HideAllOfThem();
			lbFieldsName.Text = ((PictureBox)(sender)).Tag.ToString();
		}



		private void pbFirstTinnesField_Click(object sender, EventArgs e)
		{
			if (pbCheckFirstTinnesField.Visible == false)
			{
				UnCheckTinnesFieldsAndBorders();
				pbFirstTinnesField.BorderStyle = BorderStyle.FixedSingle;
				pbCheckFirstTinnesField.Visible = true;
				StadumChecked = 5;
			}
			else
			{
				pbCheckFirstTinnesField.Visible = false;
				StadumChecked = 0;
			}
		}

		private void pbSecondTinnesField_Click(object sender, EventArgs e)
		{
			if (pbCheckSecondTinnesField.Visible == false)
			{
				UnCheckTinnesFieldsAndBorders();
				pbSecondTinnesField.BorderStyle = BorderStyle.FixedSingle;
				pbCheckSecondTinnesField.Visible = true;
				StadumChecked = 6;
			}
			else
			{
				pbCheckSecondTinnesField.Visible = false;
				StadumChecked = 0;
			}
		}

		private void pbFirstBasketField_Click(object sender, EventArgs e)
		{
			if (pbCheckFirstBasketField.Visible == false)
			{
				pbCheckFirstBasketField.Visible = true;
				pbFirstBasketField.BorderStyle = BorderStyle.FixedSingle;
				StadumChecked = 7;
			}
			else
			{
				pbCheckFirstBasketField.Visible = false;
				pbFirstBasketField.BorderStyle = BorderStyle.None;
				StadumChecked = 0;
			}
		}

		private void plChoseFacility_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			if (StadumChecked == 0)
			{
				MessageBox.Show("You Should To Select A Field You Want To Reserve ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{

				Booking.FacilityID = StadumChecked;
				FillSelectTimeComboBox();
				lbFacilityID.Text = Booking.FacilityID.ToString();
				lbDateOfBooking.Text = Booking.DateOfBooking.ToShortDateString();
				lbDateOfIssue.Text = Booking.DateOfIssue.ToString();
				lbFacilityName.Text = clsFacility.GetFieldName(Booking.FacilityID);


				plFullReservation.BringToFront();
			}
		}

		static public void SetCustomerIDForAddNewCustomer(int CustomerID)
		{
			customerID = CustomerID;
		}

		private void lbPhoneInFindingPerson_Click(object sender, EventArgs e)
		{

		}

		private void plFirstCustomerInfo_Paint(object sender, PaintEventArgs e)
		{

		}

		private void lbAddNewCustomer_Click(object sender, EventArgs e)
		{

			frmAddNewCustomer frm = new frmAddNewCustomer(ref customerID);
			frm.ShowDialog();

			if (customerID == -1)
			{
				return;
			}
			else
			{
				Customer = clsCoustomer.Find(customerID);



				if (clsCoustomer.IsCustomerExist(customerID))
				{


					Customer = clsCoustomer.Find(customerID);
					lbCustomerID.Text = Customer.CoustomerID.ToString();
					lbPersonId.Text = Customer.PersonID.ToString();
					lbName.Text = Customer.GetFullName();
					lbAddress.Text = Customer.Address;
					lbNationalNo.Text = Customer.NID.ToString();
					if (Customer.Phone.Count != 0)
					{
						lbPhone.Text = Customer.Phone.First().ToString();
					}

					lbMemberShipStatus.Text = Customer.MemberShipstatusName();

					Booking.CoustomerID = Customer.CoustomerID;

				}


			}


		}

		private void pbFind_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbFindBy.Text))
			{
				MessageBox.Show("Enter a Customer ID Or Add New Customer ....!");
			}


			else
			{
				int CustomerID = Convert.ToInt32(tbFindBy.Text.Trim());

				if (clsCoustomer.IsCustomerExist(CustomerID))
				{



					Customer = clsCoustomer.Find(CustomerID);
					lbCustomerID.Text = Customer.CoustomerID.ToString();
					lbPersonId.Text = Customer.PersonID.ToString();
					lbName.Text = Customer.GetFullName();
					lbAddress.Text = Customer.Address;
					lbNationalNo.Text = Customer.NID.ToString();
					if (Customer.Phone.Count != 0)
					{
						lbPhone.Text = Customer.Phone.First().ToString();
					}

					lbMemberShipStatus.Text = Customer.MemberShipstatusName();

					Booking.CoustomerID = Customer.CoustomerID;

				}
				else
				{
					MessageBox.Show("Enter a Valied Customer ID ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void lbAllOfThem_Click(object sender, EventArgs e)
		{
			UnCheckFootballFieldsAndBorders();
			plSecondFootballForm.BringToFront();
			lbAllOfThem.Visible = false;
			lbGoBack.Visible = true;
		}

		private void btnNextMonth_Click(object sender, EventArgs e)
		{
			if (month == 12)
			{
				month = 1;
				year++;
				DisplayDays(day, month, year);
			}
			else
			{
				DisplayDays(day, ++month, year);
			}

		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			lbCustomerID.Text = "???";
			lbPersonId.Text = "???";
			lbName.Text = "???";
			lbAddress.Text = "???";
			lbNationalNo.Text = "???";
			lbPhone.Text = "???";
			lbMemberShipStatus.Text = "???";
			tbFindBy.Clear();
			Booking.CoustomerID = -1;

			plChoseFacility.BringToFront();
		}

		static public void SetPaymentID(int paymetnID)
		{
			PaymentID = paymetnID;
		}

		private void btnBackToCalender_Click(object sender, EventArgs e)
		{
			plFirstFormOnReservation.BringToFront();
		}

		private clsBooking GetBooking()
		{
			return Booking;
		}

		private void btnFillPayment_Click(object sender, EventArgs e)
		{


			if (Booking.CoustomerID == -1)
			{
				MessageBox.Show("You Should To Select A Customer For Complite The Reservation ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (cbSelectStartTime.SelectedItem == null)
			{

				MessageBox.Show("You Should To Chose Start Time For Complite The Reservation ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				FillStartAndEndTime();
			}


			if (!clsBooking.IsValidTime(Booking.StartTime, Booking.FacilityID))
			{
				MessageBox.Show("Time You Chose Is Not Valied Please Select Another Start Time ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				Booking.PaymentID = -1;



				frmAddNewPayment frm = new frmAddNewPayment(Booking);
				frm.ShowDialog();



				Booking.PaymentID = frmBooking.PaymentID;

				if (Booking.PaymentID == -1)
				{
					MessageBox.Show("Payments Faild ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				else
				{


					lbPaymentID.Text = Booking.PaymentID.ToString();
					lbViewPayment.Visible = true;

					btnFillPayment.Enabled = false;
					cbSelectStartTime.Enabled = false;
					tbFindBy.Enabled = false;
					btnBack.Enabled = false;
					lbAddNewCustomer.Enabled = false;
					pbAddNewCustomer.Enabled = false;
					btnSave.Enabled = true;
				}
			}
		}

		private string SelectTimeRecord(DateTime startTime, double minuteForRes)
		{
			return startTime.ToShortTimeString().ToString() + " " + startTime.AddMinutes(minuteForRes).ToShortTimeString().ToString();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Booking.BookingStatusID = 3;


			if (Booking.Save() == true)
			{
				MessageBox.Show("Reservation Proces Done Successfully ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnSave.Enabled = false;
				btnClose.Visible = true;

			}
		}

		private void lbViewPayment_Click(object sender, EventArgs e)
		{
			frmViewPayment frm = new frmViewPayment(clsPayments.Find(Booking.PaymentID));
			frm.ShowDialog();
		}

		private void FillSelectTimeComboBox()
		{
			double ResTimePerMin = clsBooking.MinutAmountPerReservation(Booking.FacilityID);
			if (ResTimePerMin == -1)
				return;

			DateTime StartTime;

			switch (enSportChose)
			{
				case enSports.Football:
					for (double i = 6; i < 24; i += 1.5)
					{
						if (Math.Floor(i) < i)
						{
							StartTime = Booking.DateOfBooking.AddHours(Math.Floor(i)).AddMinutes((i % Math.Floor(i)) * 60);
							cbSelectStartTime.Items.Add(SelectTimeRecord(StartTime, ResTimePerMin));
						}
						else
						{
							StartTime = Booking.DateOfBooking.AddHours(i);

							cbSelectStartTime.Items.Add(SelectTimeRecord(StartTime, ResTimePerMin));
						}
					}

					break;
				case enSports.Tinnes:
					for (double i = 6; i < 24; i += 1)
					{

						StartTime = Booking.DateOfBooking.AddHours(i);

						cbSelectStartTime.Items.Add(SelectTimeRecord(StartTime, ResTimePerMin));

					}

					break;
				case enSports.BasketBall:
					for (double i = 6; i < 24; i += 1)
					{

						StartTime = Booking.DateOfBooking.AddHours(i);

						cbSelectStartTime.Items.Add(SelectTimeRecord(StartTime, ResTimePerMin));

					}

					break;
			}
		}

		private void FillStartAndEndTime()
		{
			DateTime start, end;


			string[] Times = cbSelectStartTime.SelectedItem.ToString().Split(' ');

			string[] HourAndMinForStart = Times[0].Split(':');
			string[] HourAndMinForEnd = Times[2].Split(':');

			if (Times[1].ToUpperInvariant() == "PM")
			{
				if (Convert.ToInt32(HourAndMinForStart[0]) < 12)
				{
					HourAndMinForStart[0] = (Convert.ToInt32(HourAndMinForStart[0]) + 12).ToString();
				}
			}





			start = new DateTime(Booking.DateOfBooking.Year, Booking.DateOfBooking.Month, Booking.DateOfBooking.Day,
								Convert.ToInt32(HourAndMinForStart[0]), Convert.ToInt16(HourAndMinForStart[1]), 00);

			if (Times[3].ToUpperInvariant() == "PM")
			{
				if (Convert.ToInt32(HourAndMinForEnd[0]) < 12)
				{
					HourAndMinForEnd[0] = (Convert.ToInt32(HourAndMinForEnd[0]) + 12).ToString();
				}
			}

			end = new DateTime(Booking.DateOfBooking.Year, Booking.DateOfBooking.Month, Booking.DateOfBooking.Day,
								Convert.ToInt32(HourAndMinForEnd[0]), Convert.ToInt16(HourAndMinForEnd[1]), 00);


			Booking.StartTime = start;
			Booking.EndTime = end;

		}
	}
}
