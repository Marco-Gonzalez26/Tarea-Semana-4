using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Primera_Vez.Models
{
    public class dto_Personal
    {
        public int? idPersonal { get; set; }
        public string nombre { get; set; }
        public decimal sueldo { get; set; }
        public int? idPais { get; set; }
        public string cargo { get; set; }
        public string cedula { get; set; }

        public string? detalle { get; set; }
    }
}
