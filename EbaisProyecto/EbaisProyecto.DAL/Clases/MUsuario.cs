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
    public class MUsuario : IUsuario
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;




        public MUsuario()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();


        }

        public void ActualizarCuenta(Usuarios usuario)
        {
            throw new NotImplementedException();
        }

        public Usuarios BuscarCuenta(int cedula)
        {
            throw new NotImplementedException();
        }

        public void EliminarCuenta(int cedula)
        {
            throw new NotImplementedException();
        }

        public void InsertarCuenta(Usuarios usuario)
        {
            throw new NotImplementedException();
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
