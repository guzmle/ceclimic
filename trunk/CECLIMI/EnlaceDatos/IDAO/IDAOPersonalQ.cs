using Entidades;

namespace EnlaceDatos.IDAO
{
    public interface IDAOPersonalQ
    {
        bool AgregarPersonalQ(Personal personal);
        bool EditarPersonalQ(Personal personal);
        bool EliminarPersonalQ(Personal personal);
    }
}
