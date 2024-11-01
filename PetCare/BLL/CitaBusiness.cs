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
        private CitaData citadata = new CitaData();

        public void GuardarCita(Cita cita)
        {
            try
            {
                using (var trx = new TransactionScope())
                {


                    if (cita.MascotaID <= 0)
                    {
                        throw new Exception("Ingrese una mascota para atender");
                    }

                    if (cita.VeterinarioID <= 0)
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

                    citadata.GuardarCita(cita);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }
       
        public void ModificarCliente(int id, DateTime fecha, TimeSpan hora, int veterinarioid, int mascotaid)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    if (mascotaid <= 0)
                    {
                        throw new Exception("Ingrese una mascota para atender");
                    }

                    if (veterinarioid <= 0)
                    {
                        throw new Exception("Ingrese un veterinario para atender a su mascota");
                    }
                    if (fecha <= DateTime.Today)
                    {
                        throw new Exception("La fecha ingresada no es valida");
                    }


                    TimeSpan horaApertura = new TimeSpan(7, 0, 0);
                    TimeSpan horaCierre = new TimeSpan(19, 0, 0);


                    if (hora < horaApertura || hora > horaCierre)
                    {
                        throw new Exception("\"La hora ingresada no es válida. Debe estar entre 07:00 y 19:00.");
                    }
                    citadata.ModificarCita(id, fecha, hora, veterinarioid, mascotaid);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void EliminarCliente(int idcita)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    citadata.EliminarCita(idcita);
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
