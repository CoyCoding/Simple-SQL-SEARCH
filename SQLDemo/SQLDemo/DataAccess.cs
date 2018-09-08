using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SQLDemo
{
    class DataAccess
    {
        public List<Customer> GetCustomers(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConValue("StoreDB")))
            {
                return connection.Query<Customer>($"Select * from Customer where LastName = '{ lastName }'").ToList();
            }
        }
    }
}
