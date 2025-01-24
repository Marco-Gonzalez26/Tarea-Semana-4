using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Primera_Vez.Models
{
    internal class dto_Usuario
    {
        public int idUsuario { get; set; }
        public string? nombre { get; set; }
        public string? nombre_usuario { get; set; }
        public string? correo { get; set; }
    }
}
