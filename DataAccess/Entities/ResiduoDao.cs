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
    public class ResiduoDao: ConnectGestionDB
    {
        private int id;
        private string nombre;
        private string descripcion;
        private int tipoResiduoId;
        private int gradoPeligrosidadId;
        private int estadoMateriaId;
        private SqlDataReader readFill;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int TipoResiduoId { get => tipoResiduoId; set => tipoResiduoId = value; }
        public int GradoPeligrosidadId { get => gradoPeligrosidadId; set => gradoPeligrosidadId = value; }
        public int EstadoMateriaId { get => estadoMateriaId; set => estadoMateriaId = value; }

        public bool InsertResiduo()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "InsertResiduo";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NOMBRE", nombre);
                        command.Parameters.AddWithValue("@DESCRIPCION", descripcion);
                        command.Parameters.AddWithValue("@TIPO_RESIDUO_ID", tipoResiduoId );
                        command.Parameters.AddWithValue("@GRADO_PELIGROSIDAD_ID", gradoPeligrosidadId);
                        command.Parameters.AddWithValue("@ESTADO_MATERIA_ID", estadoMateriaId);
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
        public DataTable SelectResiduo()
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
                        command.CommandText = "SelectResiduo";
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
        public bool UpdateResiduo()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "UpdateResiduo";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID", id);
                        command.Parameters.AddWithValue("@NOMBRE", nombre);
                        command.Parameters.AddWithValue("@DESCRIPCION", descripcion);
                        command.Parameters.AddWithValue("@TIPO_RESIDUO_ID", tipoResiduoId);
                        command.Parameters.AddWithValue("@GRADO_PELIGROSIDAD_ID", gradoPeligrosidadId);
                        command.Parameters.AddWithValue("@ESTADO_MATERIA_ID", estadoMateriaId);
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void DeleteResiduo()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "DeleteResiduo";
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
