using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Connection;


namespace DataAccess.Entities
{
    public class GradoPeligrosidadDao: ConnectGestionDB
    {
        private int id;
        private string descripcion;
        private SqlDataReader readFill;
        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public bool InsertGrado()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "InsertGradoPeligrosidad";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@DESCRIPCION", descripcion);
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
        public DataTable SelectGrado()
        {
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SelectGradoPeligrosidad";
                        command.CommandType = CommandType.StoredProcedure;
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
                finally
                {
                    connection.Close();
                }
            }
        }
        public void UpdateGrado()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "UpdateGradoPeligrosidad";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID", id);
                        command.Parameters.AddWithValue("@DESCRIPCION", descripcion);
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
        public void DeleteGrado()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "DeleteGradoPeligrosidad";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID", id);
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
