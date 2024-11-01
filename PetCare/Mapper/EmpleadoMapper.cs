using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class EmpleadoMapper
    {
        public static Empleado Map(SqlDataReader reader)
        {
            Empleado empleado = new Empleado();
            {

                empleado.ID = reader.GetInt32(0);
                empleado.Apellido = reader.GetString(1);
                empleado.Nombre = reader.GetString(2);
                empleado.DNI = reader.GetString(3);
                empleado.Email = reader.GetString(4);
                empleado.Pass = reader.GetString(5); // Contraseña sin encriptar
            };
            return empleado;
        }
    }
}
