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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		
		private void button1_Click_1(object sender, EventArgs e)
		{
			clsPaymentStatus p = clsPaymentStatus.FindPaymentStatus(1);

			if(p != null)
			{
				MessageBox.Show( p.PaymentStatusName.ToString());
			}
			else
			{
				MessageBox.Show("Faild");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DataTable db = clsBookingStatus.GetBookingStatusList();

			dataGridView1.DataSource = db;
		}
		
		private void button3_Click(object sender, EventArgs e)
		{

			clsBooking b = clsBooking.Find(3);

			b.StartTime = new DateTime(2023,10,10);

			if(b.Save())
			{
				MessageBox.Show("Done", b.BookingID.ToString());
			}
			else
			{
				MessageBox.Show("Faild");
			}

		}
	}
}
