﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EbaisProyecto.DATOS;
namespace EbaisProyecto.DAL.Interfaces
{
    public interface IFarmacia
    {
        //METODOS CRUD

        //SELECTS
        List<Farmacia> ListarFarmacia();
        //Farmacia BuscarMedicamento(int codigo);
        Farmacia BuscarPorTipo(string tipo);

        //INSERT
        Farmacia InsertarFarmacia(Farmacia farmacia);


        //UPDATE
        void ActualizarFarmacia(Farmacia farmacia);

        //Delete
        void EliminarFarmacia(int codigo);
    }
}
