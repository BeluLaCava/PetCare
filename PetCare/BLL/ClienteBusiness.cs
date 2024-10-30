using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{

    public class ClienteBusiness
    {
        private ClienteData clienteData = new ClienteData();

        public void GuardarCliente(Cliente cliente)
        {
            try
            {
                using (var trx = new TransactionScope())
                {


                    if (string.IsNullOrEmpty(cliente.Nombre))
                    {
                        throw new Exception("Complete el nombre y apellido del cliente");
                    }

                    if (string.IsNullOrEmpty(cliente.Direccion))
                    {
                        throw new Exception("Complete la direccion");
                    }
                    if (string.IsNullOrEmpty(cliente.Telefono) || !EsTelefonoValido(cliente.Telefono))
                    {
                        throw new Exception($"El telefono de {cliente.Nombre} debe ser numerico y minimo 8 numeros");
                    }

                    if (string.IsNullOrEmpty(cliente.Email) || !EsEmailValido(cliente.Email))
                    {
                        throw new Exception("Ingrese un email válido (ejemplo@ejemplo.com)");
                    }

                    clienteData.GuardarCliente(cliente);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public void GuardarClientes(List<Cliente> cliente)
        {
            try
            {
                using (var trx = new TransactionScope())
                {


                    foreach (Cliente clientes in cliente)
                    {
                        GuardarCliente(clientes);
                    }
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private bool EsTelefonoValido(string telefono)
        {
            return Regex.IsMatch(telefono, @"^\d{10,}$");
        }

        
        private bool EsEmailValido(string email)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patron);
        }

        public List<Cliente> ObtenerCliente()
        {
            try
            {
                return clienteData.ObtenerCliente();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void ModificarCliente(int idSeleccionado, string direccion, string email, string telefono)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    if (string.IsNullOrEmpty(direccion))
                    {
                        throw new Exception("Complete la direccion");
                    }
                    if (string.IsNullOrEmpty(telefono) || !EsTelefonoValido(telefono))
                    {
                        throw new Exception("El telefono debe ser numerico y minimo 8 numeros");
                    }

                    if (string.IsNullOrEmpty(email) || !EsEmailValido(email))
                    {
                        throw new Exception("Ingrese un email válido (ejemplo@ejemplo.com)");
                    }
                    clienteData.ModificarCliente(idSeleccionado, direccion, email, telefono);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void EliminarCliente(int idcliente)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    clienteData.EliminarCliente(idcliente);
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
