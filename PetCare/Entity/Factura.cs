using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Factura
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public Cliente Cliente { get; set; }

        public Producto Producto { get; set; }

        public int Cantidad { get; set; }
    }

}
