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
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDBCliente"].ConnectionString);
            try
            {

                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO Facturas (fecha, total, id_cliente, producto_id, cantidad) 
                                                    VALUES (@fecha, @total, @id_cliente, @producto_id, @cantidad)", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@fecha", factura.Fecha);
                        cmd.Parameters.AddWithValue("@total", factura.Total);
                        cmd.Parameters.AddWithValue("@id_cliente", factura.Cliente.ID);
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
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDBCliente"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT fecha, total, id_cliente, producto_id, cantidad,ID FROM Facturas", conn);
                    using (cmd)
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        using (reader)
                        {
                            Factura factura = FacturaMapper.Map(reader);
                            listaFacturas.Add(factura);
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
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDBCliente"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE FACTURAS SET fecha = @fecha, total = @total, cliente_id = @producto_id where ID = @idFactura", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@fecha", factura.Fecha);
                        cmd.Parameters.AddWithValue("@total", factura.Total);
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
        public void EliminarFactura(int idcliente)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDBCliente"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from FACTURAS where ID = @idFacturas", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@idFacturas", idcliente);
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
