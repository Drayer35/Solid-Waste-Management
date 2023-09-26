using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace Domain.Model
{
    public class TipoResiduoModel
    {
        TipoResiduoDao tipoResiduoDao = new TipoResiduoDao();
        public bool InsertTipoResiduo(string descripcion) {
            tipoResiduoDao.Descripcion = descripcion;
            return tipoResiduoDao.InsertTipoResiduo();
        }
        public void UpdateTipoResiduo(int id, string descripcion)
        {
            tipoResiduoDao.Id = id;
            tipoResiduoDao.Descripcion= descripcion;
            tipoResiduoDao.UpdateTipoResiduo();
        }
        public DataTable ToListTipoResiduo() {
            TipoResiduoDao tipoResiduoDao = new TipoResiduoDao();
            return tipoResiduoDao.ToListTipoResiduo();
        }
        public void DeleteTipoResiduo(int id) {
            tipoResiduoDao.Id= id;
            tipoResiduoDao.DeleteEstadoMateria();
        }
    }
}
