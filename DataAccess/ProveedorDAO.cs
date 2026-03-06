using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Supermercado.DataAccess
{
    public class ProveedorDAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;

        // Obtener todos los proveedores
        public DataTable GetAll()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Proveedores", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Insertar proveedor
        public void Insert(string nombre, string telefono, string email, string direccion)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Proveedores (Nombre, Telefono, Email, Direccion) VALUES (@Nombre, @Telefono, @Email, @Direccion)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Direccion", direccion);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Actualizar proveedor
        public void Update(int proveedorID, string nombre, string telefono, string email, string direccion)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Proveedores SET Nombre=@Nombre, Telefono=@Telefono, Email=@Email, Direccion=@Direccion WHERE ProveedorID=@ProveedorID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProveedorID", proveedorID);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Direccion", direccion);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Eliminar proveedor
        public void Delete(int proveedorID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Proveedores WHERE ProveedorID=@ProveedorID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProveedorID", proveedorID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
