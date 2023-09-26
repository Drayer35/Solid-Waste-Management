using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class TipoGradoModel
    {
        public DataTable ToListTipoGradoId(int id)
        {
            TipoGradoDao dao = new TipoGradoDao();
         
            return dao.ToListTipoGrado();
        }
        public DataTable ToListTipoGrado(int id)
        {
            TipoGradoDao dao = new TipoGradoDao();
            dao.IdTipoResiduo = id;
            return dao.ToListTipoGrado();

        }
    }
}
