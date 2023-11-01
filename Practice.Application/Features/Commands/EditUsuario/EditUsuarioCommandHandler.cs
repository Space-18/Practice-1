using AutoMapper;
using MediatR;
using Practice.Application.Contracts.Persistence;
using Practice.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Application.Features.Commands.EditUsuario
{
    internal class EditUsuarioCommandHandler : IRequestHandler<EditUsuarioCommand, UsuarioDTO>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public EditUsuarioCommandHandler(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }
        public async Task<UsuarioDTO> Handle(EditUsuarioCommand request, CancellationToken cancellationToken)
        {
            var usuarioExist = await _usuarioRepository.GetUsuarioById(request.UsuarioId);

            usuarioExist = _mapper.Map(request, usuarioExist);

            return _mapper.Map<UsuarioDTO>(await _usuarioRepository.EditUsuario(usuarioExist));

        }
    }
}
