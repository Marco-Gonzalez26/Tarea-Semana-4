using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using _01_Primera_Vez.Models;
namespace _01_Primera_Vez.Controllers
{
    public class cls_Personal
    {
        private readonly Conexion cn = new Conexion();

        public string Insertar(dto_Personal personal)
        {

            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "INSERT INTO Personales( nombre, cedula, idPais, sueldo, cargo) VALUES" +
                    "("
                      +"'"+ personal.nombre + "'" + ",'" + personal.cedula + "'," + personal.idPais
                     + ",'" + personal.sueldo + "'," + "'" + personal.cargo + "'"
                     +
                     ")";
               
                using (var comando = new SqlCommand(cadena, conexion)) {
                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        return "Status: OK - Datos insertados correctamente";
                    }
                    catch (Exception e){
                        return "Status: ERROR - " + e.Message;

                    }

                }

            }
        }

        public List<dto_Personal> getAll()
        {   
            var listaPersonal = new List<dto_Personal>();
            // 1 - Llamar a la conexion con la base de datos
            using (var conexion = cn.obtenerConexion())
            {
                // 2 -  Crear sentencia sql
                string cadena = "SELECT idPersonal, nombre, sueldo, cargo, cedula, Paises.detalle FROM Personales " +
                    "INNER JOIN Paises ON Paises.idPais = Personales.idPais;";
                // 3 - Ejecutar comando
                using (var comando = new SqlCommand(cadena, conexion))
                {
                   // 4 - Abrir conexión
                    conexion.Open();
                    // 5 Cargar el lector con la informacion
                    using (var lector = comando.ExecuteReader())
                    {
                        // 6 - Recorrer el lector para obtener la informacion
                        while (lector.Read()) 
                        {
                            // 7 - Crear un dto_Personal para asignar lo que trae de la bd
                            var personal = new dto_Personal
                            {
                                idPersonal = (int)lector["idPersonal"],
                                nombre = lector["nombre"].ToString(),
                                cargo = lector["cargo"].ToString(),
                                cedula = lector["cedula"].ToString(),
                                sueldo = (decimal)lector["sueldo"],
                                detalle = lector["detalle"].ToString()
                            };
                            // 8 - Añadir a la lista personal
                            listaPersonal.Add(personal);
                        }
                    }
                }

            }
            return listaPersonal;
        }
    }
}
