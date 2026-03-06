using GranBodega.DataAccess;
using GranBodega.Models;
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

namespace Supermercado.Forms
{
    public partial class FormUsuarios : Form
    {
        private UsuarioDAO dao = new UsuarioDAO();
        private RolesDAO rolDAO = new RolesDAO();

        public FormUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();
            CargarRoles();
        }
        private void CargarRoles()
        {
            cmbRoles.DataSource = rolDAO.GetAll();
            cmbRoles.DisplayMember = "Rol";
            cmbRoles.ValueMember = "RolID";
        }
        private void CargarUsuarios()
        {
            dataGridView1.DataSource = dao.GetAll();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUsuarioID.Text);
            dao.Delete(id);
            CargarUsuarios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario
            {
                Nombre = txtNombre.Text,
                UsuarioLogin = txtUsuario.Text,
                Clave = txtClave.Text,
                RolID = int.Parse(cmbRoles.SelectedValue.ToString()),
            };
            dao.Insert(u);
            CargarUsuarios();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario
            {
                UsuarioID = int.Parse(txtUsuarioID.Text),
                Nombre = txtNombre.Text,
                UsuarioLogin = txtUsuario.Text,
                Clave = txtClave.Text,
                RolID = int.Parse(cmbRoles.SelectedValue.ToString()),
            };
            dao.Update(u);
            CargarUsuarios();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                txtUsuarioID.Text = fila.Cells["UsuarioID"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtUsuario.Text = fila.Cells["Usuario"].Value.ToString();
                txtClave.Text = fila.Cells["Clave"].Value.ToString();
                cmbRoles.SelectedValue = int.Parse(fila.Cells["RolID"].Value.ToString());
            }
        }
    }
}
