using System.Collections.Generic;
using Entidades;

namespace Ceclimi.AccesoDatos.IDAO
{
    public interface IDAOCirugiaCirujano
    {
        bool AgregarCirugiaCirujano(CirugiaCirujano objeto);
        bool EditarCirugiaCirujano(float honorario, int cirugia, int cirujano);
        bool EliminarCirugiaCirujano(CirugiaCirujano objeto);
        List<CirugiaCirujano> ObtenerCirugiasCirujano(int cedula);
        float PrecioOperacion(Cirugia cirugia, Cirujano cirujano);
    }
}
