using System.Windows.Forms;

namespace CECLIMI.Contratos
{
    /// <summary>
    /// Clase que hace de contrato para la vista de agregar cirujano
    /// </summary>
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
