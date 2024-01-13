using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BesnissLayer
{
	public class clsPayments
	{
		public enum enMode { AddNew= 1,Update = 2 };
		public enMode Mode { get;set; }

		public int PaymentID { get; set; }
		public int CoustomerID { get; set; }
		public int PaymentStatusID { get; set; }
		public DateTime DateOfInitPay { get; set; }
		public DateTime DateOfFinalPay { get; set; }
		public float TotalPay { get; set; }
		public float InitialPay { get; set; }
		public float RemainingPay { get; set; }

		public clsPayments( int coustomerID, int paymentStatusID, DateTime dateOfInitPay, DateTime dateOfFinalPay, float totalPay, float initialPay)
		{
			Mode = enMode.AddNew;

		
			CoustomerID = coustomerID;
			PaymentStatusID = paymentStatusID;
			DateOfInitPay = dateOfInitPay;
			DateOfFinalPay = dateOfFinalPay;
			TotalPay = totalPay;
			InitialPay = initialPay;
			RemainingPay = TotalPay - InitialPay;
		}
		private clsPayments(int paymentID, int coustomerID, int paymentStatusID, DateTime dateOfInitPay, DateTime dateOfFinalPay, float totalPay, float initialPay, float remainingPay)
		{
			PaymentID = paymentID;
			CoustomerID = coustomerID;
			PaymentStatusID = paymentStatusID;
			DateOfInitPay = dateOfInitPay;
			DateOfFinalPay = dateOfFinalPay;
			TotalPay = totalPay;
			InitialPay = initialPay;
			RemainingPay = remainingPay;

			Mode = enMode.Update;
		}

		public clsPayments()
		{

		}
		

		static public clsPayments Find(int PaymentID)
		{
			int CoustomerID = -1;
			int PaymentStatusID = -1;
			DateTime DateOfInit = DateTime.MinValue; 
			DateTime DateOfFinal = DateTime.MinValue;
			float TotalPay = 0;
			float InitialPay = 0;
			float RemainingPay = 0;



			if(PaymentsData.GetPaymentByID(PaymentID,ref CoustomerID,ref PaymentStatusID,
				ref DateOfInit,ref DateOfFinal,ref TotalPay,ref InitialPay,ref RemainingPay))
			{
				return new clsPayments(PaymentID, CoustomerID, PaymentStatusID, DateOfInit,
								DateOfFinal, TotalPay, InitialPay, RemainingPay);

			}
			else
			{
				return null;
			}



		}

		private bool _AddNewPayment()
		{
			this.PaymentID = PaymentsData.AddPayment(this.CoustomerID, this.PaymentStatusID, this.DateOfInitPay, this.DateOfFinalPay,
									 this.TotalPay, this.InitialPay);

			this.RemainingPay = this.TotalPay - this.InitialPay;

			return (this.PaymentID != -1);
		}

		private bool _UpdatePayment()
		{
			return PaymentsData.Update(this.PaymentID,this.CoustomerID, this.PaymentStatusID, this.DateOfInitPay, this.DateOfFinalPay,
									 this.TotalPay, this.InitialPay);
		}

		public bool Save()
		{
			
			switch (this.Mode)
			{
				case enMode.AddNew:
						
					if(_AddNewPayment())
					{
						return true;
					}
					else
					{
						return false;
					}


				
				case enMode.Update:
					if(_UpdatePayment())
					{
						return true;
					}
					else
					{
						return false;
					}
					
			}
			return false;
		}

		public static bool Delete(int PaymentID)
		{
			return PaymentsData.DeletePayment(PaymentID);
		}

		public string PaymentStatusName()
		{
			return PaymentsData.GetPaymentStatus(this.PaymentStatusID);
		}

	}
}
