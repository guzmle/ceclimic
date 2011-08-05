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
    public partial class AgregarTransferencia : CECLIMI.Vista.formInicial,IContratoAgregarTransferencia
    {
        private PresentadorAgregarTransferencia _presentador;
        public AgregarTransferencia()
        {
            InitializeComponent();
            _presentador = new PresentadorAgregarTransferencia(this);
        }

        #region Implementacion del contrato Agregar Transferencia

        public TextBox TextoCiPaciente
        {
            get { return textoCiPaciente; }
        }

        public Button BotonBuscar
        {
            get { return botonBuscar; }
        }

        public DataGridView GridInformacionPagos
        {
            get { return gridInformacionPagos; }
        }

        public Label TextoTotalAbonado
        {
            get { return textoTotalAbonado; }
        }

        public Label TextoTotalAbonadoModificar
        {
            get { return textoTotalAbonadoModificar; }
        }

        public GroupBox GrupoEstatusCuenta
        {
            get { return grupoEstatusCuenta; }
        }

        public GroupBox GroupInformacionTransferencia
        {
            get { return groupInformacionTransferencia; }
        }

        public TextBox TextoMontoPagar
        {
            get { return textoMontoPagar; }
        }

        public TextBox TextoCiBeneficiario
        {
            get { return textoCIBeneficiario; }
        }

        public Button BuscarBeneficiario
        {
            get { return buscarBeneficiario; }
        }

        public Button BotonAceptar
        {
            get { return botonAceptar; }
        }

        public Button BotonCancelar
        {
            get { return botonCancelar; }
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
            get { return textoCIPacienteIngresado; }
        }

        public Label TextoCorreoElectronicoPacienteIngresado
        {
            get { return textoCorreoElectronicoPacienteIngresado; }
        }

        public Label TextoTelefonoFijoPacienteIngresado
        {
            get { return textoTelefonoFijoPacienteIngresado; }
        }

        public Label TextoTelefonoMovilPacienteIngresado
        {
            get { return textoTelefonoMovilIngresado; }
        }

        public Button ModificarInformacion
        {
            get { return botonModificarInformacion; }
        }

        public GroupBox GrupoInfrormacionPaciente
        {
            get { return grupoInformacionPaciente; }
        }

        public Label TextoNombreBeneficiario
        {
            get { return textNombreBeneficiario; }
        }

        public Label TextoApellidoBeneficiario
        {
            get { return textApellidoBeneficiario; }
        }

        public Label TextNb
        {
            get { return textNB; }
        }

        public Label TextAb
        {
            get { return textAB; }
        }

        public Label TextMp
        {
            get { return textMP; }
        }

        public Label TextBsf
        {
            get { return textBsF; }
        }

        public Label Label8
        {
            get { return label8; }
        }

        #endregion

        private void BotonBuscarClick(object sender, EventArgs e)
        {
            _presentador.BuscarInformacionPaciente();
        }

        private void BotonModificarInformacionClick(object sender, EventArgs e)
        {
            _presentador.BotonModificar();
        }

        private void BuscarBeneficiarioClick(object sender, EventArgs e)
        {
            _presentador.BuscarBeneficiario();
        }

        private void BotonAceptarClick(object sender, EventArgs e)
        {
            _presentador.ClickAceptar();
        }
    }
}
