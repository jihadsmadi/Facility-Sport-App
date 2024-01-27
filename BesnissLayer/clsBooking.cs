using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BesnissLayer
{
	public class clsBooking
	{
		public enum enMode { AddNew = 1, Update = 2 };
		public enMode Mode { get; set; }
		public int BookingID { get; set; }

		public int CoustomerID { get; set; }

		public int FacilityID { get; set; }

		public DateTime DateOfIssue { get; set; }
		public DateTime DateOfBooking { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public int BookingStatusID { get; set; }
		public int PaymentID { get; set; }

		

		public clsBooking(int coustomerID, int facilityID, DateTime dateOfIssue, DateTime dateOfBooking, DateTime startTime, DateTime endTime, int bookingStatusID, int paymentID)
		{
			Mode = enMode.AddNew;

			CoustomerID = coustomerID;
			FacilityID = facilityID;
			DateOfIssue = dateOfIssue;
			DateOfBooking = dateOfBooking;
			StartTime = startTime;
			EndTime = endTime;
			BookingStatusID = bookingStatusID;
			PaymentID = paymentID;
		}

		private clsBooking(int bookingID, int coustomerID, int facilityID, DateTime dateOfIssue, DateTime dateOfBooking, DateTime startTime, DateTime endTime, int bookingStatusID, int paymentID)
		{
			Mode = enMode.Update;

			BookingID = bookingID;
			CoustomerID = coustomerID;
			FacilityID = facilityID;
			DateOfIssue = dateOfIssue;
			DateOfBooking = dateOfBooking;
			StartTime = startTime;
			EndTime = endTime;
			BookingStatusID = bookingStatusID;
			PaymentID = paymentID;
			 
		}

		public clsBooking()
		{

		}

		
		static public bool DoseBookingExists(int BookingID)
		{
			return BookingData.isBookingExists(BookingID);
		}
		static public clsBooking Find(int BookingID)
		{
			
			if(!DoseBookingExists(BookingID))
			{
				return null;
			}
			
			int CoustomerID = 11;
			int FacilityID = 1;
			DateTime DateOfIssue = DateTime.Now;
			DateTime DateOfBooking = DateTime.Now;
			DateTime StartTime = DateTime.Now;
			DateTime EndTime = DateTime.Now;
			int BookingStatusID = 1;
			int PaymentID = 1;


			if(BookingData.GetBookingByID(BookingID,ref CoustomerID, ref FacilityID, ref DateOfIssue, ref DateOfBooking, ref StartTime,
					ref EndTime, ref BookingStatusID, ref PaymentID))
			{
				return new clsBooking(BookingID, CoustomerID, FacilityID, DateOfIssue, DateOfBooking, StartTime,
					 EndTime, BookingStatusID, PaymentID);

			}
			else
			{
				return null;
			}


		}
		private bool _AddNewBooking()
		{
			this.BookingID = BookingData.AddNewBooking( this.CoustomerID,  this.FacilityID,  this.DateOfIssue,  this.DateOfBooking,
							 this.StartTime,  this.EndTime,  this.BookingStatusID,  this.PaymentID);

			return (this.BookingID != -1);
			


		}

		private bool _UpdateBooking()
		{
			return BookingData.UpdateBooking(this.BookingID,this.CoustomerID,this.FacilityID,this.DateOfIssue,this.DateOfBooking,
						this.StartTime,this.EndTime,this.BookingStatusID,this.PaymentID);

		}

		public bool Save()
		{
			switch (Mode)
			{
				case enMode.AddNew:
					if (_AddNewBooking())
					{
						Mode = enMode.Update;
						return true;
					}
					else
					{
						return false;
					}

				case enMode.Update:
					if (_UpdateBooking())
						return true;
					else
						return false;

			}

			return false;
		}

		static public DataTable GetBookingList()
		{
			return BookingData.GetBookingList();
		}
		
		static public double MinutAmountPerReservation(int FacilityID)
		{
			return FacilityData.MinutPerReservation(FacilityID);
		}

		static public bool IsValidTime(DateTime time,int facilityID)
		{
          return BookingData.isTimeValid(time, facilityID);
			
		}

		public string GetStatusName()
		{
			string bookingStatus = "";

			if(BookingData.GetBookingStatusByID(this.BookingStatusID,ref bookingStatus))
			{
				return bookingStatus;
			}
			else
			{
				return null;
			}
		}

		public bool IsPaidPayment()
		{
			return ( clsPayments.Find(this.PaymentID).PaymentStatusID == 1);
		}

		public bool IsConfirmed()
		{
			return (this.BookingStatusID == 1);
		}

		public bool ConfirmStatus()
		{
			this.BookingStatusID = 1;

			if(this.Save())
			{
				return true;
			}else { return false; }
		}

		public bool Cencel()
		{
			this.BookingStatusID = 2;

			if (this.Save())
			{
				return true;
			}
			else { return false; }
		}

		public bool Complete()
		{
			this.BookingStatusID = 4;
			if (this.Save())
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		static public bool Delete(int bookingID)
		{ 
			return BookingData.DeleteBooking(bookingID);
		}

	}
}
