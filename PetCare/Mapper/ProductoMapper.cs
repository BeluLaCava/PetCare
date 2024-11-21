using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class ProductoMapper
    {
        public static Producto Map(SqlDataReader reader)
        {        
            Producto prod = new Producto();
            {
                prod.Nombre = reader.GetString(0);
                prod.Descripcion = reader.GetString(1);
                prod.Precio = reader.GetDecimal(2);
                prod.Stock = reader.GetInt32(3);
                prod.ID = reader.GetInt32(4);

            }

            return prod;
        }
    }
}
