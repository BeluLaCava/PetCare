using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class CitaBusiness
    {
        private CitaData citaData = new CitaData();

        public void GuardarCita(Cita cita)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    Validacion(cita);

                    citaData.GuardarCita(cita);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private static void Validacion(Cita cita)
        {
            if (cita.MascotaID == null)
            {
                throw new Exception("Ingrese una mascota para atender");
            }

            if (cita.VeterinarioID == null)
            {
                throw new Exception("Ingrese un veterinario para atender a su mascota");
            }
            if (cita.Fecha <= DateTime.Today)
            {
                throw new Exception("La fecha ingresada no es valida");
            }


            TimeSpan horaApertura = new TimeSpan(7, 0, 0);
            TimeSpan horaCierre = new TimeSpan(19, 0, 0);


            if (cita.Hora < horaApertura || cita.Hora > horaCierre)
            {
                throw new Exception("\"La hora ingresada no es válida. Debe estar entre 07:00 y 19:00.");
            }
        }

        public List<Cita> ObtenerCitas()
        {
            try
            {
               return citaData.ObtenerCita();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void ModificarCita(Cita cita)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    Validacion(cita);
                    citaData.ModificarCita(cita);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void EliminarCita(int idEliminar)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    citaData.EliminarCita(idEliminar);
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
