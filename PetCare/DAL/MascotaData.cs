using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MascotaData
    {
      private ClienteData clienteData = new ClienteData();
      public void GuardarMascota(Mascota mascota)
      {

         SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
         try
         {

            using (conn)
            {
               conn.Open();
               SqlCommand cmd = new SqlCommand(@"INSERT INTO Mascotas (nombre, especie, raza, fecha_nacimiento, cliente_id) VALUES (@nombre, @especie, @raza, @fecha_nacimiento, @cliente_id)", conn);
               using (cmd)
               {
                  cmd.Parameters.AddWithValue("@nombre", mascota.Nombre);
                  cmd.Parameters.AddWithValue("@especie", mascota.Especie);
                  cmd.Parameters.AddWithValue("@raza", mascota.Raza);
                  cmd.Parameters.AddWithValue("@fecha_nacimiento", mascota.FechaNacimiento);
                  cmd.Parameters.AddWithValue("@cliente_id", mascota.ClienteId.ID);

                  cmd.ExecuteNonQuery();
               }
            }
         }
         catch (Exception ex)
         {
            throw new Exception("Error al guardar mascota: " + ex.Message);
         }
      }

    
      public List<Mascota> ObtenerMascotas()
      {

         List<Mascota> listaMascotas = new List<Mascota>();
         SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
         try
         {

            using (conn)
                {  conn.Open();
               string query = "SELECT ID, nombre, especie, raza, fecha_nacimiento, cliente_id FROM Mascotas";

               using (SqlCommand command = new SqlCommand(query, conn))
               {
                  using (SqlDataReader reader = command.ExecuteReader())
                  {
                     while (reader.Read())
                     {
                         int clienteId = Convert.ToInt32(reader["cliente_id"].ToString());
                         Cliente cliente = clienteData.GetById(clienteId);
                         Mascota mascota = MascotaMapper.Map(reader, cliente);
                         listaMascotas.Add(mascota);
                     }
                  }
               }
            }
            return listaMascotas;
         }
         catch (Exception ex)
         {
            throw new Exception("Error al obtener las mascotas: " + ex.Message, ex);
         }
      }
      public Mascota GetById(int id)
      {
         try
         {


            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString))
            {
               conn.Open();
               string query = "SELECT ID, nombre, especie, raza, fecha_nacimiento, cliente_id FROM Mascotas WHERE ID = @id";

               using (SqlCommand command = new SqlCommand(query, conn))
               {
                  command.Parameters.AddWithValue("@id", id);

                  using (SqlDataReader reader = command.ExecuteReader())
                  {
                     while (reader.Read())
                     {
                                int clienteId = Convert.ToInt32(reader["cliente_id"].ToString());
                                Cliente cliente = clienteData.GetById(clienteId);
                                Mascota mascota = MascotaMapper.Map(reader, cliente);
                                return mascota;
                            }
                  }
               }
            }
            return null;
         }
         catch (Exception ex)
         {
            throw new Exception("Error al obtener la mascota por ID: " + ex.Message, ex);
         }
      }
      public void ModificarMascota(Mascota mascota)
      {
         SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
         try
         {

            using (conn)
            {
               conn.Open();
               SqlCommand cmd = new SqlCommand(@"UPDATE Mascotas SET nombre = @Nombre, especie = @Especie, raza = @Raza, 
                                                fecha_nacimiento = @FechaNacimiento, cliente_id = @clienteId WHERE ID = @ID", conn);
               using (cmd)
               {
                  cmd.Parameters.AddWithValue("@ID", mascota.ID);
                  cmd.Parameters.AddWithValue("@Nombre", mascota.Nombre);
                  cmd.Parameters.AddWithValue("@Especie", mascota.Especie);
                  cmd.Parameters.AddWithValue("@Raza", mascota.Raza);
                  cmd.Parameters.AddWithValue("@FechaNacimiento", mascota.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@clienteId", mascota.ClienteId.ID);
                  cmd.ExecuteNonQuery();
               }
            }
         }
         catch (Exception ex)
         {
            throw;
         }
      }

      public void EliminarMascota(int id)
      {
         SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
         try
         {

            using (conn)
         {
               conn.Open();
                    string deleteCitasQuery = "DELETE FROM citas WHERE mascota_id = @id";
                    using (SqlCommand command = new SqlCommand(deleteCitasQuery, conn))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                    string query = "DELETE FROM Mascotas WHERE ID = @id";
               using (SqlCommand command = new SqlCommand(query, conn))
               {
                  command.Parameters.AddWithValue("@id", id);
                  command.ExecuteNonQuery();
               }
                   
                }
         }
         catch (Exception ex)
         {
            throw new Exception("Error al eliminar la mascota: " + ex.Message, ex);
         }
      }

   }
}
