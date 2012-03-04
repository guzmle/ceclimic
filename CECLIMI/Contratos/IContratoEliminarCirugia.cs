using System.Windows.Forms;

namespace CECLIMI.Contratos
{
    /// <summary>
    /// Clase que hace de contrato para la vista de eliminar cirujia
    /// </summary>
    public interface IContratoEliminarCirugia
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
        Button BotonModificarInformacion { get; }

        GroupBox GrupoCirugiaPaciente { get; }
        DataGridView DataGridView1 { get; }

        GroupBox GrupoCirugiaEliminar { get; }
        TextBox TextIdCirugia { get; }
        Button BotonBuscarCirugia { get; }
    }
}
