using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BesnissLayer
{
	public class clsUser : clsPerson
	{
		

		//User Info
		public enum enumMode { AddNew=1,Update=2};
		public enumMode Mode { get; set; }

		public enum enPermessions { All=-1, Dashboard=1,Customers=2, Booking=4, Payments = 8, Users=16 }

		public int UserID { get; set; }

		public string UserName { get; set; }
		public string Password { get; set; }

		public int Permissions { get; set; }

		public clsUser(string UserName,string Password,int Permession, clsPerson person) : base(person.FirstName, person.LastName, person.Address, person.NID, person.Phone)
		{
			this.UserID = -1;
			this.UserName = UserName;
			this.Password = Password;
			this.Permissions = Permession;
			this.PersonID = person.PersonID;

			this.Mode = enumMode.AddNew;
		}

		private clsUser(int UserID,string UserName, string Password, int Permession,clsPerson person) : base(person.FirstName, person.LastName, person.Address, person.NID, person.Phone)
		{
			this.UserID = UserID;
			this.UserName = UserName;
			this.Password = Password;
			this.Permissions = Permession;

			this.Mode = enumMode.Update;

		}

		private bool _AddNewUser()
		{
			this.UserID = UserData.AddUser(this.PersonID,this.UserName,this.Password, this.Permissions);

			return (this.UserID != -1);
		}

		private bool _UpdateUser()
		{
			return UserData.UpdateUser(this.UserID, this.UserName, this.Password, this.FirstName, this.LastName, this.NID, this.Address, this.Phone, this.Permissions);
		}
		public bool Save()
		{
			switch (this.Mode)
			{
				case enumMode.AddNew:
					if (_AddNewUser())
					{
						this.Mode = enumMode.Update;
						return true;
					}
					else
					{
						return false;
					}

				case enumMode.Update:
					return _UpdateUser();
				default:
					return false;
			}
		}

		static public DataTable GetUsersList()
		{
			return UserData.UsersList();
		}

		static public bool isUserExist(int userID)
		{
			return UserData.isUserExists(userID);
		}

		static public clsUser Find(int userID)
		{
			if (!isUserExist(userID))
			{
				return null;
			}

			string UserName = "", Password = "";
			int PersonID = -1, Permession=0;

			


			if (UserData.GetUserByUserID(userID,ref UserName,ref Password,ref PersonID,ref Permession))
			{
				return new clsUser(userID,UserName,Password,Permession,clsPerson.Find(PersonID));
			}

			else
			{
				return null;
			}
		}

		 public bool isAllowPermession(int PermissionYouWant)
		{
			if (this.Permissions == -1)
				return true;

			if ((PermissionYouWant & this.Permissions) == PermissionYouWant)
			{
				return true;
			}
			else
			{ return false; }
		}

		static public bool Delete(int userID)
		{
			return UserData.Delete(userID);
		}

	}
}
