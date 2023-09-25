
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;
using System.Data;


using DataAccess.Entities;

namespace Domain.Model
{

    public class EstablecimientoModel
    {
        EstablecimientoDao establecimientoDao = new EstablecimientoDao();
        public bool CreateEstablecimiento(string name) {
            establecimientoDao.Nombre = name;
            return establecimientoDao.InsertarEstablecimiento();
        }





        public DataTable ToListEstablecimientos() {
           return establecimientoDao.ListarEstablecimiento();
        }
        public void UpdateEstablecimiento(int id, string name) {
            establecimientoDao.Id = id;
            establecimientoDao.Nombre=name;
            establecimientoDao.UpdateEstablecimiento();
        } 
        public void DeleteEstablecimiento(int id) {
            establecimientoDao.Id=id;
            establecimientoDao.DeleteEstablecimiento();
        }




    }
}
