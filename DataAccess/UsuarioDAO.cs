using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;
using GranBodega.Models;

namespace GranBodega.DataAccess
{
    public class UsuarioDAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;

        public DataTable GetAll()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Usuarios", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void Insert(Usuario usuario)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Usuarios (Nombre, Usuario, Clave, RolID) VALUES (@Nombre, @Usuario, @Clave, @RolID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Usuario", usuario.UsuarioLogin);
                cmd.Parameters.AddWithValue("@Clave", usuario.Clave);
                cmd.Parameters.AddWithValue("@RolID", usuario.RolID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Usuario usuario)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Usuarios SET Nombre=@Nombre, Usuario=@Usuario, Clave=@Clave, RolID=@RolID WHERE UsuarioID=@UsuarioID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UsuarioID", usuario.UsuarioID);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Usuario", usuario.UsuarioLogin);
                cmd.Parameters.AddWithValue("@Clave", usuario.Clave);
                cmd.Parameters.AddWithValue("@RolID", usuario.RolID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int usuarioID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Usuarios WHERE UsuarioID=@UsuarioID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable Login(string usuario, string clave)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Usuarios WHERE Usuario = @Usuario AND Clave = @Clave ", conn);
                da.SelectCommand.Parameters.AddWithValue("@Usuario", usuario);
                da.SelectCommand.Parameters.AddWithValue("@Clave", clave);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
