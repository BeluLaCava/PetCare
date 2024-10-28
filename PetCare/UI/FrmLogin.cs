using BLL;
using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmLogin : Form
    {
        private EmpleadoBusiness empleadoBusiness = new EmpleadoBusiness();
        private Empleado empleado = new Empleado();
        public Empleado EmpleadoAutenticado { get; private set; }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string password = txtPass.Text;

                // Llama al método de la capa de negocio para validar el login
                Empleado empleado = empleadoBusiness.LoginEmpleado(email, password);

                if (empleado != null)
                {
                    // Login exitoso: guarda el empleado autenticado y cierra el formulario
                    EmpleadoAutenticado = empleado;
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // Login fallido: muestra un mensaje de error
                    MessageBox.Show("Email o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPass.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            


        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtEmail.Text = "Ramirez@gmail.com";
            txtPass.Text = "123";
        }
    }
}
