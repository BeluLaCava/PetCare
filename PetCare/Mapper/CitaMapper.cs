using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class CitaMapper
    {
        public static Cita Map(SqlDataReader reader, Mascota mascota, Veterinario veterinario)
        {
            Cita cita = new Cita
            {
                ID = Convert.ToInt32(reader["ID"].ToString()),
                Fecha = Convert.ToDateTime(reader["fecha"].ToString()),
                Hora = TimeSpan.Parse(reader["hora"].ToString()),
                MascotaID = mascota,
                VeterinarioID = veterinario
            };
            return cita;

        }
    }
}
