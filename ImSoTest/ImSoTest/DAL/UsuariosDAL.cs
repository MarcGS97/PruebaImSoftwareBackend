using ImSoTest.DTO;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Data;

namespace ImSoTest.DAL
{
    public class UsuariosDAL
    {
        BDConnection bd = new BDConnection();

        public DataTable RegistrarUsuario(UsuarioDTO usuario, string url)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            SqlConnection conn = new SqlConnection(bd.cadena);
            using (SqlCommand cmd = new SqlCommand("[test].[sp002RegistroUsuario]", conn))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@_url", SqlDbType.VarChar).Value = url;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = usuario.nombre;
                    cmd.Parameters.Add("@edad", SqlDbType.Int).Value = usuario.edad;
                    cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = usuario.correo;

                    cmd.Parameters.Add("@aPaterno", SqlDbType.VarChar).Value = usuario.aPaterno;
                    cmd.Parameters.Add("@aMaterno", SqlDbType.VarChar).Value = usuario.aMaterno;
                    cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = usuario.telefono;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    Log.WriteLine(ex.ToString());
                }
            }
            return dt;
        }

        public DataTable ListaUsuarios(string url)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            SqlConnection conn = new SqlConnection(bd.cadena);
            using (SqlCommand cmd = new SqlCommand("[test].[sp002ListaUsuario]", conn))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@_url", SqlDbType.VarChar).Value = url;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    Log.WriteLine(ex.ToString());
                }
            }
            return dt;
        }
        public DataTable ObtenerDatosUsuario(UsuarioDTO usuario, string url)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            SqlConnection conn = new SqlConnection(bd.cadena);
            using (SqlCommand cmd = new SqlCommand("[test].[sp002ObtenerDatosUsuario]", conn))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@_url", SqlDbType.VarChar).Value = url;
                    cmd.Parameters.Add("@idPersona", SqlDbType.BigInt).Value = usuario.idPersona;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    Log.WriteLine(ex.ToString());
                }
            }
            return dt;
        }

        public DataTable ActualizarUsuario(UsuarioDTO usuario, string url)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            SqlConnection conn = new SqlConnection(bd.cadena);
            using (SqlCommand cmd = new SqlCommand("[test].[sp002ActualizarUsuario]", conn))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@_url", SqlDbType.VarChar).Value = url;
                    cmd.Parameters.Add("@idPersona", SqlDbType.BigInt).Value = usuario.idPersona;
                    cmd.Parameters.Add("@idUsuario", SqlDbType.BigInt).Value = usuario.idUsuario;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = usuario.nombre;
                    cmd.Parameters.Add("@edad", SqlDbType.Int).Value = usuario.edad;
                    cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = usuario.correo;

                    cmd.Parameters.Add("@aPaterno", SqlDbType.VarChar).Value = usuario.aPaterno;
                    cmd.Parameters.Add("@aMaterno", SqlDbType.VarChar).Value = usuario.aMaterno;
                    cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = usuario.telefono;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    Log.WriteLine(ex.ToString());
                }
            }
            return dt;
        }

        public DataTable EliminarUsuario(UsuarioDTO usuario, string url)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            SqlConnection conn = new SqlConnection(bd.cadena);
            using (SqlCommand cmd = new SqlCommand("[test].[sp002EliminarUsuario]", conn))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@_url", SqlDbType.VarChar).Value = url;
                    cmd.Parameters.Add("@idPersona", SqlDbType.BigInt).Value = usuario.idPersona;
                    cmd.Parameters.Add("@idUsuario", SqlDbType.BigInt).Value = usuario.idUsuario;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    Log.WriteLine(ex.ToString());
                }
            }
            return dt;
        }
    }
}
