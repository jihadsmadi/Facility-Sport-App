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

			

			DateTime now = DateTime.Now;
			day = now.Day;
			month = now.Month;
			year = now.Year;

			monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

			enSportChose = enSports.Football;

			Booking = new clsBooking();
		}

		private clsCoustomer Customer;

		static private int customerID = -1;

		int day, month, year;
		string monthName;
		 //for code
		private enum enSports { Football =1,Tinnes = 2,BasketBall = 3 }
		private enSports enSportChose ;

		private short StadumChecked = 0;

		static private short selectDay = 0;

		public clsBooking Booking { get; set; }

		static public void SetDay(short day)
		{
			selectDay = day;
		}
		

		private void frmBooking_Load(object sender, EventArgs e)
		{
			
			DisplayDays(day,month,year);
		}

		private void DisplayDays(int _day,int _month,int _year)
		{
			fpContainer.Controls.Clear();

			day= _day;
			month = _month;
			year = _year;

			DateTime FirstDayOnNowMonth = new DateTime(year, month, 1);

			string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
			lbMonthData.Text = MonthName+" "+year;

			int NumOfDaysInNowMonth = Convert.ToInt32(DateTime.DaysInMonth(year, month));

			int dayOfTheWeek = Convert.ToInt32(FirstDayOnNowMonth.DayOfWeek.ToString("d")) + 1;

			for (int i = 1; i < dayOfTheWeek; i++)
			{
				UserControlDayBox userControl = new UserControlDayBox();
				fpContainer.Controls.Add(userControl);
			}



			for(int i=1;i<=NumOfDaysInNowMonth;i++)
			{
				UserControlDays userControlDays = new UserControlDays();
				userControlDays.SetDay(i);

				if(MonthName == this.monthName && day == i )
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
				DisplayDays(day,month, year);
			}
			else
			{
				DisplayDays(day,--month, year);
			}
		}

		private void pbClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		

		private void btnBookNow_Click(object sender, EventArgs e)
		{
			if(selectDay != 0)
			{
				Booking.DateOfBooking = new DateTime(year, month, selectDay);
				Booking.BookingStatusID = 3;
				Booking.DateOfIssue = DateTime.Now;

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
			pbCheckOnFirstFootballField.Visible= false;
			pbCheckOnSecondFootballField.Visible= false;
			pbCheckOnThierdFootballField.Visible= false;

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
			if(pbCheckOnFirstFootballField.Visible == false)
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
			if(pbCheckOnSecondFootballField.Visible == false)
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
			if(pbCheckOnThierdFootballField.Visible == false)
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
			pbFootball.BorderStyle= BorderStyle.FixedSingle;
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

		private void label15_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void pbFirstBasketField_Click(object sender, EventArgs e)
		{
			if(pbCheckFirstBasketField.Visible == false)
			{
				pbCheckFirstBasketField.Visible = true;
				pbFirstBasketField.BorderStyle= BorderStyle.FixedSingle;
				StadumChecked= 7;
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
			if(StadumChecked ==0)
			{
				MessageBox.Show("You Should To Select A Field You Want To Reserve ....!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{

				Booking.FacilityID = StadumChecked;
				FillSelectTimeComboBox();
				


				plFullReservation.BringToFront();
			}
		}

		static public void SetCustomerIDForAddNewCustomer(int CustomerID)
		{
			customerID= CustomerID;
		}

		private void button7_Click(object sender, EventArgs e)
		{

		}

		private void lbPhoneInFindingPerson_Click(object sender, EventArgs e)
		{

		}

		private void plFirstCustomerInfo_Paint(object sender, PaintEventArgs e)
		{

		}

		

		
		private void lbAddNewCustomer_Click(object sender, EventArgs e)
		{
			
			frmAddNewCustomer frm = new frmAddNewCustomer( ref customerID);
			frm.ShowDialog();

			if(customerID == -1)
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



				}
				else
				{
					MessageBox.Show("Enter a Valied Customer ID ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void button12_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void label26_Click(object sender, EventArgs e)
		{

		}

		private void label29_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void label31_Click(object sender, EventArgs e)
		{

		}

		private void label38_Click(object sender, EventArgs e)
		{

		}

		private void label39_Click(object sender, EventArgs e)
		{

		}

		private void label25_Click(object sender, EventArgs e)
		{

		}

		private void label27_Click(object sender, EventArgs e)
		{

		}

		private void panel5_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void label28_Click(object sender, EventArgs e)
		{

		}

		private void button16_Click(object sender, EventArgs e)
		{

		}

		private void label25_Click_1(object sender, EventArgs e)
		{

		}

		private void label29_Click_1(object sender, EventArgs e)
		{

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
			if(month == 12)
			{
				month = 1;
				year++;
				DisplayDays(day,month, year);
			}
			else
			{
				DisplayDays(day, ++month, year);
			}
			
		}

		private string SelectTimeRecord(DateTime startTime,double minuteForRes)
		{	
			return startTime.ToShortTimeString().ToString() + " " + startTime.AddMinutes(minuteForRes).ToShortTimeString().ToString();
		}
		private void FillSelectTimeComboBox()
		{
			double ResTimePerMin = clsBooking.MinutAmountPerReservation(Booking.FacilityID);
			if (ResTimePerMin == -1)
				return;

			DateTime StartTime ;

			switch (enSportChose)
			{
				case enSports.Football:
					for(double i=6; i < 24; i += 1.5)
					{
						if(Math.Floor(i) < i)
						{
							StartTime = Booking.DateOfBooking.AddHours(Math.Floor(i)).AddMinutes((i % Math.Floor(i)) * 60);
							cbSelectStartTime.Items.Add(SelectTimeRecord(StartTime,ResTimePerMin));
						}
						else
						{
							StartTime = Booking.DateOfBooking.AddHours(i);

							cbSelectStartTime.Items.Add(SelectTimeRecord(StartTime,ResTimePerMin));
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
					for (double i = 6; i < 24; i += 1.5)
					{
						
							StartTime = Booking.DateOfBooking.AddHours(i);

							cbSelectStartTime.Items.Add(SelectTimeRecord(StartTime, ResTimePerMin));
						
					}

					break;
			}
		}


	}
}
