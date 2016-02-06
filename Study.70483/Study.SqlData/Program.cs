using System.Collections.Generic;
using System.Data.SqlClient;

namespace Study.SqlData {
    class Program {
        const string sqlSelectCustomers = "SELECT CustomerID, CompanyName FROM Customers";
        private static IEnumerable<Customer> GetCustomers(string sqlConnectionString) {
            List<Customer> customers = new List<Customer>();
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
            using (sqlConnection) {
                SqlCommand sqlCommand = new SqlCommand(sqlSelectCustomers, sqlConnection);

                // Opens the connection with the options specified by the connectionString
                sqlConnection.Open();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {

                    // Read advances to the next record, returning true or false
                    while (sqlDataReader.Read()) {
                        Customer customer = new Customer();
                        customer.Id = (string)sqlDataReader["CustomerID"];
                        customer.CompanyName = (string)sqlDataReader["CompanyName"];
                        customers.Add(customer);
                    }
                }
            }
            return customers;
        }

        static void Main(string[] args) { }
    }

    class Customer {
        public string CompanyName { get; set; }
        public string Id { get; set; }
    }
}
