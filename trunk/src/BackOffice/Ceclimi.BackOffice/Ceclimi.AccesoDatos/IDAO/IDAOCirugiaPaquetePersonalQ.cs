using Entidades;

namespace Ceclimi.AccesoDatos.IDAO
{
    public interface IDAOCirugiaPaquetePersonalQ
    {
        bool AgregarCirugiaPaquetePersonalQ(PersonalPaquete personalPaquete);
        bool EditarCirugiaPaquetePersonalQ(PersonalPaquete personalPaquete);
        bool EliminarCirugiaPaquetePersonalQ(PersonalPaquete personalPaquete);
    }
}
