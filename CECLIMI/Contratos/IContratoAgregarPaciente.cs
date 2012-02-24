using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CECLIMI.Contratos
{
    public interface IContratoAgregarPaciente
    {
        GroupBox GrupoDatosPaciente { get; }
        TextBox TextPrimerNombre { get; }
        TextBox TextSegundoNombre { get; }
        TextBox TextPrimerApellido { get; }
        TextBox TextSegundoApellido { get; }
        TextBox TextIdPaciente { get; }
        TextBox TextCodigoAreaFijo { get; }
        TextBox TextTelefonoFijo { get; }
        TextBox TextCodigoAreaMovil { get; }
        TextBox TextTelefonoMovil { get; }
        TextBox TextCorreoElectronico { get; }
        
        Label TextInformacionVentana { get; }
        
    }

}
