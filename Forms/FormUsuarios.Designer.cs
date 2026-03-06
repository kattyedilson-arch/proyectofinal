namespace Supermercado.Forms
{
    partial class FormUsuarios
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
            txtUsuarioID = new TextBox();
            txtNombre = new TextBox();
            txtClave = new TextBox();
            txtUsuario = new TextBox();
            btnEliminar = new Button();
            btnAgregar = new Button();
            btnEditar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnVolver = new Button();
            cmbRoles = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(47, 14);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(635, 170);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtUsuarioID
            // 
            txtUsuarioID.Enabled = false;
            txtUsuarioID.Location = new Point(114, 199);
            txtUsuarioID.Name = "txtUsuarioID";
            txtUsuarioID.ReadOnly = true;
            txtUsuarioID.Size = new Size(215, 23);
            txtUsuarioID.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(114, 228);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(215, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(114, 286);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(215, 23);
            txtClave.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(114, 256);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(215, 23);
            txtUsuario.TabIndex = 4;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(502, 311);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(88, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(502, 224);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(88, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(502, 271);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(88, 23);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 201);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 9;
            label1.Text = "UsuarioID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 236);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 10;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 264);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 11;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 294);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 12;
            label4.Text = "Clave";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 323);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 13;
            label5.Text = "Rol";
            label5.Click += label5_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(269, 387);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(226, 28);
            btnVolver.TabIndex = 14;
            btnVolver.Text = "&Cerrar";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // cmbRoles
            // 
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(114, 323);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(215, 23);
            cmbRoles.TabIndex = 15;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbRoles);
            Controls.Add(btnVolver);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(txtUsuario);
            Controls.Add(txtClave);
            Controls.Add(txtNombre);
            Controls.Add(txtUsuarioID);
            Controls.Add(dataGridView1);
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtUsuarioID;
        private TextBox txtNombre;
        private TextBox txtClave;
        private TextBox txtUsuario;
        private Button btnEliminar;
        private Button btnAgregar;
        private Button btnEditar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnVolver;
        private ComboBox cmbRoles;
    }
}