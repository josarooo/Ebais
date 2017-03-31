using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EbaisProyecto.DATOS;

namespace EbaisProyecto.DAL.Interfaces
{
    public interface IPadecimiento
    {
        //METODOS CRUD

        //SELECTS
        List<Padecimiento> ListarPadecimiento();
        Padecimiento BuscarPadecimiento(int codigo);
        List<Padecimiento> BuscarPorTipo(string tipo);

        int UltimoValor();

        //INSERT
        Padecimiento InsertarPadecimiento(Padecimiento padecimiento);


        //UPDATE
        void ActualizarPadecimiento(Padecimiento padecimiento);

        //Delete
        void EliminarPadecimiento(int codigo);
    }
}
