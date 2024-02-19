using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
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

		public int UserID { get; set; }

		public int Permession { get; set; }

		public clsUser(int Permession, clsPerson person) : base(person.FirstName, person.LastName, person.Address, person.NID, person.Phone)
		{
			this.UserID = -1;
			this.Permession = Permession;

			this.Mode = enumMode.AddNew;
		}

		private clsUser(int UserID,int Permession,clsPerson person) : base(person.FirstName, person.LastName, person.Address, person.NID, person.Phone)
		{
			this.UserID = UserID;
			this.Permession = Permession;

			this.Mode = enumMode.Update;

		}

		private bool _AddNewUser()
		{
			this.UserID = UserData.AddUser(this.PersonID, this.Permession);

			return (this.UserID != -1);
		}

		private bool _UpdateUser()
		{
			return UserData.UpdateUser(this.UserID, this.FirstName, this.LastName, this.NID, this.Address, this.Phone, this.Permession);
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




	}
}
