using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EbaisProyecto.DAL.Interfaces;
using EbaisProyecto.DATOS;

namespace EbaisProyecto.DAL.Clases
{
    public class Mfarmacia : IFarmacia
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public Mfarmacia()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();


        }

        public void ActualizarFarmacia(Farmacia farmacia)
        {
            _db.Update(farmacia);
        }

        public Farmacia BuscarMedicamento(int codigo)
        {
            return _db.Select<Farmacia>(x => x.IdMedicamento == codigo).FirstOrDefault();
        }

        public List<Farmacia> BuscarPorTipo(string tipo)
        {
            return _db.Select<Farmacia>(x => x.Tipo == tipo).ToList();


        }

       
        public void EliminarFarmacia(int codigo)
        {
            _db.Delete<Farmacia>(x => x.IdMedicamento == codigo);
        }

        public Farmacia InsertarFarmacia(Farmacia farmacia)
        {
            _db.Insert(farmacia);
            return _db.Select<Farmacia>(x => x.IdMedicamento == farmacia.IdMedicamento).FirstOrDefault();
        }

        public List<Farmacia> ListarFarmacia()
        {
            return _db.Select<Farmacia>();
        }

        public int UltimoValor()//Incrementa 
        {
            return _db.Scalar<int>("select max(IdMedicamento) from Farmacia");
        }
    }
}