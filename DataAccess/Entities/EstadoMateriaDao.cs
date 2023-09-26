using DataAccess.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;
using System.Data.Linq;

namespace DataAccess.Entities
{
    public class EstadoMateriaDao : ConnectGestionDB
    {
        private int id;
        private string descripcion;

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public bool InsertEstadoMateria()
        {
            using (var bd = GetDataContext())
            {
                try
                {
                    ESTADO_MATERIA estado = new ESTADO_MATERIA();
                    estado.DESCRIPCION = descripcion;
                    bd.ESTADO_MATERIA.InsertOnSubmit(estado);
                    bd.SubmitChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
                finally
                {
                    bd.Connection.Close();
                }
            }
        }
        public DataTable ToListEstadosMateria()
        {
            using (var bd = GetDataContext())
            {
                try
                {
                    var query = from estado in bd.ESTADO_MATERIA orderby estado.ID ascending
                                select new
                                {
                                    estado.ID,
                                    estado.DESCRIPCION, 
                                };
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("ID", typeof(int));
                    dataTable.Columns.Add("DESCRIPCION", typeof(string));

                    foreach (var estado in query)
                    {
                        dataTable.Rows.Add(estado.ID, estado.DESCRIPCION);
                    }
                    return dataTable;
                }
                catch (Exception ex)
                {
                    return null; 
                }
                finally
                {
                    bd.Connection.Close();
                }
            }
        }
        public bool UpdateEstadoMateria()
        {
            using (var bd = GetDataContext())
            {
                try
                {
                    var estado = bd.ESTADO_MATERIA.SingleOrDefault(e => e.ID == id);
                    if (estado != null)
                    {
                        estado.DESCRIPCION = descripcion;
                        bd.SubmitChanges();
                        return true; 
                    }

                    return false; 
                }
                catch (Exception ex)
                {
                    return false; 
                }
                finally
                {
                    bd.Connection.Close();
                }
            }
        }
        public void DeleteEstadoMateria(){
            using (var bd = GetDataContext())
            {
                try {
                    var estadoAEliminar = bd.ESTADO_MATERIA.SingleOrDefault(estado => estado.ID == id);
                    if (estadoAEliminar != null)
                    {
  
                        bd.ESTADO_MATERIA.DeleteOnSubmit(estadoAEliminar);
   
                        bd.SubmitChanges();
                    }
                    else
                    {
                        Console.WriteLine("No se encontró el estado con ID: " + id);
                    }
                }
                catch (Exception ex) { 
                    Console.WriteLine(ex.Message);

                }finally { bd.Connection.Close(); }
            }
            
        }
    }
}


