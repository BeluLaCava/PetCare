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
            ID = reader.GetInt32(reader.GetOrdinal("ID")),
            Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
            Especie = reader.GetString(reader.GetOrdinal("Especie")),
            Raza = reader.GetString(reader.GetOrdinal("Raza")),
            FechaNacimiento = reader.IsDBNull(reader.GetOrdinal("FechaNacimiento")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("FechaNacimiento")),
            Cliente = cliente

         };
         return mascota;
      }

   }
}
