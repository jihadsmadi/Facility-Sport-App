﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public class PaymentsData
	{

		static public bool GetPaymentStatusByID(int PaymentStatusID, ref string PaymentStatusName)
		{
			bool isFind = false;



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			//Use View in database name it "CoustomerInfo" 
			string Queny = "select * from PaymentStatus where PaymentStatusID = @PaymentStatusID;";

			


			SqlCommand cmd = new SqlCommand(Queny, sqlConnection);

			cmd.Parameters.AddWithValue("@PaymentStatusID", PaymentStatusID);
			

			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();


				if (reader.Read())
				{
					PaymentStatusName = (string)reader["Status"];
					
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

		static public bool GetPaymentByID(int paymentID,ref int coustomerID,ref int paymentStatusID, ref DateTime dateOfInitPay, ref DateTime dateOfFinalPay, ref float totalPay, ref float initialPay, ref float remainingPay)
		{
			bool isFind = false;



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			//Use View in database name it "CoustomerInfo" 
			string Queny = "select * from Payments where PaymentID = @PaymentID;";




			SqlCommand cmd = new SqlCommand(Queny, sqlConnection);

			cmd.Parameters.AddWithValue("@PaymentID", paymentID);


			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();


				if (reader.Read())
				{
					coustomerID = (int)reader["CoustomerID"];
					paymentStatusID = (int)reader["PaymentStatusID"];
					dateOfInitPay = (DateTime)reader["DateOfInitPay"];

					if(reader["DateOfFinalPay"] != DBNull.Value)
					{
						dateOfFinalPay = (DateTime)reader["DateOfFinalPay"];
					}
					else
					{
						dateOfFinalPay = DateTime.MinValue;
					}


					if (reader["InitialPay"] != DBNull.Value)
					{
						initialPay = Convert.ToSingle(reader["InitialPay"]);
					}
					else
					{
						initialPay = -1;
					}

				
					totalPay = Convert.ToSingle(reader["TotalPay"]);
					remainingPay = Convert.ToSingle(reader["RemainingPay"]);


					reader.Close();

					isFind = true;


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

		static public int AddPayment(int coustomerID,  int paymentStatusID, 
						 DateTime dateOfInitPay,  DateTime dateOfFinalPay, float totalPay, 
							float initialPay)
		{
			int PaymentID = -1;

			

			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "insert into Payments values(@CoustomerID,@DateOfInitPay," +
								"@DateOfFinalPay,@TotalPay,@InitialPay,@PaymentStatusID,@RemainingPay);" +
						   "select SCOPE_IDENTITY();";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@CoustomerID", coustomerID);
			cmd.Parameters.AddWithValue("@DateOfInitPay", dateOfInitPay);

			if(dateOfFinalPay ==DateTime.MinValue)
			{
				cmd.Parameters.AddWithValue("@DateOfFinalPay", DBNull.Value);
			}
			else
			{
				cmd.Parameters.AddWithValue("@DateOfFinalPay", dateOfFinalPay);
			}
			
			cmd.Parameters.AddWithValue("@TotalPay", totalPay);
			cmd.Parameters.AddWithValue("@InitialPay", initialPay);
			cmd.Parameters.AddWithValue("@PaymentStatusID", paymentStatusID);
			cmd.Parameters.AddWithValue("@RemainingPay", totalPay-initialPay);
			



			try
			{
				connection.Open();

				object value = cmd.ExecuteScalar();


				if (value != null && int.TryParse(value.ToString(), out int InsintionId))
				{
					PaymentID = InsintionId;
				}

			}
			catch (Exception)
			{
				PaymentID = -1;
			}
			finally { connection.Close(); }


			return PaymentID;




		}


		static public bool Update(int PaymentID,int coustomerID, int paymentStatusID,
						 DateTime dateOfInitPay, DateTime dateOfFinalPay, float totalPay,
							float initialPay)
		{
			bool isUpdate = false;



			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);


			string qeure = "Update Payments set CoustomerID = @CoustomerID," +
				"DateOfInitPay = @DateOfInitPay," +
				"DateOfFinalPay = @DateOfFinalPay," +
				"TotalPay = @TotalPay," +
				"InitialPay = @InitialPay," +
				"PaymentStatusID = @PaymentStatusID " +
				"RemainingPay = @remainingPay +"+	
				"where PaymentID = @PaymentID";

			SqlCommand cmd = new SqlCommand(qeure, connection);


			cmd.Parameters.AddWithValue("@CoustomerID", coustomerID);
			cmd.Parameters.AddWithValue("@DateOfInitPay", dateOfInitPay);

			if (dateOfFinalPay == DateTime.MinValue)
			{
				cmd.Parameters.AddWithValue("@DateOfFinalPay", DBNull.Value);
			}
			else
			{
				cmd.Parameters.AddWithValue("@DateOfFinalPay", dateOfFinalPay);
			}

			cmd.Parameters.AddWithValue("@TotalPay", totalPay);
			cmd.Parameters.AddWithValue("@InitialPay", initialPay);
			cmd.Parameters.AddWithValue("@PaymentStatusID", paymentStatusID);
			cmd.Parameters.AddWithValue("@PaymentID", PaymentID);
			float remainingPay = totalPay - initialPay;
			cmd.Parameters.AddWithValue("@remainingPay", remainingPay);





			try
			{
				connection.Open();

				int rowsEfficted = cmd.ExecuteNonQuery();


				if (rowsEfficted > 0)
				{
					isUpdate = true;
				}
				else
				{
					isUpdate = false;
				}

			}
			catch (Exception)
			{
				isUpdate = false;
			}
			finally { connection.Close(); }


			return isUpdate;




		}

		static public bool PaidPayment(int PaymentID)
		{
			bool isUpdate = false;



			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);


			string qeure = "Update Payments set PaymentStatusID = @PaymentStatusID," +
				"RemainingPay = @RemainingPay "+
				"where PaymentID = @PaymentID";

			SqlCommand cmd = new SqlCommand(qeure, connection);

			int PaymentStatusID = 1;
			cmd.Parameters.AddWithValue("@PaymentStatusID", PaymentStatusID);
			float RemainingPay = 0;
			cmd.Parameters.AddWithValue("@RemainingPay", RemainingPay);
			cmd.Parameters.AddWithValue("@PaymentID", PaymentID);





			try
			{
				connection.Open();

				int rowsEfficted = cmd.ExecuteNonQuery();


				if (rowsEfficted > 0)
				{
					isUpdate = true;
				}
				else
				{
					isUpdate = false;
				}

			}
			catch (Exception)
			{
				isUpdate = false;
			}
			finally { connection.Close(); }


			return isUpdate;




		}

		static public bool DeletePayment(int PaymentID)
		{
			

			

			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "delete from Payments Where PaymentID = @PaymentID";

			SqlCommand sqlCommand = new SqlCommand(Quere, sqlConnection);

			sqlCommand.Parameters.AddWithValue("@PaymentID", PaymentID);

			int rowsEffected = 0;
			try
			{
				sqlConnection.Open();

				rowsEffected = sqlCommand.ExecuteNonQuery();



				

			}
			catch (Exception)
			{
				rowsEffected = 0;
			}
			finally { sqlConnection.Close(); }

			return (rowsEffected>0);






		}

		static public string GetPaymentStatus(int paymentStatusID)
		{
			



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			//Use View in database name it "CoustomerInfo" 
			string Queny = "select Status from PaymentStatus where PaymentStatusID = @PaymentStatusID;";




			SqlCommand cmd = new SqlCommand(Queny, sqlConnection);

			cmd.Parameters.AddWithValue("@PaymentStatusID", paymentStatusID);


			try
			{
				sqlConnection.Open();

				object value = cmd.ExecuteScalar();


				if(value != null)
				{
					return value.ToString();
				}

			}
			catch (Exception)
			{

				return null;
			}
			finally { sqlConnection.Close(); }


			return null;
			
		}

		static public DataTable GetPaymentsList()
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select PaymentID,CoustomerID,DateOfInitPay,DateOfFinalPay,TotalPay,InitialPay,RemainingPay,PaymentStatus.Status " +
				" from Payments join PaymentStatus on PaymentStatus.PaymentStatusID =  Payments.PaymentStatusID " +
				" Order by PaymentID";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			DataTable PaymentList = new DataTable();



			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					PaymentList.Load(reader);
				}

				reader.Close();



			}
			catch (Exception)
			{
				return null;
			}
			finally
			{ sqlConnection.Close(); }


			return PaymentList;



		}



	}
}
