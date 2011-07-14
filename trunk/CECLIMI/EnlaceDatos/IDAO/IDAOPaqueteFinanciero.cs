using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
namespace EnlaceDatos.IDAO
{
    public interface IDAOPaqueteFinanciero
    {
        bool AgregarPaqueteFinanciero(PaqueteFinanciero paquete);
    }
}
