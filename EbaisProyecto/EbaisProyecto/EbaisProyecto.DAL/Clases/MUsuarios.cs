using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ServiceStack.OrmLite;
using EbaisProyecto.DATOS;
using EbaisProyecto.DAL.Clases;
using EbaisProyecto.DAL.Interfaces;

namespace EbaisProyecto.DAL.Clases
{
    public class MUsuarios : IUsuarios
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MUsuarios()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();


        }

        public void ActualizarUsuario(Usuarios usuario)
        {
            _db.Update(usuario);
        }

        public Usuarios BuscarPorNombre(string nombre)
        {
            return _db.Select<Usuarios>(x => x.Nombre == nombre).FirstOrDefault();
        }

        public Usuarios BuscarUsuario(int cedula)
        {
            return _db.Select<Usuarios>(x => x.Cedula == cedula).FirstOrDefault();
        }

        public void EliminarUsuario(int cedula)
        {
            _db.Delete<Usuarios>(x => x.Cedula == cedula);
        }

        public void InsertarUsuario(Usuarios usuario)
        {
            _db.Insert(usuario);

        }

        public List<Usuarios> ListarUsuarios()
        {
            return _db.Select<Usuarios>();
        }

     



    }
}
