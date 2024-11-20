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
    public class VeterinarioData
    {
        public static List<Veterinario> ObtenerVeterinario(int veterinarioId)
        {
            List<Veterinario> listaVeterinarios = new List<Veterinario>();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();

                    // Consulta dinámica según si se pasa un ID
                    string query = "SELECT * FROM Veterinarios";


                    SqlCommand cmd = new SqlCommand(query, conn);

                    using (cmd)
                    {


                        SqlDataReader reader = cmd.ExecuteReader();
                        using (reader)
                        {
                            while (reader.Read())
                            {
                                Veterinario veterinario = VeterinarioMapper.Map(reader);

                                listaVeterinarios.Add(veterinario);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al obtener los veterinarios: " + ex.Message);
            }
            return listaVeterinarios;
        }

        public static List<Veterinario> ObtenerVeterinario()
        {
            throw new NotImplementedException();
        }

        public void EliminarVeterinario(int id)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Veterinarios WHERE ID = @id", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el veterinario: " + ex.Message);
            }
        }

        public Veterinario GetById(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT ID, nombre, especialidad, horario_trabajo FROM Veterinarios WHERE ID = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Se usa `if` porque solo debe haber un resultado
                            {
                                Veterinario veterinario = VeterinarioMapper.Map(reader);
                                return veterinario;
                            }
                        }
                    }
                }
                return null; // Si no se encuentra ningún registro
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al obtener el veterinario por ID: " + ex.Message);
            }
        }

        public void GuardarVeterinario(Veterinario veterinario)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO Veterinarios (nombre, especialidad, horario_trabajo) 
                                              VALUES (@nombre, @especialidad, @horario_trabajo)", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@nombre", veterinario.Nombre);
                        cmd.Parameters.AddWithValue("@especialidad", veterinario.Especialidad);
                        cmd.Parameters.AddWithValue("@horario_trabajo", veterinario.HorarioTrabajo);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Maneja o lanza la excepción según sea necesario
                throw new Exception("Ocurrió un error al guardar el veterinario: " + ex.Message);
            }
        }


        public void ModificarVeterinario(Veterinario veterinario)

        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE Veterinarios 
                                              SET nombre = @nombre, 
                                                  especialidad = @especialidad, 
                                                  horario_trabajo = @horario_trabajo 
                                              WHERE ID = @id", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@id", veterinario.ID);
                        cmd.Parameters.AddWithValue("@nombre", veterinario.Nombre);
                        cmd.Parameters.AddWithValue("@especialidad", veterinario.Especialidad);
                        cmd.Parameters.AddWithValue("@horario_trabajo", veterinario.HorarioTrabajo);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el veterinario: " + ex.Message);
            }


        }





    }
}


