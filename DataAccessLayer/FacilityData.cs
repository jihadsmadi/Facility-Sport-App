﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public class FacilityData
	{

		public static bool FindFacilityServes(int pKFacilityServesesID,ref string facilityServesName, ref byte numOfBalles, ref byte numOfTishirts)
		{
			bool isFind = false;



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			//Use View in database name it "CoustomerInfo" 
			string Query = "select * from FacilityServeses where FacilityServesesID = @FacilityServesesID;" ;
								

			SqlCommand cmd = new SqlCommand(Query, sqlConnection);


			cmd.Parameters.AddWithValue("@FacilityServesesID", pKFacilityServesesID);
			

			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();


				if (reader.Read())
				{
					facilityServesName = (string)reader["ServesName"];
					numOfBalles = (byte)reader["NumOfBalles"];
					numOfTishirts = (byte)reader["NumOfTishirts"];
					

					isFind = true;

					reader.Close();

					


				}
				else
				{
					isFind = false;
				}


			}
			catch (Exception)
			{
				isFind = false;

			}
			finally { sqlConnection.Close(); }


			return isFind;

		}

		static public bool isFacilityServesExists(int FacilityServesesID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select A = 1 From FacilityServeses where  FacilityServesesID = @FacilityServesesID";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@FacilityServesesID", FacilityServesesID);


			try
			{
				sqlConnection.Open();

				object value = cmd.ExecuteScalar();

				if (value != null)
				{
					return true;
				}
				else return false;
			}
			catch (Exception)
			{
				return false;
			}
			finally
			{ sqlConnection.Close(); }



			



		}

		static public bool UpdateFacilityServese(int FacilityServesesID, string facilityServesName,  byte numOfBalles,  byte numOfTishirts)
		{
			bool isUpdate = false;



			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string qeure = "Update FacilityServeses set ServesName = @ServesName," +
				"NumOfBalles = @NumOfBalles," +
				"NumOfTishirts = @NumOfTishirts" +
				" where FacilityServesesID = @FacilityServesesID";

			SqlCommand sqlCommand = new SqlCommand(qeure, connection);

			sqlCommand.Parameters.AddWithValue("@ServesName", facilityServesName);
			sqlCommand.Parameters.AddWithValue("@NumOfBalles", numOfBalles);
			sqlCommand.Parameters.AddWithValue("@NumOfTishirts", numOfTishirts);
			sqlCommand.Parameters.AddWithValue("@FacilityServesesID", FacilityServesesID);




			try
			{
				connection.Open();

				int rowsEfficted = sqlCommand.ExecuteNonQuery();


				if (rowsEfficted > 0)
				{
					isUpdate = true;
				}
				else
				{
					isUpdate = false;
				}

			}
			catch (Exception )
			{
				isUpdate = false;
			}
			finally { connection.Close(); }


			return isUpdate;
		}

		static public int AddNewFacilityServes(string facilityServesName, byte numOfBalles, byte numOfTishirts)
		{

			int FacilityServesID = -1;

		


			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "insert into FacilityServeses values(@ServesName,@NumOfBalles,@NumOfTishirts);" +
						   "select SCOPE_IDENTITY();";

			SqlCommand sqlCommand = new SqlCommand(query, connection);

			sqlCommand.Parameters.AddWithValue("@ServesName", facilityServesName);
			sqlCommand.Parameters.AddWithValue("@NumOfBalles", numOfBalles);
			sqlCommand.Parameters.AddWithValue("@NumOfTishirts", numOfTishirts);
			




			try
			{
				connection.Open();

				object value = sqlCommand.ExecuteScalar();


				if (value != null && int.TryParse(value.ToString(), out int InsintionId))
				{
					FacilityServesID = InsintionId;
				}

			}
			catch (Exception)
			{
				FacilityServesID = -1;
			}
			finally { connection.Close(); }


			return FacilityServesID;


		}

		static public double MinutPerReservation(int FacilityID)
		{
			double minuteForRes =-1;

			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "SELECT [FacilityBookingTimePerMin] FROM [dbo].[Facility] where FacilityID = @FacilityID ; ";

			SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

			sqlCommand.Parameters.AddWithValue("@FacilityID", FacilityID);

			try
			{
				sqlConnection.Open();

				object value = sqlCommand.ExecuteScalar();

				if (value != null && double.TryParse(value.ToString(), out double min))
				{
					minuteForRes = min;
				}

			}
			catch (Exception )
			{
				
				minuteForRes = -1;
			}

			finally { sqlConnection.Close(); }


			return minuteForRes;
		}

		static public string GetFacilityNameByID(int FacilityID)
		{
			
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "SELECT [FacilityName] FROM [dbo].[Facility] where FacilityID = @FacilityID ; ";

			SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

			sqlCommand.Parameters.AddWithValue("@FacilityID", FacilityID);

			string FacilityName = "";
			try
			{
				sqlConnection.Open();

				object value = sqlCommand.ExecuteScalar();

				if (value != null )
				{
					FacilityName = value.ToString();
				}

			}
			catch (Exception)
			{

				return null;
			}

			finally { sqlConnection.Close(); }


			return FacilityName;
		}

		static public float GetFacilityAmountPerRes(int FacilityID)
		{

			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "SELECT [FacilityAmountPerRes] FROM [dbo].[Facility] where FacilityID = @FacilityID ; ";

			SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

			sqlCommand.Parameters.AddWithValue("@FacilityID", FacilityID);

			float FacilityAmountPerRes =-1;

			try
			{
				sqlConnection.Open();

				object value = sqlCommand.ExecuteScalar();

				if (value != null)
				{
					FacilityAmountPerRes = Convert.ToSingle(value);
				}

			}
			catch (Exception)
			{

				return -1;
			}

			finally { sqlConnection.Close(); }


			return FacilityAmountPerRes;
		}

		static public DataTable GetFacilitysProductivity()
		{

			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "select FacilityServeses.ServesName," +
				" ((A1.countt *1.0) / (select COUNT(Booking.BookingID) As ProductivityAvg from Booking) * 100) from" +
				" (select Facility.FacilityServesesID , count(Booking.BookingID) as countt from" +
				" Facility inner join Booking on Facility.FacilityID = Booking.FacilityID " +
				"group by Facility.FacilityServesesID) as A1 " +
				"inner join FacilityServeses on FacilityServeses.FacilityServesesID = A1.FacilityServesesID ";

			SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);


			DataTable result = new DataTable();


			try
			{
				sqlConnection.Open();

				SqlDataReader reader = sqlCommand.ExecuteReader();

				if (reader.HasRows)
				{
					result.Load(reader);
				}

			}
			catch (Exception)
			{

				return null;
			}

			finally { sqlConnection.Close(); }


			return result;
		}
	}
}
