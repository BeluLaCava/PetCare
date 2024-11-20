using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class VeterinarioMapper
    {
        public static Veterinario Map(SqlDataReader reader)
        {
            Veterinario veterinario = new Veterinario();
            {
                veterinario.ID = reader.GetInt32(0); // Columna 0: ID
                veterinario.Nombre = reader.GetString(1); // Columna 1: Nombre
                veterinario.Especialidad = reader.GetString(2); // Columna 2: Especialidad
                veterinario.HorarioTrabajo = reader.GetString(3); // Columna 3: Horario de Trabajo
            }
            return veterinario;
        }
    }
}
