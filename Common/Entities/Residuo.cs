using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Residuo
    {
        private int Id;
        private string   Nombre;
        private string Descripcion;
        private string TipoResiduo;
        private string GradoPeligrosidad;
        private string EstadoMateria;

        public int Id1 { get => Id; set => Id = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public string TipoResiduo1 { get => TipoResiduo; set => TipoResiduo = value; }
        public string GradoPeligrosidad1 { get => GradoPeligrosidad; set => GradoPeligrosidad = value; }
        public string EstadoMateria1 { get => EstadoMateria; set => EstadoMateria = value; }
    }
}
