using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class ProductoMapper
    {
        public static Producto Map(SqlDataReader reader)
        {        
            Producto producto = new Producto();
            {
                producto.ID = reader.GetInt32(0);
                producto.Nombre = reader.GetString(1);
                producto.Descripcion = reader.GetString(2);
                producto.Precio = reader.GetDecimal(3);
                producto.Stock = reader.GetInt32(4);
            }
            return producto;
        }
    }
}
