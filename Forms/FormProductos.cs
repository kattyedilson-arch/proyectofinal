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
    public partial class FormProductos : Form
    {
        ProductoDAO dao = new ProductoDAO();
        ProveedorDAO proveedorDAO = new ProveedorDAO();

        public FormProductos()
        {
            InitializeComponent();
            CargarProductos();
            CargarProveedores();
        }


        private void CargarProductos()
        {
            dataGridView1.DataSource = dao.GetAll();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dao.Insert(txtNombre.Text, txtCategoria.Text, decimal.Parse(txtPrecio.Text), int.Parse(txtStock.Text), int.Parse(cmbProveedores.SelectedValue.ToString()));
            CargarProductos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductoID.Text);
            dao.Update(id, txtNombre.Text, txtCategoria.Text, decimal.Parse(txtPrecio.Text), int.Parse(txtStock.Text), int.Parse(cmbProveedores.SelectedValue.ToString()));
            CargarProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductoID.Text);
            dao.Delete(id);
            CargarProductos();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Validar que no sea encabezado
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                txtProductoID.Text = fila.Cells["ProductoID"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtCategoria.Text = fila.Cells["Categoria"].Value.ToString();
                txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                txtStock.Text = fila.Cells["Stock"].Value.ToString();
                cmbProveedores.SelectedValue = int.Parse(fila.Cells["ProveedorID"].Value.ToString());
            }
        }
        private void CargarProveedores()
        {
            cmbProveedores.DataSource = proveedorDAO.GetAll();
            cmbProveedores.DisplayMember = "Nombre";
            cmbProveedores.ValueMember = "ProveedorID";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cmbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
