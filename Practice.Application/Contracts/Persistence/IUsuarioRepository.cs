using Practice.Domain;

namespace Practice.Application.Contracts.Persistence
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> GetUsuarios();
        Task<Usuario> GetUsuarioById(int id);
        Task<Usuario> SaveUsuario(Usuario usuario);
        Task<Usuario> EditUsuario(Usuario usuario);
        Task<bool> DeleteUsuario(Usuario usuario);
    }
}
