using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CECLIMI.Contratos
{
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
        Label TextoTelefonoMovilPacienteIngresado { get; }
        Button BotonModificarInformacion { get; }

        GroupBox GrupoCirugiaPaciente { get; }
        DataGridView DataGridView1 { get; }

        GroupBox GrupoCirugiaEliminar { get; }
        TextBox TextIdCirugia { get; }
        Button BotonBuscarCirugia { get; }
    }
}
