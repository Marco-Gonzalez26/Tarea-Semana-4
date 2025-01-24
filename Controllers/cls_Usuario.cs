using _01_Primera_Vez.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Primera_Vez.Controllers
{
    internal class cls_Usuario
    {
        private readonly Conexion cn = new Conexion();

        public string Insertar(dto_Usuario usuario)
        {

            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"INSERT INTO Usuarios( nombre, nombre_usuario, correo) VALUES('" +
                    $"{usuario.nombre}', '{usuario.nombre_usuario}', '{usuario.correo}');";
                    

                using (var comando = new SqlCommand(cadena, conexion))
                {
                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        return "Status: OK - Datos insertados correctamente";
                    }
                    catch (Exception e)
                    {
                        return "Status: ERROR - " + e.Message;

                    }

                }

            }
        }

        public List<dto_Usuario> getAll()
        {
            var listaUsuarios = new List<dto_Usuario>();
            // 1 - Llamar a la conexion con la base de datos
            using (var conexion = cn.obtenerConexion())
            {
                // 2 -  Crear sentencia sql
                string cadena = "SELECT * FROM Usuarios;";
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
                            var usuario = new dto_Usuario
                            {
                                idUsuario = (int)lector["idUsuario"],
                                nombre = lector["nombre"].ToString(),
                                correo = lector["correo"].ToString(),
                                nombre_usuario = lector["nombre_usuario"].ToString()
                                
                            };
                            // 8 - Añadir a la lista personal
                            listaUsuarios.Add(usuario);
                        }
                    }
                }

            }
            return listaUsuarios;
        }

        public dto_Usuario getOne(int id )
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"SELECT * FROM Usuarios WHERE idUsuario = {id}";

                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();

                    using (var lector = comando.ExecuteReader())
                    {
                        dto_Usuario usuario = new dto_Usuario();
                        if (lector.Read())
                        {

                            usuario = new dto_Usuario
                            {
                                idUsuario = (int)lector["idUsuario"],
                                nombre = lector["nombre"].ToString(),
                                correo = lector["correo"].ToString(),
                                nombre_usuario = lector["nombre_usuario"].ToString()

                            };

                        }

                        return usuario;
                    }

                }
            }
        }

        public bool isCIEmail(string email)
        {

            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"SELECT count(*) AS repetidos FROM Usuarios WHERE correo='{email}'";

                using (var comando = new SqlCommand(cadena, conexion))
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
        public string updateOne(dto_Usuario usuario)
        {

            using (var conexion = cn.obtenerConexion())
            {
                var cadena = $"UPDATE Usuarios SET nombre='{usuario.nombre}', " +
                    $"correo='{usuario.correo}', " +
                    $"nombre_usuario='{usuario.nombre_usuario}'" +
                    $" WHERE idUsuario = {usuario.idUsuario};";

                using (var comando = new SqlCommand(cadena, conexion))
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

        public bool deleteOne(int id)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"DELETE FROM Usuarios WHERE idUsuario = {id}";

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

        public List<dto_Usuario> search(string texto)
        {
            var usersList = new List<dto_Usuario>();
            // 1 - Llamar a la conexion con la base de datos
            using (var conexion = cn.obtenerConexion())
            {
                // 2 -  Crear sentencia sql
                string cadena = $"SELECT idUsuario, nombre, nombre_usuario, correo  FROM Usuarios WHERE nombre like '%{texto}%';";
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
                            var user = new dto_Usuario
                            {
                                idUsuario = (int)lector["idUsuario"],
                                nombre = lector["nombre"].ToString(),
                                correo = lector["correo"].ToString(),
                                nombre_usuario = lector["nombre_usuario"].ToString()
                               
                            };
                            // 8 - Añadir a la lista personal
                            usersList.Add(user);
                        }
                    }
                }

            }
            return usersList;
        }
    }
}
