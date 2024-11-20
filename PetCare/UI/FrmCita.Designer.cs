namespace UI
{
    partial class FrmCita
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
            Clientes = new GroupBox();
            dgvCitas = new DataGridView();
            groupBox3 = new GroupBox();
            txtEliminarCita = new TextBox();
            btnEliminarCita = new Button();
            label10 = new Label();
            groupBox2 = new GroupBox();
            dtpModificarHora = new DateTimePicker();
            txtCita = new TextBox();
            dtpModificarFecha = new DateTimePicker();
            label8 = new Label();
            cmbModificarVeterinario = new ComboBox();
            label6 = new Label();
            cmbModificarMascota = new ComboBox();
            label9 = new Label();
            label5 = new Label();
            label7 = new Label();
            btnModificar = new Button();
            groupBox1 = new GroupBox();
            btnConfirmar = new Button();
            btnBorrador = new Button();
            dtpHora = new DateTimePicker();
            dtpFecha = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            cmbVeterinario = new ComboBox();
            cmbMascota = new ComboBox();
            label4 = new Label();
            btnGuardar = new Button();
            btnSalir = new Button();
            Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Clientes
            // 
            Clientes.Controls.Add(dgvCitas);
            Clientes.Location = new Point(613, 59);
            Clientes.Name = "Clientes";
            Clientes.Size = new Size(816, 591);
            Clientes.TabIndex = 9;
            Clientes.TabStop = false;
            Clientes.Text = "Citas";
            // 
            // dgvCitas
            // 
            dgvCitas.AllowUserToAddRows = false;
            dgvCitas.AllowUserToDeleteRows = false;
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new Point(6, 22);
            dgvCitas.MultiSelect = false;
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCitas.Size = new Size(804, 557);
            dgvCitas.TabIndex = 0;
            dgvCitas.SelectionChanged += dgvCitas_SelectionChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtEliminarCita);
            groupBox3.Controls.Add(btnEliminarCita);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(119, 656);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(465, 109);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar Cita";
            // 
            // txtEliminarCita
            // 
            txtEliminarCita.Font = new Font("Segoe UI", 12F);
            txtEliminarCita.Location = new Point(101, 50);
            txtEliminarCita.Name = "txtEliminarCita";
            txtEliminarCita.Size = new Size(198, 29);
            txtEliminarCita.TabIndex = 26;
            // 
            // btnEliminarCita
            // 
            btnEliminarCita.Font = new Font("Segoe UI", 12F);
            btnEliminarCita.Location = new Point(306, 41);
            btnEliminarCita.Name = "btnEliminarCita";
            btnEliminarCita.Size = new Size(139, 44);
            btnEliminarCita.TabIndex = 24;
            btnEliminarCita.Text = "Eliminar";
            btnEliminarCita.UseVisualStyleBackColor = true;
            btnEliminarCita.Click += btnEliminarCita_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(21, 53);
            label10.Name = "label10";
            label10.Size = new Size(37, 21);
            label10.TabIndex = 22;
            label10.Text = "Cita";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpModificarHora);
            groupBox2.Controls.Add(txtCita);
            groupBox2.Controls.Add(dtpModificarFecha);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(cmbModificarVeterinario);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cmbModificarMascota);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Location = new Point(119, 349);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(465, 301);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modificar Cita";
            // 
            // dtpModificarHora
            // 
            dtpModificarHora.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpModificarHora.Font = new Font("Segoe UI", 12F);
            dtpModificarHora.Format = DateTimePickerFormat.Time;
            dtpModificarHora.Location = new Point(101, 156);
            dtpModificarHora.MinDate = new DateTime(2024, 11, 18, 0, 0, 0, 0);
            dtpModificarHora.Name = "dtpModificarHora";
            dtpModificarHora.Size = new Size(198, 29);
            dtpModificarHora.TabIndex = 19;
            // 
            // txtCita
            // 
            txtCita.Font = new Font("Segoe UI", 12F);
            txtCita.Location = new Point(101, 29);
            txtCita.Name = "txtCita";
            txtCita.Size = new Size(198, 29);
            txtCita.TabIndex = 25;
            // 
            // dtpModificarFecha
            // 
            dtpModificarFecha.Font = new Font("Segoe UI", 12F);
            dtpModificarFecha.Location = new Point(101, 202);
            dtpModificarFecha.Name = "dtpModificarFecha";
            dtpModificarFecha.Size = new Size(198, 29);
            dtpModificarFecha.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(8, 120);
            label8.Name = "label8";
            label8.Size = new Size(86, 21);
            label8.TabIndex = 23;
            label8.Text = "Veterinario";
            // 
            // cmbModificarVeterinario
            // 
            cmbModificarVeterinario.Font = new Font("Segoe UI", 12F);
            cmbModificarVeterinario.FormattingEnabled = true;
            cmbModificarVeterinario.Location = new Point(101, 117);
            cmbModificarVeterinario.Name = "cmbModificarVeterinario";
            cmbModificarVeterinario.Size = new Size(198, 29);
            cmbModificarVeterinario.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(8, 83);
            label6.Name = "label6";
            label6.Size = new Size(68, 21);
            label6.TabIndex = 21;
            label6.Text = "Mascota";
            // 
            // cmbModificarMascota
            // 
            cmbModificarMascota.Font = new Font("Segoe UI", 12F);
            cmbModificarMascota.FormattingEnabled = true;
            cmbModificarMascota.Location = new Point(101, 75);
            cmbModificarMascota.Name = "cmbModificarMascota";
            cmbModificarMascota.Size = new Size(198, 29);
            cmbModificarMascota.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(6, 32);
            label9.Name = "label9";
            label9.Size = new Size(37, 21);
            label9.TabIndex = 19;
            label9.Text = "Cita";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(8, 158);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 13;
            label5.Text = "Hora";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(8, 210);
            label7.Name = "label7";
            label7.Size = new Size(50, 21);
            label7.TabIndex = 11;
            label7.Text = "Fecha";
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F);
            btnModificar.Location = new Point(306, 253);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(143, 42);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConfirmar);
            groupBox1.Controls.Add(btnBorrador);
            groupBox1.Controls.Add(dtpHora);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbVeterinario);
            groupBox1.Controls.Add(cmbMascota);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Location = new Point(119, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 274);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alta Cita";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Segoe UI", 12F);
            btnConfirmar.Location = new Point(157, 211);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(143, 42);
            btnConfirmar.TabIndex = 20;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnBorrador
            // 
            btnBorrador.Font = new Font("Segoe UI", 12F);
            btnBorrador.Location = new Point(8, 211);
            btnBorrador.Name = "btnBorrador";
            btnBorrador.Size = new Size(143, 42);
            btnBorrador.TabIndex = 19;
            btnBorrador.Text = "Agregar Borrador";
            btnBorrador.UseVisualStyleBackColor = true;
            btnBorrador.Click += btnBorrador_Click;
            // 
            // dtpHora
            // 
            dtpHora.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpHora.Font = new Font("Segoe UI", 12F);
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(101, 109);
            dtpHora.MinDate = new DateTime(2024, 11, 18, 0, 0, 0, 0);
            dtpHora.Name = "dtpHora";
            dtpHora.Size = new Size(198, 29);
            dtpHora.TabIndex = 18;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 12F);
            dtpFecha.Location = new Point(101, 151);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(198, 29);
            dtpFecha.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(8, 157);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 14;
            label2.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(6, 69);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 12;
            label3.Text = "Veterinario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(8, 22);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 11;
            label1.Text = "Mascota";
            // 
            // cmbVeterinario
            // 
            cmbVeterinario.Font = new Font("Segoe UI", 12F);
            cmbVeterinario.FormattingEnabled = true;
            cmbVeterinario.Location = new Point(101, 66);
            cmbVeterinario.Name = "cmbVeterinario";
            cmbVeterinario.Size = new Size(198, 29);
            cmbVeterinario.TabIndex = 10;
            // 
            // cmbMascota
            // 
            cmbMascota.Font = new Font("Segoe UI", 12F);
            cmbMascota.FormattingEnabled = true;
            cmbMascota.Location = new Point(101, 19);
            cmbMascota.Name = "cmbMascota";
            cmbMascota.Size = new Size(198, 29);
            cmbMascota.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(8, 109);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 4;
            label4.Text = "Hora";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(306, 211);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(143, 42);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 12F);
            btnSalir.Location = new Point(633, 697);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(139, 44);
            btnSalir.TabIndex = 27;
            btnSalir.Text = "Cerrar";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmCita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1461, 766);
            Controls.Add(btnSalir);
            Controls.Add(Clientes);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmCita";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cita";
            WindowState = FormWindowState.Maximized;
            Load += FrmCita_Load;
            Clientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Clientes;
        private DataGridView dgvClientes;
        private GroupBox groupBox3;
        private Label label10;
        private ComboBox cmbEliminar;
        private Button button3;
        private GroupBox groupBox2;
        private Label label9;
        private TextBox txtModificarEmail;
        private Label label5;
        private Label label7;
        private Button btnModificar;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label1;
        private ComboBox cmbVeterinario;
        private ComboBox cmbMascota;
        private TextBox txtHora;
        private Label label4;
        private Button btnGuardar;
        private Label label8;
        private ComboBox cmbModificarVeterinario;
        private Label label6;
        private ComboBox cmbModificarMascota;
        private DateTimePicker dtpModificarFecha;
        private Button btnEliminarCita;
        private DataGridView dgvCitas;
        private TextBox txtEliminarCita;
        private TextBox txtCita;
        private DateTimePicker dtpFecha;
        private Button btnSalir;
        private DateTimePicker dtpHora;
        private DateTimePicker dtpModificarHora;
        private Button btnConfirmar;
        private Button btnBorrador;
    }
}