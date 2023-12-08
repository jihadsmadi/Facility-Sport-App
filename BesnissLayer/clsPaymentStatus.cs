using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesnissLayer
{
	public class clsPaymentStatus
	{

		public int PaymentStatusID { get; set; }

		public string PaymentStatusName { get; set;}

		public clsPaymentStatus(int paymentStatusID, string paymentStatusName)
		{
			PaymentStatusID = paymentStatusID;
			PaymentStatusName = paymentStatusName;
		}

		static public clsPaymentStatus FindPaymentStatus(int paymentStatusID)
		{
			string PaymentStatus = "";
			if(PaymentsData.GetPaymentStatusByID(paymentStatusID, ref PaymentStatus))
			{
				return new clsPaymentStatus(paymentStatusID, PaymentStatus);
			}
			else
			{
				return null;
			}
		}







	}
}
