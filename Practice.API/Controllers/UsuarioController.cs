using MediatR;
using Microsoft.AspNetCore.Mvc;
using Practice.Application.Features.Commands.DeleteUsuario;
using Practice.Application.Features.Commands.EditUsuario;
using Practice.Application.Features.Commands.SaveUsuario;
using Practice.Application.Features.Queries.GetUsuarioById;
using Practice.Application.Features.Queries.GetUsuarios;

namespace Practice.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsuarioController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetUsuarios()
        {
            return Ok(await _mediator.Send(new GetUsuariosQuery()));
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetUsuarioById(int id)
        {
            return Ok(await _mediator.Send(new GetUsuarioByIdQuery(id)));
        }

        [HttpPost]
        public async Task<ActionResult> SaveUsuario([FromBody] SaveUsuarioCommand usuario)
        {
            return Ok(await _mediator.Send(usuario));
        }

        [HttpPut]
        public async Task<ActionResult> EditUsuario([FromBody] EditUsuarioCommand usuario)
        {
            return Ok(await _mediator.Send(usuario));
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteUsuario([FromBody] DeleteUsuarioCommand usuario)
        {
            return Ok(await _mediator.Send(usuario));
        }
    }
}
