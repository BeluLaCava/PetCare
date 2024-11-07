using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class MascotaBusiness
    {
      private MascotaData mascotaData = new MascotaData();

      public void AgregarMascota(Mascota mascota)
      {
         try
         {
            using (TransactionScope trx = new TransactionScope())
            {
               if (string.IsNullOrEmpty(mascota.Nombre))
               {
                  throw new Exception("El nombre de la mascota es obligatorio.");
               }

               if (string.IsNullOrEmpty(mascota.Especie))
               {
                  throw new Exception("La especie de la mascota es obligatoria.");
               }

               if (string.IsNullOrEmpty(mascota.Raza))
               {
                  throw new Exception("La raza de la mascota es obligatoria.");
               }

               mascotaData.AgregarMascota(mascota);
               trx.Complete();
            }
         }
         catch (Exception ex)
         {
            throw new Exception("Error al guardar la mascota: " + ex.Message);
         }
      }

      public void ActualizarMascota(int ID, string nombre, string especie, string raza, DateTime? fecha_nacimiento, int cliente_id)
      {
         try
         {
            using (TransactionScope trx = new TransactionScope())
            {
               Mascota mascota = mascotaData.ObtenerMascotaPorID(ID);
               if (mascota == null)
               {
                  throw new Exception("La mascota no existe.");
               }

               if (string.IsNullOrEmpty(nombre))
               {
                  throw new Exception("El nombre de la mascota es obligatorio.");
               }

               if (string.IsNullOrEmpty(especie))
               {
                  throw new Exception("La especie de la mascota es obligatoria.");
               }

               if (string.IsNullOrEmpty(raza))
               {
                  throw new Exception("La raza de la mascota es obligatoria.");
               }

               mascota.Nombre = nombre;
               mascota.Especie = especie;
               mascota.Raza = raza;
               mascota.FechaNacimiento = fecha_nacimiento;
               mascota.ClienteID = cliente_id;

               mascotaData.ActualizarMascota(mascota);
               trx.Complete();
            }
         }
         catch (Exception ex)
         {
            throw new Exception("Error al modificar la mascota: " + ex.Message);
         }
      }

      public void EliminarMascota(int id)
      {
         try
         {
            using (TransactionScope trx = new TransactionScope())
            {
               Mascota mascota = mascotaData.ObtenerMascotaPorID(id);
               if (mascota == null)
               {
                  throw new Exception("La mascota no existe.");
               }

               mascotaData.EliminarMascota(id);
               trx.Complete();
            }
         }
         catch (Exception ex)
         {
            throw new Exception("Error al eliminar la mascota: " + ex.Message);
         }
      }

      public List<Mascota> ObtenerMascotas()
      {
         try
         {
            return mascotaData.ObtenerTodasLasMascotas();
         }
         catch (Exception ex)
         {
            throw new Exception("Error al obtener la lista de mascotas: " + ex.Message);
         }
      }

   }
}
