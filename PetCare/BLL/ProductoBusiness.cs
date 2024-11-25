using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class ProductoBusiness
    {

        ProductoData productoData = new ProductoData();


        public Producto obtenerProducto(int id)
        {
            return productoData.GetById(id);
        }

        public void GuardarProductos(Producto producto)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    if (string.IsNullOrEmpty(producto.Nombre))
                    {
                        throw new Exception("Complete el nombre del producto");
                    }
                    if (string.IsNullOrEmpty(producto.Descripcion))
                    {
                        throw new Exception("Complete la descripcion del producto");
                    }
                    if (producto.Precio <= 0)
                    {
                        throw new Exception("El precio debe ser mayor a cero");
                    }
                    if (producto.Stock < 0)
                    {
                        throw new Exception("El stock no puede ser menor a cero");
                    }
                    productoData.GuardarProducto(producto);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }


        public void GuardarProducto(List<Producto> producto)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    foreach (Producto productos in producto)
                    {

                        GuardarProductos(productos);
                    }
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void ModificarProducto(Producto producto)
        {
            Producto productos = productoData.GetById(producto.ID);
            using (TransactionScope trx = new TransactionScope())
            {
                if (productos == null)
                {
                    throw new Exception("El producto no existe");
                }
                if (string.IsNullOrEmpty(producto.Nombre))
                {
                    throw new Exception("Complete el nombre del producto");
                }
                if (string.IsNullOrEmpty(producto.Descripcion))
                {
                    throw new Exception("Complete la descripcion del producto");
                }
                if (producto.Precio <= 0)
                {
                    throw new Exception("El precio debe ser mayor a cero");
                }
                if (producto.Stock < 0)
                {
                    throw new Exception("El stock no puede ser menor a cero");
                }
                productoData.ModificarProducto(producto);
                trx.Complete();
            }
        }


        public void EliminarProducto(int id)
        {
            try
            {
                Producto producto = productoData.GetById(id);
                using (TransactionScope trx = new TransactionScope())
                {
                    if (producto == null)
                    {
                        throw new Exception("El producto no existe");
                    }
                    productoData.EliminarProducto(id);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }


        public List<Producto> ObtenerProductos()
        {
            return productoData.ObtenerProducto();
        }
    }
}