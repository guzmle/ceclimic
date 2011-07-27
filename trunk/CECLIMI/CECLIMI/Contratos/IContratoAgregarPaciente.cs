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
        GroupBox GrupoDatosPaciente1 { get; }
        GroupBox GrupoIntervencionQuirurgica { get; }
        Button BotonAgregarIQX { get; }
        Button ModificarInformacion { get; }
        Label TextoNombrePacienteIngresado { get; }
        Label TextoApellidoPacienteIngresado { get; }
        Label TextoCIPacienteIngresado { get; }
        Label TextoCorreoElectronicoPacienteIngresado { get; }
        Label TextoTelefonoFijoPacienteIngresado { get; }
        Label TextoTelefonoMovilIngresado { get; }
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
        TextBox TextProtesis { get; }
        TextBox TextDescuento { get; }
        Label TextInformacionVentana { get; }
        ComboBox ComboIntervencionQuirurgica { get; }
        ComboBox ComboCirujano { get; }
        Label TextoHonorarioCirujano { get; }
        Label TextoBsFHonorarios { get; }

        ComboBox Combo1ErAyudante { get; }
        ComboBox ComboAnestesiologo { get; }
        ComboBox ComboInstrumentista { get; }
        ComboBox ComboCirculante { get; }
        ComboBox ComboInstrumentalEspecial { get; }

        Button BotonAgregarIntervencionQuirurgica { get; }
        Button BotonQuitarIntervencionQuirurgica { get; }

        DataGridView DataGridCirugias { get; }

        TextBox TextDiaIQX1 { get; }
        TextBox TextmesIQX1 { get; }
        TextBox TextAnoIQX1 {get;}

        Label Label1 { get; }
        Label Label2 { get; }
        Label Label3 { get; }
        Label Label4 { get; }
        Label Label5 { get; }
    }

}
