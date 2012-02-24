using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CECLIMI.Contratos
{
    public interface IContratoAgregarCirujano
    {
        GroupBox GrupoDatosCirujano { get; }
        TextBox PNombre { get; }
        TextBox SNombre { get; }
        TextBox PApellido { get; }
        TextBox SApellido { get; }
        TextBox Cedula { get; }
        TextBox CodigoTelefonoFijo { get; }
        TextBox TelefonoFijo { get; }
        TextBox CodigoTelefonoMovil { get; }
        TextBox TelefonoMovil { get; }
        TextBox CorreoElectronico { get; }
        Label MensajePNombre { get; }
        Label MensajePApellido { get; }
        Label MensajeCedula { get; }
        Label MensajeTelefonoMovil { get; }
    }
}
