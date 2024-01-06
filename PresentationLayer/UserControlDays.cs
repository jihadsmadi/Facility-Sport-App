﻿using System;
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
	public partial class UserControlDays : UserControl
	{
		public UserControlDays()
		{
			InitializeComponent();
		}

		static private UserControlDays PrevSelected = null;
		private void UserControlDays_Load(object sender, EventArgs e)
		{

		}

		public void SetBackColor(Color color)
		{
			this.BackColor = color;
		}

		public void SetForColor(Color color)
		{
			lbDay.ForeColor = color;
		}
		public void SetDay(int day)
		{
			lbDay.Text = day.ToString();
		}

		private void UserControlDays_MouseHover(object sender, EventArgs e)
		{
			if(this.BackColor == Color.DarkOrchid)
			{
				return;
			}
			SetBackColor(Color.Silver);
			
		}

		private void UserControlDays_MouseLeave(object sender, EventArgs e)
		{
			if (this.BackColor == Color.DarkOrchid)
			{
				return;
			}
			SetBackColor(Color.White);
		}

		private void btnBookNow_Click(object sender, EventArgs e)
		{
			
		}

		private void UserControlDays_Click(object sender, EventArgs e)
		{
			if(UserControlDays.PrevSelected != null)
			{
				PrevSelected.SetBackColor(this.BackColor);
			}

			SetBackColor(Color.LightGray);
			

			PrevSelected = ((UserControlDays)(sender));

			frmBooking.SetDay(Convert.ToInt16(lbDay.Text));

		}
	}
}
