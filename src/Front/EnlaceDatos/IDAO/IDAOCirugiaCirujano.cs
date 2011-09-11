using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace EnlaceDatos.IDAO
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
