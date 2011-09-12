using System.Collections.Generic;
using Entidades;

namespace Ceclimi.AccesoDatos.IDAO
{
    public interface IDAOPersonalQ
    {
        bool AgregarPersonalQ(Personal personal);
        bool EditarPersonalQ(Personal personal);
        bool EliminarPersonalQ(Personal personal);
        List<Personal> ObtenerPersonalQ();
    }
}
