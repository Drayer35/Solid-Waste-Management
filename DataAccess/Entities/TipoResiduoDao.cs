using DataAccess.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class TipoResiduoDao : ConnectGestionDB
    {

        private int id;
        private string descripcion;

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public bool InsertTipoResiduo()
        {
            using (var bd = GetDataContext())
            {
                try
                {
                    TIPO_RESIDUO tipoResiduo = new TIPO_RESIDUO();
                    tipoResiduo.DESCRIPCION = Descripcion;
                    bd.TIPO_RESIDUO.InsertOnSubmit(tipoResiduo);
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
        public DataTable ToListTipoResiduo()
        {
            using (var bd = GetDataContext())
            {
                try
                {
                    var query = from tipoResiduo in bd.TIPO_RESIDUO
                                orderby tipoResiduo.ID ascending
                                select new
                                {
                                    tipoResiduo.ID,
                                    tipoResiduo.DESCRIPCION,
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
        public bool UpdateTipoResiduo()
        {
            using (var bd = GetDataContext())
            {
                try
                {
                    var tipoResiduo = bd.TIPO_RESIDUO.SingleOrDefault(e => e.ID == id);
                    if (tipoResiduo != null)
                    {
                        tipoResiduo.DESCRIPCION = Descripcion;
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
        public void DeleteEstadoMateria()
        {
            using (var bd = GetDataContext())
            {
                try
                {
                    var tipoResiduo = bd.TIPO_RESIDUO.SingleOrDefault(tipo =>tipo.ID == id);
                    if (tipoResiduo != null)
                    {                
                        bd.TIPO_RESIDUO.DeleteOnSubmit(tipoResiduo);
                        bd.SubmitChanges();
                    }
                    else
                    {
                        Console.WriteLine("No se encontró el registro - ID: " + id);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
                finally { bd.Connection.Close(); }
            }

        }
    }
}
