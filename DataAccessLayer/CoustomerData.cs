using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Net;
using System.Security.Cryptography;

namespace DataAccessLayer
{
	public class CoustomerData
	{


		static public int AddCoustomer(int PersonID, int CoustomerMemberShipStatusID)
		{
			int CoustomerID = -1;

			

			// Error at Person Function
			if(PersonID == -1)
			{
				return -1;
			}


			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "insert into Coustomers values(@PersonID,@CoustomerMemberShipStatus);" +
						   "select SCOPE_IDENTITY();";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@PersonID", PersonID);
			cmd.Parameters.AddWithValue("@CoustomerMemberShipStatus", CoustomerMemberShipStatusID);

			


			try
			{
				connection.Open();

				object value = cmd.ExecuteScalar();


				if (value != null && int.TryParse(value.ToString(), out int InsintionId))
				{
					CoustomerID = InsintionId;
				}

			}
			catch (Exception )
			{
				CoustomerID = -1;
			}
			finally { connection.Close(); }


			return CoustomerID;




		}



		// for coding
		static public bool GetCoustomerByID(int coustomerID,ref int personID, ref  int CoustomerMemberShipStatusID)
		{
			bool isFind = false;



			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			//Use View in database name it "CoustomerInfo" 
			string InfoQuere = "select * from CoustomerInfo where CoustomerID = @CoustomerID;";

			

			SqlCommand Infocmd = new SqlCommand(InfoQuere, sqlConnection);
			

			Infocmd.Parameters.AddWithValue("@CoustomerID", coustomerID);
			

			try
			{
				sqlConnection.Open();

				SqlDataReader reader = Infocmd.ExecuteReader();
				

				if (reader.Read())
				{
					personID = (int)reader["PersonID"];
					
					CoustomerMemberShipStatusID = (int)reader["MemberShipStatusID"];

					isFind = true;

					reader.Close();

					

				
				}
				else
				{
					isFind = false;
				}


			}
			catch (Exception )
			{
				isFind = false;
				
			}finally { sqlConnection.Close(); }



			return isFind;


		}


		static public bool UpdateCoustomer(int CoustomerID,string FirstName, string LastName,
			string NID, string Address,
			List<string> Phone, int CoustomerMemberShipStatusID)
		{
			bool isUpdate = PersonsData.UpdatePerson(CoustomerID, FirstName, LastName, NID, Address, Phone);



			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string qeure = "Update Coustomers set MemberShipStatusID = @MemberShipStatusID" +
				"where CoustomerID = @coustomerID";

			SqlCommand sqlCommand= new SqlCommand(qeure, connection);

			sqlCommand.Parameters.AddWithValue("@MemberShipStatusID", CoustomerMemberShipStatusID);
			sqlCommand.Parameters.AddWithValue("@coustomerID", CoustomerID);




			try
			{
				connection.Open();

				int rowsEfficted = sqlCommand.ExecuteNonQuery();


				if (rowsEfficted > 0 )
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


		static public bool DeleteCoustomer(int CoustomerID)
		{
			bool isDelete = false;

				int PersonID = PersonsData._GetPersonIDByCoustomerID(CoustomerID);

				SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

				string Quere = "delete from Coustomers Where CoustomerID = @CoustomerID";

				SqlCommand sqlCommand = new SqlCommand(Quere, sqlConnection);

				sqlCommand.Parameters.AddWithValue("@CoustomerID", CoustomerID);

				
				try
				{
					sqlConnection.Open();

					sqlCommand.ExecuteNonQuery();

					

					isDelete = PersonsData.DeletePerson(PersonID);

			}
				catch (Exception)
				{
					isDelete= false;
				}
				finally { sqlConnection.Close(); }

				return isDelete;



			


		}

		static public bool isCoustomerExists(int coustomerID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select A = 1 From Coustomers where CoustomerID = @CI";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@CI", coustomerID);


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

		
		static public DataTable GetCoustomersInfoList()
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select * from CoustomerInfo";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			DataTable CoustomersDB = new DataTable();

			

			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				if(reader.HasRows)
				{
					CoustomersDB.Load(reader);
				}

				reader.Close();
				

				
			}
			catch (Exception)
			{
				return null;
			}
			finally
			{ sqlConnection.Close(); }


			return CoustomersDB;



		}

		static public DataTable GetMembershipStatus()
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select * from MemberShipStatus";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			DataTable dbMembershipStatus = new DataTable();



			try
			{
				sqlConnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					dbMembershipStatus.Load(reader);
				}

				reader.Close();



			}
			catch (Exception)
			{
				return null;
			}
			finally
			{ sqlConnection.Close(); }


			return dbMembershipStatus;



		}

	}
}
