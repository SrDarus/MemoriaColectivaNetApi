using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UsuarioPermiso
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int PermisoId { get; set; }
        public Usuario Usuario { get; set; }= new Usuario();
        public Permiso Permiso { get; set; } = new Permiso();
    }
}
