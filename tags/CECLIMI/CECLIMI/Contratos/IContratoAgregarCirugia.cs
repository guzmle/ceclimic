using System.Windows.Forms;

namespace CECLIMI.Contratos
{
    /// <summary>
    /// Clase que hace de contrato para la vista de agregar cirujia
    /// </summary>
    public interface IContratoAgregarCirugia
    {
        TextBox TextNombreCirugia { get; }
        TextBox TextDescripcionCirugia { get; }
        Button BotonAceptar { get; }
        Button BotonCancelar { get; }
        Label MensajeDeError { get; }
    }
}
