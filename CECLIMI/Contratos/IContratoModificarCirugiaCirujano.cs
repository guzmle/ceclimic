using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CECLIMI.Contratos
{
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
