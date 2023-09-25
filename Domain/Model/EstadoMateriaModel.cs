using DataAccess;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;
using System.Data;
namespace Domain.Model
{
    public class EstadoMateriaModel
    {
        EstadoMateriaDao materiaDao = new EstadoMateriaDao();
        public bool InserEstado(string descripcion)
        {
            materiaDao.Descripcion = descripcion;
            return materiaDao.InsertEstadoMateria();
        }




        public DataTable GetCantidadEstadosMateria() {
            return materiaDao.ToListEstadosMateria();
        }
        public bool UpdateEstadoMateria(int id, string descripcion) {
            materiaDao.Id = id;
            materiaDao.Descripcion = descripcion;
            return materiaDao.UpdateEstadoMateria();
        }
        public void DeleteEstadoMateria(int id) {
            materiaDao.Id = id;
            materiaDao.DeleteEstadoMateria();

        }
    }
}
