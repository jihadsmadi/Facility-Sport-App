using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesnissLayer
{
	public class clsFacility
	{



		//Facility Column
		public int FacilityID { get; set; }
		public int FKFacilityServesesID { get; set; }
		public string FacilityName { get; set; }
		public byte PlayersCapacity { get; set; }
		public bool FacilityStatus { get; set; }
		public double FacilityAmountPerRes { get; set; }


		static public string GetFieldName(int FacilityID)
		{
			return FacilityData.GetFacilityNameByID(FacilityID);
		}

		static public float GetFacilityAmountPerRes(int FacilityID)
		{
			return FacilityData.GetFacilityAmountPerRes(FacilityID);
		}

		static public DataTable GetFacilitysProductivity()
		{
			return FacilityData.GetFacilitysProductivity();
		}

		
	}
}
