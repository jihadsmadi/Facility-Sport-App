using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesnissLayer
{
	public class clsUser : clsPerson
	{
		

		//User Info

		public int UserID { get; set; }

		public int Permession { get; set; }

		public clsUser(int UserID, int Permession, string firstName, string lastName, string address, string nID, List<string> phone) : base(firstName, lastName, address, nID, phone)
		{
			this.UserID = UserID;
			this.Permession = Permession;
		}


	}
}
