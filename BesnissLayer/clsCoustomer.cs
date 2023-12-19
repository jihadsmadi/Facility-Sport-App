using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BesnissLayer
{
	public class clsCoustomer : clsPerson
	{
		//Person Info

		

		

		//Coustomer Info

		public enum enMode { AddNew = 0, Update = 1 }
		enMode Mode { get; set; }

		public int CoustomerID { get; set; }

		public int CoustomerMemberShipStatusID { get; set; }

		public clsCoustomer(string firstName, string lastName, string address, string nID, List<string> phone, int coustomerMemberShipStatusID) : base (firstName,lastName,address,nID,phone)
		{
			CoustomerID = -1;
			
			
			CoustomerMemberShipStatusID = coustomerMemberShipStatusID;

			Mode = enMode.AddNew;
		}

		private clsCoustomer(int CoustomerID,string firstName, string lastName, string address, string nID, List<string> phone, int coustomerMemberShipStatusID)
								: base(firstName, lastName, address, nID, phone)
		{
			this.CoustomerID = CoustomerID;


			
			this.CoustomerMemberShipStatusID = coustomerMemberShipStatusID;

			this.Mode = enMode.Update;
		}
		

		 private bool _AddNewCoustomer()
		{
			this.CoustomerID = CoustomerData.AddCoustomer(this.FirstName, this.LastName, this.NID, this.Address
									, this.Phone, this.CoustomerMemberShipStatusID);


			return (this.CoustomerID != -1);
		}
		
		private bool _UpdateCoustomer()
		{
			return CoustomerData.UpdateCoustomer(this.CoustomerID, this.FirstName, this.LastName, this.NID, this.Address,
							this.Phone, this.CoustomerMemberShipStatusID);
		}

		public bool Save()
		{
			switch (Mode)
			{
				case enMode.AddNew:
					if(_AddNewCoustomer())
					{
						Mode  = enMode.Update;
						return true;
					}
					else
					{
						return false;
					}
					
				case enMode.Update:
					if (_UpdateCoustomer())
						return true;
					else
						return false;
					
			}

			return false;
		}

		public static bool IsCustomerExist(int CustomerID)
		{
			return CoustomerData.isCoustomerExists(CustomerID);
		}

		static public clsCoustomer Find(int CoustomerID)
		{

			if(!IsCustomerExist(CoustomerID))
			{
				return	null;
			}

			string FirstName="", LastName="", NID = "", Address = "";
			int CoustomerMemberShipStatusID=-1;
			List<string> Phones= new List<string>();


			if(CoustomerData.GetCoustomerByID(CoustomerID,ref FirstName, ref LastName, ref NID,ref Address,ref Phones,ref CoustomerMemberShipStatusID)==true)
			{
				return new clsCoustomer(CoustomerID, FirstName, LastName, Address, NID, Phones, CoustomerMemberShipStatusID);
			}

			else
			{
				return null;
			}


		}

		static public bool Delete(int coustomeID)
		{
			return CoustomerData.DeleteCoustomer(coustomeID);
		}

		static public DataTable CoustomersList()
		{
			return CoustomerData.GetCoustomersInfoList();

		}

		
	}
}
