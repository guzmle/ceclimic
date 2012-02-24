using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CECLIMI.Contratos
{
    public interface IContratoReportePaqueteFinanciero
    {
        GroupBox InformacionPaciente { get; }
        TextBox TextCiPaciente { get; }
        Button BotonBuscar { get; }

        GroupBox PaquetesFinancieros { get; }
        ComboBox ComboPaquetesFinancieros { get; }

        GroupBox PaqueteFinanciero { get; }
        Label NombrePaciente { get; }
        Label FechaElaboracion { get; }
        Label Cedula { get; }
        Label Telefonos { get; }
        Label Correo { get; }
        Label PacientesAlternos { get; }
        DataGridView Cirugias { get; }
        DataGridView Pagos { get; }
        Label FechaIntervencion { get; }
        Label Observaciones { get; }

        Button Aceptar { get; }
    }
}
