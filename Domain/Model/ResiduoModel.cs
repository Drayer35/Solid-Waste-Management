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
        public bool InsertResiduo(int id) { 
            ResiduoDao residuoDao = new ResiduoDao();   
            residuoDao.Id = id;
            return residuoDao.InsertResiduo();
        }
        public DataTable SelectResiduo() { 
            ResiduoDao residuoDao = new ResiduoDao();
            return residuoDao.SelectResiduo();
        }
        public void UpdateResiduo(string nombre,string descripcion, int tipoResiduo, int gradoPeligro, int estadoMateria) { 
            ResiduoDao residuoDao = new ResiduoDao();
            residuoDao.Nombre = nombre;
            residuoDao.Descripcion = descripcion;
            residuoDao.TipoResiduoId = tipoResiduo;
            residuoDao.GradoPeligrosidadId = gradoPeligro;
            residuoDao.EstadoMateriaId = estadoMateria;
            residuoDao.UpdateEstablecimiento();
        }
        public void DeleteResiduo(int id)
        {
            ResiduoDao residuoDao=new ResiduoDao();
            residuoDao.Id = id;
            residuoDao.DeleteEstablecimiento();
        }
    
    }


}
