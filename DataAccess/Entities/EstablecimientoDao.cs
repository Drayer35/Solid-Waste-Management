using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;
using DataAccess.Connection;
using System.Runtime.Remoting.Messaging;

namespace DataAccess.Entities
{
    public class EstablecimientoDao:ConnectGestionDB
    {
        private SqlDataReader readFill;
        public bool InsertarEstablecimiento(string nombre) {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "InsertarEstablecimiento";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NOMBRE", nombre);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());   
                    connection.Close();
                    return false;
                }
            } 
        }
        public DataTable  ListarEstablecimiento() {
            DataTable table = new DataTable();
            using (var connection = GetConnection()) {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "ListarEstablecimientos";
                        command.CommandType= CommandType.StoredProcedure;
                        readFill = command.ExecuteReader();
                        table.Load(readFill);
                        readFill.Close();
                        connection.Close();
                        return table;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return table;
                }
                finally { 
                    connection.Close();
                }
            }
        }
        public void UpdateEstablecimiento(int id, string nombre)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "UpdateEstablecimiento";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID", id);
                        command.Parameters.AddWithValue("@NOMBRE", nombre);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void DeleteEstablecimiento(int id) {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "DeleteEstablecimiento";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID",id);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
