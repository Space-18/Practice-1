using MediatR;
using Practice.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Practice.Application.Features.Commands.SaveUsuario
{
    public class SaveUsuarioCommand : IRequest<UsuarioDTO>
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public int DNI { get; set; }

        public SaveUsuarioCommand(string nombre, string apellidos, int edad, int dNI)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
            DNI = dNI;
        }
    }
}
