using System.Windows.Forms;

namespace CECLIMI.Contratos
{
    /// <summary>
    /// Clase que hace de contrato para la vista de modificar cirujia cirujano
    /// </summary>
    public interface IContratoModificarCirugiaCirujano
    {
        GroupBox GrupoInformacionCirujano { get; }
        TextBox TextCiCirujano { get; }
        Button BotonBuscar { get; }

        GroupBox GrupoDatosCirujano { get; }
        Label TextNombreModificar { get; }
        Label TextApellidoModificar { get; }
        Label TextTelefonoModificar { get; }
        Label TextTelefonoMovilModificar { get; }
        Label TextCorreoModificar { get; }

        GroupBox GroupCirugiasCirujano { get; }
        DataGridView GridInformacionCirugiasCirujano { get; }

        Button BotonAceptar { get; }
        Button BotonCancelar { get; }

    }
}
