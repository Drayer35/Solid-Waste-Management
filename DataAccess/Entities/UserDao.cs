using DataAccess.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using Common.Cache;


namespace DataAccess.Entities
{
    public class UserDao:ConnectUserDB
    {
        public bool Login(string username, string password) {
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) { 
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM USUARIO WHERE USERNAME=@username AND PASSWORD=@password ";
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();  
                    if (reader.HasRows) {
                        while (reader.Read()) {
                            UserLoginCache.Nombre = reader.GetString(1);
                            UserLoginCache.Apellido = reader.GetString(2);
                            UserLoginCache.Correo = reader.GetString(3);    
                            UserLoginCache.UserName = reader.GetString(4);
                        }
                        return true;
                    }
                    else { return false; }
                }    
            }
            
        }
    }
}
