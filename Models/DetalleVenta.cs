using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado.Models
{
 
    
        public class DetalleVenta
        {
            public int DetalleID { get; set; }  
            public int VentaID { get; set; }
            public int ProductoID { get; set; }
            public int Cantidad { get; set; }
            public decimal PrecioUnitario { get; set; }
/*
            public string Cliente { get; set; }
            public string ClienteGmail { get; set; }
*/
        }
}


