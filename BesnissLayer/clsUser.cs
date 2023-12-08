using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesnissLayer
{
	public class clsUser : IPerson
	{

		//Person Info

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; }
		public string NID { get; set; }
		public List<string> Phone { get; set; }

		public string GetFullName()
		{
			return FirstName + " " + LastName;
		}

		//User Info

		public int UserID { get; set; }

		public int Permession { get; set; }

	}
}
