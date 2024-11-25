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
                using (TransactionScope trx = new TransactionScope())
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
                using (TransactionScope trx = new TransactionScope())
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
        public void ModificarCliente(int id, string apellido, string direccion, string email, string telefono)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    Cliente cliente = clienteData.GetById(id);
                    if (cliente == null)
                    {
                        throw new Exception("El cliente no existe");
                    }
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
                    cliente.Nombre = apellido;
                    cliente.Email = email;
                    cliente.Direccion = direccion;
                    cliente.Telefono = telefono;
                    clienteData.ModificarCliente(cliente);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void EliminarCliente(int id)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    Cliente cliente = clienteData.GetById(id);
                    if (cliente == null)
                    {
                        throw new Exception("El cliente no existe");
                    }
                    clienteData.EliminarCliente(id);
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
