using System.Collections.Generic;
using Entidades;

namespace Ceclimi.AccesoDatos.IDAO
{
    public interface IDAOCirujano
    {
        bool AgregarCirujano(Cirujano cirujano);
        bool EliminarCirujano(Entidad cirujano);
        bool EditarCirujano(Cirujano cirujano);
        Cirujano ObtenerInformacionCirujano(int cedula);
        List<Cirujano> ObtenerCirujanos(Entidad cirugia);
    }
}
