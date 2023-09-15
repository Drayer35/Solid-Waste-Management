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
            MuestraTodosPedidos();                                    
        }

        private void MuestraTodosPedidos() {
            string consulta = "SELECT * FROM ESTABLECIMIENTO";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta,miConexionSql);
            using (adapter) { 
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                todosPedidos.DisplayMemberPath= "NOMBRE";
                todosPedidos.SelectedValuePath = "ID";
                todosPedidos.ItemsSource = dataTable.DefaultView;
            }
        }
        
    }
}
