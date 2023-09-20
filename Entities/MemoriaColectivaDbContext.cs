using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MemoriaColectivaDbContext : DbContext
    {
        public MemoriaColectivaDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Pais> Paises { get; set; }
    }
}
