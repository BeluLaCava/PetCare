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

      public List<Mascota> ObtenerMascotas()
      {
         try
         {
            return mascotaData.ObtenerMascotas();
         }
         catch (Exception ex)
         {
            throw;
         }
      }

      public void GuardarMascota(Mascota mascota)
      {
         try
         {
            using (TransactionScope trx = new TransactionScope())
            {
               if (string.IsNullOrEmpty(mascota.Nombre))
               {
                  throw new Exception("El nombre de la mascota no puede estar vacío.");
               }

               if (string.IsNullOrEmpty(mascota.Especie))
               {
                  throw new Exception("La especie de la mascota no puede estar vacía.");
               }


               mascotaData.GuardarMascota(mascota);
               trx.Complete();
            }
         }
         catch (Exception ex)
         {
            throw;
         }
      }

      public Mascota GetById(int id)
      {
         try
         {
            return mascotaData.GetById(id);
         }
         catch (Exception ex)
         {
            throw;
         }
      }

      public void ModificarMascota(int idMascota, Mascota nuevaMascota)
      {
         try
         {
            using (TransactionScope trx = new TransactionScope())
            {
               Mascota mascotaExistente = mascotaData.GetById(idMascota);
               if (mascotaExistente == null)
               {
                  throw new Exception("Mascota inexistente.");
               }
               mascotaExistente.Nombre = nuevaMascota.Nombre;
               mascotaExistente.Especie = nuevaMascota.Especie;
               mascotaExistente.Raza = nuevaMascota.Raza;
               mascotaExistente.FechaNacimiento = nuevaMascota.FechaNacimiento;

               mascotaData.ModificarMascota(mascotaExistente);
               trx.Complete();
            }
         }
         catch (Exception ex)
         {
            throw;
         }
      }

      public void EliminarMascota(int idMascota)
      {
         try
         {
            using (TransactionScope trx = new TransactionScope())
            {
               Mascota mascota = mascotaData.GetById(idMascota);
               if (mascota == null)
               {
                  throw new Exception("Mascota inexistente.");
               }

               mascotaData.EliminarMascota(idMascota);
               trx.Complete();
            }
         }
         catch (Exception ex)
         {
            throw;
         }
      }

      public void GuardarMascotasMultiples(List<Mascota> mascotas)
      {
         try
         {
            using (TransactionScope trx = new TransactionScope())
            {
               foreach (var mascota in mascotas)
               {
                  GuardarMascota(mascota);
               }
               trx.Complete();
            }
         }
         catch (Exception ex)
         {
            throw;
         }
      }
   }
}
