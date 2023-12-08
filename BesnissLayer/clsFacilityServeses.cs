using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BesnissLayer
{
	public class clsFacilityServeses
	{

		//Facility Serveses Column

		public int FacilityServesesID { get; set; }
		public string FacilityServesName { get; set; }
		public byte NumOfBalles { get; set; }
		public byte NumOfTishirts { get; set; }


		private clsFacilityServeses(int FacilityServesesID, string facilityServesName, byte numOfBalles, byte numOfTishirts)
		{
			this.FacilityServesesID = FacilityServesesID;
			FacilityServesName = facilityServesName;
			NumOfBalles = numOfBalles;
			NumOfTishirts = numOfTishirts;
		}

		public static clsFacilityServeses Find(int FacilityServesID)
		{
			if (!isExists(FacilityServesID))
				return null;
			
			string FacilityServesName = "";
			byte NumOfBalles = 0;
			byte NumOfTishirts = 0;
			
			if(FacilityData.FindFacilityServes(FacilityServesID,ref FacilityServesName, ref NumOfBalles, ref NumOfTishirts))
			{
				return new clsFacilityServeses(FacilityServesID,FacilityServesName,NumOfBalles,NumOfTishirts);
			}
			else
			{
				return null;
			}


			
		}

		public static bool isExists(int FacilityServesID)
		{
			return FacilityData.isFacilityServesExists(FacilityServesID);
		}

		public static bool UpdateServeses(int FacilityServesID, string facilityServesName, byte numOfBalles, byte numOfTishirts)
		{
			if(!isExists(FacilityServesID))
				return false;


			return FacilityData.UpdateFacilityServese(FacilityServesID, facilityServesName, numOfBalles, numOfTishirts);
			




		}

		public static int AddNewServeses(string facilityServesName, byte numOfBalles, byte numOfTishirts)
		{
			int FacilityServesID = FacilityData.AddNewFacilityServes(facilityServesName,numOfBalles,numOfTishirts);

			
				return FacilityServesID;
			
		}

	}
}
