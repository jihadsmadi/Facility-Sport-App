using System;
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
	public class BookingData
	{

		public static bool GetBookingStatusByID(int id,ref string bookingStatus)
		{

			bool isFind = false;



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			//Use View in database name it "CoustomerInfo" 
			string Queny = "select * from BookingStatus where BookingStatusID = @BookingStatusID;";




			SqlCommand cmd = new SqlCommand(Queny, sqlConnection);

			cmd.Parameters.AddWithValue("@BookingStatusID", id);


			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();


				if (reader.Read())
				{
					bookingStatus = (string)reader["Status"];

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

		public static DataTable GetBookingStatusList()
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select * from BookingStatus";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			DataTable BookingStatusDB= new DataTable();



			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					BookingStatusDB.Load(reader);
				}

				reader.Close();



			}
			catch (Exception)
			{
				return null;
			}
			finally
			{ sqlConnection.Close(); }


			return BookingStatusDB;
		}

		public static DataTable GetBookingList()
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select * from Booking";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			DataTable BookingDB = new DataTable();



			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					BookingDB.Load(reader);
				}

				reader.Close();



			}
			catch (Exception)
			{
				return null;
			}
			finally
			{ sqlConnection.Close(); }


			return BookingDB;
		}

		public static bool GetBookingByID(int bookingID,ref int coustomerID, ref int facilityID, ref DateTime dateOfIssue, ref DateTime dateOfBooking,
							ref DateTime startTime,ref DateTime endTime, ref int bookingStatusID, ref int paymentID)
		{

			bool isFind = false;



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			//Use View in database name it "CoustomerInfo" 
			string Queny = "select * from Booking where BookingID = @BookingID;";




			SqlCommand cmd = new SqlCommand(Queny, sqlConnection);

			cmd.Parameters.AddWithValue("@BookingID", bookingID);


			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();


				if (reader.Read())
				{
					coustomerID = (int)reader["CoustomerID"];
					facilityID = (int)reader["FacilityID"];
					dateOfIssue = (DateTime)reader["DateOfIssue"];
					dateOfBooking = (DateTime)reader["DateOfBooking"];
					startTime = (DateTime)reader["StartTime"];
					endTime = (DateTime)reader["EndTime"];
					bookingStatusID = (int)reader["BookingStatusID"];
					paymentID = (int)reader["PaymentID"];
					
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

		public static int AddNewBooking( int coustomerID, int facilityID,  DateTime dateOfIssue,  DateTime dateOfBooking, DateTime startTime,
										DateTime endTime, int bookingStatusID, int paymentID)
		{
			int BookingID = -1;
		



			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "INSERT INTO Booking " +
						" VALUES(@CoustomerID ,@FacilityID ,@DateOfIssue ,@DateOfBooking ,@StartTime  " +
						" ,@EndTime ,@BookingStatusID ,@PaymentID);" +
						   "select SCOPE_IDENTITY();";

			SqlCommand cmd = new SqlCommand(query, connection);

			if( coustomerID == -1)
			{
				cmd.Parameters.AddWithValue("@CoustomerID", DBNull.Value);
			}
			else
			{
				cmd.Parameters.AddWithValue("@CoustomerID", coustomerID);
			}

			if (facilityID == -1)
			{
				cmd.Parameters.AddWithValue("@FacilityID", DBNull.Value);
			}
			else
			{
				cmd.Parameters.AddWithValue("@FacilityID", facilityID);
			}

			
			cmd.Parameters.AddWithValue("@DateOfIssue", dateOfIssue);
			cmd.Parameters.AddWithValue("@DateOfBooking", dateOfBooking);
			cmd.Parameters.AddWithValue("@StartTime", startTime);
			cmd.Parameters.AddWithValue("@EndTime", endTime);

			if (bookingStatusID == -1)
			{
				cmd.Parameters.AddWithValue("@BookingStatusID", DBNull.Value);
			}
			else
			{
				cmd.Parameters.AddWithValue("@BookingStatusID", bookingStatusID);
			}

			if (paymentID == -1)
			{
				cmd.Parameters.AddWithValue("@PaymentID", DBNull.Value);
			}
			else
			{
				cmd.Parameters.AddWithValue("@PaymentID", paymentID);
			}
			
			




			try
			{
				connection.Open();

				object value = cmd.ExecuteScalar();


				if (value != null && int.TryParse(value.ToString(), out int InsintionId))
				{
					BookingID = InsintionId;
				}

			}
			catch (Exception)
			{
				BookingID = -1;
			}
			finally { connection.Close(); }


			return BookingID;

		}

		static public bool UpdateBooking(int bookingID,int coustomerID, int facilityID, DateTime dateOfIssue, DateTime dateOfBooking, DateTime startTime,
										DateTime endTime, int bookingStatusID, int paymentID)
		{
			

			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string qeure = "UPDATE [dbo].[Booking] SET [CoustomerID] = @CoustomerID ,[FacilityID] = @FacilityID" +
				",[DateOfIssue] = @DateOfIssue ,[DateOfBooking] = @DateOfBooking ,[StartTime] = @StartTime" +
				",[EndTime] = @EndTime ,[BookingStatusID] = @BookingStatusID ,[PaymentID] = @PaymentID " +
				" WHERE BookingID = @BookingID";
			
			SqlCommand cmd = new SqlCommand(qeure, connection);

			if (coustomerID == -1)
			{
				cmd.Parameters.AddWithValue("@CoustomerID", DBNull.Value);
			}
			else
			{
				cmd.Parameters.AddWithValue("@CoustomerID", coustomerID);
			}

			if (facilityID == -1)
			{
				cmd.Parameters.AddWithValue("@FacilityID", DBNull.Value);
			}
			else
			{
				cmd.Parameters.AddWithValue("@FacilityID", facilityID);
			}


			cmd.Parameters.AddWithValue("@DateOfIssue", dateOfIssue);
			cmd.Parameters.AddWithValue("@DateOfBooking", dateOfBooking);
			cmd.Parameters.AddWithValue("@StartTime", startTime);
			cmd.Parameters.AddWithValue("@EndTime", endTime);

			if (bookingStatusID == -1)
			{
				cmd.Parameters.AddWithValue("@BookingStatusID", DBNull.Value);
			}
			else
			{
				cmd.Parameters.AddWithValue("@BookingStatusID", bookingStatusID);
			}

			if (paymentID == -1)
			{
				cmd.Parameters.AddWithValue("@PaymentID", DBNull.Value);
			}
			else
			{
				cmd.Parameters.AddWithValue("@PaymentID", paymentID);
			}


			cmd.Parameters.AddWithValue("@BookingID", bookingID);



			int rowsEfficted = 0;

			try
			{
				connection.Open();

				 rowsEfficted = cmd.ExecuteNonQuery();



			}
			catch (Exception)
			{
				rowsEfficted = 0;
			}
			finally { connection.Close(); }


			return (rowsEfficted > 0);




		}

		

	}
}
