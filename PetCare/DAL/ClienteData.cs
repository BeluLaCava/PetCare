using Entity;
using Mapper;
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
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
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
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
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
                                Cliente cliente = ClienteMapper.Map(reader);
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

        public Cliente GetById(int id)
        {
            try
            {
                ;
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString)) 
                {
                    conn.Open();
                    string query = "SELECT ID, nombre, direccion, telefono, email FROM Clientes WHERE ID = @id";
                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                Cliente cliente = ClienteMapper.Map(reader);
                                return cliente;
                            }
                        }    
                    }
                }
                return null;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void ModificarCliente(Cliente cliente)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Clientes SET nombre = @nombre, direccion = @direccion, email = @email, telefono = @telefono where ID = @id", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@id", cliente.ID);
                        cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                        cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                        cmd.Parameters.AddWithValue("@email", cliente.Email);
                        cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void EliminarCliente(int id)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from Clientes where ID = @id", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@id", id);
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
