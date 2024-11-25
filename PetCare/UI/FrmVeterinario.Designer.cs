namespace UI
{
    partial class FrmVeterinario
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
            dgvVeterinarios = new DataGridView();
            groupBox3 = new GroupBox();
            txtEliminarID = new TextBox();
            btnEliminar = new Button();
            label10 = new Label();
            groupBox2 = new GroupBox();
            txtModificarID = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtModificarHora = new TextBox();
            txtModificarNombre = new TextBox();
            txtModificarEspecialidad = new TextBox();
            btnModificar = new Button();
            groupBox1 = new GroupBox();
            btnGuardar = new Button();
            btnBorrador = new Button();
            txtEspecialidad = new TextBox();
            txtHorario = new TextBox();
            txtApellido = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnConfirmar = new Button();
            btnCerrar = new Button();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVeterinarios).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvVeterinarios);
            groupBox4.Location = new Point(568, 65);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(731, 543);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Veterinarios";
            // 
            // dgvVeterinarios
            // 
            dgvVeterinarios.AllowUserToAddRows = false;
            dgvVeterinarios.AllowUserToDeleteRows = false;
            dgvVeterinarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVeterinarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVeterinarios.Location = new Point(6, 22);
            dgvVeterinarios.MultiSelect = false;
            dgvVeterinarios.Name = "dgvVeterinarios";
            dgvVeterinarios.ReadOnly = true;
            dgvVeterinarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVeterinarios.Size = new Size(719, 503);
            dgvVeterinarios.TabIndex = 4;
            dgvVeterinarios.SelectionChanged += dgvVeterinarios_SelectionChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtEliminarID);
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(104, 558);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(437, 124);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar Veterinario";
            // 
            // txtEliminarID
            // 
            txtEliminarID.Font = new Font("Microsoft Sans Serif", 12F);
            txtEliminarID.Location = new Point(153, 29);
            txtEliminarID.Name = "txtEliminarID";
            txtEliminarID.Size = new Size(143, 26);
            txtEliminarID.TabIndex = 11;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Microsoft Sans Serif", 12F);
            btnEliminar.Location = new Point(290, 73);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(141, 45);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(10, 29);
            label10.Name = "label10";
            label10.Size = new Size(86, 21);
            label10.TabIndex = 22;
            label10.Text = "Veterinario";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtModificarID);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtModificarHora);
            groupBox2.Controls.Add(txtModificarNombre);
            groupBox2.Controls.Add(txtModificarEspecialidad);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Location = new Point(104, 308);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(437, 244);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modificar Veterinario";
            // 
            // txtModificarID
            // 
            txtModificarID.Font = new Font("Microsoft Sans Serif", 12F);
            txtModificarID.Location = new Point(153, 22);
            txtModificarID.Name = "txtModificarID";
            txtModificarID.Size = new Size(143, 26);
            txtModificarID.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(10, 24);
            label7.Name = "label7";
            label7.Size = new Size(86, 21);
            label7.TabIndex = 22;
            label7.Text = "Veterinario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(10, 107);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 21;
            label4.Text = "Especialidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(10, 148);
            label5.Name = "label5";
            label5.Size = new Size(63, 21);
            label5.TabIndex = 20;
            label5.Text = "Horario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(10, 62);
            label6.Name = "label6";
            label6.Size = new Size(141, 21);
            label6.TabIndex = 19;
            label6.Text = "Apellido y Nombre";
            // 
            // txtModificarHora
            // 
            txtModificarHora.Font = new Font("Segoe UI", 12F);
            txtModificarHora.Location = new Point(153, 145);
            txtModificarHora.Name = "txtModificarHora";
            txtModificarHora.Size = new Size(143, 29);
            txtModificarHora.TabIndex = 9;
            // 
            // txtModificarNombre
            // 
            txtModificarNombre.Font = new Font("Segoe UI", 12F);
            txtModificarNombre.Location = new Point(153, 59);
            txtModificarNombre.Name = "txtModificarNombre";
            txtModificarNombre.Size = new Size(143, 29);
            txtModificarNombre.TabIndex = 7;
            // 
            // txtModificarEspecialidad
            // 
            txtModificarEspecialidad.Font = new Font("Segoe UI", 12F);
            txtModificarEspecialidad.Location = new Point(153, 104);
            txtModificarEspecialidad.Name = "txtModificarEspecialidad";
            txtModificarEspecialidad.Size = new Size(143, 29);
            txtModificarEspecialidad.TabIndex = 8;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F);
            btnModificar.Location = new Point(288, 196);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(143, 42);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnBorrador);
            groupBox1.Controls.Add(txtEspecialidad);
            groupBox1.Controls.Add(txtHorario);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnConfirmar);
            groupBox1.Location = new Point(104, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(437, 227);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alta Veterinario";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(301, 170);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 42);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnBorrador
            // 
            btnBorrador.Font = new Font("Segoe UI", 12F);
            btnBorrador.Location = new Point(19, 170);
            btnBorrador.Name = "btnBorrador";
            btnBorrador.Size = new Size(143, 42);
            btnBorrador.TabIndex = 3;
            btnBorrador.Text = "Agregar Borrador";
            btnBorrador.UseVisualStyleBackColor = true;
            btnBorrador.Click += btnBorrador_Click;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Font = new Font("Segoe UI", 12F);
            txtEspecialidad.Location = new Point(153, 68);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(143, 29);
            txtEspecialidad.TabIndex = 1;
            // 
            // txtHorario
            // 
            txtHorario.Font = new Font("Segoe UI", 12F);
            txtHorario.Location = new Point(153, 108);
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(143, 29);
            txtHorario.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 12F);
            txtApellido.Location = new Point(153, 26);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(143, 29);
            txtApellido.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(10, 71);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 3;
            label3.Text = "Especialidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(10, 111);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 2;
            label2.Text = "Horario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 1;
            label1.Text = "Apellido y Nombre";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Segoe UI", 12F);
            btnConfirmar.Location = new Point(168, 170);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(127, 42);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnGuardar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Microsoft Sans Serif", 12F);
            btnCerrar.Location = new Point(568, 631);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(141, 45);
            btnCerrar.TabIndex = 23;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmVeterinario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 694);
            Controls.Add(btnCerrar);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmVeterinario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Veterinario";
            WindowState = FormWindowState.Maximized;
            Load += FrmVeterinario_Load;
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVeterinarios).EndInit();
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
        private DataGridView dgvVeterinarios;
        private GroupBox groupBox3;
        private Label label10;
        private Button button3;
        private GroupBox groupBox2;
        private Label label9;
        private TextBox txtModificarHora;
        private TextBox txtModificarNombre;
        private TextBox txtModificarEspecialidad;
        private Label label8;
        private Button btnModificar;
        private GroupBox groupBox1;
        private TextBox txtEspecialidad;
        private TextBox txtHorario;
        private TextBox txtApellido;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnConfirmar;
        private Label label7;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnEliminar;
        private Button btnBorrador;
        private TextBox txtEliminarID;
        private TextBox txtModificarID;
        private Button btnGuardar;
        private Button btnCerrar;
    }
}