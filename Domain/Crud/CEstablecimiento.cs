using DataAccess.Procedures;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Crud
{
    public class CEstablecimiento
    {
        ProEstablecimiento Establecimiento = new ProEstablecimiento();

        public DataTable Mostrar()
        {
            DataTable dt = new DataTable();
            dt = Establecimiento.Mostrar();
            return dt;
        }
    }
}
