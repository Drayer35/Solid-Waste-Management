using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess.Connection;

namespace Common.Atributtes
{
    public class Registro
    {
        private int Id;
        private string Residuo;
        private string Fecha; 
        private string Descripcion;
        private string TipoResiduo;
        private string Establecimiento;
        private string ProcesoGenerador;
        private string GradoPeligrosidad;
        private string Estado;
        private int Cantidad;
        private string Gestion;
        private string TipoGestion;
        private string MecanimoEntrega;
        private string Presentacion;
        private string Gestor;
        private string Certificado;

        public int Id1 { get => Id; set => Id = value; }
        public string Residuo1 { get => Residuo; set => Residuo = value; }
        public string Fecha1 { get => Fecha; set => Fecha = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public string TipoResiduo1 { get => TipoResiduo; set => TipoResiduo = value; }
        public string Establecimiento1 { get => Establecimiento; set => Establecimiento = value; }
        public string ProcesoGenerador1 { get => ProcesoGenerador; set => ProcesoGenerador = value; }
        public string GradoPeligrosidad1 { get => GradoPeligrosidad; set => GradoPeligrosidad = value; }
        public string Estado1 { get => Estado; set => Estado = value; }
        public int Cantidad1 { get => Cantidad; set => Cantidad = value; }
        public string Gestion1 { get => Gestion; set => Gestion = value; }
        public string TipoGestion1 { get => TipoGestion; set => TipoGestion = value; }
        public string MecanimoEntrega1 { get => MecanimoEntrega; set => MecanimoEntrega = value; }
        public string Presentacion1 { get => Presentacion; set => Presentacion = value; }
        public string Gestor1 { get => Gestor; set => Gestor = value; }
        public string Certificado1 { get => Certificado; set => Certificado = value; }
    }
}
