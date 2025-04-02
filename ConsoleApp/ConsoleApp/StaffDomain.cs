using System;
using System.Collections.Generic;
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
	}
}
