using ImSoTest.BLL;
using ImSoTest.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ImSoTest.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly UsuariosBLL _UsuariosBLL;

        public UsuariosController(IConfiguration config)
        {
            Log.nombreClase = typeof(UsuariosController).FullName.Replace(".", "_").Trim();
            _UsuariosBLL = new UsuariosBLL();
        }

        [HttpPost("RegistrarUsuario")]
        public Response<UsuarioDTO> RegistrarUsuario(UsuarioDTO usuario)
        {
            var response = new Response<UsuarioDTO>();
            var request = HttpContext.Request;
            string url = $"{request.Scheme}://{request.Host}{request.Path}{request.QueryString}";
            Log.WriteLine($"URL Endpoint : {url}");
            response = _UsuariosBLL.RegistrarUsuario(usuario, url);
            return response;
        }

        [HttpPost("ListaUsuarios")]
        public Response<List<UsuarioDTO>> ListaUsuarios()
        {
            var response = new Response<List<UsuarioDTO>>();
            var request = HttpContext.Request;
            string url = $"{request.Scheme}://{request.Host}{request.Path}{request.QueryString}";
            Log.WriteLine($"URL Endpoint : {url}");
            response = _UsuariosBLL.ListaUsuarios(url);
            return response;
        }

        [HttpPost("ObtenerDatosUsuario")]
        public Response<UsuarioDTO> ObtenerDatosUsuario(UsuarioDTO usuario)
        {
            var response = new Response<UsuarioDTO>();
            var request = HttpContext.Request;
            string url = $"{request.Scheme}://{request.Host}{request.Path}{request.QueryString}";
            Log.WriteLine($"URL Endpoint : {url}");
            response = _UsuariosBLL.ObtenerDatosUsuario(usuario, url);
            return response;
        }

        [HttpPost("ActualizarUsuario")]
        public Response<UsuarioDTO> ActualizarUsuario(UsuarioDTO usuario)
        {
            var response = new Response<UsuarioDTO>();
            var request = HttpContext.Request;
            string url = $"{request.Scheme}://{request.Host}{request.Path}{request.QueryString}";
            Log.WriteLine($"URL Endpoint : {url}");
            response = _UsuariosBLL.ActualizarUsuario(usuario, url);
            return response;
        }

        [HttpPost("EliminarUsuario")]
        public Response<UsuarioDTO> EliminarUsuario(UsuarioDTO usuario)
        {
            var response = new Response<UsuarioDTO>();
            var request = HttpContext.Request;
            string url = $"{request.Scheme}://{request.Host}{request.Path}{request.QueryString}";
            Log.WriteLine($"URL Endpoint : {url}");
            response = _UsuariosBLL.EliminarUsuario(usuario, url);
            return response;
        }
    }
}
