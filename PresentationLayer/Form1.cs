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

		private void plTopBar_MouseMove(object sender, MouseEventArgs e)
		{
			
			if (isClick)
			{
				

				this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
			}

			
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{

		}

		private void plSideBar_Paint(object sender, PaintEventArgs e)
		{

		}

		private void plTopBar_MouseUp(object sender, MouseEventArgs e)
		{
			isClick = false;
		}
	}
}
