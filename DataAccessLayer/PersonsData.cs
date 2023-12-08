using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public class PersonsData
	{
		static private  bool _AddPhoneNumberForPerson(int PersonID,string PhoneNumber)
		{
			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "insert into Phones values(@PersonID,@PhoneNumber);";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@PersonID", PersonID);
			cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

			
			
				

				try
				{
					connection.Open();

					cmd.ExecuteNonQuery();


				}
				catch (Exception)
				{
					return false;
				}

			finally { connection.Close(); }
				

			

			return true;
			
						  

			




		}

		static private bool _DeletePhoneNumberForPerson(int PersonID)
		{
			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "delete from Phones where PersonID = @personID";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@personID", PersonID);
			





			try
			{
				connection.Open();

				cmd.ExecuteNonQuery();


			}
			catch (Exception)
			{
				return false;
			}

			finally { connection.Close(); }




			return true;








		}

		static public int _GetPersonIDByCoustomerID(int CoustomerID)
		{
			int PersonID = -1;

			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string qeure = "select PersonID from Coustomers where CoustomerID = @CoustomerID;";

			SqlCommand cmd = new SqlCommand(qeure, connection);

			cmd.Parameters.AddWithValue("@CoustomerID", CoustomerID);

			try
			{
				connection.Open();

				object value = cmd.ExecuteScalar();

				if (value != null)
				{
					PersonID = (int)value;
				}
				
			}
			catch (Exception)
			{

				PersonID = -1;
			}finally { connection.Close(); }

			return PersonID;
		}


		static public int AddPerson(string FirstName, string LastName,
			string NID, string Address,
			List<string> Phones)
		{

			int PersonID = -1;

			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "insert into Persons values(@FirstName,@LastName,@Address,@NationalIdentificationNumber);" +
						   "select SCOPE_IDENTITY();";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@FirstName", FirstName);
			cmd.Parameters.AddWithValue("@LastName", LastName);
			cmd.Parameters.AddWithValue("@Address", Address);
			cmd.Parameters.AddWithValue("@NationalIdentificationNumber", NID);


			try
			{
				connection.Open();

				object value = cmd.ExecuteScalar();


				if (value != null && int.TryParse(value.ToString(), out int InsintionId))
				{
					PersonID = InsintionId;
					
					for(int i=0;i<Phones.Count;i++) 
					{ 
						_AddPhoneNumberForPerson(PersonID, Phones[i]);
					}
				}

			}
			catch (Exception)
			{
				PersonID = -1;
			}
			finally { connection.Close(); }

			
			return PersonID ;
		}

		static public bool UpdatePerson(int CoustomerID,string FirstName, string LastName,
			string NID, string Address,
			List<string> Phones)
		{
			int personID = _GetPersonIDByCoustomerID(CoustomerID);


			bool isUpdate = false;
			

			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "UPDATE Persons " +
							"SET FirstName = @FirstName ," +
							"LastName = @LastName ," +
							"Address = @Address ," +
							"NationalIdentificationNumber = @NID " +
							"  where PersonID = @personID";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@FirstName", FirstName);
			cmd.Parameters.AddWithValue("@LastName", LastName);
			cmd.Parameters.AddWithValue("@Address", Address);
			cmd.Parameters.AddWithValue("@NID", NID);
			cmd.Parameters.AddWithValue("@personID", personID);
		


			try
			{
				connection.Open();

				int EffectedRows = cmd.ExecuteNonQuery();


				if (EffectedRows > 0)
				{
					
					
						_DeletePhoneNumberForPerson(personID);

						for (int i = 0; i < Phones.Count; i++)
						{
							_AddPhoneNumberForPerson(personID, Phones[i]);
						}

				}

					isUpdate = true;




				

			}
			catch (Exception)
			{
				isUpdate = false;

			}
			finally { connection.Close(); }


			return isUpdate;
		}

		static public bool DeletePerson(int PersonID)
		{
			

			if (PersonID == -1)
				return false;

			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string quere = "Delete from Persons where" +
						" PersonID = @PersonID;";

			SqlCommand cmd = new SqlCommand(quere, sqlConnection);

			cmd.Parameters.AddWithValue("@PersonID", PersonID);

			int RowsEfficted = -1;

			_DeletePhoneNumberForPerson(PersonID);


			try 
			{ 
				sqlConnection.Open();

				 RowsEfficted = cmd.ExecuteNonQuery();

			}catch(Exception)
			{
				return false;
			}
			finally { sqlConnection.Close(); }


			return RowsEfficted > 0;
		}
		
		
	}
}
