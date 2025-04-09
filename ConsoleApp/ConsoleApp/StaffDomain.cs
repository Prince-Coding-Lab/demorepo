using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
	public class StaffDomain
	{

		private static string conn = "Server=DESKTOP-4DHV51D;Database=BikeStores;Integrated Security=True;";
		public void GetCustomerData()
		{

		}
		public void GetStaffData()
		{
			string querystring = "select * from sales.staffs";

			string connectionString = "Server=DESKTOP-NDTMO2E;Database=BikeStores;Integrated Security=True;";


			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				SqlCommand command =
						new SqlCommand(querystring, connection);
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();

				// Call Read before accessing data.
				while (reader.Read())
				{
					Console.WriteLine(String.Format("{0}, {1},{2}",
							reader[0], reader[1], reader[2]));
				}

				// Call Close when done reading.
				reader.Close();
			}
		}

		public void GetStaffDataSet()
		{
			string querystring = "select * from sales.staffs";

			string connectionString = "Server=DESKTOP-4DHV51D;Database=BikeStores;Integrated Security=True;";


			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				//SqlCommand command =
				//		new SqlCommand(querystring, connection);
				SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, connection);

				//connection.Open();

				//Creating DataSet Object
				DataSet dataSet = new DataSet();
				//Filling the DataSet using the Fill Method of SqlDataAdapter object
				//Here, we have not specified the data table name and the data table will be created at index position 0
				dataAdapter.Fill(dataSet);
				foreach (DataRow row in dataSet.Tables[0].Rows)
				{
					//Accessing the Data using the string column name as key
					Console.WriteLine(row["staff_id"] + ",  " + row["first_name"] + ",  " + row["last_name"]);

				}
				// Call Read before accessing data.
				//while (reader.Read())
				//{
				//	Console.WriteLine(String.Format("{0}, {1},{2}",
				//			reader[0], reader[1], reader[2]));
				//}

				//// Call Close when done reading.
				//reader.Close();
			}
		}

		public void AddBrand(string brandValue)
		{
			int returnCode = 0;
			try
			{
				string spAddBrand = string.Empty;
				spAddBrand = "spi_brands";
				SqlConnection connection = new SqlConnection(conn);
				SqlCommand cmd = new SqlCommand(spAddBrand, connection);
				cmd.Parameters.AddWithValue("@BrandName", brandValue);

				SqlParameter returnParam = cmd.Parameters.Add("@return", SqlDbType.Int);
				returnParam.Direction = ParameterDirection.ReturnValue;
				cmd.CommandType = CommandType.StoredProcedure;
				connection.Open();
				int result = cmd.ExecuteNonQuery();
				returnCode = (int)returnParam.Value;
				if (returnCode == 105)
				{
					Console.WriteLine("Brand is already exists");
				}
				else if (returnCode == 100)
				{
					Console.WriteLine("Brand added successfully.");

				}
				else
				{
					Console.WriteLine("Nothing happened.");
				}
			}
			catch (Exception ex)
			{

				throw;
			}



		}

		public void AddCustomer(string fName, string lName, string phone, string email, string street, string city, string state, string zipcode)
		{ 
		
		}

	}
}
