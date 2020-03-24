using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TestWebApplication
{
    public class CustomerHandling
    {
        public List<Customer> GetCustomers()
        {
            List<Customer> listCustomer = new List<Customer>();
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DirectoryDB;Integrated Security=True;"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(@"SELECT * FROM CUSTOMER;", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {

                            while (reader.Read())
                            {
                                Customer customer = new Customer
                                {
                                    CustomerId = Convert.ToInt32(reader["CUSTOMER_ID"]),
                                    CustomerName = reader["CUSTOMER_NAME"].ToString(),
                                    INN = reader["INN"].ToString(),
                                    Address = reader["ADDRESS"].ToString()
                                };
                                listCustomer.Add(customer);
                            }
                        }
                    }
                }
            }
            return listCustomer;
        }

        public Customer GetCustomerById(string customerId)
        {
            Customer customer = new Customer();
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DirectoryDB;Integrated Security=True;"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM CUSTOMER WHERE CUSTOMER_ID = @customerId", connection))
                {
                    command.Parameters.AddWithValue("@customerId", customerId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        customer = new Customer
                        {
                            CustomerId = Convert.ToInt32(reader["CUSTOMER_ID"]),
                            CustomerName = reader["CUSTOMER_NAME"].ToString(),
                            INN = reader["INN"].ToString(),
                            Address = reader["ADDRESS"].ToString()
                        };
                    }
                }
            }
            return customer;
        }

        public void CreateCustomer(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DirectoryDB;Integrated Security=True;"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(@"INSERT INTO CUSTOMER VALUES (@customerName, @inn, @address);", connection))
                {
                    command.Parameters.AddWithValue("@customerName", customer.CustomerName);
                    command.Parameters.AddWithValue("@inn", customer.INN);
                    command.Parameters.AddWithValue("@address", customer.Address);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditCustomer(string customerId, Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DirectoryDB;Integrated Security=True;"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE CUSTOMER SET CUSTOMER_NAME = @customerName, INN = @inn, ADDRESS = @address WHERE CUSTOMER_ID = @customerId", connection))
                {
                    command.Parameters.AddWithValue("@customerId", customerId);
                    command.Parameters.AddWithValue("@customerName", customer.CustomerName);
                    command.Parameters.AddWithValue("@inn", customer.INN);
                    command.Parameters.AddWithValue("@address", customer.Address);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCustomer(string customerId)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DirectoryDB;Integrated Security=True;"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM CUSTOMER WHERE CUSTOMER_ID = @customerId", connection))
                {
                    command.Parameters.AddWithValue("@customerId", customerId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}