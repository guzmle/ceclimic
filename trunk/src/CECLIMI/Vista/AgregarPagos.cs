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
            textNombreQuienPaga.MaxLength = 15;
            textSeguro.MaxLength = 30;
            textTipoPago.MaxLength = 3;
            textDiaPago.MaxLength = 2;
            textMesPago.MaxLength = 2;
            textAnoPago.MaxLength = 4;
            _presentador = new PresentadorAgregarPagos(this);
        }

        private void Button6Click(object sender, EventArgs e)
        {
           _presentador.ClickBotonBuscar();

        }

        private void BotonAgregarPagoClick(object sender, EventArgs e)
        {
            _presentador.ClickBotonAgregarPagos();
        }
        #region Implementacion de contratos para AgregarPagos

        public GroupBox GroupInformacionPaciente
        {
            get { return grupoDatosPaciente1; }
        }

        public GroupBox GroupEstatusCuenta
        {
            get { return groupEstatusCuenta; }
        }

        public GroupBox GroupInformacionPago
        {
            get { return groupInformacionPago; }
        }

        public Label TextNombreModificar
        {
            get { return textoNombrePacienteIngresado; }
        }

        public Label TextApellidoModificar
        {
            get { return textoApellidoPacienteIngresado; }
        }

        public Label TextCedulaModificar
        {
            get { return textoCIPacienteIngresado; }
        }

        public Label TextCorreoModificar
        {
            get { return textoCorreoElectronicoPacienteIngresado; }
        }

        public Label TextTelefonoFijoModificar
        {
            get { return textoTelefonoFijoPacienteIngresado; }
        }

        public Label TextTelefonoMovilModificar
        {
            get { return textoTelefonoMovilIngresado; }
        }

        public TextBox TextoCiPaciente
        {
            get { return textoCiPaciente; }
        }
        public DataGridView GridInformacionPagos
        {
            get { return gridInformacionPagos; }
        }

        public DataGridView GridPagosNuevos
        {
            get { return gridPagosNuevos; }
        }

        public Label TextoInformacionGrid
        {
            get { return textoInformacionEstatusCliente; }
        }
        public Label TextoSaldoFavor
        {
            get { return textoSaldoFavor; }
        }
        public Label TextoSaldoFavorModificar
        {
            get { return textoSaldoFavorModificar; }
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

        public TextBox TextQuienPaga
        {
            get { return textNombreQuienPaga; }
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

        public TextBox TextSeguro
        {
            get { return textSeguro; }
        }

        public TextBox TextTipoPago
        {
            get { return textTipoPago; }
        }

        #endregion

        private void BotonAceptarClick(object sender, EventArgs e)
        {
            _presentador.ClickBotonAceptar();
        }

    }
}
