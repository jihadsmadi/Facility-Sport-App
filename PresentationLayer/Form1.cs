﻿using BesnissLayer;
using Guna.UI2.WinForms;
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
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

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
		

		//btn Methodes

		private void ReturnToDefultBtnStyle()
		{
			btnDashboard.FillColor = Color.SkyBlue;
			btnCoustomers.FillColor = Color.SkyBlue;
			btnApointments.FillColor = Color.SkyBlue;
		}

		
		private void ChangeSideBarBtn(object sender)
		{
			ReturnToDefultBtnStyle();
			

			((Guna2Button)sender).FillColor = Color.FromArgb(126, 200, 193);
		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			ChangeSideBarBtn(sender);

			plDashboard.BringToFront();

			
		}

		private void btnApointments_Click(object sender, EventArgs e)
		{
			ChangeSideBarBtn(sender);

			plAppointements.BringToFront();

		
		}

		private void btnAddCustomer_Click(object sender, EventArgs e)
		{
			
		}

		private void btnUpdateCustomer_Click(object sender, EventArgs e)
		{
			
		}

		private void btnDeleteCustomer_Click(object sender, EventArgs e)
		{
			
		}

		private void plCustomers_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnCoustomers_Click(object sender, EventArgs e)
		{
			ChangeSideBarBtn(sender);

			plCustomers.BringToFront();

			gvCutomers.DataSource = clsCoustomer.CoustomersList();




		}

	
	}
}
