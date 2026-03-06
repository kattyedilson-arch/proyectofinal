using Supermercado.DataAccess;
using Supermercado.Models;
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
    public partial class FormVentas : Form
    {
        private VentaDAO dao = new VentaDAO();
        public FormVentas()
        {
            InitializeComponent();
            CargarVentas();
        }
        private void CargarVentas()
        {
            dataGridView1.DataSource = dao.GetAll();
        }
       

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Venta v = new Venta
            {
                Fecha = dateTimePickerFecha.Value,
                Cliente = txtClienteID.Text,
                Empleado = txtEmpleadoID.Text,
                Total = decimal.Parse(txtTotal.Text)
            };
            dao.Insert(v);
            CargarVentas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Venta v = new Venta
            {
                VentaID = int.Parse(txtVentaID.Text),
                Fecha = dateTimePickerFecha.Value,
                Cliente = txtClienteID.Text,
                Empleado = txtEmpleadoID.Text,
                Total = decimal.Parse(txtTotal.Text)
            };
            dao.Update(v);
            CargarVentas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtVentaID.Text);
            dao.Delete(id);
            CargarVentas();
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
                txtVentaID.Text = fila.Cells["VentaID"].Value.ToString();
                dateTimePickerFecha.Value = Convert.ToDateTime(fila.Cells["Fecha"].Value);
                txtClienteID.Text = fila.Cells["Cliente"].Value.ToString();
                txtEmpleadoID.Text = fila.Cells["Empleado"].Value.ToString();
                txtTotal.Text = fila.Cells["Total"].Value.ToString();
            }
        }
    }
}
