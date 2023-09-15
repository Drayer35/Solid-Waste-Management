using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Establecimiento
    {
        private int id;
        private string nombre;
 
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

    }
}
