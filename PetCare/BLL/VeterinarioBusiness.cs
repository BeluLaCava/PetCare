﻿using DAL;
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
        private VeterinarioData veterinarioData = new VeterinarioData();

        public void GuardarVeterinario(Veterinario veterinario)
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

                    veterinarioData.GuardarVeterinario(veterinario);
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
                        GuardarVeterinario(veterinarios);
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
                return veterinarioData.ObtenerVeterinario();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void ModificarVeterinario(Veterinario veterinarios)
        {
            try
            {
                Veterinario veterinario = veterinarioData.GetById(veterinarios.ID);
                using (TransactionScope trx = new TransactionScope())
                {
                  
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
                    veterinarioData.ModificarVeterinario(veterinarios);

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
                Veterinario veterinario = veterinarioData.GetById(id);
                using (TransactionScope trx = new TransactionScope())
                {
                   
                    if (veterinario == null)
                    {
                        throw new Exception("El Veterinario no existe");
                    }
                    veterinarioData.EliminarVeterinario(id);
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
