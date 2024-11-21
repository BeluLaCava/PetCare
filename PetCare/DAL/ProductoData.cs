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
        public void GuardarProducto(Producto producto)
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
                        cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                        cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                        cmd.Parameters.AddWithValue("@precio", producto.Precio);
                        cmd.Parameters.AddWithValue("@stock", producto.Stock);                        
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
                    using (SqlCommand cmd = new SqlCommand("SELECT ID, nombre, descripcion, precio, stock FROM Productos", conn))
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
                    SqlCommand cmd = new SqlCommand(@"UPDATE Productos SET nombre = @nombre, descripcion = @descripcion, 
                                                    precio = @precio, stock = @stock where ID = @idProducto", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@idProducto", producto.ID);
                        cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                        cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                        cmd.Parameters.AddWithValue("@precio", producto.Precio);
                        cmd.Parameters.AddWithValue("@stock", producto.Stock);
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
        public Producto GetById(int id)
        {
            try
            {

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PetCareDB"].ConnectionString);
                using (conn)
                {
                    conn.Open();
                    string query = "SELECT * FROM Productos WHERE ID = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        SqlDataReader reader = cmd.ExecuteReader();
                        using (reader)
                        {
                            while (reader.Read())
                            {
                                Producto producto = ProductoMapper.Map(reader);
                                return producto;

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
