using MediatR;
using Practice.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Application.Features.Queries.GetUsuarioById
{
    public class GetUsuarioByIdQuery : IRequest<UsuarioDTOExtend>
    {
        public readonly int Id;

        public GetUsuarioByIdQuery(int id)
        {
            Id = id;
        }
    }
}
