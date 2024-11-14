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
      public void GuardarMascota(Mascota mascota)
      {
         if (!ExisteCliente(mascota.ClienteID))
         {
            throw new Exception("El cliente seleccionado no existe.");
         }

         SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDBCliente"].ConnectionString);
         try
         {
            using (conn)
            {
               conn.Open();
               SqlCommand cmd = new SqlCommand(@"INSERT INTO Mascotas (nombre, especie, raza, fecha_nacimiento, cliente_id) 
                                            VALUES (@nombre, @especie, @raza, @fecha_nacimiento, @cliente_id)", conn);
               using (cmd)
               {
                  cmd.Parameters.AddWithValue("@nombre", mascota.Nombre);
                  cmd.Parameters.AddWithValue("@especie", mascota.Especie);
                  cmd.Parameters.AddWithValue("@raza", mascota.Raza);
                  cmd.Parameters.AddWithValue("@fecha_nacimiento", mascota.FechaNacimiento);
                  cmd.Parameters.AddWithValue("@cliente_id", mascota.ClienteID);

                  cmd.ExecuteNonQuery();
               }
            }
         }
         catch (Exception ex)
         {
            throw new Exception("Error al guardar mascota: " + ex.Message);
         }
      }

      public bool ExisteCliente(int clienteID)
      {
         SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDBCliente"].ConnectionString);
         try
         {
            using (conn)
            {
               conn.Open();
               SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Clientes WHERE ID = @clienteID", conn);
               cmd.Parameters.AddWithValue("@clienteID", clienteID);

               int count = (int)cmd.ExecuteScalar();
               return count > 0;
            }
         }
         catch (Exception ex)
         {
            throw new Exception("Error al verificar el cliente: " + ex.Message);
         }
      }
      public List<Mascota> ObtenerMascotas()
      {
         List<Mascota> listaMascotas = new List<Mascota>();
         SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDBCliente"].ConnectionString);
         try
         {
            using (conn)
            {
               conn.Open();
               SqlCommand cmd = new SqlCommand("SELECT * FROM Mascotas", conn);
               using (cmd)
               {
                  SqlDataReader reader = cmd.ExecuteReader();
                  while (reader.Read())
                  {
                     Mascota mascota = new Mascota
                     {
                        ID = Convert.ToInt32(reader["ID"]),
                        Nombre = reader["nombre"].ToString(),
                        Especie = reader["especie"].ToString(),
                        Raza = reader["raza"].ToString(),
                        FechaNacimiento = reader["fecha_nacimiento"] != DBNull.Value ? Convert.ToDateTime(reader["fecha_nacimiento"]) : (DateTime?)null,
                        ClienteID = Convert.ToInt32(reader["cliente_id"])
                     };
                     listaMascotas.Add(mascota);
                  }
               }
            }
         }
         catch (Exception ex)
         {
            throw new Exception("Error al obtener mascotas: " + ex.Message);
         }
         return listaMascotas;
      }
      public Mascota GetById(int id)
      {
         try
         {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDBCliente"].ConnectionString))
            {
               conn.Open();
               string query = "SELECT ID, Nombre, Especie, Raza, FechaNacimiento, ClienteID FROM Mascotas WHERE ID = @id";

               using (SqlCommand cmd = new SqlCommand(query, conn))
               {
                  cmd.Parameters.AddWithValue("@id", id);
                  using (SqlDataReader reader = cmd.ExecuteReader())
                  {
                     while (reader.Read())
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
            throw;
         }
      }
      public void ModificarMascota(Mascota mascota)
      {
         SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDBCliente"].ConnectionString);
         try
         {
            using (conn)
            {
               conn.Open();
               SqlCommand cmd = new SqlCommand(@"UPDATE Mascotas SET Nombre = @Nombre, Especie = @Especie, Raza = @Raza,  FechaNacimiento = @FechaNacimiento WHERE ID = @ID", conn);
               using (cmd)
               {
                  cmd.Parameters.AddWithValue("@ID", mascota.ID);
                  cmd.Parameters.AddWithValue("@Nombre", mascota.Nombre);
                  cmd.Parameters.AddWithValue("@Especie", mascota.Especie);
                  cmd.Parameters.AddWithValue("@Raza", mascota.Raza);
                  cmd.Parameters.AddWithValue("@FechaNacimiento", (object)mascota.FechaNacimiento ?? DBNull.Value);
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
         SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDBCliente"].ConnectionString);
         try
         {
            using (conn)
            {
               conn.Open();
               SqlCommand cmd = new SqlCommand("DELETE FROM Mascotas WHERE ID = @id", conn);
               using (cmd)
               {
                  cmd.Parameters.AddWithValue("@id", id);
                  cmd.ExecuteNonQuery();
               }
            }
         }
         catch (Exception ex)
         {
            throw new Exception("Error al eliminar mascota: " + ex.Message);
         }
      }

   }
}
