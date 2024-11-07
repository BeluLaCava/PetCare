using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class MascotaMapper
    {
      public static Mascota Map(SqlDataReader reader)
      {
         Mascota mascota = new Mascota();
         {
            mascota.ID = reader.GetInt32(0);
            mascota.Nombre = reader.GetString(1);
            mascota.Especie = reader.GetString(2);
            mascota.Raza = reader.GetString(3);
            mascota.FechaNacimiento = reader.GetDateTime(4);
            mascota.ClienteID = reader.GetInt32(5);
         };

         return mascota;
      }

   }
}
