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
    public class MExpediente : IExpediente
    {

        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MExpediente()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();

        }
        public void ActualizarExpediente(Expediente expediente)
        {
            _db.Update(expediente);
        }

        public Expediente BuscarExpediente(int idExpediente)
        {
            return _db.Select<Expediente>(x => x.IdExpediente == idExpediente).FirstOrDefault();
        }

        public void EliminarExpediente(int idExpediente)
        {
            _db.Delete<Expediente>(x => x.IdExpediente == idExpediente);
        }

        public void InsertarExpediente(Expediente expediente)
        {
            _db.Insert(expediente);
        }

        public List<Expediente> ListarExpedientes()
        {
            return _db.Select<Expediente>();
        }
    }
}
