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
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool InserEstado(string descripcion)
        {
            EstadoMateriaDao materiaDao = new EstadoMateriaDao();
            return materiaDao.InsertEstadoMateria(descripcion);
        }

        public DataTable GetCantidadEstadosMateria() {
            EstadoMateriaDao materiaDao = new EstadoMateriaDao();
            return materiaDao.ToListEstadosMateria();
        }
        public bool UpdateEstadoMateria(int id, string descripcion) { 
            EstadoMateriaDao materiaDao = new EstadoMateriaDao();
            return materiaDao.UpdateEstadoMateria(id,descripcion);
        }
        public void DeleteEstadoMateria(int id) {
            EstadoMateriaDao materiaDao = new EstadoMateriaDao();
            materiaDao.DeleteEstadoMateria(id);

        }
    }
}
