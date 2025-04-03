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

			string connectionString = "Server=DESKTOP-NDTMO2E;Database=BikeStores;Integrated Security=True;";


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
	}
}
