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
        public bool InsertarEstablecimiento(string nombre) {
               return EstablecimientoDao.InsertarEstablecimiento(nombre);
        }

        public DataTable ListarEstablecientos() { 
            return EstablecimientoDao.ListarEstablecimiento();
        }
    }
}
