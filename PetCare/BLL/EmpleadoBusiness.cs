using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmpleadoBusiness
    {
        
        private EmpleadoData empleadoData = new EmpleadoData();
        public Empleado LoginEmpleado(string email, string password)
        {
            try
            {
                Empleado empleado = empleadoData.ObtenerEmpleadoPorEmail(email);

                if (empleado != null && empleado.Pass == password)
                {
                    return empleado;
                }
                return null;
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }
        
    }
}
