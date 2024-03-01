using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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
			this.UserName = UserName.ToLower();
			this.Password = Password;
			this.Permissions = Permession;
			this.PersonID = person.PersonID;

			this.Mode = enumMode.AddNew;
		}

		private clsUser(int UserID,string UserName, string Password, int Permession,clsPerson person) : base(person.FirstName, person.LastName, person.Address, person.NID, person.Phone)
		{
			this.UserID = UserID;
			this.UserName = UserName.ToLower();
			this.Password = Password;
			this.Permissions = Permession;
			this.PersonID = person.PersonID;

			this.Mode = enumMode.Update;

		}

		private bool _AddNewUser()
		{
			this.UserID = UserData.AddUser(this.PersonID,this.UserName,clsUser.HashingString(this.Password), this.Permissions);

			return (this.UserID != -1);
		}

		private bool _UpdateUser()
		{
			return UserData.UpdateUser(this.UserID, this.UserName, clsUser.HashingString(this.Password), this.FirstName, this.LastName, this.NID, this.Address, this.Phone, this.Permissions);
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

		static public bool isUserExistByUserName(string UserName,string password)
		{
			return UserData.isUserCorrectByUserName(UserName.ToLower(),clsUser.HashingString(password));
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

		static public clsUser Find(string UserName,string Password)
		{
			if (!isUserExistByUserName(UserName.ToLower(),Password))
			{
				return null;
			}

			int UserID = -1;
			int PersonID = -1, Permession = 0;




			if (UserData.GetUserByUserName(ref UserID,  UserName, ref Password, ref PersonID, ref Permession))
			{
				return new clsUser(UserID, UserName, Password, Permession, clsPerson.Find(PersonID));
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

		static public string HashingString(string password)
		{
			 var SHA = SHA256.Create();
			byte[] bytes =  SHA.ComputeHash(Encoding.UTF8.GetBytes(password));

			var s = new StringBuilder();

			for(int i =0;i<bytes.Length;i++)
			{
				s.Append(bytes[i].ToString("x2"));
			}

			return s.ToString();
		}

	

	}
}
