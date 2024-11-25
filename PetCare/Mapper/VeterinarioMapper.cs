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
            Veterinario veterinario = new Veterinario
            {
                ID = Convert.ToInt32(reader["ID"].ToString()), // Columna 0: ID
                Nombre = reader["nombre"].ToString(), // Columna 1: Nombre
                Especialidad = reader["especialidad"].ToString(), // Columna 2: Especialidad
                HorarioTrabajo = reader["horario_trabajo"].ToString(), // Columna 3: Horario de Trabajo
            };
            return veterinario;
        }
    }
}
