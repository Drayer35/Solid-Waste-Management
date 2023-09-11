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
        ConnectDB connDb = new ConnectDB();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter;
        DataTable td=new DataTable();

    }
}
