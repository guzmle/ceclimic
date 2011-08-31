using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CECLIMI.Contratos
{
    public interface IContratoModificarCirujano
    {
        TextBox TextCiCirujano { get; }
        Button BotonBuscar { get; }

        GroupBox GrupoDatosCirujano { get; }
        TextBox TextPrimerNombre { get; }
        TextBox TextSegundoNombre { get; }
        TextBox TextPrimerApellido { get; }
        TextBox TextSegundoApellido { get; }
        TextBox TextCodigoAreaFijo { get; }
        TextBox TextCodigoAreaMovil { get; }
        TextBox TextTelefonoFijo { get; }
        TextBox TextTelefonoMovil { get; }
        TextBox TextCorreoElectronico { get; }

        Button BotonAceptar { get; }
        Button BotonCancelar { get; }

    }
}
