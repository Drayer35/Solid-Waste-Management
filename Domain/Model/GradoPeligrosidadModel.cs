using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class GradoPeligrosidadModel
    {
        public bool InsertGrado(string descripcion) { 
            GradoPeligrosidadDao gradoPeligrosidadDao= new GradoPeligrosidadDao();
            gradoPeligrosidadDao.Descripcion = descripcion;
            return gradoPeligrosidadDao.InsertGrado();
        }

        public DataTable SelectGrado() { 
            GradoPeligrosidadDao gradoPeligrosidadDao = new GradoPeligrosidadDao();
            return gradoPeligrosidadDao.SelectGrado();
        }

        public void UpdateGrado(int id, string descripcion) {
            GradoPeligrosidadDao gradoPeligrosidadDao = new GradoPeligrosidadDao();
            gradoPeligrosidadDao.Id = id;
            gradoPeligrosidadDao.Descripcion= descripcion;
            gradoPeligrosidadDao.UpdateGrado();
        }
        public void DeleteGrado(int id)
        {
            GradoPeligrosidadDao gradoPeligrosidadDao = new GradoPeligrosidadDao();
            gradoPeligrosidadDao.Id= id;
            gradoPeligrosidadDao.DeleteGrado();
        }
    }
}
