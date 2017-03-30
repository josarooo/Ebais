using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbaisProyecto.DATOS
{
    public class Farmacia
    {
        private static int cod = 0;

        public Farmacia()
        {
            cod++;
            IdMedicamento = cod;
        }
        public int IdMedicamento { get; set; }

        public String Tipo { get; set; }

        public int Cantidad { get; set; }

        public string Descripcion { get; set; }

    }
}
