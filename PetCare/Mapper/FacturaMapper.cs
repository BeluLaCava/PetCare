using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class FacturaMapper
    {
        public static Factura Map(SqlDataReader reader,Producto prod, Cliente cli)
        {
            Factura factura = new Factura();
            {
                factura.Fecha = reader.GetDateTime(0);
                factura.Total = reader.GetDecimal(1);
                factura.Cliente = cli;
                //factura.Cliente.ID = reader.GetInt32(2);
                factura.Producto = prod;
                //factura.Producto.ID = reader.GetInt32(3);
                factura.Cantidad = reader.GetInt32(4);
                factura.ID = reader.GetInt32(5);

            }
            return factura;
        }
    }
       
}
