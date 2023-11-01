using AutoMapper;
using Practice.Application.Features.Commands.EditUsuario;
using Practice.Application.Features.Commands.SaveUsuario;
using Practice.Application.Models;
using Practice.Domain;

namespace Practice.Application.Mappings
{
    internal class UsuarioAutoMapperProfile : Profile
    {
        public UsuarioAutoMapperProfile()
        {
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
            CreateMap<Usuario, UsuarioDTOExtend>().ReverseMap();
            CreateMap<Usuario, SaveUsuarioCommand>().ReverseMap();
            CreateMap<Usuario, EditUsuarioCommand>().ReverseMap();
        }
    }
}
