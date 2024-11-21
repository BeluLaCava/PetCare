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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 33);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha Emision";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 309);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Crear Factura";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(286, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(502, 243);
            dataGridView1.TabIndex = 3;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(23, 105);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(121, 23);
            cmbProducto.TabIndex = 4;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(330, 337);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 23);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar Factura";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(619, 337);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar Factura";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dateFechaValidez
            // 
            dateFechaValidez.Location = new Point(23, 50);
            dateFechaValidez.Margin = new Padding(3, 2, 3, 2);
            dateFechaValidez.Name = "dateFechaValidez";
            dateFechaValidez.Size = new Size(216, 23);
            dateFechaValidez.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 87);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 8;
            label2.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 140);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 9;
            label3.Text = "Cliente";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(23, 158);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(121, 23);
            cmbCliente.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 270);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 11;
            label4.Text = "Total:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 203);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 12;
            label5.Text = "Cantidad";
            label5.Click += label5_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(23, 221);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(121, 23);
            txtCantidad.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(71, 270);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 14;
            label6.Text = "----";
            label6.Click += label6_Click;
            // 
            // txtModCant
            // 
            txtModCant.Location = new Point(424, 455);
            txtModCant.Name = "txtModCant";
            txtModCant.Size = new Size(121, 23);
            txtModCant.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(424, 437);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 19;
            label7.Text = "Cantidad";
            // 
            // cmbModClie
            // 
            cmbModClie.FormattingEnabled = true;
            cmbModClie.Location = new Point(286, 455);
            cmbModClie.Name = "cmbModClie";
            cmbModClie.Size = new Size(121, 23);
            cmbModClie.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(286, 437);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 17;
            label8.Text = "Cliente";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(424, 377);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 16;
            label9.Text = "Producto";
            // 
            // cmbModProd
            // 
            cmbModProd.FormattingEnabled = true;
            cmbModProd.Location = new Point(424, 395);
            cmbModProd.Name = "cmbModProd";
            cmbModProd.Size = new Size(121, 23);
            cmbModProd.TabIndex = 15;
            // 
            // txtIdMod
            // 
            txtIdMod.Location = new Point(286, 395);
            txtIdMod.Name = "txtIdMod";
            txtIdMod.Size = new Size(121, 23);
            txtIdMod.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(286, 377);
            label10.Name = "label10";
            label10.Size = new Size(104, 15);
            label10.TabIndex = 22;
            label10.Text = "Id Fac. a Modificar";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(634, 377);
            label11.Name = "label11";
            label11.Size = new Size(117, 15);
            label11.TabIndex = 24;
            label11.Text = "Id Factura a Eliminar.";
            // 
            // txtIdEliminar
            // 
            txtIdEliminar.Location = new Point(634, 395);
            txtIdEliminar.Name = "txtIdEliminar";
            txtIdEliminar.Size = new Size(121, 23);
            txtIdEliminar.TabIndex = 23;
            // 
            // FrmFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 603);
            Controls.Add(label11);
            Controls.Add(txtIdEliminar);
            Controls.Add(label10);
            Controls.Add(txtIdMod);
            Controls.Add(txtModCant);
            Controls.Add(label7);
            Controls.Add(cmbModClie);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(cmbModProd);
            Controls.Add(label6);
            Controls.Add(txtCantidad);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cmbCliente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateFechaValidez);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(cmbProducto);
            Controls.Add(dataGridView1);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Name = "FrmFactura";
            Text = "Factura";
            WindowState = FormWindowState.Maximized;
            Load += FrmFactura_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}