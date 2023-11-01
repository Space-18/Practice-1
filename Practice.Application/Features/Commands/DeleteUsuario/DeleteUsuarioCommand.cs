using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Application.Features.Commands.DeleteUsuario
{
    public class DeleteUsuarioCommand : IRequest<bool>
    {
        public int UsuarioId { get; set; }

        public DeleteUsuarioCommand(int usuarioId)
        {
            UsuarioId = usuarioId;
        }
    }
}
