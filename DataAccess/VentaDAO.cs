using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;
using Supermercado.Models;

namespace Supermercado.DataAccess
{
    public class VentaDAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;

        public DataTable GetAll()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Ventas", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public int Insert(Venta venta)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Ventas (Fecha, Cliente, Empleado, Total) VALUES (@Fecha, @Cliente, @Empleado, @Total); SELECT SCOPE_IDENTITY()";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Fecha", venta.Fecha);
                cmd.Parameters.AddWithValue("@Cliente", venta.Cliente);
                cmd.Parameters.AddWithValue("@Empleado", venta.Empleado);
                cmd.Parameters.AddWithValue("@Total", venta.Total);

                conn.Open();
                // cmd.ExecuteNonQuery();
                object result = cmd.ExecuteScalar();
                if (result != null) {
                    System.Diagnostics.Debug.WriteLine("Venta");
                    System.Diagnostics.Debug.WriteLine(result);
                    return Convert.ToInt32(result);
                } else {
                    return -1;
                }
            }
        }

        public void Update(Venta venta)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Ventas SET Fecha=@Fecha, Cliente=@Cliente, Empleado=@Empleado, Total=@Total WHERE VentaID=@VentaID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@VentaID", venta.VentaID);
                cmd.Parameters.AddWithValue("@Fecha", venta.Fecha);
                cmd.Parameters.AddWithValue("@Cliente", venta.Cliente);
                cmd.Parameters.AddWithValue("@Empleado", venta.Empleado);
                cmd.Parameters.AddWithValue("@Total", venta.Total);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int ventaID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Ventas WHERE VentaID=@VentaID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@VentaID", ventaID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
