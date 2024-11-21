namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            agregarVeterinarioToolStripMenuItem = new ToolStripMenuItem();
            agregarClienteToolStripMenuItem = new ToolStripMenuItem();
            agregarMascotaToolStripMenuItem = new ToolStripMenuItem();
            agregarProductoToolStripMenuItem = new ToolStripMenuItem();
            servicioToolStripMenuItem = new ToolStripMenuItem();
            agendarCitaToolStripMenuItem = new ToolStripMenuItem();
            facturarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            lblEmpleadoNombre = new Label();
            dgvCitasHoy = new DataGridView();
            lblTitulo = new Label();
            lblVeterinaria = new Label();
            imgCruz = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitasHoy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCruz).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, servicioToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1265, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarVeterinarioToolStripMenuItem, agregarClienteToolStripMenuItem, agregarMascotaToolStripMenuItem, agregarProductoToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(100, 20);
            menuToolStripMenuItem.Text = "Administracion";
            // 
            // agregarVeterinarioToolStripMenuItem
            // 
            agregarVeterinarioToolStripMenuItem.Name = "agregarVeterinarioToolStripMenuItem";
            agregarVeterinarioToolStripMenuItem.Size = new Size(175, 22);
            agregarVeterinarioToolStripMenuItem.Text = "Agregar Veterinario";
            agregarVeterinarioToolStripMenuItem.Click += agregarVeterinarioToolStripMenuItem_Click;
            // 
            // agregarClienteToolStripMenuItem
            // 
            agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            agregarClienteToolStripMenuItem.Size = new Size(175, 22);
            agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            agregarClienteToolStripMenuItem.Click += agregarClienteToolStripMenuItem_Click_1;
            // 
            // agregarMascotaToolStripMenuItem
            // 
            agregarMascotaToolStripMenuItem.Name = "agregarMascotaToolStripMenuItem";
            agregarMascotaToolStripMenuItem.Size = new Size(175, 22);
            agregarMascotaToolStripMenuItem.Text = "Agregar Mascota";
            agregarMascotaToolStripMenuItem.Click += agregarMascotaToolStripMenuItem_Click;
            // 
            // agregarProductoToolStripMenuItem
            // 
            agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            agregarProductoToolStripMenuItem.Size = new Size(175, 22);
            agregarProductoToolStripMenuItem.Text = "Agregar Producto";
            agregarProductoToolStripMenuItem.Click += agregarProductoToolStripMenuItem_Click;
            // 
            // servicioToolStripMenuItem
            // 
            servicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agendarCitaToolStripMenuItem, facturarToolStripMenuItem });
            servicioToolStripMenuItem.Name = "servicioToolStripMenuItem";
            servicioToolStripMenuItem.Size = new Size(60, 20);
            servicioToolStripMenuItem.Text = "Servicio";
            // 
            // agendarCitaToolStripMenuItem
            // 
            agendarCitaToolStripMenuItem.Name = "agendarCitaToolStripMenuItem";
            agendarCitaToolStripMenuItem.Size = new Size(143, 22);
            agendarCitaToolStripMenuItem.Text = "Agendar Cita";
            agendarCitaToolStripMenuItem.Click += agendarCitaToolStripMenuItem_Click;
            // 
            // facturarToolStripMenuItem
            // 
            facturarToolStripMenuItem.Name = "facturarToolStripMenuItem";
            facturarToolStripMenuItem.Size = new Size(143, 22);
            facturarToolStripMenuItem.Text = "Facturar";
            facturarToolStripMenuItem.Click += facturarToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // lblEmpleadoNombre
            // 
            lblEmpleadoNombre.AutoSize = true;
            lblEmpleadoNombre.BackColor = Color.Transparent;
            lblEmpleadoNombre.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblEmpleadoNombre.Location = new Point(320, 218);
            lblEmpleadoNombre.Name = "lblEmpleadoNombre";
            lblEmpleadoNombre.Size = new Size(86, 31);
            lblEmpleadoNombre.TabIndex = 3;
            lblEmpleadoNombre.Text = "label1";
            // 
            // dgvCitasHoy
            // 
            dgvCitasHoy.AllowUserToAddRows = false;
            dgvCitasHoy.AllowUserToDeleteRows = false;
            dgvCitasHoy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitasHoy.BackgroundColor = SystemColors.ButtonFace;
            dgvCitasHoy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitasHoy.Location = new Point(320, 325);
            dgvCitasHoy.MultiSelect = false;
            dgvCitasHoy.Name = "dgvCitasHoy";
            dgvCitasHoy.ReadOnly = true;
            dgvCitasHoy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCitasHoy.Size = new Size(1164, 619);
            dgvCitasHoy.TabIndex = 5;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 15.75F);
            lblTitulo.Location = new Point(320, 279);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(169, 25);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Turnos para hoy";
            // 
            // lblVeterinaria
            // 
            lblVeterinaria.AutoSize = true;
            lblVeterinaria.BackColor = Color.Transparent;
            lblVeterinaria.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblVeterinaria.Location = new Point(763, 76);
            lblVeterinaria.Name = "lblVeterinaria";
            lblVeterinaria.Size = new Size(453, 65);
            lblVeterinaria.TabIndex = 8;
            lblVeterinaria.Text = "Veterinaria PetCare";
            // 
            // imgCruz
            // 
            imgCruz.BackColor = Color.Transparent;
            imgCruz.Image = (Image)resources.GetObject("imgCruz.Image");
            imgCruz.Location = new Point(622, 44);
            imgCruz.Name = "imgCruz";
            imgCruz.Size = new Size(150, 150);
            imgCruz.SizeMode = PictureBoxSizeMode.StretchImage;
            imgCruz.TabIndex = 9;
            imgCruz.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 617);
            Controls.Add(imgCruz);
            Controls.Add(lblVeterinaria);
            Controls.Add(lblTitulo);
            Controls.Add(dgvCitasHoy);
            Controls.Add(lblEmpleadoNombre);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PetCare";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitasHoy).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCruz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem agregarVeterinarioToolStripMenuItem;
        private ToolStripMenuItem agregarClienteToolStripMenuItem;
        private ToolStripMenuItem agregarMascotaToolStripMenuItem;
        private ToolStripMenuItem agregarProductoToolStripMenuItem;
        private ToolStripMenuItem servicioToolStripMenuItem;
        private ToolStripMenuItem agendarCitaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Label lblEmpleadoNombre;
        private DataGridView dgvCitasHoy;
        private Label lblTitulo;
        private ToolStripMenuItem facturarToolStripMenuItem;
        private Label lblVeterinaria;
        private PictureBox imgCruz;
    }
}
