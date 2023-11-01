using AutoMapper;
using MediatR;
using Practice.Application.Contracts.Persistence;
using Practice.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Application.Features.Queries.GetUsuarioById
{
    internal class GetUsuarioByIdQueryHandler : IRequestHandler<GetUsuarioByIdQuery, UsuarioDTOExtend>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public GetUsuarioByIdQueryHandler(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        public async Task<UsuarioDTOExtend> Handle(GetUsuarioByIdQuery request, CancellationToken cancellationToken)
        {
            var data = await _usuarioRepository.GetUsuarioById(request.Id);

            return _mapper.Map<UsuarioDTOExtend>(data);
        }
    }
}
