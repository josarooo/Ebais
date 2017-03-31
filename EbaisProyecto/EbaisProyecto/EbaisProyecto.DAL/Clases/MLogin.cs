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
    public class MLogin : ILogin
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MLogin()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public List<Usuarios> ListarUsuarios()
        {
            return _db.Select<Usuarios>();
        }
    }
}
