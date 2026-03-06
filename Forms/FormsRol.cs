using GranBodega.DataAccess;
using GranBodega.Models;
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
    public partial class FormsRol : Form
    {
        private RolesDAO dao = new RolesDAO();
        public FormsRol()
        {
            InitializeComponent();
            CargarRoles();
        }

        private void CargarRoles()
        {
            dataGridView1.DataSource = dao.GetAll();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Roles r = new Roles
            {
                RolID = int.Parse(txtRolID.Text),
                Rol = txtRol.Text
            };
            dao.Update(r);
            CargarRoles();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Roles r = new Roles
            {
                Rol = txtRol.Text
            };
            dao.Insert(r);
            CargarRoles();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtRolID.Text);
            dao.Delete(id);
            CargarRoles();
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
                txtRolID.Text = fila.Cells["RolID"].Value.ToString();
                txtRol.Text = fila.Cells["Rol"].Value.ToString();
            }
        }
    }
}
