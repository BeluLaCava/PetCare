using Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAL
{
    public class EmpleadoData
    {
        
        public Empleado ObtenerEmpleadoPorEmail(string email)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDBCliente"].ConnectionString);
                using (conn)
                {
                    string query = "SELECT * FROM Empleado WHERE EMAIL = @correo";
                    SqlCommand command = new SqlCommand(query, conn);
                    using (command)
                    {
                        command.Parameters.AddWithValue("@correo", email);

                        conn.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        using (reader)
                        {

                            if (reader.Read())
                            {
                                return new Empleado
                                {
                                    ID = reader.GetInt32(0),
                                    Apellido = reader.GetString(1),
                                    Nombre = reader.GetString(2),
                                    DNI = reader.GetString(3),
                                    Email = reader.GetString(4),
                                    Pass = reader.GetString(5) // Contraseña sin encriptar
                                };
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        
    }
}
