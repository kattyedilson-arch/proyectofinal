using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado.Models
{
    public class Venta
    {
        public int VentaID { get; set; }
        public DateTime Fecha { get; set; }
        public string? Cliente { get; set; }
        public string? Empleado { get; set; }
        public decimal Total { get; set; }
    }
}
