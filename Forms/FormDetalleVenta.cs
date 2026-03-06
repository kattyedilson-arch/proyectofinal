using Farmacia;
using GranBodega.DataAccess;
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
    public partial class FormDetalleVenta : Form
    {
        public string rolID = "1";
        private DetalleVentaDAO dao = new DetalleVentaDAO();
        private ProductoDAO productoDAO = new ProductoDAO();
        private VentaDAO ventaDAO = new VentaDAO();

        public FormDetalleVenta()
        {
            InitializeComponent();
            CargarDetalleVentas();
            CargarProductos();
        }
        private void CargarDetalleVentas()
        {
            dataGridView1.DataSource = dao.GetAll();
        }
        private void CargarProductos()
        {
            DataTable productos = productoDAO.GetAll(); // tu método que trae ProductoID y NombreProducto
            cmbProducto.DataSource = productos;
            cmbProducto.DisplayMember = "Nombre";  // lo que se muestra al usuario
            cmbProducto.ValueMember = "ProductoID";        // el valor interno que se guarda
        }
        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedValue != null && cmbProducto.SelectedValue is int)
            {
                int productoID = (int)cmbProducto.SelectedValue;
                decimal precio = productoDAO.ObtenerPrecio(productoID);
                txtPrecioUnitario.Text = precio.ToString("0.00");
                CalcularTotal();
            }
        }

        private void txtCantidad_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }
        private void CalcularTotal()
        {
            if (decimal.TryParse(txtPrecioUnitario.Text, out decimal precio) &&
            int.TryParse(txtCantidad.Text, out int cantidad))
            {
                txtTotal.Text = (precio * cantidad).ToString("0.00");
            }
            else
            {
                txtTotal.Text = "0.00";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Venta v = new Venta
            {
                Fecha = DateTime.Now,
                Cliente = txtCliente.Text,
                Empleado = "Hernán",
                Total = decimal.Parse(txtTotal.Text)
            };

            int ventaID = ventaDAO.Insert(v);
            if (ventaID < 0)
            {
                MessageBox.Show("Ingrese un número válido en VentaID");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Ingrese una cantidad válida");
                return;
            }

            if (!decimal.TryParse(txtPrecioUnitario.Text, out decimal precioUnitario))
            {
                MessageBox.Show("Ingrese un precio válido");
                return;
            }

            DetalleVenta d = new DetalleVenta
            {
                VentaID = ventaID,
                ProductoID = Convert.ToInt32(cmbProducto.SelectedValue),
                Cantidad = cantidad,
                PrecioUnitario = precioUnitario
            };

            dao.Insert(d);
            productoDAO.AumentarStock(d.ProductoID, d.Cantidad);
            CargarDetalleVentas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DetalleVenta d = new DetalleVenta
            {
                DetalleID = int.Parse(txtDetalleID.Text),
                VentaID = int.Parse(txtVentaID.Text),
                ProductoID = int.Parse(cmbProducto.SelectedValue.ToString()),
                Cantidad = int.Parse(txtCantidad.Text),
                PrecioUnitario = decimal.Parse(txtPrecioUnitario.Text)
            };
            dao.Update(d);
            CargarDetalleVentas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDetalleID.Text);
            dao.Delete(id);
            CargarDetalleVentas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                txtDetalleID.Text = fila.Cells["DetalleID"].Value.ToString();
                txtVentaID.Text = fila.Cells["VentaID"].Value.ToString();
                cmbProducto.SelectedValue = int.Parse(fila.Cells["ProductoID"].Value.ToString());
                txtCantidad.Text = fila.Cells["Cantidad"].Value.ToString();
                txtPrecioUnitario.Text = fila.Cells["PrecioUnitario"].Value.ToString();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDetalleVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (rolID != "1")
                Application.Exit();
        }
    }
}
