using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace EnlaceDatos.IDAO
{
    public interface IDAOTransferencia
    {
        bool AgregarTransferencia(Transferencia transferencia);
        bool EditarTransferencia(Transferencia transferencia);
        bool EliminarTransferencia(Transferencia transferencia);
    }
}
