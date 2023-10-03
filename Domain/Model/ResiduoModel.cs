using DataAccess;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class ResiduoModel
    {
        public bool InsertResiduo(string nombre, string descripcion, int tipoResiduo, int gradoPeligro, int estadoMateria) { 
            ResiduoDao residuoDao = new ResiduoDao();
            residuoDao.Nombre = nombre;
            residuoDao.Descripcion = descripcion;
            residuoDao.TipoResiduoId = tipoResiduo;
            residuoDao.GradoPeligrosidadId = gradoPeligro;
            residuoDao.EstadoMateriaId = estadoMateria;
            return residuoDao.InsertResiduo();
        }
        public DataTable SelectResiduo() { 
            ResiduoDao residuoDao = new ResiduoDao();
            return residuoDao.SelectResiduo();
        }
        public bool UpdateResiduo(int id,string nombre,string descripcion, int tipoResiduo, int gradoPeligro, int estadoMateria) { 
            ResiduoDao residuoDao = new ResiduoDao();
            residuoDao.Id = id;
            residuoDao.Nombre = nombre;
            residuoDao.Descripcion = descripcion;
            residuoDao.TipoResiduoId = tipoResiduo;
            residuoDao.GradoPeligrosidadId = gradoPeligro;
            residuoDao.EstadoMateriaId = estadoMateria;
            return residuoDao.UpdateResiduo();
        }
        public void DeleteResiduo(int id)
        {
            ResiduoDao residuoDao=new ResiduoDao();
            residuoDao.Id = id;
            residuoDao.DeleteResiduo();
        }
    
    }


}
