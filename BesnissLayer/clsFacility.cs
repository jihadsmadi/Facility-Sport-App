﻿using System;
using System.Collections.Generic;
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
		public float FacilityAmountPerRes { get; set; }
		



	}
}
