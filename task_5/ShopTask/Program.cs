using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ShopTask
{
    class Program
    {
        private static string _connectionString = @"Data Source=DESKTOP-F65ASKG\SQLEXPRESS01;Initial Catalog=BlogSystem;Trusted_Connection=Yes";

        static void Main(string[] args)
        {
            string command = "get-info";

            if (command == "get-info")
            {
                List<CustomerInfo> customerInfos = GetCustomerInfos();
                foreach (CustomerInfo customerInfo in customerInfos)
                {
                    Console.WriteLine(customerInfo.Name + " " + customerInfo.OrdersCount + " " + customerInfo.TotalPrice);
                }
            }
        }

        private static List<CustomerInfo> GetCustomerInfos()
        {
            List<CustomerInfo> customerInfos = new List<CustomerInfo>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        @"SELECT [Customer].[CustomerId], 
		                         [Customer].[Name] as [CustomerName],
		                         COUNT([Order].[OrderId]) as [OrdersCount], 
		                         SUM([Order].[Price]) as [TotalPrice] 
		                  FROM [Customer] 
                          LEFT JOIN [Order] 
		                    ON ([Customer].[CustomerId] = [Order].[CustomerId]) 
                            GROUP BY [Customer].[CustomerId], [Customer].[Name]";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var customerInfo = new CustomerInfo
                            {
                                Name = Convert.ToString(reader["CustomerName"]),
                                OrdersCount = Convert.ToInt32(reader["OrdersCount"]),
                                TotalPrice = Convert.ToInt32(reader["TotalPrice"])
                            };
                            customerInfos.Add(customerInfo);
                        }
                    }
                }
            }
            return customerInfos;
        }
    }
}
