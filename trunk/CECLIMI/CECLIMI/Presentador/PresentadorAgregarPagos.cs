using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CECLIMI.Contratos;

namespace CECLIMI.Presentador
{
    public class PresentadorAgregarPagos
    {
        private IContratoAgregarPagos _vista;

        public PresentadorAgregarPagos (IContratoAgregarPagos vista)
        {
            _vista = vista;
        }

        //metodo que muestra la informacion del paciente cuando busca por cedula en agregar pagos
        public void ClickBotonBuscar ()
        {
            _vista.TextoInformacionGrid.Text = "";
            _vista.GridInformacionPagos.Visible = true;
            _vista.TextoTotalAbonado.Visible = _vista.TextoSaldoFavor.Visible = _vista.TextoSaldoDeudor.Visible = true;
            _vista.TextoSaldoFavorModificar.Visible = _vista.TextoSaldoDeudorModificar.Visible = _vista.TextoTotalAbonadoModificar.Visible = true;
        }


    }
}
