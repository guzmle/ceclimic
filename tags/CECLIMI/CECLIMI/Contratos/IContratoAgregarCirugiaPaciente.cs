using System.Windows.Forms;

namespace CECLIMI.Contratos
{
    /// <summary>
    /// Clase que hace de contrato para la vista de agregar cirujia paciente
    /// </summary>
    public interface IContratoAgregarCirugiaPaciente
    {
        GroupBox GrupoInformacionPaciente { get; }
        TextBox TextoCiPaciente { get; }
        Button BotonBuscar { get; }

        GroupBox GrupoDatosPaciente1 { get; }
        Label TextoNombrePacienteIngresado { get; }
        Label TextoApellidoPacienteIngresado { get; }
        Label TextoCiPacienteIngresado { get; }
        Label TextoCorreoElectronicoPacienteIngresado { get; }
        Label TextoTelefonoFijoPacienteIngresado { get; }
        Label TextoTelefonoMoviServicioPacienteSoapIngresado { get; }

        GroupBox GrupoIntervencionQuirurgica { get; }
        ComboBox ComboIntervencionQuirurgica { get; }
        ComboBox ComboCirujano { get; }
        Label TextoBsfHonorario { get; }
        Label TextoHonorarioCirujano { get; }
        TextBox TextProtesis { get; }
        TextBox TextDescuento { get; }
        Label TextoBsfTotal { get; }
        Label TextoTotaServicioCirugiaSoap { get; }
        Button BotonCalculadora { get; }
        Button BotonAgregarCirugia { get; }
        Button BotonEliminarCirugia { get; }
        DataGridView GridCirugias { get; }

        GroupBox GrupoPersonalQuirurgico { get; }
        ComboBox ComboPrimerAyudante { get; }
        ComboBox ComboAnestesiologo { get; }
        ComboBox ComboInstrumentista { get; }
        ComboBox ComboCirculante { get; }
        ComboBox InstrumentistaEspecial { get; }
        TextBox TextDiaIqx1 { get; }
        TextBox TextMesIqx1 { get; }
        TextBox TextAnoIqx1 { get; }
        TextBox TextDiaElaboracion { get; }
        TextBox TextMesElaboracion { get; }
        TextBox TextAnoElaboracion { get; }
        Label LabelObservaciones { get; }
        TextBox Observaciones { get; }

        Button BotonAceptar { get; }
        Button BotonCancelar { get; }


    }
}
