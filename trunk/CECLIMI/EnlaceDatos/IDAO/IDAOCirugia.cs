using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace EnlaceDatos.IDAO
{
    public interface IDAOCirugia
    {
        int AgregarCirugia(Cirugia cirugia);
        bool EliminarCirugia(Entidad cirugia);
        bool ModificarCirugia(Cirugia cirugia);
        List<Cirugia> ObtenerCirugias();
    }
}
