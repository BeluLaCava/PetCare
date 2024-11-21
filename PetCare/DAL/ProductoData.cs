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
    public  class ProductoData
    {
        public void GuardarProducto(Producto prod)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
            try
            {

                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO Productos (nombre, descripcion, precio, stock) 
                                                    VALUES (@nombre, @descripcion, @precio, @stock)", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@nombre", prod.Nombre);
                        cmd.Parameters.AddWithValue("@descipcion", prod.Descripcion);
                        cmd.Parameters.AddWithValue("@precio", prod.Precio);
                        cmd.Parameters.AddWithValue("@stock", prod.Stock);                        
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public List<Producto> ObtenerProducto()
        {
            List<Producto> listaProducto = new List<Producto>();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();                    
                    using (SqlCommand cmd = new SqlCommand("SELECT nombre, descripcion, precio, stock, ID FROM Productos", conn))
                    {
                        
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Producto producto = ProductoMapper.Map(reader);
                                listaProducto.Add(producto);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return listaProducto;
        }

        public void ModificarProducto(Producto producto)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Productos SET nombre = @nombre, descripcion = @descripcion, precio = @precio, stock = @stock where ID = @idProducto", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                        cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                        cmd.Parameters.AddWithValue("@precio", producto.Precio);
                        cmd.Parameters.AddWithValue("@stock", producto.Stock);
                        cmd.Parameters.AddWithValue("@idProducto", producto.ID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void EliminarProducto(int idProducto)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from Productos where ID = @idProducto", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@idProducto", idProducto);
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
