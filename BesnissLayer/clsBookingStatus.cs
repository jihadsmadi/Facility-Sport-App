using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BesnissLayer
{
	public class clsBookingStatus
	{

		public int BookingStatusID { get; set; }

		public string BookingStatus { get; set; }

		private	 clsBookingStatus(int bookingStatusID,string bookingStatus)
		{
			this.BookingStatusID = bookingStatusID;
			this.BookingStatus = bookingStatus;
		}
		public static clsBookingStatus Find(int BookingStatusID)
		{
			string BookingStatus = "";

			if(BookingData.GetBookingStatusByID(BookingStatusID,ref BookingStatus))
			{
				return new clsBookingStatus(BookingStatusID,BookingStatus);
			}
			else
			{
				return null;
			}

		}

		public static DataTable GetBookingStatusList()
		{
			return BookingData.GetBookingStatusList();
		}








	}
}
