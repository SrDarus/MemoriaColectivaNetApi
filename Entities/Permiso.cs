using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Permiso
    {
        public string Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
    }
}
