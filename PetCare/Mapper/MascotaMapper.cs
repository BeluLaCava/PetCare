using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public static class MascotaMapper
    {
        public static Mascota Map(SqlDataReader reader, Cliente cliente)
        {
            Mascota mascota = new Mascota
            {
                ID = Convert.ToInt32(reader["ID"]),
                Nombre = reader["nombre"].ToString(),
                Especie = reader["especie"].ToString(),
                Raza = reader["raza"].ToString(),
                FechaNacimiento = Convert.ToDateTime(reader["fecha_nacimiento"]).Date,
                ClienteId = cliente
            };
                return mascota;
            

        }
    }
}
