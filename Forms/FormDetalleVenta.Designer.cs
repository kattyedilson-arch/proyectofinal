namespace Supermercado.Forms
{
    partial class FormDetalleVenta
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
            dataGridView1 = new DataGridView();
            txtPrecioUnitario = new TextBox();
            txtCliente = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnVolver = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbProducto = new ComboBox();
            txtTotal = new TextBox();
            txtCantidad = new NumericUpDown();
            label6 = new Label();
            txtDetalleID = new TextBox();
            txtVentaID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(59, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(701, 164);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(151, 259);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.ReadOnly = true;
            txtPrecioUnitario.Size = new Size(213, 23);
            txtPrecioUnitario.TabIndex = 3;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(151, 288);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(213, 23);
            txtCliente.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(551, 201);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(551, 259);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(551, 317);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(227, 415);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(296, 23);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "&Cerrar";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 204);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 10;
            label1.Text = "ProductoID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 238);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 11;
            label2.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 267);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 12;
            label3.Text = "PrecioUnitario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 296);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 13;
            label4.Text = "Cliente";
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(151, 201);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(213, 23);
            cmbProducto.TabIndex = 15;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(151, 318);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(213, 23);
            txtTotal.TabIndex = 16;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(151, 230);
            txtCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(158, 23);
            txtCantidad.TabIndex = 17;
            txtCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            txtCantidad.ValueChanged += txtCantidad_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 326);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 18;
            label6.Text = "Total";
            // 
            // txtDetalleID
            // 
            txtDetalleID.Location = new Point(459, 201);
            txtDetalleID.Name = "txtDetalleID";
            txtDetalleID.Size = new Size(25, 23);
            txtDetalleID.TabIndex = 21;
            txtDetalleID.Visible = false;
            // 
            // txtVentaID
            // 
            txtVentaID.Location = new Point(459, 235);
            txtVentaID.Name = "txtVentaID";
            txtVentaID.Size = new Size(25, 23);
            txtVentaID.TabIndex = 22;
            txtVentaID.Visible = false;
            // 
            // FormDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtVentaID);
            Controls.Add(txtDetalleID);
            Controls.Add(label6);
            Controls.Add(txtCantidad);
            Controls.Add(txtTotal);
            Controls.Add(cmbProducto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(txtCliente);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(dataGridView1);
            Name = "FormDetalleVenta";
            Text = "FormDetalleVenta";
            FormClosed += FormDetalleVenta_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtPrecioUnitario;
        private TextBox txtCliente;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnVolver;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbProducto;
        private TextBox txtTotal;
        private NumericUpDown txtCantidad;
        private Label label6;
        private TextBox txtDetalleID;
        private TextBox txtVentaID;
    }
}