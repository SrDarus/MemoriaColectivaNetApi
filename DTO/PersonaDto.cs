using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class PersonaDto
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public DireccionDto direccion { get; set; }
        public string Nombre { get; set; }

        
        public PersonaDto(string nombres, string apellidos, string correo, DireccionDto direccion, string nombre)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            Correo = correo;
            this.direccion = direccion;
            Nombre = nombre;
        }
    }
}
