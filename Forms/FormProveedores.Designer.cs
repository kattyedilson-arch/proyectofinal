namespace Supermercado
{
    partial class FormProveedores
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
            txtProveedorID = new TextBox();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtDireccion = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnRefrescar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(854, 180);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // txtProveedorID
            // 
            txtProveedorID.Location = new Point(527, 215);
            txtProveedorID.Name = "txtProveedorID";
            txtProveedorID.Size = new Size(100, 23);
            txtProveedorID.TabIndex = 1;
            txtProveedorID.Visible = false;
            txtProveedorID.TextChanged += txtProveedorID_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(174, 215);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(129, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(174, 270);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(129, 23);
            txtTelefono.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(174, 331);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(129, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(174, 388);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(129, 23);
            txtDireccion.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(131, 470);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(101, 32);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(282, 470);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(102, 32);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(440, 470);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(96, 32);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(580, 470);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(94, 32);
            btnRefrescar.TabIndex = 9;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 223);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 10;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 278);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 11;
            label2.Text = "Telefono";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 339);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 12;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 391);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 13;
            label4.Text = "Direccion";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(282, 515);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(254, 26);
            btnVolver.TabIndex = 14;
            btnVolver.Text = "&Cerrar";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 564);
            Controls.Add(btnVolver);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRefrescar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(txtDireccion);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(txtProveedorID);
            Controls.Add(dataGridView1);
            Name = "FormProveedores";
            Text = "FormProveedores";
            Load += FormProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtProveedorID;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtDireccion;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnRefrescar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnVolver;
    }
}