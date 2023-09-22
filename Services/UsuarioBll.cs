using AutoMapper;
using DTOs;
using Entities;
using Microsoft.EntityFrameworkCore;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UsuarioBll : IUsuarioBll
    {
        private readonly MemoriaColectivaDbContext _context;
        private readonly IMapper _mapper;

        public UsuarioBll(MemoriaColectivaDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<ResponseEntity> Login(string usuario, string password)
        {
            var usuarioEntity = await _context.Usuarios.FirstOrDefaultAsync(u => u.Username == usuario && u.Password == password);
                
            if(usuarioEntity == null)
            {
                return new ResponseEntity(HttpStatusCode.Unauthorized, "Usuario o password no exísten");
            } else
            {
                return new ResponseEntity(HttpStatusCode.OK, "OK");
            }
        }

        public async Task<ResponseEntity> Save(UsuarioDto usuario)
        {
            var entidad = _mapper.Map<Usuario>(usuario);
            _context.Add(entidad);
            await _context.SaveChangesAsync();
            usuario.Id = entidad.Id;
            return new ResponseEntity(HttpStatusCode.OK, "OK");

        }
    }
}
