using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbaisProyecto.DATOS
{
    public class Cita
    {
        public int NumeroCita { get; set; }

        public DateTime FechaHora { get; set; }

        public bool Estado { get; set; }

        public string Motivo { get; set; }

        public int IdExpediente { get; set; }

    }
}
