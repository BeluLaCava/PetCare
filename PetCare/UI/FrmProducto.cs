using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmProducto : Form
    {
        private ProductoBusiness productoBLL = new ProductoBusiness();
        public FrmProducto()
        {
            InitializeComponent();
            CargarProductosComboBoxes();
            CargarProductosGrid();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string descripcion = txtDescripcion.Text;
                decimal precio;
                int stock;

                if (decimal.TryParse(txtPrecio.Text, out precio) && int.TryParse(txtStock.Text, out stock))
                {
                    productoBLL.GuardarProducto(nombre, descripcion, precio, stock);
                    LimpiarCampos();
                    CargarProductosComboBoxes();
                    CargarProductosGrid();
                }
                else
                {
                    MessageBox.Show("Por favor, introduce valores válidos para precio y stock.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el producto: {ex.Message}");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProductos.SelectedValue is int id)
                {
                    string nuevoNombre = txtModificarNombre.Text;
                    string nuevaDescripcion = txtModificarDescripcion.Text;
                    decimal nuevoPrecio;
                    int nuevoStock;

                    if (decimal.TryParse(txtModificarPrecio.Text, out nuevoPrecio) && int.TryParse(txtModificarStock.Text, out nuevoStock))
                    {
                        productoBLL.ModificarProducto(id, nuevoNombre, nuevaDescripcion, nuevoPrecio, nuevoStock);
                        LimpiarCampos();
                        CargarProductosComboBoxes();
                        CargarProductosGrid();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, introduce valores válidos para precio y stock.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el producto: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEliminar.SelectedValue is int id)
                {
                    productoBLL.EliminarProducto(id);
                    CargarProductosComboBoxes();
                    CargarProductosGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el producto: {ex.Message}");
            }

        }
        private void CargarProductosComboBoxes()
        {
            try
            {
                // Cargar productos en los ComboBoxes
                cmbProductos.DataSource = productoBLL.ObtenerProductos();
                cmbProductos.DisplayMember = "Nombre"; // Cambia esto si necesitas mostrar otra propiedad
                cmbProductos.ValueMember = "ID";

                cmbEliminar.DataSource = productoBLL.ObtenerProductos();
                cmbEliminar.DisplayMember = "Nombre"; // Cambia esto si necesitas mostrar otra propiedad
                cmbEliminar.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}");
            }
        }

        private void CargarProductosGrid()
        {
            try
            {
                // Cargar productos en el DataGridView
                dgvProductos.DataSource = productoBLL.ObtenerProductos(); // Asumiendo que retorna una lista
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el DataGridView: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            // Limpiar campos de texto
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtModificarNombre.Clear();
            txtModificarDescripcion.Clear();
            txtModificarPrecio.Clear();
            txtModificarStock.Clear();
        }
    }
}
