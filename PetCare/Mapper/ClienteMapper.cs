using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class ClienteMapper
    {
        public static Cliente Map(SqlDataReader reader)
        {
            Cliente cliente = new Cliente();
            {
                cliente.ID = reader.GetInt32(0);
                cliente.Nombre = reader.GetString(1);
                cliente.Direccion = reader.GetString(2);
                cliente.Telefono = reader.GetString(3);
                cliente.Email = reader.GetString(4);
            }
            return cliente;
        }
    }
}
