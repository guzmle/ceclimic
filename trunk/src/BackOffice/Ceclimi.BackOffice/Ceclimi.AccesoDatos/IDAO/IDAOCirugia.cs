using System.Collections.Generic;
using Entidades;

namespace Ceclimi.AccesoDatos.IDAO
{
    public interface IDAOCirugia
    {
        int AgregarCirugia(Cirugia cirugia);
        bool EliminarCirugia(Entidad cirugia);
        bool ModificarCirugia(Cirugia cirugia);
        List<Cirugia> ObtenerCirugias();
    }
}
