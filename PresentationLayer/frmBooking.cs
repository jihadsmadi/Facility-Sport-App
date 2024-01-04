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

		int day,month, year;
		string monthName;
		
		private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void plTopBar_Paint(object sender, PaintEventArgs e)
		{

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

		private void lbMonthData_Click(object sender, EventArgs e)
		{

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
