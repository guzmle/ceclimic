using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace EnlaceDatos.IDAO
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
