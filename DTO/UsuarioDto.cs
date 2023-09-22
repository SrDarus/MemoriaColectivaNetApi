
using Entities;
using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public class UsuarioDto
    {
        public long Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }

        public List<Permiso> Permisos { get; set; } = new();

        public UsuarioDto(long id, string password, List<Permiso> permisos)
        {
            Id = id;
            Password = password;
            Permisos = permisos;
        }
    }
}