using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EbaisProyecto.DATOS;
namespace EbaisProyecto.DAL.Interfaces
{
  public  interface IUsuario
    {
        //METODOS CRUD

        //SELECTS
        List<Usuarios> ListarUsuarios();
        Usuarios BuscarCuenta(int cedula);




        //INSERT
        void InsertarCuenta(Usuarios usuario);


        //UPDATE
        void ActualizarCuenta(Usuarios usuario);

        //Delete
        void EliminarCuenta(int cedula);


    }
}
