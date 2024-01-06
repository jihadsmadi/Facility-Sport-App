using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
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
		}

		int day, month, year;
		string monthName;

		private short FootballStadumChecked = 0;

		static private short selectDay = 0;

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
				plChoseFacility.BringToFront();
				lbData.Text = selectDay.ToString() + "/" + this.month.ToString() +"/"+this.year.ToString();
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
		private void pbFirstField_Click(object sender, EventArgs e)
		{
			if(pbCheckOnFirstFootballField.Visible == false)
			{
				UnCheckFootballFieldsAndBorders();
				pbFirstField.BorderStyle = BorderStyle.FixedSingle;
				pbCheckOnFirstFootballField.Visible = true;
				FootballStadumChecked = 1;
			}
			else
			{
				UnCheckFootballFieldsAndBorders();
				
				pbCheckOnFirstFootballField.Visible = false;
				FootballStadumChecked = 0;
			}

			

		}

		private void pbSecondFootballField_Click(object sender, EventArgs e)
		{
			if(pbCheckOnSecondFootballField.Visible == false)
			{
				UnCheckFootballFieldsAndBorders();
				pbSecondFootballField.BorderStyle = BorderStyle.FixedSingle;
				pbCheckOnSecondFootballField.Visible = true;
				FootballStadumChecked = 2;
			}
			else
			{
				UnCheckFootballFieldsAndBorders();
				
				pbCheckOnSecondFootballField.Visible = false;
				FootballStadumChecked = 0;
			}
		}

		private void pbThierdFootballField_Click(object sender, EventArgs e)
		{
			if(pbCheckOnThierdFootballField.Visible == false)
			{
				UnCheckFootballFieldsAndBorders();
				pbThierdFootballField.BorderStyle = BorderStyle.FixedSingle;
				pbCheckOnThierdFootballField.Visible = true;
				FootballStadumChecked = 3;
			}
			else
			{
				UnCheckFootballFieldsAndBorders();
				
				pbCheckOnThierdFootballField.Visible = false;
				FootballStadumChecked = 0;
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
				FootballStadumChecked = 4;
			}
			else
			{
				pbCheckFourthFootballField.Visible = false;
				FootballStadumChecked = 0;
			}
		}

		private void NoneBorderStyle()
		{
			pbFootball.BorderStyle = BorderStyle.None;
			pbTinnes.BorderStyle = BorderStyle.None;
			pbBasketball.BorderStyle = BorderStyle.None;

		}
		private void pbFootball_Click(object sender, EventArgs e)
		{
			NoneBorderStyle();
			plFootballStad.BringToFront();
			pbFootball.BorderStyle= BorderStyle.FixedSingle;
		}

		private void pbTinnes_Click(object sender, EventArgs e)
		{
			NoneBorderStyle();
			plTinnesStad.BringToFront();
			pbTinnes.BorderStyle = BorderStyle.FixedSingle;
		}

		private void pbBasketball_Click(object sender, EventArgs e)
		{
			NoneBorderStyle();
			plBasketStad.BringToFront();
			pbBasketball.BorderStyle = BorderStyle.FixedSingle;
		
		}

		private void guna2PictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void guna2PictureBox1_Click_1(object sender, EventArgs e)
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
	}
}
