namespace UI
{
    partial class FrmFactura
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
            label1 = new Label();
            btnAgregar = new Button();
            dataGridView1 = new DataGridView();
            cmbProducto = new ComboBox();
            btnModificar = new Button();
            btnEliminar = new Button();
            dateFechaValidez = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            cmbCliente = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            txtCantidad = new TextBox();
            label6 = new Label();
            txtModCant = new TextBox();
            label7 = new Label();
            cmbModClie = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            cmbModProd = new ComboBox();
            txtIdMod = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtIdEliminar = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 33);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 0;
            label1.Text = "Fecha Emision";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(245, 279);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(148, 47);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Crear Factura";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(799, 444);
            dataGridView1.TabIndex = 3;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(154, 71);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(216, 29);
            cmbProducto.TabIndex = 4;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(245, 221);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(148, 55);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar Factura";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(188, 42);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(139, 48);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar Factura";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dateFechaValidez
            // 
            dateFechaValidez.Location = new Point(154, 27);
            dateFechaValidez.Margin = new Padding(3, 2, 3, 2);
            dateFechaValidez.Name = "dateFechaValidez";
            dateFechaValidez.Size = new Size(216, 29);
            dateFechaValidez.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 74);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 8;
            label2.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 121);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 9;
            label3.Text = "Cliente";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(154, 118);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(216, 29);
            cmbCliente.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 234);
            label4.Name = "label4";
            label4.Size = new Size(45, 21);
            label4.TabIndex = 11;
            label4.Text = "Total:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 170);
            label5.Name = "label5";
            label5.Size = new Size(72, 21);
            label5.TabIndex = 12;
            label5.Text = "Cantidad";
            label5.Click += label5_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(154, 167);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(216, 29);
            txtCantidad.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(223, 221);
            label6.Name = "label6";
            label6.Size = new Size(61, 37);
            label6.TabIndex = 14;
            label6.Text = "----";
            label6.Click += label6_Click;
            // 
            // txtModCant
            // 
            txtModCant.Location = new Point(154, 168);
            txtModCant.Name = "txtModCant";
            txtModCant.Size = new Size(216, 29);
            txtModCant.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 171);
            label7.Name = "label7";
            label7.Size = new Size(72, 21);
            label7.TabIndex = 19;
            label7.Text = "Cantidad";
            // 
            // cmbModClie
            // 
            cmbModClie.FormattingEnabled = true;
            cmbModClie.Location = new Point(154, 130);
            cmbModClie.Name = "cmbModClie";
            cmbModClie.Size = new Size(216, 29);
            cmbModClie.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 133);
            label8.Name = "label8";
            label8.Size = new Size(58, 21);
            label8.TabIndex = 17;
            label8.Text = "Cliente";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 86);
            label9.Name = "label9";
            label9.Size = new Size(73, 21);
            label9.TabIndex = 16;
            label9.Text = "Producto";
            // 
            // cmbModProd
            // 
            cmbModProd.FormattingEnabled = true;
            cmbModProd.Location = new Point(154, 83);
            cmbModProd.Name = "cmbModProd";
            cmbModProd.Size = new Size(216, 29);
            cmbModProd.TabIndex = 15;
            // 
            // txtIdMod
            // 
            txtIdMod.Location = new Point(154, 39);
            txtIdMod.Name = "txtIdMod";
            txtIdMod.Size = new Size(216, 29);
            txtIdMod.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 42);
            label10.Name = "label10";
            label10.Size = new Size(134, 21);
            label10.TabIndex = 22;
            label10.Text = "Id Fac. a Modificar";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 34);
            label11.Name = "label11";
            label11.Size = new Size(153, 21);
            label11.TabIndex = 24;
            label11.Text = "Id Factura a Eliminar.";
            // 
            // txtIdEliminar
            // 
            txtIdEliminar.Location = new Point(20, 61);
            txtIdEliminar.Name = "txtIdEliminar";
            txtIdEliminar.Size = new Size(139, 29);
            txtIdEliminar.TabIndex = 23;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(560, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(811, 472);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Facturas";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(cmbProducto);
            groupBox2.Controls.Add(dateFechaValidez);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cmbCliente);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtCantidad);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(123, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(408, 338);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cargar factura";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtModCant);
            groupBox3.Controls.Add(btnModificar);
            groupBox3.Controls.Add(cmbModProd);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(cmbModClie);
            groupBox3.Controls.Add(txtIdMod);
            groupBox3.Controls.Add(label7);
            groupBox3.Font = new Font("Segoe UI", 12F);
            groupBox3.Location = new Point(123, 453);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(408, 293);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            groupBox3.Text = "Editar factura";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnEliminar);
            groupBox4.Controls.Add(txtIdEliminar);
            groupBox4.Controls.Add(label11);
            groupBox4.Font = new Font("Segoe UI", 12F);
            groupBox4.Location = new Point(123, 752);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(408, 112);
            groupBox4.TabIndex = 28;
            groupBox4.TabStop = false;
            groupBox4.Text = "Eliminar factura";
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 12F);
            btnCerrar.Location = new Point(560, 802);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(141, 48);
            btnCerrar.TabIndex = 25;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 825);
            Controls.Add(btnCerrar);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmFactura";
            Text = "Factura";
            WindowState = FormWindowState.Maximized;
            Load += FrmFactura_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnAgregar;
        private DataGridView dataGridView1;
        private ComboBox cmbProducto;
        private Button btnModificar;
        private Button btnEliminar;
        private DateTimePicker dateFechaValidez;
        private Label label2;
        private Label label3;
        private ComboBox cmbCliente;
        private Label label4;
        private Label label5;
        private TextBox txtCantidad;
        private Label label6;
        private TextBox txtModCant;
        private Label label7;
        private ComboBox cmbModClie;
        private Label label8;
        private Label label9;
        private ComboBox cmbModProd;
        private TextBox txtIdMod;
        private Label label10;
        private Label label11;
        private TextBox txtIdEliminar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btnCerrar;
    }
}