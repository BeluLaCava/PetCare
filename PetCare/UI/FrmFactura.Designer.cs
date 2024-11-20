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
            txtTotal = new TextBox();
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
            // txtTotal
            // 
            txtTotal.Location = new Point(23, 217);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(121, 23);
            txtTotal.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(23, 328);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Crear Factura";
            btnAgregar.UseVisualStyleBackColor = true;
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
            btnModificar.Location = new Point(23, 357);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 23);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar Factura";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(23, 386);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar Factura";
            btnEliminar.UseVisualStyleBackColor = true;
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
            label4.Location = new Point(23, 199);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 11;
            label4.Text = "Total";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 253);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 12;
            label5.Text = "Cantidad";
            label5.Click += label5_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(23, 271);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(121, 23);
            txtCantidad.TabIndex = 13;
            // 
            // FrmFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(txtTotal);
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
        private TextBox txtTotal;
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
    }
}