﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Connection
{
    public abstract class ConnectUserDB
    {
        private  string connectionString;
        public ConnectUserDB() { 
            connectionString= "Server=LAPTOP-N7AE4C24;DataBase=LoginDB; integrated security= true";
        }

        protected SqlConnection GetConnection() {
            return new SqlConnection(connectionString);
        }

    }
}
