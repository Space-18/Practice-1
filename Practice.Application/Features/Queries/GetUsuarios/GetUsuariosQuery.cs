using MediatR;
using Practice.Application.Models;

namespace Practice.Application.Features.Queries.GetUsuarios
{
    public class GetUsuariosQuery : IRequest<List<UsuarioDTO>>
    {

    }
}
