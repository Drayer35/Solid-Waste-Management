using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

using System.Configuration;


using System.Data;
using System.Data.SqlClient;
namespace DataAccess.Connection
{
    public class ConnectGestionDB
    {
        private string connectionString;
        public ConnectGestionDB() {
            connectionString = "Server=LAPTOP-N7AE4C24;DataBase=GestionResiduos; integrated security= true";
        }
        protected SqlConnection GetConnection() { 
            return new SqlConnection(connectionString);
        }
        protected DataClasses1DataContext GetDataContext()
        {
            return new DataClasses1DataContext(connectionString);
        }
    }
}



