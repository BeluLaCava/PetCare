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
    public class FacturaData
    {
        public void GuardarFactura(Factura factura)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
            try
            {

                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO Facturas (fecha, total, cliente_id, producto_id, cantidad) 
                                                    VALUES (@fecha, @total, @cliente_id, @producto_id, @cantidad)", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@fecha", factura.Fecha);
                        cmd.Parameters.AddWithValue("@total", factura.Total);
                        cmd.Parameters.AddWithValue("@cliente_id", factura.Cliente.ID);
                        cmd.Parameters.AddWithValue("@producto_id", factura.Producto.ID);
                        cmd.Parameters.AddWithValue("@cantidad", factura.Cantidad);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public List<Factura> ObtenerFacturas()
        {
            List<Factura> listaFacturas = new List<Factura>();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT fecha, total, cliente_id, producto_id, cantidad,ID FROM Facturas", conn);
                    using (cmd)
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        using (reader)
                        {
                            while (reader.Read())
                            {
                                Factura factura = FacturaMapper.Map(reader);
                                listaFacturas.Add(factura);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return listaFacturas;
        }

        public void ModificarFactura(Factura factura)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE FACTURAS SET cantidad = @cantidad, total = @total, cliente_id = @producto_id where ID = @idFactura", conn);
                    using (cmd)
                    {                        
                        cmd.Parameters.AddWithValue("@total", factura.Total);
                        cmd.Parameters.AddWithValue("@cantidad", factura.Cantidad);
                        cmd.Parameters.AddWithValue("@cliente_id", factura.Cliente.ID);
                        cmd.Parameters.AddWithValue("@producto_id", factura.Producto.ID);
                        cmd.Parameters.AddWithValue("@idFactura", factura.ID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void EliminarFactura(int id)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from FACTURAS where ID = @idFacturas", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@idFacturas", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public Factura ObtenerPorId(int id)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
                {
                    con.Open();
                    string query = "SELECT fecha, total, cliente_id, producto_id, cantidad,ID from facturas where id = @id";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Factura fac = FacturaMapper.Map(reader);

                                return fac;
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


    }   

}
