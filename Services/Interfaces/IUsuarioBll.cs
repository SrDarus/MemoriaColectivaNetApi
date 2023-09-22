//using DTOs;

using DTOs;
using Entities;

namespace Services.Interface
{
    public interface IUsuarioBll
    {
        Task<ResponseEntity> Login(string usuario, string password);
        Task<ResponseEntity> Save(UsuarioDto usuario);
    }
}
