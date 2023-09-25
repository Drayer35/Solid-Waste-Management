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
    public class TipoGradoDao: ConnectGestionDB
    {
        private int id;
        private int idTipoResiduo;
        private int idGradoPeligrosidad;
        private SqlDataReader readFill;

        public int Id { get => id; set => id = value; }
        public int IdTipoResiduo { get => idTipoResiduo; set => idTipoResiduo = value; }
        public int IdGradoPeligrosidad { get => idGradoPeligrosidad; set => idGradoPeligrosidad = value; }


        public DataTable ToListTipoGrado()
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
                        command.CommandText = "SelectGrado_x_Tipo";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TIPO_RESIDUO_ID", idTipoResiduo);
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



    }




}
