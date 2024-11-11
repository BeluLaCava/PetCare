using Entity;
using Mapper;
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
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
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
                                Empleado empleado = EmpleadoMapper.Map(reader);
                                return empleado;

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
