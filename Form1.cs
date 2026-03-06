using Farmacia;
using Supermercado.Forms;

namespace Supermercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos();
            formProductos.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProveedores formProveedores = new FormProveedores();
            formProveedores.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuarios formUsuarios = new FormUsuarios();
            formUsuarios.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVentas formVentas = new FormVentas();
            formVentas.ShowDialog();
        }

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsRol formsRol = new FormsRol();
            formsRol.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            FLogin flogin = new FLogin();
            flogin.ShowDialog();
            if (!flogin.autorizado)
            {
                this.Close();
            }
        }

        private void parametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void detallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDetalleVenta formDetalleVenta = new FormDetalleVenta();
            formDetalleVenta.ShowDialog();
        }
    }
}
