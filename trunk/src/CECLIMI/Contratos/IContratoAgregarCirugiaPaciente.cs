using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CECLIMI.Contratos
{
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
        Label TextoTelefonoMovilPacienteIngresado { get; }
        Button BotonModificarInformacion { get; }

        GroupBox GrupoIntervencionQuirurgica { get; }
        ComboBox ComboIntervencionQuirurgica { get; }
        ComboBox ComboCirujano { get; }
        Label TextoBsfHonorario { get; }
        Label TextoHonorarioCirujano { get; }
        TextBox TextProtesis { get; }
        ComboBox ComboPrimerAyudante { get; }
        ComboBox ComboAnestesiologo { get; }
        ComboBox ComboInstrumentista { get; }
        ComboBox ComboCirculante { get; }
        ComboBox InstrumentistaEspecial { get; }
        TextBox TextDescuento { get; }
        TextBox TextDiaIqx1 { get; }
        TextBox TextMesIqx1 { get; }
        TextBox TextAnoIqx1 { get; }


    }
}
