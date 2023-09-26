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
using System.Configuration;
using LiveCharts;
using LiveCharts.Wpf;
using System.Data.SqlClient;
using Domain.Model;

namespace Presentation.View
{
    public partial class Dashboard : UserControl
    {
        SqlConnection miConexionSql;
        public Dashboard()
        {
            InitializeComponent();
            string miconexion = ConfigurationManager.ConnectionStrings["Presentation.Properties.Settings.GestionResiduosConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miconexion);
            ListarEstablecimientos();
            //ListarFechas();

            
        }

        public void ListarEstablecimientos() {
            string consulta = "SELECT * FROM ESTABLECIMIENTO";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta,miConexionSql);
            using (adapter) { 
                DataTable DataEstablecimientos = new DataTable();
                adapter.Fill(DataEstablecimientos);
                ListaEstablecimientos.DisplayMemberPath= "NOMBRE";
                ListaEstablecimientos.SelectedValuePath = "ID";
                ListaEstablecimientos.ItemsSource = DataEstablecimientos.DefaultView;
            }
        }
        public void RefreshEstablecimientos(object sender, EventArgs e) {
            ListarEstablecimientos();
        }
        private void ListarFechas() {

            string consulta = "SELECT * FROM FECHA";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, miConexionSql);
            using (adapter)
            {
                DataTable DataFecha= new DataTable();
                adapter.Fill(DataFecha);
                FechaData.DisplayMemberPath = "MES";
                FechaData.ItemsSource = DataFecha.DefaultView;
            }
        }

        private void Establecimiento(object sender, RoutedEventArgs e)
        {
            WindowEstablecimiento windowEstablecimiento = new WindowEstablecimiento();
            windowEstablecimiento.RefreshListEstablecimientos += RefreshEstablecimientos;
            windowEstablecimiento.ShowDialog();
        }
        private void OpenWindowResiduos(object sender, RoutedEventArgs e)
        {
            WindowResiduos windowResiduos = new WindowResiduos();
            windowResiduos.ShowDialog();
        }


    }
}
