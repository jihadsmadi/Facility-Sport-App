using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public class UserData
	{

		static public int AddUser(int PersonID,string UserName,string Password, int Permession)
		{
			int UserID = -1;



			// Error at Person Function
			if (PersonID == -1)
			{
				return -1;
			}


			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "insert into Users values(@UserName,@Password,@PersonID,@Permession);" +
						   "select SCOPE_IDENTITY();";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@PersonID", PersonID);
			cmd.Parameters.AddWithValue("@UserName", UserName);
			cmd.Parameters.AddWithValue("@Password", Password);
			cmd.Parameters.AddWithValue("@Permession", Permession);




			try
			{
				connection.Open();

				object value = cmd.ExecuteScalar();


				if (value != null && int.TryParse(value.ToString(), out int InsintionId))
				{
					UserID = InsintionId;
				}

			}
			catch (Exception)
			{
				UserID = -1;
			}
			finally { connection.Close(); }


			return UserID;




		}

		static public bool UpdateUser(int UserID,string UserName,string Password, string FirstName, string LastName,
			string NID, string Address,
			List<string> Phone, int Permession)
		{
			int PersonID = PersonsData.GetPersonIDByUserID(UserID);

			bool isUpdate = PersonsData.UpdatePerson(PersonID, FirstName, LastName, NID, Address, Phone);



			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string qeure = "Update Users set UserName = @UserName, Password = @Password," +
				"Permession = @Permession" +
				" where UserID = @UserID";

			SqlCommand sqlCommand = new SqlCommand(qeure, connection);

			sqlCommand.Parameters.AddWithValue("@UserName", UserName);
			sqlCommand.Parameters.AddWithValue("@Password", Password);
			sqlCommand.Parameters.AddWithValue("@Permession", Permession);
			sqlCommand.Parameters.AddWithValue("@UserID", UserID);




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
			catch (Exception)
			{
				isUpdate = false;
			}
			finally { connection.Close(); }


			return isUpdate;




		}

		static public DataTable UsersList()
		{
			SqlConnection sqlconnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "select Users.UserID,Users.UserName,Persons.FirstName + ' ' + Persons.LastName As Name, " +
				"Users.Permession from Users inner join Persons on Users.PersonID = Persons.PersonID; ";

			SqlCommand cmd = new SqlCommand(query,sqlconnection);

			DataTable db = new DataTable();

			try
			{
				sqlconnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				if(reader.HasRows)
				{
					db.Load(reader);
				}

			}
			catch (Exception)
			{

				return null;
			}finally { sqlconnection.Close(); }

			return db;
		}

		static public bool isUserExists(int coustomerID)
		{
			SqlConnection sqlConnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string Quere = "select A = 1 From Users where UserID = @UserID";

			SqlCommand cmd = new SqlCommand(Quere, sqlConnection);

			cmd.Parameters.AddWithValue("@UserID", coustomerID);


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

		static public bool GetUserByUserID(int UserID,ref string UserName,ref string Password,ref int PersonID,ref int Permession)
		{
			bool isFind = false;

			SqlConnection sqlconnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "select * from Users where UserID = @UserID ;";

			SqlCommand cmd = new SqlCommand(query, sqlconnection);

			cmd.Parameters.AddWithValue("@UserID",UserID);

			try
			{
				sqlconnection.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.Read())
				{
					isFind = true;
					UserName = reader["UserName"].ToString();
					Password = reader["Password"].ToString();
					PersonID = (int)reader["PersonID"];
					Permession = (int)reader["Permession"];
				}
				else
				{
					isFind = false;
					reader.Close();
				}
			}
			catch (Exception)
			{
				isFind = false;
			
			}
			finally { sqlconnection.Close(); }


			return isFind;
		}

		static public bool Delete(int UserID)
		{
			int rowsEfficted = 0;

			SqlConnection sqlconnection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "delete from Users where UserID = @UserID ;";

			SqlCommand cmd = new SqlCommand(query, sqlconnection);

			cmd.Parameters.AddWithValue("@UserID", UserID);

			try
			{
				sqlconnection.Open();

				 rowsEfficted = cmd.ExecuteNonQuery();

			}
			catch (Exception)
			{

				rowsEfficted = 0;
			}
			finally { sqlconnection.Close(); }


			return (rowsEfficted>0);
		}
	}
}
