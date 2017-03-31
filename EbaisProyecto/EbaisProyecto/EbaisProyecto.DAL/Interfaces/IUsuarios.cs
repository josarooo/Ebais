using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EbaisProyecto.DATOS;
namespace EbaisProyecto.DAL.Interfaces
{
  public  interface IUsuarios 
    {
        //METODOS CRUD

        //SELECTS
        List<Usuarios> ListarUsuarios();
        Usuarios BuscarUsuario(int cedula);
        Usuarios BuscarPorNombre(string nombre);

        //INSERT
        void InsertarUsuario(Usuarios usuario);


        //UPDATE
        void ActualizarUsuario(Usuarios usuario);

        //Delete
        void EliminarUsuario(int cedula);


    }
}
