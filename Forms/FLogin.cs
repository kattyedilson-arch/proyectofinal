using GranBodega.DataAccess;
using Supermercado.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class FLogin : Form
    {
        public bool autorizado = false;
        UsuarioDAO usuarioDAO = new UsuarioDAO();

        public FLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataTable dt = usuarioDAO.Login(txtUsuario.Text, txtContrasena.Text);
            if (dt.Rows.Count > 0 ) 
            {
                this.autorizado = true;
                if (dt.Rows[0]["RolID"].ToString() != "1")
                {
                    FormDetalleVenta formDetalleVenta = new FormDetalleVenta();
                    formDetalleVenta.rolID = dt.Rows[0]["RolID"].ToString();
                    formDetalleVenta.ShowDialog();
                }
                this.Close();
            }
            else
            {
                lblMensaje.Visible = true;
            }
        }
    }
}
