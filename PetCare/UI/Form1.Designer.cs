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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            agregarVeterinarioToolStripMenuItem = new ToolStripMenuItem();
            agregarClienteToolStripMenuItem = new ToolStripMenuItem();
            agregarMascotaToolStripMenuItem = new ToolStripMenuItem();
            agregarProductoToolStripMenuItem = new ToolStripMenuItem();
            servicioToolStripMenuItem = new ToolStripMenuItem();
            agendarCitaToolStripMenuItem = new ToolStripMenuItem();
            comprarProductoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, servicioToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
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
            servicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agendarCitaToolStripMenuItem, comprarProductoToolStripMenuItem });
            servicioToolStripMenuItem.Name = "servicioToolStripMenuItem";
            servicioToolStripMenuItem.Size = new Size(60, 20);
            servicioToolStripMenuItem.Text = "Servicio";
            // 
            // agendarCitaToolStripMenuItem
            // 
            agendarCitaToolStripMenuItem.Name = "agendarCitaToolStripMenuItem";
            agendarCitaToolStripMenuItem.Size = new Size(180, 22);
            agendarCitaToolStripMenuItem.Text = "Agendar Cita";
            agendarCitaToolStripMenuItem.Click += agendarCitaToolStripMenuItem_Click;
            // 
            // comprarProductoToolStripMenuItem
            // 
            comprarProductoToolStripMenuItem.Name = "comprarProductoToolStripMenuItem";
            comprarProductoToolStripMenuItem.Size = new Size(180, 22);
            comprarProductoToolStripMenuItem.Text = "Comprar Producto";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private ToolStripMenuItem comprarProductoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}
