using Entidades;

namespace Ceclimi.AccesoDatos.IDAO
{
    public interface IDAOTransferencia
    {
        bool AgregarTransferencia(Transferencia transferencia);
        bool EditarTransferencia(Transferencia transferencia);
        bool EliminarTransferencia(Transferencia transferencia);
    }
}
