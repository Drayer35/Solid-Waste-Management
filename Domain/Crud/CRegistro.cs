using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Procedures;
using System.Data;

namespace Domain.Crud
{
    public class CRegistro
    {
        ProRegistro Registro= new ProRegistro();

        public DataTable Mostrar() { 
            DataTable dt = new DataTable();
            dt = Registro.Mostrar();
            return dt;
        }
    }
}
