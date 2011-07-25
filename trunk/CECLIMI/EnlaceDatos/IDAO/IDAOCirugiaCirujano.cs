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
        bool EditarCirugiaCirujano(CirugiaCirujano objeto);
        bool EliminarCirugiaCirujano(CirugiaCirujano objeto);
        float PrecioOperacion(Cirugia cirugia, Cirujano cirujano);
    }
}
