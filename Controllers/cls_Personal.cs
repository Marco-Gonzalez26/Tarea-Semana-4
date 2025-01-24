using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using _01_Primera_Vez.Models;
using _01_Primera_Vez.Views;
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

        public dto_Personal getOne(string id, bool isId) {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"SELECT * FROM Personales WHERE cedula = '{id}'";
                if (isId) {
                    cadena = $"SELECT * FROM Personales WHERE idPersonal = '{id}'";
                }
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
             
                    using (var lector = comando.ExecuteReader())
                    {
                        dto_Personal personal = new dto_Personal();
                        if (lector.Read())
                        {

                        personal = new dto_Personal
                        {
                            idPersonal = Convert.ToInt32(lector["idPersonal"]),
                            nombre = lector["nombre"].ToString(),
                            cargo = lector["cargo"].ToString(),
                            cedula = lector["cedula"].ToString(),
                            sueldo = (decimal)lector["sueldo"],
                            idPais = (int)lector["idPais"]
                        };

                        }

                    return personal;
                    }

                }
            }
        }

        public bool isCIDuplicated(string cedula) {

            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"SELECT count(*) AS repetidos FROM Personales WHERE cedula='{cedula}'";

                using (var comando = new SqlCommand(cadena, conexion) )
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        lector.Read();
                        if ((int)lector["repetidos"] > 0) { return true; }
                        else { return false; }
                    }
                }
            }
        }
        public string updateOne(dto_Personal personal) {

            using (var conexion = cn.obtenerConexion())
            {
                var cadena = $"UPDATE Personal SET cargo='{personal.cargo}', cedula='{personal.cedula}', idPais={personal.idPais}, nombre='{personal.nombre}', sueldo={personal.sueldo} WHERE idPersonal = {personal.idPersonal}";

                using (var comando  = new SqlCommand(cadena, conexion))
                {

                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        return "ok";
                    }
                    catch (Exception e)
                    {

                        return e.Message;
                    }
                }
            }

        }

        public bool deleteOne(int id) {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"DELETE FROM Personales WHERE idPersonal = {id}";

                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    try
                    {
                        comando.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception)
                    {

                        return false;
                    }
                }
            }
        }

        public List<dto_Personal> search(string texto)
        {
            var listaPersonal = new List<dto_Personal>();
            // 1 - Llamar a la conexion con la base de datos
            using (var conexion = cn.obtenerConexion())
            {
                // 2 -  Crear sentencia sql
                string cadena = $"SELECT idPersonal, nombre, sueldo, cargo, cedula, Paises.detalle FROM Personales INNER JOIN Paises ON Paises.idPais = Personales.idPais WHERE nombre like '%{texto}%';";
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
