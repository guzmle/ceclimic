using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CECLIMI.Contratos
{
    public interface IContratoAgregarPagos
    {
        TextBox TextoCiPaciente { get; }
        DataGridView GridInformacionPagos { get; }
        Label TextoInformacionGrid { get; }
        Label TextoTotalAbonado { get; }
        Label TextoTotalAbonadoModificar { get; }
        Label TextoSaldoFavor { get; }
        Label TextoSaldoFavorModificar { get; }
        Label TextoSaldoDeudor { get; }
        Label TextoSaldoDeudorModificar { get; }
        TextBox TextoMontoFactura { get; }
        TextBox TextoNumeroFactura { get; }
        TextBox TextoDia { get; }
        TextBox TextoAno { get; }
        TextBox TextoMes { get; }
        Button BotonBuscar { get; }
        Button BotonAgregarNuevaFactura { get; }
        Button BotonCancelarAgregarPagos { get; }
        Button BotonAceptarPagosAgregados { get; }

    }
}
