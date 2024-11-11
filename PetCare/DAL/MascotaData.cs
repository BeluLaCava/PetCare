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
    public class MascotaData
    {
      public Mascota ObtenerMascotaPorID(int id)
      {
         try
         {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
            using (conn)
            {
               string query = "SELECT * FROM Mascota WHERE ID = @id";
               SqlCommand command = new SqlCommand(query, conn);
               using (command)
               {
                  command.Parameters.AddWithValue("@id", id);

                  conn.Open();
                  SqlDataReader reader = command.ExecuteReader();
                  using (reader)
                  {
                     if (reader.Read())
                     {

                        Mascota mascota = MascotaMapper.Map(reader);
                        return mascota;
                     }
                  }
               }
            }
            return null;
         }
         catch (Exception ex)
         {
            throw new Exception("Error al obtener la mascota por ID", ex);
         }
      }

      public void AgregarMascota(Mascota mascota)
      {
         try
         {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
            using (conn)
            {
               string query = "INSERT INTO Mascota (Nombre, Especie, Raza, Fecha_Nacimiento, Cliente_ID) VALUES (@nombre, @especie, @raza, @fechaNacimiento, @clienteId)";
               SqlCommand command = new SqlCommand(query, conn);
               using (command)
               {
                  command.Parameters.AddWithValue("@nombre", mascota.Nombre);
                  command.Parameters.AddWithValue("@especie", mascota.Especie);
                  command.Parameters.AddWithValue("@raza", mascota.Raza);
                  command.Parameters.AddWithValue("@fechaNacimiento", mascota.FechaNacimiento);
                  command.Parameters.AddWithValue("@clienteId", mascota.ClienteID);

                  conn.Open();
                  command.ExecuteNonQuery();
               }
            }
         }
         catch (Exception ex)
         {
            throw new Exception("Error al agregar una nueva mascota", ex);
         }
      }
      public List<Mascota> ObtenerTodasLasMascotas()
      {
         try
         {
            List<Mascota> mascotas = new List<Mascota>();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
            using (conn)
            {
               string query = "SELECT * FROM Mascota";
               SqlCommand command = new SqlCommand(query, conn);

               conn.Open();
               SqlDataReader reader = command.ExecuteReader();
               using (reader)
               {
                  while (reader.Read())
                  {
                     Mascota mascota = MascotaMapper.Map(reader);
                     mascotas.Add(mascota);
                  }
               }
            }
            return mascotas;
         }
         catch (Exception ex)
         {
            throw new Exception("Error al obtener todas las mascotas", ex);
         }
      }
      public void ActualizarMascota(Mascota mascota)
      {
         try
         {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
            using (conn)
            {
               string query = "UPDATE Mascota SET Nombre = @nombre, Especie = @especie, Raza = @raza, Fecha_Nacimiento = @fechaNacimiento, Cliente_ID = @clienteId WHERE ID = @id";
               SqlCommand command = new SqlCommand(query, conn);
               using (command)
               {
                  command.Parameters.AddWithValue("@id", mascota.ID);
                  command.Parameters.AddWithValue("@nombre", mascota.Nombre);
                  command.Parameters.AddWithValue("@especie", mascota.Especie);
                  command.Parameters.AddWithValue("@raza", mascota.Raza);
                  command.Parameters.AddWithValue("@fechaNacimiento", mascota.FechaNacimiento);
                  command.Parameters.AddWithValue("@clienteId", mascota.ClienteID);

                  conn.Open();
                  command.ExecuteNonQuery();
               }
            }
         }
         catch (Exception ex)
         {
            throw new Exception("Error al actualizar la mascota", ex);
         }
      }
      public void EliminarMascota(int id)
      {
         try
         {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
            using (conn)
            {
               string query = "DELETE FROM Mascota WHERE ID = @id";
               SqlCommand command = new SqlCommand(query, conn);
               using (command)
               {
                  command.Parameters.AddWithValue("@id", id);

                  conn.Open();
                  command.ExecuteNonQuery();
               }
            }
         }
         catch (Exception ex)
         {
            throw new Exception("Error al eliminar la mascota", ex);
         }
      }

   }
}
