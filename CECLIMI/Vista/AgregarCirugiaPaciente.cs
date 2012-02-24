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
    public partial class AgregarCirugiaPaciente : CECLIMI.Vista.formInicial,IContratoAgregarCirugiaPaciente
    {
        private PresentadorAgregarCirugiaPaciente _presentador;

        public AgregarCirugiaPaciente()
        {
            InitializeComponent();
            _presentador = new PresentadorAgregarCirugiaPaciente(this);
        }

        #region Implementation of IContratoAgregarCirugiaPaciente

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
            get { return textoCIPacienteIngresado; }
        }

        public Label TextoCorreoElectronicoPacienteIngresado
        {
            get { return textoCorreoElectronicoPacienteIngresado; }
        }

        public Label TextoTelefonoFijoPacienteIngresado
        {
            get { return  textoTelefonoFijoPacienteIngresado; }
        }

        public Label TextoTelefonoMovilPacienteIngresado
        {
            get { return textoTelefonoMovilIngresado; }
        }

        public GroupBox GrupoIntervencionQuirurgica
        {
            get { return grupoIntervencionQuirurgica; }
        }

        public ComboBox ComboIntervencionQuirurgica
        {
            get { return comboIntervencionQuirurgica1; }
        }

        public ComboBox ComboCirujano
        {
            get { return comboCirujano1; }
        }

        public Label TextoBsfHonorario
        {
            get { return textoBsFHonorarios; }
        }

        public Label TextoHonorarioCirujano
        {
            get { return textoHonorarioCirujano; }
        }

        public TextBox TextProtesis
        {
            get { return textProtesis; }
        }

        public Label TextoTotalCirugia
        {
            get { throw new NotImplementedException(); }
        }

        public Button BotonCalculadora
        {
            get { throw new NotImplementedException(); }
        }

        public Button BotonAgregarCirugia
        {
            get { return botonAgregarIqx; }
        }

        public Button BotonEliminarCirugia
        {
            get { return botonEliminarIqx; }
        }

        public DataGridView GridCirugias
        {
            get { return gridInfoCirugias; }
        }

        public GroupBox GrupoPersonalQuirurgico
        {
            get { return grupoPersonalQuirurgico; }
        }

        public ComboBox ComboPrimerAyudante
        {
            get { return combo1erAyudante; }
        }

        public ComboBox ComboAnestesiologo
        {
            get { return comboAnestesiologo; }
        }

        public ComboBox ComboInstrumentista
        {
            get { return comboInstrumentista; }
        }

        public ComboBox ComboCirculante
        {
            get { return comboCirculante; }
        }

        public ComboBox InstrumentistaEspecial
        {
            get { return comboInstrumentalEspecial; }
        }

        public TextBox TextDescuento
        {
            get { return textDescuento1; }
        }

        public Label TextoBsfTotal
        {
            get { throw new NotImplementedException(); }
        }

        public TextBox TextDiaIqx1
        {
            get { return textDiaIQX1; }
        }

        public TextBox TextMesIqx1
        {
            get { return textMesIQX1; }
        }

        public TextBox TextAnoIqx1
        {
            get { return textAnoIQX1; }
        }

        public TextBox TextDiaElaboracion
        {
            get { return textDiaElaboracion; }
        }

        public TextBox TextMesElaboracion
        {
            get { return textMesElaboracion; }
        }

        public TextBox TextAnoElaboracion
        {
            get { return textAnoElaboracion; }
        }

        public Label LabelObservaciones
        {
            get { return labelObservaciones; }
        }

        public TextBox Observaciones
        {
            get { return observaciones; }
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
            _presentador.BuscarInformacionPaciente();
            _presentador.LLenarCirugias();
            _presentador.LlenarPersonalQuirurgico();
            _presentador.ActivarControladoresOcultos();
        }

        private void ComboIntervencionQuirurgica1SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboIntervencionQuirurgica1.SelectedIndex != -1)
            {
                _presentador.CargarInformacionCirujanos();
            }
        }

        private void ComboCirujano1SelectedIndexChanged(object sender, EventArgs e)
        {
            _presentador.PrecioOperacion();
        }

        private void BotonAceptarClick(object sender, EventArgs e)
        {
            if (_presentador.ClickAceptar())
            {
                this.Close();
            }
        }

        private void BotonAgregarIqxClick(object sender, EventArgs e)
        {
            _presentador.AgregarCirugia();
        }

        private void BotonEliminarIqxClick(object sender, EventArgs e)
        {
            _presentador.EliminarCirugia();
        }

        private void BotonCancelarClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
