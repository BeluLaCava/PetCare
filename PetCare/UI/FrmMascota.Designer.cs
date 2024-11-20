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
            groupBox4.Location = new Point(467, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(789, 464);
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
            dgvMascotas.Location = new Point(6, 22);
            dgvMascotas.MultiSelect = false;
            dgvMascotas.Name = "dgvMascotas";
            dgvMascotas.ReadOnly = true;
            dgvMascotas.RowHeadersWidth = 51;
            dgvMascotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMascotas.Size = new Size(777, 430);
            dgvMascotas.TabIndex = 4;
            dgvMascotas.SelectionChanged += dgvMascotas_SelectionChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtEliminarId);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Location = new Point(467, 482);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(328, 109);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar Mascota";
            // 
            // txtEliminarId
            // 
            txtEliminarId.Font = new Font("Segoe UI", 12F);
            txtEliminarId.Location = new Point(19, 48);
            txtEliminarId.Name = "txtEliminarId";
            txtEliminarId.Size = new Size(100, 29);
            txtEliminarId.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(19, 24);
            label10.Name = "label10";
            label10.Size = new Size(68, 21);
            label10.TabIndex = 22;
            label10.Text = "Mascota";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(171, 40);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(143, 42);
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
            groupBox2.Location = new Point(12, 332);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(437, 348);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modificar Mascota";
            // 
            // txtModificarID
            // 
            txtModificarID.Font = new Font("Segoe UI", 12F);
            txtModificarID.Location = new Point(96, 18);
            txtModificarID.Name = "txtModificarID";
            txtModificarID.Size = new Size(223, 29);
            txtModificarID.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(10, 210);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 12;
            label2.Text = "Cliente";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(6, 21);
            label13.Name = "label13";
            label13.Size = new Size(68, 21);
            label13.TabIndex = 24;
            label13.Text = "Mascota";
            // 
            // cmbModificarCliente
            // 
            cmbModificarCliente.Font = new Font("Segoe UI", 12F);
            cmbModificarCliente.FormattingEnabled = true;
            cmbModificarCliente.Location = new Point(96, 207);
            cmbModificarCliente.Name = "cmbModificarCliente";
            cmbModificarCliente.Size = new Size(223, 29);
            cmbModificarCliente.TabIndex = 10;
            // 
            // dtpModificarFecha
            // 
            dtpModificarFecha.Font = new Font("Segoe UI", 12F);
            dtpModificarFecha.Location = new Point(171, 252);
            dtpModificarFecha.Name = "dtpModificarFecha";
            dtpModificarFecha.Size = new Size(215, 29);
            dtpModificarFecha.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(10, 258);
            label8.Name = "label8";
            label8.Size = new Size(134, 21);
            label8.TabIndex = 22;
            label8.Text = "Fecha Nacimiento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(10, 114);
            label9.Name = "label9";
            label9.Size = new Size(43, 21);
            label9.TabIndex = 21;
            label9.Text = "Raza";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(10, 161);
            label11.Name = "label11";
            label11.Size = new Size(61, 21);
            label11.TabIndex = 20;
            label11.Text = "Especie";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(6, 69);
            label12.Name = "label12";
            label12.Size = new Size(68, 21);
            label12.TabIndex = 19;
            label12.Text = "Nombre";
            // 
            // txtModificarEspecie
            // 
            txtModificarEspecie.Font = new Font("Segoe UI", 12F);
            txtModificarEspecie.Location = new Point(96, 158);
            txtModificarEspecie.Name = "txtModificarEspecie";
            txtModificarEspecie.Size = new Size(223, 29);
            txtModificarEspecie.TabIndex = 9;
            // 
            // txtModificarNombre
            // 
            txtModificarNombre.Font = new Font("Segoe UI", 12F);
            txtModificarNombre.Location = new Point(96, 66);
            txtModificarNombre.Name = "txtModificarNombre";
            txtModificarNombre.Size = new Size(223, 29);
            txtModificarNombre.TabIndex = 7;
            // 
            // txtModificarRaza
            // 
            txtModificarRaza.Font = new Font("Segoe UI", 12F);
            txtModificarRaza.Location = new Point(96, 111);
            txtModificarRaza.Name = "txtModificarRaza";
            txtModificarRaza.Size = new Size(223, 29);
            txtModificarRaza.TabIndex = 8;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F);
            btnModificar.Location = new Point(275, 287);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(143, 42);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(437, 314);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alta Mascota";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(10, 174);
            label14.Name = "label14";
            label14.Size = new Size(58, 21);
            label14.TabIndex = 10;
            label14.Text = "Cliente";
            // 
            // cmbCliente
            // 
            cmbCliente.Font = new Font("Segoe UI", 12F);
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(96, 171);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(223, 29);
            cmbCliente.TabIndex = 3;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 12F);
            dtpFecha.Location = new Point(150, 213);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(215, 29);
            dtpFecha.TabIndex = 4;
            // 
            // txtRaza
            // 
            txtRaza.Font = new Font("Segoe UI", 12F);
            txtRaza.Location = new Point(96, 74);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(222, 29);
            txtRaza.TabIndex = 1;
            // 
            // txtEspecie
            // 
            txtEspecie.Font = new Font("Segoe UI", 12F);
            txtEspecie.Location = new Point(96, 122);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(222, 29);
            txtEspecie.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(96, 29);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(222, 29);
            txtNombre.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(10, 219);
            label4.Name = "label4";
            label4.Size = new Size(134, 21);
            label4.TabIndex = 4;
            label4.Text = "Fecha Nacimiento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(10, 77);
            label7.Name = "label7";
            label7.Size = new Size(43, 21);
            label7.TabIndex = 3;
            label7.Text = "Raza";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(10, 125);
            label6.Name = "label6";
            label6.Size = new Size(61, 21);
            label6.TabIndex = 2;
            label6.Text = "Especie";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(10, 29);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 1;
            label5.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(275, 257);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(143, 42);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 12F);
            btnSalir.Location = new Point(638, 619);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(143, 42);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmMascota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 689);
            Controls.Add(btnSalir);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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
    }
}