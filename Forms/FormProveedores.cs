using Supermercado.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermercado
{
    public partial class FormProveedores : Form
    {
        ProveedorDAO dao = new ProveedorDAO();
        public FormProveedores()
        {
            InitializeComponent();
            CargarProveedores();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void CargarProveedores()
        {
            dataGridView1.DataSource = dao.GetAll();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dao.Insert(txtNombre.Text, txtTelefono.Text, txtEmail.Text, txtDireccion.Text); CargarProveedores();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProveedorID.Text);
            dao.Update(id, txtNombre.Text, txtTelefono.Text, txtEmail.Text, txtDireccion.Text);
            CargarProveedores();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProveedorID.Text);
            dao.Delete(id);
            CargarProveedores();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                txtProveedorID.Text = fila.Cells["ProveedorID"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                txtEmail.Text = fila.Cells["Email"].Value.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();
            }
        }

        private void txtProveedorID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}
