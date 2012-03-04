using System.Windows.Forms;

namespace CECLIMI.Contratos
{

    /// <summary>
    /// Clase que hace de contrato para la vista de agregar paciente
    /// </summary>
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
