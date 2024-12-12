using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _01_Primera_Vez.Models
{
    public class Conexion
    {
        private readonly string conexionString =
            "Server=LAPTOP-L6SUJ856\\ALWAYSDEV;Database=POOII;uid=root;pwd=123456;TrustServerCertificate=True";

        public SqlConnection obtenerConexion() { 

            return new SqlConnection(conexionString);
        }
    }
}
