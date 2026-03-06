using GranBodega.Models;
using Microsoft.Data.SqlClient;
using Supermercado.Models;
using System.Configuration;
using System.Data;

namespace GranBodega.DataAccess
{
    public class DetalleVentaDAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;

        public DataTable GetAll()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DetalleVentas", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void Insert(DetalleVenta detalle)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO DetalleVentas (VentaID, ProductoID, Cantidad, PrecioUnitario) " +
                               "VALUES (@VentaID, @ProductoID, @Cantidad, @PrecioUnitario)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@VentaID", detalle.VentaID);
                cmd.Parameters.AddWithValue("@ProductoID", detalle.ProductoID);
                cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                cmd.Parameters.AddWithValue("@PrecioUnitario", detalle.PrecioUnitario);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(DetalleVenta detalle)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE DetalleVentas SET VentaID=@VentaID, ProductoID=@ProductoID, Cantidad=@Cantidad, PrecioUnitario=@PrecioUnitario WHERE DetalleID=@DetalleID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DetalleID", detalle.DetalleID);
                cmd.Parameters.AddWithValue("@VentaID", detalle.VentaID);
                cmd.Parameters.AddWithValue("@ProductoID", detalle.ProductoID);
                cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                cmd.Parameters.AddWithValue("@PrecioUnitario", detalle.PrecioUnitario);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int detalleID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM DetalleVentas WHERE DetalleID=@DetalleID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DetalleID", detalleID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
