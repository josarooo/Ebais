using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EbaisProyecto.DATOS;

namespace EbaisProyecto.DAL.Interfaces
{
    public interface ILogin
    {
        List<Usuarios> ListarUsuarios();
    }
}
