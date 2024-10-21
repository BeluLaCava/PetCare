using Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClienteData
    {
        public void GuardarCliente(Cliente cliente)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDBCliente"].ConnectionString);
            try
            {

                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO Clientes (nombre, direccion, telefono, email) 
                                                    VALUES (@nombre, @direccion, @telefono, @email)", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                        cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                        cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                        cmd.Parameters.AddWithValue("@email", cliente.Email);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public List<Cliente> ObtenerCliente ()
        {
            List<Cliente> listaCliente = new List<Cliente>();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDBCliente"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Clientes", conn);
                    using (cmd)
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        using (reader)
                        {
                            while (reader.Read())
                            {
                                Cliente cliente = new Cliente();
                                {
                                    cliente.ID = reader.GetInt32(0);
                                    cliente.Nombre = reader.GetString(1);
                                    cliente.Direccion = reader.GetString(2);
                                    cliente.Telefono = reader.GetString(3);
                                    cliente.Email = reader.GetString(4);
                                }
                                listaCliente.Add(cliente);
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return listaCliente;
        }
        public void ModificarCliente(int idcliente, string direccion, string email, string telefono)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDBCliente"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Clientes SET direccion = @direccion, email = @email, telefono = @telefono where ID = @idcliente", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@idcliente", idcliente);
                        cmd.Parameters.AddWithValue("@direccion", direccion);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@telefono", telefono);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void EliminarCliente(int idcliente)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDBCliente"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from Clientes where ID = @idcliente", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@idcliente", idcliente);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
