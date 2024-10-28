using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductoBusiness
    {
        private List<Producto> productos; // Simulando una base de datos en memoria

        public ProductoBusiness()
        {
            productos = new List<Producto>();
        }

        // Método para agregar un nuevo producto
        public void GuardarProducto(string nombre, string descripcion, decimal precio, int stock)
        {
            Producto nuevoProducto = new Producto
            {
                ID = productos.Count + 1, // Asignar un ID basado en la cantidad actual
                Nombre = nombre,
                Descripcion = descripcion,
                Precio = precio,
                Stock = stock
            };

            productos.Add(nuevoProducto);
        }

        // Método para modificar un producto existente
        public void ModificarProducto(int id, string nuevoNombre, string nuevaDescripcion, decimal nuevoPrecio, int nuevoStock)
        {
            Producto producto = productos.Find(p => p.ID == id);
            if (producto != null)
            {
                producto.Nombre = nuevoNombre;
                producto.Descripcion = nuevaDescripcion;
                producto.Precio = nuevoPrecio;
                producto.Stock = nuevoStock;
            }
        }

        // Método para eliminar un producto
        public void EliminarProducto(int id)
        {
            Producto producto = productos.Find(p => p.ID == id);
            if (producto != null)
            {
                productos.Remove(producto);
            }
        }

        // Método para obtener todos los productos (opcional, para llenar el ComboBox)
        public List<Producto> ObtenerProductos()
        {
            return productos;
        }
    }
}
