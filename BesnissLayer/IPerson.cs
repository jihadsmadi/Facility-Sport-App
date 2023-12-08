using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesnissLayer
{
	public interface IPerson
	{

		string FirstName { get; set; }

		string LastName { get; set; }

		string Address { get; set; }
		string NID { get; set; }

		List<string> Phone { get; set; }

		 string GetFullName();




	}
}
