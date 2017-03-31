using EbaisProyecto.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EbaisProyecto.DATOS;
using System.Data;
using ServiceStack.OrmLite;

namespace EbaisProyecto.DAL.Clases
{
    public class MPadecimiento : IPadecimiento
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MPadecimiento()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();


        }

        public void ActualizarPadecimiento(Padecimiento padecimiento)
        {
            _db.Update(padecimiento);
        }

        public Padecimiento BuscarPadecimiento(int codigo)
        {
            return _db.Select<Padecimiento>(x => x.IdPadecimiento == codigo).FirstOrDefault();
        }

        public List<Padecimiento> BuscarPorTipo(string tipo)
        {
            return _db.Select<Padecimiento>(x => x.Tipo == tipo).ToList();
        }

        public void EliminarPadecimiento(int codigo)
        {
            _db.Delete<Padecimiento>(x => x.IdPadecimiento == codigo);
        }

        public Padecimiento InsertarPadecimiento(Padecimiento padecimiento)
        {
            _db.Insert(padecimiento);
            return _db.Select<Padecimiento>(x => x.IdPadecimiento == padecimiento.IdPadecimiento).FirstOrDefault();
        }

        public List<Padecimiento> ListarPadecimiento()
        {
            return _db.Select<Padecimiento>();
        }

        public int UltimoValor()
        {
            return _db.Scalar<int>("select max(IdPadecimiento) from Padecimiento");
        }
    }
}
