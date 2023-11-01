using Microsoft.EntityFrameworkCore;
using Practice.Application.Contracts.Persistence;
using Practice.Domain;

namespace Practice.Persistence.Repositories
{
    internal class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationDBContext _context;

        public UsuarioRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<List<Usuario>> GetUsuarios()
        {
            try
            {
                return await _context.Usuarios.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Usuario> GetUsuarioById(int id)
        {
            try
            {
                return await _context.Usuarios.FirstOrDefaultAsync(x => x.UsuarioId == id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Usuario> SaveUsuario(Usuario usuario)
        {
            await _context.AddAsync(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }

        public async Task<Usuario> EditUsuario(Usuario usuario)
        {
            await _context.SaveChangesAsync();
            return usuario;
        }

        public async Task<bool> DeleteUsuario(Usuario usuario)
        {
            try
            {
                _context.Remove(usuario);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
