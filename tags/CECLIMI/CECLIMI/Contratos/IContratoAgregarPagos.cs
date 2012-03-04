using System.Windows.Forms;

namespace CECLIMI.Contratos
{
    /// <summary>
    /// Clase que hace de contrato para la vista de agregar pagos
    /// </summary>
    public interface IContratoAgregarPagos
    {
        GroupBox GroupInformacionPaciente { get; }
        GroupBox GroupInformacionPago { get; }
        GroupBox GroupInformacionPaquetesFinancieros { get; }

        Label TextNombreModificar { get; }
        Label TextApellidoModificar { get; }
        Label TextCedulaModificar { get; }
        Label TextCorreoModificar { get; }
        Label TextTelefonoFijoModificar { get; }
        Label TextTelefonoMovilModificar { get; }
        ComboBox ComboPaquetes { get; }

        TextBox TextoCiPaciente { get; }
        DataGridView GridPagosNuevos { get; }
        TextBox TextoMontoFactura { get; }
        TextBox TextoNumeroFactura { get; }
        TextBox TextoDia { get; }
        TextBox TextoAno { get; }
        TextBox TextoMes { get; }
        TextBox TextQuienPaga { get; }
        Button BotonBuscar { get; }
        Button BotonAgregarNuevaFactura { get; }
        Button BotonCancelarAgregarPagos { get; }
        Button BotonAceptarPagosAgregados { get; }
        TextBox TextSeguro { get; }
        TextBox TextTipoPago { get; }


    }
}
