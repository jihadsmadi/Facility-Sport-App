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
	public partial class UserControlTopProdactivityItem : UserControl
	{
		public UserControlTopProdactivityItem()
		{
			InitializeComponent();
		}

		public int CustomerID {  get; set; }
		public void SetImage(Image image)
		{
			this.pbImage.Image = image;
		}

		public void SetName(string name)
		{
			this.lbName.Text = name;
		}

		public void SetNumberOfReservatio(int numberOfReservatio)
		{
			this.lbNumberOfReservation.Text = numberOfReservatio.ToString();
		}

		private void btnViewProfile_Click(object sender, EventArgs e)
		{

			frmViewCustomer frm = new frmViewCustomer(clsCoustomer.Find( this.CustomerID));
			frm.ShowDialog();

		}
	}
}
