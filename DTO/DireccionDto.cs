using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class DireccionDto
    {
        public int Id { get; set; }
        public long ComunaId { get; set; }
        public int Numeracion { get; set; }
        public string RestoDireccion { get; set; }
    }
}
