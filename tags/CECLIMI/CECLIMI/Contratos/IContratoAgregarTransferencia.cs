﻿using System.Windows.Forms;

namespace CECLIMI.Contratos
{
    /// <summary>
    /// Clase que hace de contrato para la vista de agregar transferencia
    /// </summary>
    public interface IContratoAgregarTransferencia
    {
        TextBox TextoCiPaciente { get; }
        Button BotonBuscar { get; }
        DataGridView GridInformacionPagos { get; }
        Label TextoTotalAbonado { get; }
        Label TextoTotalAbonadoModificar { get; }
        GroupBox GrupoEstatusCuenta { get; }
        GroupBox GroupInformacionTransferencia { get; }
        TextBox TextoMontoPagar { get; }
        TextBox TextoCiBeneficiario { get; }
        Button BuscarBeneficiario { get; }
        Button BotonAceptar { get; }
        Button BotonCancelar { get; }
        GroupBox GrupoDatosPaciente1 { get; }
        Label TextoNombrePacienteIngresado { get; }
        Label TextoApellidoPacienteIngresado { get; }
        Label TextoCiPacienteIngresado { get; }
        Label TextoCorreoElectronicoPacienteIngresado { get; }
        Label TextoTelefonoFijoPacienteIngresado { get; }
        Label TextoTelefonoMoviServicioPacienteSoapIngresado { get; }
        Button ModificarInformacion { get; }
        GroupBox GrupoInfrormacionPaciente { get; }
        Label TextoNombreBeneficiario { get; }
        Label TextoApellidoBeneficiario { get; }
        Label TextNb { get; }
        Label TextAb { get; }
        Label TextMp { get; }
        Label TextBsf { get; }
        Label Label8 { get; }

    }
}
