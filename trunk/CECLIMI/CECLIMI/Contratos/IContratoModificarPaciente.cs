using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CECLIMI.Contratos
{
    public interface IContratoModificarPaciente
    {
        TextBox TextoCiPaciente { get; }
        Button BotonBuscar { get; }
        Label PrimerNombre { get; }
        Label SegundoNombre { get; }
        Label PrimerApellido { get; }
        Label SegundoApellido { get; }
        Label CiPaciente { get; }
        Label TelefonoFijo { get; }
        Label TelefonoMovil { get; }
        Label CorreoElectronico { get; }
        TextBox TextPrimerNombre { get; }
        TextBox TextSegundoNombre { get; }
        TextBox TextPrimerApellido { get; }
        TextBox TextSegundoApellido { get; }
        TextBox TextIdPaciente { get; }
        TextBox TextCodigoAreaFijo { get; }
        TextBox TextCodigoAreaMovil { get; }
        TextBox TextTelefonoFijo { get; }
        TextBox TextTelefonoMovil { get; }
        TextBox TextCorreoElectronico { get; }
    }
}
