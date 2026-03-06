namespace Supermercado.Forms
{
    partial class FormVentas
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
            txtVentaID = new TextBox();
            txtClienteID = new TextBox();
            txtTotal = new TextBox();
            txtEmpleadoID = new TextBox();
            dateTimePickerFecha = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(657, 195);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtVentaID
            // 
            txtVentaID.Location = new Point(146, 213);
            txtVentaID.Name = "txtVentaID";
            txtVentaID.Size = new Size(208, 23);
            txtVentaID.TabIndex = 1;
            // 
            // txtClienteID
            // 
            txtClienteID.Location = new Point(146, 242);
            txtClienteID.Name = "txtClienteID";
            txtClienteID.Size = new Size(208, 23);
            txtClienteID.TabIndex = 2;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(146, 300);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(208, 23);
            txtTotal.TabIndex = 4;
            // 
            // txtEmpleadoID
            // 
            txtEmpleadoID.Location = new Point(146, 271);
            txtEmpleadoID.Name = "txtEmpleadoID";
            txtEmpleadoID.Size = new Size(208, 23);
            txtEmpleadoID.TabIndex = 5;
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Location = new Point(146, 329);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(208, 23);
            dateTimePickerFecha.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 216);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 7;
            label1.Text = "VentaID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 250);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 8;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 308);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 9;
            label3.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 279);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 10;
            label4.Text = "Empleado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 337);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 11;
            label5.Text = "Fecha_de_Venta";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(558, 222);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(558, 261);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(558, 304);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(300, 384);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(211, 27);
            btnVolver.TabIndex = 15;
            btnVolver.Text = "&Cerrar";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePickerFecha);
            Controls.Add(txtEmpleadoID);
            Controls.Add(txtTotal);
            Controls.Add(txtClienteID);
            Controls.Add(txtVentaID);
            Controls.Add(dataGridView1);
            Name = "FormVentas";
            Text = "FormVentas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtVentaID;
        private TextBox txtClienteID;
        private TextBox txtTotal;
        private TextBox txtEmpleadoID;
        private DateTimePicker dateTimePickerFecha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnVolver;
    }
}