using AutoMapper;
using MediatR;
using Practice.Application.Contracts.Insfrastructure;
using Practice.Application.Contracts.Persistence;
using Practice.Application.Models;
using Practice.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Application.Features.Commands.SaveUsuario
{
    internal class SaveUsuarioCommandHandler : IRequestHandler<SaveUsuarioCommand, UsuarioDTO>
    {
        private readonly IRequestExternalApiService _requestExternalApiService;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public SaveUsuarioCommandHandler(IRequestExternalApiService requestExternalApiService, IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _requestExternalApiService = requestExternalApiService;
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }
        public async Task<UsuarioDTO> Handle(SaveUsuarioCommand request, CancellationToken cancellationToken)
        {
            var apiResult = await _requestExternalApiService.GetTleAPIData();

            Random random = new Random();
            int randomIndex = random.Next(0, apiResult.Member.Count);

            var userMapped = _mapper.Map<Usuario>(request);

            userMapped.Username = apiResult.Member[randomIndex].Name;

            var result = await _usuarioRepository.SaveUsuario(userMapped);

            return _mapper.Map<UsuarioDTO>(result);
        }
    }
}
