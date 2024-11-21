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
    public class CitaData
    {
        private MascotaData mascotaData = new MascotaData();
        private VeterinarioData veterinarioData = new VeterinarioData();
        public void GuardarCita(Cita cita)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
            try
            {

                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO Citas (fecha, hora, veterinario_id, mascota_id) 
                                                    VALUES (@fecha, @hora, @veterinarioid, @mascotaid)", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@fecha", cita.Fecha);
                        cmd.Parameters.AddWithValue("@hora", cita.Hora);
                        cmd.Parameters.AddWithValue("@veterinarioid", cita.VeterinarioID.ID);
                        cmd.Parameters.AddWithValue("@mascotaid", cita.MascotaID.ID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public List<Cita> ObtenerCita()
        {
            List<Cita> listacitas = new List<Cita>();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Citas", conn);
                    using (cmd)
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        using (reader)
                        {
                            while (reader.Read())
                            {
                                int idMascota = Convert.ToInt32(reader["mascota_id"].ToString());
                                Mascota mascota = mascotaData.GetById(idMascota);
                                int idVeterinario = Convert.ToInt32(reader["veterinario_id"].ToString());
                                Veterinario veterinario = veterinarioData.GetById(idVeterinario);
                                Cita cita = CitaMapper.Map(reader, mascota, veterinario);
                                listacitas.Add(cita);
                            }
                        }

                    }
                }
                return listacitas;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public Cita GetById(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Citas WHERE ID = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Se usa `if` porque solo debe haber un resultado
                            {
                                int idMascota = Convert.ToInt32(reader["mascota_id"].ToString());
                                Mascota mascota = mascotaData.GetById(idMascota);
                                int idVeterinario = Convert.ToInt32(reader["veterinario_id"].ToString());
                                Veterinario veterinario = veterinarioData.GetById(idVeterinario);
                                Cita cita = CitaMapper.Map(reader, mascota, veterinario);
                                return cita;
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
        public void ModificarCita(Cita cita)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE Citas SET fecha = @fecha, hora = @hora, veterinario_id = @veterinarioid, 
                                                    mascota_id = @mascotaid where ID = @idcita", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@idcita", cita.ID);
                        cmd.Parameters.AddWithValue("@fecha", cita.Fecha);
                        cmd.Parameters.AddWithValue("@hora", cita.Hora);
                        cmd.Parameters.AddWithValue("@veterinarioid", cita.VeterinarioID.ID);
                        cmd.Parameters.AddWithValue("@mascotaid", cita.MascotaID.ID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void EliminarCita(int idEliminar)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from Citas where ID = @idcita", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@idcita", idEliminar);
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
