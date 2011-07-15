using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CECLIMI.Contratos;
using CECLIMI.Presentador;

namespace CECLIMI.Vista
{
    public partial class AgregarPagos : CECLIMI.Vista.formInicial,IContratoAgregarPagos
    {
        private PresentadorAgregarPagos _presentador;
        public AgregarPagos()
        {
            InitializeComponent();
            _presentador = new PresentadorAgregarPagos(this);
        }

        private void AgregarPagos_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           _presentador.ClickBotonBuscar();

        }

        #region Implementacion de contratos para AgregarPagos
        public TextBox TextoCiPaciente
        {
            get { return textoCiPaciente; }
        }
        public DataGridView GridInformacionPagos
        {
            get { return gridInformacionPagos; }
        }
        public Label TextoInformacionGrid
        {
            get { return textoInformacionEstatusCliente; }
        }
        public Label TextoTotalAbonado
        {
            get { return textoTotalAbonado; }
        }
        public Label TextoTotalAbonadoModificar
        {
            get { return textoTotalAbonadoModificar; }
        }
        public Label TextoSaldoFavor
        {
            get { return textoSaldoFavor; }
        }
        public Label TextoSaldoFavorModificar
        {
            get { return textoSaldoFavorModificar; }
        }
        public Label TextoSaldoDeudor
        {
            get { return textoSaldoDeudor; }
        }
        public Label TextoSaldoDeudorModificar
        {
            get { return textoSaldoDeudorModificar; }
        }
        public TextBox TextoMontoFactura
        {
            get { return textoMontoPagar; }
        }
        public TextBox TextoNumeroFactura
        {
            get { return textoNumeroFactura; }
        }
        public TextBox TextoDia
        {
            get { return textDiaPago; }
        }
        public TextBox TextoAno
        {
            get { return textAnoPago; }
        }
        public TextBox TextoMes
        {
            get { return textMesPago; }
        }
        public Button BotonBuscar
        {
            get { return botonBuscar; }
        }
        public Button BotonAgregarNuevaFactura
        {
            get { return botonAgregarPago; }
        }
        public Button BotonCancelarAgregarPagos
        {
            get { return botonCancelar; }
        }
        public Button BotonAceptarPagosAgregados
        {
            get { return botonAceptar; }
        }
        #endregion


    }
}
