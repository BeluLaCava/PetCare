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
    public class VeterinarioBusiness
    {
        private VeterinarioData veterinarioDAL = new VeterinarioData();

        public void Guardar(Veterinario veterinario)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())

                {

                    if (string.IsNullOrEmpty(veterinario.Nombre))
                        throw new Exception("El nombre no puede estar vacío.");
                    if (string.IsNullOrEmpty(veterinario.Especialidad))
                        throw new Exception("La especialidad no puede estar vacía.");
                    if (string.IsNullOrEmpty(veterinario.HorarioTrabajo))
                        throw new Exception("El horario de trabajo no puede estar vacío.");

                    veterinarioDAL.GuardarVeterinario(veterinario);
                    trx.Complete();
                }
            }

            catch (Exception ex)
            {

                throw;
            }
        }

        public void GuardarVeterinarios(List<Veterinario> veterinario)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {


                    foreach (Veterinario veterinarios in veterinario)
                    {
                        Guardar(veterinarios);
                    }
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

     

        public List<Veterinario> ObtenerVeterinario()
        {
            try
            {
                return VeterinarioData.ObtenerVeterinario();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void ModificarVeterinario(int id, string nombre, string especialidad, string horariodetrabajo)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    Veterinario veterinario = veterinarioDAL.GetById(id);
                    if (veterinario == null)
                    {
                        throw new Exception("El veterinario no existe");
                    }
                    if (string.IsNullOrEmpty(veterinario.Nombre))
                    {
                        throw new Exception("El nombre no puede estar vacío.");
                    }
                    if (string.IsNullOrEmpty(veterinario.Especialidad))
                    {
                        throw new Exception("La especialidad no puede estar vacía.");
                    }
                    if (string.IsNullOrEmpty(veterinario.HorarioTrabajo))
                    {
                        throw new Exception("El horario de trabajo no puede estar vacío.");
                    }
                    veterinario.Nombre = nombre;
                    veterinario.Especialidad = especialidad;
                    veterinario.HorarioTrabajo = horariodetrabajo;

                    trx.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void EliminarVeterinario(int id)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    Veterinario veterinario = veterinarioDAL.GetById(id);
                    if (veterinario == null)
                    {
                        throw new Exception("El Veterinario no existe");
                    }
                    veterinarioDAL.EliminarVeterinario(id);
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
