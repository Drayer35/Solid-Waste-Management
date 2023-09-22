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
    public class EstablecimientoModel
    {
        EstablecimientoDao EstablecimientoDao = new EstablecimientoDao();
        public bool CreateEstablecimiento(string name) {
            return EstablecimientoDao.InsertarEstablecimiento(name);
        }

        public DataTable ToListEstablecimientos() { 
            return EstablecimientoDao.ListarEstablecimiento();
        }
        public void UpdateEstablecimiento(int id, string name) {
            EstablecimientoDao.UpdateEstablecimiento(id,name);
        
        } 
        public void DeleteEstablecimiento(int id) {
            EstablecimientoDao.DeleteEstablecimiento(id);
        
        }
    }
}
