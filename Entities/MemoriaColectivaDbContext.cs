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

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Pais> Paises { get; set; }

        public DbSet<Permiso> Permisos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {         

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Permiso>().HasData(
                new Permiso(1, "ADMIN"),
                new Permiso(2, "READ"),
                new Permiso(3, "WRITE")
            );
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    Id = 1,
                    Username = "darus",
                    Password = "admin"
                }
            );


            modelBuilder.Entity<Usuario>()
                .HasMany(p => p.Permisos)
                .WithMany(t => t.Usuarios)
                .UsingEntity<Dictionary<string, object>>(
                    "UsuarioPermiso",
                    r => r.HasOne<Permiso>().WithMany().HasForeignKey("PermisoId"),
                    l => l.HasOne<Usuario>().WithMany().HasForeignKey("UsuarioId"),
                    je =>
                    {
                        je.HasKey("PermisoId", "UsuarioId");
                        je.HasData( new { UsuarioId = 1, PermisoId = 1 });
                    });

        }
    }
}
