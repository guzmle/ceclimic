using System;
using System.Collections.Generic;

using System.Text;
using Entidades;

namespace EnlaceDatos.IDAO
{
    public interface IDAOCirugiaPaquetePersonalQ
    {
        bool AgregarCirugiaPaquetePersonalQ(PersonalPaquete personalPaquete);
        bool EditarCirugiaPaquetePersonalQ(PersonalPaquete personalPaquete);
        bool EliminarCirugiaPaquetePersonalQ(PersonalPaquete personalPaquete);
    }
}
