using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Common.Entities;
using Domain.Crud;
using LiveCharts;
using LiveCharts.Wpf;

namespace Presentation.View
{
    /// <summary>
    /// Lógica de interacción para Dashboard.xaml
    /// </summary>
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            PointLabel = charPoint => string.Format("{0}({1:P})", charPoint.Y, charPoint.Participation);
            DataContext = this;
            Console.Write("sdasd");
            getDataEstablecimiento();
        }


        //VARIABLES
        CRegistro establecimiento = new CRegistro();
        Registro attEstablecimiento = new Registro();
        bool edit = false;

        public void getDataEstablecimiento()
        {
            CRegistro cEstablecimiento = new CRegistro();
            DataTable dataTable = cEstablecimiento.Mostrar();

            // Convierte el DataTable a una lista de Registro
            List<Registro> establecimientos = new List<Registro>();
            foreach (DataRow row in dataTable.Rows)
            {
                Registro establecimiento = new Registro
                {
                    // Asigna los valores de las columnas a las propiedades de Registro
                    // Por ejemplo: Propiedad1 = (tipo) row["NombreColumna"];
                };
                establecimientos.Add(establecimiento);
            }
            // Asigna la lista de registros como ItemsSource del DataGrid
            EstablecimientoData.ItemsSource = establecimientos;
        }


        public Func<ChartPoint, string> PointLabel { get; set; }
        private void PieChart_DataClick(object sender, LiveCharts.ChartPoint chartPoint) { 
        
        }

        private void PieSeries_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
