using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CECLIMI.Contratos
{
    public interface IContratoAgregarCirugia
    {
        TextBox TextNombreCirugia { get; }
        TextBox TextDescripcionCirugia { get; }
        Button BotonAceptar { get; }
        Button BotonCancelar { get; }
    }
}
