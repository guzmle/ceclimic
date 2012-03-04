﻿using System.Windows.Forms;

namespace CECLIMI.Contratos
{
    /// <summary>
    /// Clase que hace de contrato para la vista de modificar pagos
    /// </summary>
    public interface IContratoModificarPago
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

        GroupBox GroupEstatusCuenta { get; }
        DataGridView GridInformacionPagos { get; }
        Label TextoSaldoFavor { get; }
        Label TextoSaldoFavorModificar { get; }

        GroupBox DatoModificar { get; }
        TextBox TextoMontoFactura { get; }
        TextBox TextoNumeroFactura { get; }
        TextBox TextoDia { get; }
        TextBox TextoAno { get; }
        TextBox TextoMes { get; }
        TextBox TextQuienPaga { get; }
        TextBox TextSeguro { get; }
        TextBox TextTipoPago { get; }

        TextBox TextoIdFactura { get; }
        Button BuscarPago { get; }
        Label TextFacturaModificar { get; }

        Button BotonAceptar { get; }
        Button BotonCancelar { get; }
    }
}
