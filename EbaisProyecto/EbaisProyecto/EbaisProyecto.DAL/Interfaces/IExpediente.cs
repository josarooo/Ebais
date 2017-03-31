using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EbaisProyecto.DATOS;

namespace EbaisProyecto.DAL.Interfaces
{
    public interface IExpediente
    {
        List<Expediente> ListarExpedientes();
        Expediente BuscarExpediente(int idExpediente);

        //INSERT
        void InsertarExpediente(Expediente expediente);


        //UPDATE
        void ActualizarExpediente(Expediente expediente);

        //Delete
        void EliminarExpediente(int idExpediente);
    }
}
