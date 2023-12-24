using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

		public clsCoustomer(clsPerson person, int coustomerMemberShipStatusID) :
					base(person.FirstName, person.LastName, person.Address, person.NID, person.Phone)
		{
			CoustomerID = -1;


			CoustomerMemberShipStatusID = coustomerMemberShipStatusID;

			Mode = enMode.AddNew;
		}

		private clsCoustomer(int CoustomerID, clsPerson person, int coustomerMemberShipStatusID) :
						base(person.FirstName, person.LastName, person.Address, person.NID, person.Phone)
		{
			this.CoustomerID = CoustomerID;



			this.CoustomerMemberShipStatusID = coustomerMemberShipStatusID;

			this.Mode = enMode.Update;
		}


		private bool _AddNewCoustomer()
		{
			this.CoustomerID = CoustomerData.AddCoustomer(this.PersonID, this.CoustomerMemberShipStatusID);


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
					if (_AddNewCoustomer())
					{
						Mode = enMode.Update;
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

		public static bool IsCustomerExistByPersonID(int perosnID)
		{
			return CoustomerData.isCoustomerExistsByPersonID(perosnID);
		}

		static public clsCoustomer Find(int CoustomerID)
		{

			if(!IsCustomerExist(CoustomerID))
			{
				return	null;
			}

			int personID = -1;
			int CoustomerMemberShipStatusID=-1;


			if(CoustomerData.GetCoustomerByID(CoustomerID,ref personID ,ref CoustomerMemberShipStatusID)==true)
			{
				return new clsCoustomer(CoustomerID,clsPerson.Find(personID), CoustomerMemberShipStatusID);
			}

			else
			{
				return null;
			}


		}

		static public clsCoustomer FindByPersonID(int PersonID)
		{

			if (!IsCustomerExistByPersonID(PersonID))
			{
				return null;
			}

			int CoustomerID = -1;
			int CoustomerMemberShipStatusID = -1;


			if (CoustomerData.GetCoustomerByPersonID(ref CoustomerID,  PersonID, ref CoustomerMemberShipStatusID) == true)
			{
				return new clsCoustomer(CoustomerID, clsPerson.Find(PersonID), CoustomerMemberShipStatusID);
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

		static public DataTable GetMemberShipStatus()
		{
			return CoustomerData.GetMembershipStatus();
		}

		static public DataTable CoustomersList()
		{
			return CoustomerData.GetCoustomersInfoList();

		}

		
	}
}
