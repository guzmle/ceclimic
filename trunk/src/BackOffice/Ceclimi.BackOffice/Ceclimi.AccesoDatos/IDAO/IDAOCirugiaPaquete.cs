using Entidades;

namespace Ceclimi.AccesoDatos.IDAO
{
    public interface IDAOCirugiaPaquete
    {
        int AgregarCirugiaPaquete(CirugiaPqtFinanciero cirugiaPaquete);
        bool EditarCirugiaPaquete(CirugiaPqtFinanciero cirugiaPaquete);
        bool EliminarCirugiaPaquete(int id);
    }
}
