using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranBodega.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string Nombre { get; set; }
        public string UsuarioLogin { get; set; }
        public string Clave { get; set; }
        public int RolID { get; set; }
    }
}
