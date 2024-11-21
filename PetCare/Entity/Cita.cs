using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cita
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Veteriarios { get => VeterinarioID.Nombre; }
        public string Mascotas { get => MascotaID.Nombre; }
        public Veterinario VeterinarioID { get; set; }
        public Mascota MascotaID { get; set; }
    }
}
