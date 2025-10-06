namespace ImSoTest.DTO
{
    public class UsuarioDTO : PersonaDTO
    {
        public long? idUsuario { get; set; }
        public string? correo {  get; set; }
        public string? telefono {  get; set; }
        public string? fechaHoraRegistro { get; set; }
        public string? fechaHoraRegistroUsuario { get; set; }
    }
}
