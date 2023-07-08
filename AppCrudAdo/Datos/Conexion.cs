using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace AppCrudAdo.Datos
{
    public class Conexion
    {
        private string CadenaSQL = string.Empty;

        public Conexion()
        {
            string buider = "CadenaSQL";
            CadenaSQL = ConfigurationManager.ConnectionStrings[buider].ConnectionString;
        }

        public string getCadenaSQL()
        {
            return CadenaSQL;
        }
    }
}