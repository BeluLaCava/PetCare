namespace UI
{
    partial class FrmMascota
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox4 = new GroupBox();
            dgvMascotas = new DataGridView();
            groupBox3 = new GroupBox();
            txtEliminarId = new TextBox();
            label10 = new Label();
            btnEliminar = new Button();
            groupBox2 = new GroupBox();
            txtModificarID = new TextBox();
            label2 = new Label();
            label13 = new Label();
            cmbModificarCliente = new ComboBox();
            dtpModificarFecha = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtModificarEspecie = new TextBox();
            txtModificarNombre = new TextBox();
            txtModificarRaza = new TextBox();
            btnModificar = new Button();
            groupBox1 = new GroupBox();
            btnConfirmar = new Button();
            btnBorrador = new Button();
            label14 = new Label();
            cmbCliente = new ComboBox();
            dtpFecha = new DateTimePicker();
            txtRaza = new TextBox();
            txtEspecie = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            btnGuardar = new Button();
            btnSalir = new Button();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvMascotas);
            groupBox4.Location = new Point(615, 67);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(1046, 891);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Mascotas";
            // 
            // dgvMascotas
            // 
            dgvMascotas.AllowUserToAddRows = false;
            dgvMascotas.AllowUserToDeleteRows = false;
            dgvMascotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMascotas.Location = new Point(7, 29);
            dgvMascotas.Margin = new Padding(3, 4, 3, 4);
            dgvMascotas.MultiSelect = false;
            dgvMascotas.Name = "dgvMascotas";
            dgvMascotas.ReadOnly = true;
            dgvMascotas.RowHeadersWidth = 51;
            dgvMascotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMascotas.Size = new Size(1032, 853);
            dgvMascotas.TabIndex = 4;
            dgvMascotas.SelectionChanged += dgvMascotas_SelectionChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtEliminarId);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Location = new Point(83, 965);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(499, 145);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar Mascota";
            // 
            // txtEliminarId
            // 
            txtEliminarId.Font = new Font("Segoe UI", 12F);
            txtEliminarId.Location = new Point(110, 64);
            txtEliminarId.Margin = new Padding(3, 4, 3, 4);
            txtEliminarId.Name = "txtEliminarId";
            txtEliminarId.Size = new Size(175, 34);
            txtEliminarId.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(25, 68);
            label10.Name = "label10";
            label10.Size = new Size(86, 28);
            label10.TabIndex = 22;
            label10.Text = "Mascota";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(314, 53);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(163, 56);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtModificarID);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(cmbModificarCliente);
            groupBox2.Controls.Add(dtpModificarFecha);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtModificarEspecie);
            groupBox2.Controls.Add(txtModificarNombre);
            groupBox2.Controls.Add(txtModificarRaza);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Location = new Point(83, 493);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(499, 464);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modificar Mascota";
            // 
            // txtModificarID
            // 
            txtModificarID.Font = new Font("Segoe UI", 12F);
            txtModificarID.Location = new Point(110, 24);
            txtModificarID.Margin = new Padding(3, 4, 3, 4);
            txtModificarID.Name = "txtModificarID";
            txtModificarID.Size = new Size(254, 34);
            txtModificarID.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(11, 280);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 12;
            label2.Text = "Cliente";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(11, 28);
            label13.Name = "label13";
            label13.Size = new Size(86, 28);
            label13.TabIndex = 24;
            label13.Text = "Mascota";
            // 
            // cmbModificarCliente
            // 
            cmbModificarCliente.Font = new Font("Segoe UI", 12F);
            cmbModificarCliente.FormattingEnabled = true;
            cmbModificarCliente.Location = new Point(110, 276);
            cmbModificarCliente.Margin = new Padding(3, 4, 3, 4);
            cmbModificarCliente.Name = "cmbModificarCliente";
            cmbModificarCliente.Size = new Size(254, 36);
            cmbModificarCliente.TabIndex = 10;
            // 
            // dtpModificarFecha
            // 
            dtpModificarFecha.Font = new Font("Segoe UI", 12F);
            dtpModificarFecha.Location = new Point(195, 336);
            dtpModificarFecha.Margin = new Padding(3, 4, 3, 4);
            dtpModificarFecha.Name = "dtpModificarFecha";
            dtpModificarFecha.Size = new Size(245, 34);
            dtpModificarFecha.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(11, 344);
            label8.Name = "label8";
            label8.Size = new Size(168, 28);
            label8.TabIndex = 22;
            label8.Text = "Fecha Nacimiento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(11, 152);
            label9.Name = "label9";
            label9.Size = new Size(53, 28);
            label9.TabIndex = 21;
            label9.Text = "Raza";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(11, 215);
            label11.Name = "label11";
            label11.Size = new Size(76, 28);
            label11.TabIndex = 20;
            label11.Text = "Especie";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(11, 92);
            label12.Name = "label12";
            label12.Size = new Size(85, 28);
            label12.TabIndex = 19;
            label12.Text = "Nombre";
            // 
            // txtModificarEspecie
            // 
            txtModificarEspecie.Font = new Font("Segoe UI", 12F);
            txtModificarEspecie.Location = new Point(110, 211);
            txtModificarEspecie.Margin = new Padding(3, 4, 3, 4);
            txtModificarEspecie.Name = "txtModificarEspecie";
            txtModificarEspecie.Size = new Size(254, 34);
            txtModificarEspecie.TabIndex = 9;
            // 
            // txtModificarNombre
            // 
            txtModificarNombre.Font = new Font("Segoe UI", 12F);
            txtModificarNombre.Location = new Point(110, 88);
            txtModificarNombre.Margin = new Padding(3, 4, 3, 4);
            txtModificarNombre.Name = "txtModificarNombre";
            txtModificarNombre.Size = new Size(254, 34);
            txtModificarNombre.TabIndex = 7;
            // 
            // txtModificarRaza
            // 
            txtModificarRaza.Font = new Font("Segoe UI", 12F);
            txtModificarRaza.Location = new Point(110, 148);
            txtModificarRaza.Margin = new Padding(3, 4, 3, 4);
            txtModificarRaza.Name = "txtModificarRaza";
            txtModificarRaza.Size = new Size(254, 34);
            txtModificarRaza.TabIndex = 8;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F);
            btnModificar.Location = new Point(314, 383);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(163, 56);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConfirmar);
            groupBox1.Controls.Add(btnBorrador);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(cmbCliente);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(txtRaza);
            groupBox1.Controls.Add(txtEspecie);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Location = new Point(83, 67);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(499, 419);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alta Mascota";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Segoe UI", 12F);
            btnConfirmar.Location = new Point(183, 343);
            btnConfirmar.Margin = new Padding(3, 4, 3, 4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(153, 56);
            btnConfirmar.TabIndex = 12;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnBorrador
            // 
            btnBorrador.Font = new Font("Segoe UI", 12F);
            btnBorrador.Location = new Point(11, 343);
            btnBorrador.Margin = new Padding(3, 4, 3, 4);
            btnBorrador.Name = "btnBorrador";
            btnBorrador.Size = new Size(165, 56);
            btnBorrador.TabIndex = 11;
            btnBorrador.Text = "Agregar Borrador";
            btnBorrador.UseVisualStyleBackColor = true;
            btnBorrador.Click += btnBorrador_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(11, 232);
            label14.Name = "label14";
            label14.Size = new Size(72, 28);
            label14.TabIndex = 10;
            label14.Text = "Cliente";
            // 
            // cmbCliente
            // 
            cmbCliente.Font = new Font("Segoe UI", 12F);
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(110, 228);
            cmbCliente.Margin = new Padding(3, 4, 3, 4);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(254, 36);
            cmbCliente.TabIndex = 3;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 12F);
            dtpFecha.Location = new Point(171, 284);
            dtpFecha.Margin = new Padding(3, 4, 3, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(245, 34);
            dtpFecha.TabIndex = 4;
            // 
            // txtRaza
            // 
            txtRaza.Font = new Font("Segoe UI", 12F);
            txtRaza.Location = new Point(110, 99);
            txtRaza.Margin = new Padding(3, 4, 3, 4);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(253, 34);
            txtRaza.TabIndex = 1;
            // 
            // txtEspecie
            // 
            txtEspecie.Font = new Font("Segoe UI", 12F);
            txtEspecie.Location = new Point(110, 163);
            txtEspecie.Margin = new Padding(3, 4, 3, 4);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(253, 34);
            txtEspecie.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(110, 39);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 34);
            txtNombre.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(11, 292);
            label4.Name = "label4";
            label4.Size = new Size(168, 28);
            label4.TabIndex = 4;
            label4.Text = "Fecha Nacimiento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(11, 103);
            label7.Name = "label7";
            label7.Size = new Size(53, 28);
            label7.TabIndex = 3;
            label7.Text = "Raza";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(11, 167);
            label6.Name = "label6";
            label6.Size = new Size(76, 28);
            label6.TabIndex = 2;
            label6.Text = "Especie";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(11, 39);
            label5.Name = "label5";
            label5.Size = new Size(85, 28);
            label5.TabIndex = 1;
            label5.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(7, 39);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(343, 343);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 56);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 12F);
            btnSalir.Location = new Point(1497, 1012);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(163, 56);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Cerrar";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmMascota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1695, 1055);
            Controls.Add(btnSalir);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMascota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mascota";
            WindowState = FormWindowState.Maximized;
            Load += FrmMascota_Load;
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private DataGridView dgvMascotas;
        private GroupBox groupBox3;
        private Label label10;
        private Button btnEliminar;
        private GroupBox groupBox2;
        private ComboBox cmbMascota;
        private TextBox txtModificarEspecie;
        private TextBox txtModificarNombre;
        private TextBox txtModificarRaza;
        private Button btnModificar;
        private GroupBox groupBox1;
        private TextBox txtRaza;
        private TextBox txtEspecie;
        private TextBox txtNombre;
        private Label label4;
        private Label label1;
        private Button btnGuardar;
        private DateTimePicker dtpFecha;
        private DateTimePicker dtpModificarFecha;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label13;
        private Label label14;
        private ComboBox cmbCliente;
        private Button btnSalir;
        private Label label2;
        private ComboBox cmbModificarCliente;
        private TextBox txtModificarID;
        private TextBox txtEliminarId;
        private Button btnConfirmar;
        private Button btnBorrador;
    }
}