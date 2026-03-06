using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Supermercado
{
    internal class ProductoDAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;

        public DataTable GetAll()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT p.ProductoID, p.Nombre, Categoria, Precio, Stock, v.Nombre AS Proveedor, v.ProveedorID FROM Productos p JOIN Proveedores v ON p.ProveedorID = v.ProveedorID", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void Insert(string nombre, string categoria, decimal precio, int stock, int proveedorID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Productos (Nombre, Categoria, Precio, Stock, ProveedorID) VALUES (@Nombre, @Categoria, @Precio, @Stock, @ProveedorID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Categoria", categoria);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@Stock", stock);
                cmd.Parameters.AddWithValue("@ProveedorID", proveedorID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(int productoID, string nombre, string categoria, decimal precio, int stock, int proveedorID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Productos SET Nombre=@Nombre, Categoria=@Categoria, Precio=@Precio, Stock=@Stock, ProveedorID=@ProveedorID WHERE ProductoID=@ProductoID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductoID", productoID);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Categoria", categoria);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@Stock", stock);
                cmd.Parameters.AddWithValue("@ProveedorID", proveedorID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int productoID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Productos WHERE ProductoID=@ProductoID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductoID", productoID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void ActualizarStock(int productoID, int cantidadVendida)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Productos SET Stock = Stock - @Cantidad WHERE ProductoID = @ProductoID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Cantidad", cantidadVendida);
                cmd.Parameters.AddWithValue("@ProductoID", productoID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public decimal ObtenerPrecio(int productoID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Precio FROM Productos WHERE ProductoID=@ProductoID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductoID", productoID);

                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToDecimal(result) : 0;
            }
        }
        public void AumentarStock(int productoID, int cantidad)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Productos SET Stock = Stock + @Cantidad WHERE ProductoID = @ProductoID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@ProductoID", productoID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


    }
}
