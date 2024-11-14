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
      private MascotaData mascotaData;

      public MascotaBusiness()
      {
         mascotaData = new MascotaData();
      }
      public void GuardarMascota(Mascota mascota)
      {
         try
         {
            mascotaData.GuardarMascota(mascota);
         }
         catch (Exception ex)
         {
            throw new Exception("Error al guardar la mascota: " + ex.Message);
         }
      }
      public List<Mascota> ObtenerMascotas()
      {
         try
         {
            return mascotaData.ObtenerMascotas();
         }
         catch (Exception ex)
         {
            throw new Exception("Error al obtener las mascotas: " + ex.Message);
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
            throw new Exception("Error al obtener la mascota: " + ex.Message);
         }
      }

      public void ModificarMascota(Mascota mascota)
      {
         try
         {
            mascotaData.ModificarMascota(mascota);
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
            mascotaData.EliminarMascota(id);
         }
         catch (Exception ex)
         {
            throw new Exception("Error al eliminar la mascota: " + ex.Message);
         }
      }

   }
}
