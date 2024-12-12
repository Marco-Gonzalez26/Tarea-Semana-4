using _01_Primera_Vez.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Primera_Vez.Controllers;
using System.Data.SqlClient;

namespace _01_Primera_Vez.Controllers
{
    internal class cls_Pais
    {
        private readonly Conexion cn = new Conexion();
        public List<dto_Pais> Obtener()
        {
            var paises = new List<dto_Pais>();
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "SELECT * FROM paises";

                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read()) {

                            paises.Add(new dto_Pais()
                            {
                                idPais = Convert.ToInt32(lector["idPais"]),
                                detalle = lector["detalle"].ToString()
                            }); 

                        }
                    }
                }
            }

            return paises;
        }
    }
}
