using DTOs;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace MemoriaColectivaNetApi.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioBll _usuarioService;
        public UsuarioController(IUsuarioBll usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        [Route("/login")]
        public async Task<ResponseEntity> Login(string username, string password)
        {
            return  await _usuarioService.Login(username, password);
            //return Ok();
        }

        [HttpPost]
        [Route("/save")]
        public async Task<ResponseEntity> Save([FromBody]  UsuarioDto usuario)
        {
            return await _usuarioService.Save(usuario);
            //return Ok();
        }
    }
}
