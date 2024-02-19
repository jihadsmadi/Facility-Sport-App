using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public class UserData
	{

		static public int AddUser(int PersonID, int Permession)
		{
			int UserID = -1;



			// Error at Person Function
			if (PersonID == -1)
			{
				return -1;
			}


			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string query = "insert into Users values(@PersonID,@Permession);" +
						   "select SCOPE_IDENTITY();";

			SqlCommand cmd = new SqlCommand(query, connection);

			cmd.Parameters.AddWithValue("@PersonID", PersonID);
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

		static public bool UpdateUser(int UserID, string FirstName, string LastName,
			string NID, string Address,
			List<string> Phone, int Permession)
		{
			int PersonID = PersonsData.GetPersonIDByUserID(UserID);

			bool isUpdate = PersonsData.UpdatePerson(PersonID, FirstName, LastName, NID, Address, Phone);



			SqlConnection connection = new SqlConnection(DataAccessSettings.SqlConnectionString);

			string qeure = "Update Users set Permession = @Permession" +
				" where UserID = @UserID";

			SqlCommand sqlCommand = new SqlCommand(qeure, connection);

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


	}
}
