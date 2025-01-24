using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Primera_Vez.Models
{
    class dto_asistencia
    {
        public int? IdAsistecia { get; set; }
        public int IdPersonal { get; set; }
        public string Cedula { get; set; }
        public DateTime? fecharegsitro { get; set; }
    }
}