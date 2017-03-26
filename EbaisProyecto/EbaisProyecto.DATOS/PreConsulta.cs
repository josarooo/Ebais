using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbaisProyecto.DATOS
{
    public class PreConsulta
    {
        public int IdPreConsulta { get; set; }

        public DateTime Fecha { get; set; }

        public int Estatura { get; set; }

        public int Peso { get; set; }

        public int PresionSis { get; set; }

        public int PresionDias { get; set; }

        public string Notas { get; set; }

        public int IdExpediente { get; set; }

    }
}
