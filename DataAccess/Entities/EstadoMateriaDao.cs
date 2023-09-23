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

        public bool InsertEstadoMateria(string descripcion)
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

        public bool UpdateEstadoMateria(int id, string descripcion)
        {
            using (var bd = GetDataContext())
            {
                try
                {
                    // Buscar el estado que deseas actualizar por su ID
                    var estado = bd.ESTADO_MATERIA.SingleOrDefault(e => e.ID == id);

                    if (estado != null)
                    {
                        // Modificar las propiedades del objeto
                        estado.DESCRIPCION = descripcion;

                        // Luego, guardar los cambios en la base de datos
                        bd.SubmitChanges();
                        return true; // La actualización fue exitosa
                    }

                    return false; // El estado no se encontró, no se pudo actualizar
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones si es necesario
                    return false; // Otra opción podría ser lanzar una excepción personalizada aquí
                }
                finally
                {
                    bd.Connection.Close();
                }
            }
        }
        public void DeleteEstadoMateria(int id){
            using (var bd = GetDataContext())
            {
                try {
                    var estadoAEliminar = bd.ESTADO_MATERIA.SingleOrDefault(estado => estado.ID == id);
                    if (estadoAEliminar != null)
                    {
                        // Elimina el estado encontrados
                        bd.ESTADO_MATERIA.DeleteOnSubmit(estadoAEliminar);
                        // Guarda los cambios en la base de datos
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


