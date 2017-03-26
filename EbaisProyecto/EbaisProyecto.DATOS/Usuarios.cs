using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbaisProyecto.DATOS
{
    public class Usuarios
    {
        public int Cedula { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public int Telefono { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Direccion { get; set; }

        public string TipoUsuario { get; set; }

        public string Password { get; set; }

        public string Sexo { get; set; }

    }
}
