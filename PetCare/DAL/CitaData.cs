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
    public class CitaData
    {
        public void GuardarCita(Cita cita)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDBCliente"].ConnectionString);
            try
            {

                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO Cita (fecha, hora, veterinarioid, mascotaid) 
                                                    VALUES (@fecha, @hora, @veterinarioid, @mascotaid)", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@fecha", cita.Fecha);
                        cmd.Parameters.AddWithValue("@hora", cita.Hora);
                        cmd.Parameters.AddWithValue("@veterinarioid", cita.VeterinarioID);
                        cmd.Parameters.AddWithValue("@mascotaid", cita.MascotaID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public List<Cliente> ObtenerCita()
        {
            List<Cita> listacitas = new List<Cita>();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDBCliente"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Cita", conn);
                    using (cmd)
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        using (reader)
                        {
                            while (reader.Read())
                            {
                                Cita cita = new Cita();
                                {
                                    cita.ID = reader.GetInt32(0);
                                    cita.Fecha = reader.GetDateTime(1);
                                    cita.Hora = reader.GetTimeSpan(2);
                                    cita.VeterinarioID = reader.GetInt32(3);
                                    cita.MascotaID = reader.GetInt32(4);
                                }
                                listacitas.Add(cita);
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return listacitas;
        }
        public void ModificarCita(int id, DateTime fecha, TimeSpan hora, int veterinarioid, int mascotaid)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDBCliente"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Cita SET fecha = @fecha, Hora = @hora, Veterinarioid = @veterinarioid, Mascotaid = @mascotaid where ID = @idcita", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@idcita", id);
                        cmd.Parameters.AddWithValue("@fecha", fecha);
                        cmd.Parameters.AddWithValue("@hora", hora);
                        cmd.Parameters.AddWithValue("@veterinarioid", veterinarioid);
                        cmd.Parameters.AddWithValue("@mascotaid", mascotaid);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void EliminarCita(int idcita)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDBCliente"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from Cita where ID = @idcita", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@idcita", idcita);
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
