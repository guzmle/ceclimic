using Entidades;

namespace Ceclimi.AccesoDatos.IDAO
{
    public interface IDAOPaqueteFinanciero
    {
        int AgregarPaqueteFinanciero(PaqueteFinanciero paquete);
        bool EditarPaqueteFinanciero(PaqueteFinanciero paquete);
        bool EliminarPaqueteFinanciero(PaqueteFinanciero paquete);
    }
}
