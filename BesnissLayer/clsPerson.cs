using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesnissLayer
{
	public class clsPerson
	{
		public enum enMode { AddNew = 0, Update = 1 }
		public enMode Mode { get; set; }

		public int PersonID { get; set; }
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Address { get; set; }
		public string NID { get; set; }

		public List<string> Phone { get; set; }

		public string GetFullName()
		{
			return FirstName + " " + LastName;
		}

		public clsPerson(string firstName, string lastName, string address, string nID, List<string> phone)
		{
			PersonID = -1;

			FirstName = firstName;
			LastName = lastName;
			Address = address;
			NID = nID;
			Phone = phone;

			Mode = enMode.AddNew;
		}
		private clsPerson(int PersonID,string firstName, string lastName, string address, string nID, List<string> phone)
		{
			this.PersonID = PersonID;

			this.FirstName = firstName;
			this.LastName = lastName;
			this.Address = address;
			this.NID = nID;
			this.Phone = phone;

			this.Mode = enMode.Update;
		}

		public static bool IsPersonExists(int PersonID)
		{
			return PersonsData.isPersonExists(PersonID);
		}

		static public clsPerson Find(int PersonID)
		{

			if (!IsPersonExists(PersonID))
			{
				return null;
			}

			string FirstName = "", LastName = "", NID = "", Address = "";
			
			List<string> Phones = new List<string>();


			if (PersonsData.GetPersonByID(PersonID, ref FirstName, ref LastName, ref NID, ref Address, ref Phones) == true)
			{
				return new clsPerson(PersonID, FirstName, LastName, Address, NID, Phones);
			}

			else
			{
				return null;
			}


		}

		private bool _AddNewCoustomer()
		{
			this.PersonID = PersonsData.AddPerson(this.FirstName, this.LastName, this.NID, this.Address, this.Phone);


			return (this.PersonID != -1);
		}

		private bool _UpdateCoustomer()
		{
			return PersonsData.UpdatePerson(this.PersonID,this.FirstName, this.LastName, this.NID, this.Address, this.Phone);
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

		static public DataTable PersonsIDList()
		{
			return PersonsData.GetPersonsIDList();
		}


	}
}
