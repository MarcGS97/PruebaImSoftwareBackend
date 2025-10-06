using ImSoTest.DAL;
using ImSoTest.DTO;
using Newtonsoft.Json;
using System.Data;

namespace ImSoTest.BLL
{
    public class UsuariosBLL
    {
        private readonly UsuariosDAL _UsuariosDAL = new UsuariosDAL();

        public Response<UsuarioDTO> RegistrarUsuario(UsuarioDTO usuario, string url)
        {
            Response<UsuarioDTO> response = new Response<UsuarioDTO>();
            DataTable dt = new DataTable();
            dt = _UsuariosDAL.RegistrarUsuario(usuario, url);
            string json = "";
            if (dt != null && dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                var dat = row.Table.Columns.Cast<DataColumn>().ToDictionary(c => c.ColumnName, c => row[c]);

                json = JsonConvert.SerializeObject(dat, Formatting.Indented);
                response = JsonConvert.DeserializeObject<Response<UsuarioDTO>>(json);
            }
            else
            {
                response.success = false;
                response.message = "Error al intentar registrar el usuario";
            }
            return response;
        }

        public Response<List<UsuarioDTO>> ListaUsuarios(string url)
        {
            Response<List<UsuarioDTO>> response = new Response<List<UsuarioDTO>>();
            DataTable dt = new DataTable();
            string json = "";
            dt = _UsuariosDAL.ListaUsuarios(url);
            if (dt != null && dt.Rows.Count > 0)
            {
                json = JsonConvert.SerializeObject(dt);
                response.data = new List<UsuarioDTO>();
                response.data = JsonConvert.DeserializeObject<List<UsuarioDTO>>(json);
                response.success = true;
                response.message = "Lista de usuarios obtenida";
            }
            else
            {
                response.success = false;
                response.message = "Error al intentar registrar el usuario";
            }
            return response;
        }

        public Response<UsuarioDTO> ObtenerDatosUsuario(UsuarioDTO usuario, string url)
        {
            Response<UsuarioDTO> response = new Response<UsuarioDTO>();
            DataTable dt = new DataTable();
            string json = "";
            dt = _UsuariosDAL.ListaUsuarios(url);
            if (dt != null && dt.Rows.Count > 0)
            {
                json = JsonConvert.SerializeObject(dt);
                response.data = new UsuarioDTO();
                response.data = JsonConvert.DeserializeObject<List<UsuarioDTO>>(json).FirstOrDefault();
                response.success = true;
                response.message = "Lista de usuarios obtenida";
            }
            else
            {
                response.success = false;
                response.message = "Error al intentar registrar el usuario";
            }
            return response;
        }

        public Response<UsuarioDTO> ActualizarUsuario(UsuarioDTO usuario, string url)
        {
            Response<UsuarioDTO> response = new Response<UsuarioDTO>();
            DataTable dt = new DataTable();
            string json = "";
            dt = _UsuariosDAL.ActualizarUsuario(usuario, url);
            Log.WriteLine($"JSON : {JsonConvert.SerializeObject(dt)}");
            if (dt != null && dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                var dat = row.Table.Columns.Cast<DataColumn>().ToDictionary(c => c.ColumnName, c => row[c]);

                json = JsonConvert.SerializeObject(dat, Formatting.Indented);
                response = JsonConvert.DeserializeObject<Response<UsuarioDTO>>(json);
            }
            else
            {
                response.success = false;
                response.message = "Error al intentar actualizar el usuario";
            }
            return response;
        }

        public Response<UsuarioDTO> EliminarUsuario(UsuarioDTO usuario, string url)
        {
            Response< UsuarioDTO> response = new Response<UsuarioDTO>();
            DataTable dt = new DataTable();
            string json = "";
            dt = _UsuariosDAL.EliminarUsuario(usuario, url);
            Log.WriteLine($"JSON : {JsonConvert.SerializeObject(dt)}");
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                var dat = row.Table.Columns.Cast<DataColumn>().ToDictionary(c => c.ColumnName, c => row[c]);

                json = JsonConvert.SerializeObject(dat, Formatting.Indented);
                response = JsonConvert.DeserializeObject<Response<UsuarioDTO>>(json);
            }
            else
            {
                response.success = false;
                response.message = "Error al intentar eliminar el usuario";
            }
            return response;
        }
    }
}
