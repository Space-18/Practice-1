namespace Practice.Application.Models
{
    public class UsuarioDTO
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public int Edad { get; set; }
        public int DNI { get; set; }
        public string Username { get; set; } = string.Empty;
    }

    public class UsuarioDTOExtend : UsuarioDTO
    {
        public DateTime CreateDate { get; set; }
        public string? CreateBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}
