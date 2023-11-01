using AutoMapper;
using MediatR;
using Practice.Application.Contracts.Persistence;
using Practice.Application.Models;

namespace Practice.Application.Features.Queries.GetUsuarios
{
    internal class GetUsuariosQueryHandler : IRequestHandler<GetUsuariosQuery, List<UsuarioDTO>>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public GetUsuariosQueryHandler(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        public async Task<List<UsuarioDTO>> Handle(GetUsuariosQuery request, CancellationToken cancellationToken)
        {
            var data = await _usuarioRepository.GetUsuarios();

            return _mapper.Map<List<UsuarioDTO>>(data);
        }
    }
}
