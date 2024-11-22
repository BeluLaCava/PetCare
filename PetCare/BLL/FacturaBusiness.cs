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
    public class FacturaBusiness
    {

        private FacturaData facturaData = new FacturaData();

        public List<Factura> obtenerFacturas()
        {
            return facturaData.ObtenerFacturas();
        }
        public void agregarFactura(Factura fac)
        {
            try
            {

                if (fac == null) throw new ArgumentNullException("La factura no puede ser nula.");
                if (fac.Cantidad <= 0) throw new ArgumentException("La cantidad debe ser mayor a cero.");
                if (fac.Producto == null || fac.Producto.ID <= 0)
                    throw new ArgumentException("El producto es inválido o no está seleccionado.");
                if (fac.Cliente == null || fac.Cliente.ID <= 0)
                    throw new ArgumentException("El cliente es inválido o no está seleccionado.");
                if (fac.Fecha != DateTime.Today)
                    throw new ArgumentException("La fecha de la factura no es válida.");

                using (TransactionScope t = new TransactionScope())
                {
                    facturaData.GuardarFactura(fac);
                    t.Complete();
                }
            }
            catch(Exception ex) { throw; }
        }

        public void modificarFactura(Factura fac)
        {

            try
            {
                Factura fact = facturaData.ObtenerPorId(fac.ID);
                if(fact == null) throw new ArgumentException("No existe la factura seleccionada por Id.");
                if (fac == null) throw new ArgumentNullException("La factura no puede ser nula.");
                if (fac.Cantidad <= 0) throw new ArgumentException("La cantidad debe ser mayor a cero.");
                if (fac.Producto == null || fac.Producto.ID <= 0)
                    throw new ArgumentException("El producto es inválido o no está seleccionado.");
                if (fac.Cliente == null || fac.Cliente.ID <= 0)
                    throw new ArgumentException("El cliente es inválido o no está seleccionado.");                
                using (TransactionScope t = new TransactionScope())
                {
                    facturaData.ModificarFactura(fac);
                    t.Complete();
                }
            }
            catch (Exception ex) { throw; }            
        }
        public void eliminarFactura(int id)
        {
            try
            {
                Factura fac = facturaData.ObtenerPorId(id);
                if (fac == null)
                {
                    throw new Exception("No existe la factura seleccionado por Id");
                }
                using (TransactionScope t = new TransactionScope())
                {
                    facturaData.EliminarFactura(id);
                    t.Complete();
                }
            }
            catch (Exception ex) { throw; }
        }


    }
}
