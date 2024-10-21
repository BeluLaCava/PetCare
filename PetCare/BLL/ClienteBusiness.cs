using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{

    public class ClienteBusiness
    {
        private ClienteData clienteData = new ClienteData();

        public void GuardarCliente(Cliente cliente)
        {
            try
            {
                if(string.IsNullOrEmpty(cliente.Nombre))
                {
                    throw new Exception("Complete el nombre y apellido del cliente");
                }

                if (string.IsNullOrEmpty(cliente.Direccion))
                {
                    throw new Exception("Complete la direccion");
                }
                if (string.IsNullOrEmpty(cliente.Telefono) || !EsTelefonoValido(cliente.Telefono))
                {
                    throw new Exception("El telefono debe ser numerico y minimo 8 numeros");
                }

                if (string.IsNullOrEmpty(cliente.Email) || !EsEmailValido(cliente.Email))
                {
                    throw new Exception("Ingrese un email válido (ejemplo@ejemplo.com)");
                }
               
                clienteData.GuardarCliente(cliente);

            }
            catch (Exception ex)
            {

                throw;
            }

        }
        private bool EsTelefonoValido(string telefono)
        {
            return Regex.IsMatch(telefono, @"^\d{8,}$");
        }

        // Método para validar un email usando expresión regular
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
                clienteData.EliminarCliente(idcliente);

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
