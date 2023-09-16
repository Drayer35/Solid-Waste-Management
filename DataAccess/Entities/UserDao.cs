using DataAccess.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace DataAccess.Entities
{
    public class UserDao:ConnectUserDB
    {
        public bool Login(string username, string password) {
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) { 
                    command.Connection = connection;
                    command.CommandText = "Select * from USUARIO where USERNAME=@username and PASSWORD]=@password ";
                    command.Parameters.AddWithValue("username", username);
                    command.Parameters.AddWithValue("password", password);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
              
                    if (reader.HasRows) { 
                        return true;
                    }
                    else { return false; }
                }    
            }
            
        }
    }
}
