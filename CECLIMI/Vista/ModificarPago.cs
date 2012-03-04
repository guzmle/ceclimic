using System;
using System.Windows.Forms;
using CECLIMI.Contratos;
using CECLIMI.Presentador;

namespace CECLIMI.Vista
{
    public partial class ModificarPago : CECLIMI.Vista.formInicial,IContratoModificarPago
    {
        private PresentadorModificarPago _presentador;
        public ModificarPago()
        {
            InitializeComponent();
            _presentador = new PresentadorModificarPago(this);
        }

        #region Implementation of IContratoModificarPago

        public GroupBox GrupoInformacionPaciente
        {
            get { return grupoInformacionPaciente; }
        }

        public TextBox TextoCiPaciente
        {
            get { return textoCiPaciente; }
        }

        public Button BotonBuscar
        {
            get { return botonBuscar; }
        }

        public GroupBox GrupoDatosPaciente1
        {
            get { return grupoDatosPaciente1; }
        }

        public Label TextoNombrePacienteIngresado
        {
            get { return textoNombrePacienteIngresado; }
        }

        public Label TextoApellidoPacienteIngresado
        {
            get { return textoApellidoPacienteIngresado; }
        }

        public Label TextoCiPacienteIngresado
        {
            get { return textoCIPacienteIngresado;  }
        }

        public Label TextoCorreoElectronicoPacienteIngresado
        {
            get { return textoCorreoElectronicoPacienteIngresado; }
        }

        public Label TextoTelefonoFijoPacienteIngresado
        {
            get { return textoTelefonoFijoPacienteIngresado; }
        }

        public Label TextoTelefonoMoviServicioPacienteSoapIngresado
        {
            get { return textoTelefonoMovilIngresado; }
        }

        public GroupBox GroupEstatusCuenta
        {
            get { return groupEstatusCuenta; }
        }

        public DataGridView GridInformacionPagos
        {
            get { return gridInformacionPagos; }
        }

        public Label TextoSaldoFavor
        {
            get { return textoSaldoFavor; }
        }

        public Label TextoSaldoFavorModificar
        {
            get { return textoSaldoFavorModificar; }
        }

        public GroupBox DatoModificar
        {
            get { return groupDatoModificar; }
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
            get { return TextQuienPaga; }
        }

        public TextBox TextSeguro
        {
            get { return textSeguro; }
        }

        public TextBox TextTipoPago
        {
            get { return textTipoPago; }
        }

        public TextBox TextoIdFactura
        {
            get { return textoIdFactura; }
        }

        public Button BuscarPago
        {
            get { return buscarFactura; }
        }

        public Label TextFacturaModificar
        {
            get { return textFacturaModificar; }
        }

        public Button BotonAceptar
        {
            get { return botonAceptar; }
        }

        public Button BotonCancelar
        {
            get { return botonCancelar; }
        }

        #endregion

        private void BotonBuscarClick(object sender, EventArgs e)
        {
            _presentador.BuscarPaciente();
        }
    }
}
