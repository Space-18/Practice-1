using MediatR;
using Practice.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Application.Features.Commands.EditUsuario
{
    public class EditUsuarioCommand : IRequest<UsuarioDTO>
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Username { get; set; }

        public EditUsuarioCommand(int usuarioId, string nombre, string apellidos, string username)
        {
            UsuarioId = usuarioId;
            Nombre = nombre;
            Apellidos = apellidos;
            Username = username;
        }
    }
}
