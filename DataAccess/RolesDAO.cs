using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;
using GranBodega.Models;

namespace GranBodega.DataAccess
{
    public class RolesDAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;

        public DataTable GetAll()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Roles", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void Insert(Roles rol)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Roles (Rol) VALUES (@Rol)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Rol", rol.Rol);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Roles rol)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Roles SET Rol=@Rol WHERE RolID=@RolID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Rol", rol.Rol);
                cmd.Parameters.AddWithValue("@RolID", rol.RolID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int usuarioID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Roles WHERE RolID=@UsuarioID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
