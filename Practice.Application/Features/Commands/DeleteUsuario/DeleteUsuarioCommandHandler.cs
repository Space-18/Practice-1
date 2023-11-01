using MediatR;
using Practice.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Application.Features.Commands.DeleteUsuario
{
    internal class DeleteUsuarioCommandHandler : IRequestHandler<DeleteUsuarioCommand, bool>
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public DeleteUsuarioCommandHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public async Task<bool> Handle(DeleteUsuarioCommand request, CancellationToken cancellationToken)
        {
            var usuarioMapped = await _usuarioRepository.GetUsuarioById(request.UsuarioId);
                
            return await _usuarioRepository.DeleteUsuario(usuarioMapped);
        }
    }
}
