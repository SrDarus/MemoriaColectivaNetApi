using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public class Pais
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Nombre { get; set; }
    }
}
