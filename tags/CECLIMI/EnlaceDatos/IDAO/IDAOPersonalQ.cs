using System;
using System.Collections.Generic;

using System.Text;
using Entidades;

namespace EnlaceDatos.IDAO
{
    public interface IDAOPersonalQ
    {
        bool AgregarPersonalQ(Personal personal);
        bool EditarPersonalQ(Personal personal);
        bool EliminarPersonalQ(Personal personal);
        List<Personal> ObtenerPersonalQ();
    }
}
