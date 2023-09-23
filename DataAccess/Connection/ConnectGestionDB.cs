using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess.Connection
{
    public class ConnectGestionDB
    {
        private string connectionString;
        public ConnectGestionDB() {
            connectionString = "Server=DESKTOP-MFTECGS;DataBase=GestionResiduos; integrated security= true";
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

