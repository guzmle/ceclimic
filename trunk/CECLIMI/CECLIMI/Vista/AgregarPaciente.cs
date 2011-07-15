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
    public partial class AgregarPaciente : CECLIMI.Vista.formInicial,IContratoAgregarPaciente
    {
        private PresentadorAgregarPaciente _presentador;
        public AgregarPaciente()
        {
            InitializeComponent();
            _presentador = new PresentadorAgregarPaciente(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            textCodigoAreaFijo.MaxLength = 4;
            textTelefonoFijo.MaxLength = 7;
            textCodigoAreaMovil.MaxLength = 4;
            textTelefonoMovil.MaxLength = 7;
            textDescuento1.MaxLength = 3;
            textDiaIQX1.MaxLength = textMesIQX1.MaxLength = 2;
            textAnoIQX1.MaxLength = 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textCodigoAreaFijo.Text = "";textCodigoAreaMovil.Text = "";textCorreoElectronico.Text = "";textIdPaciente.Text = "";
            textPrimerApellido.Text = "";textSegundoApellido.Text = "";textPrimerNombre.Text = "";textSegundoNombre.Text = "";
            textTelefonoFijo.Text = "";textTelefonoMovil.Text = "";

        }

        private void botonAgregarIntervencionQuirurgica_Click(object sender, EventArgs e)
        {
              
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _presentador.agregarIntervencionesQuirurgicas();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _presentador.modificarInformacionPaciente();
        }

        #region Implementation of IContratoAgregarPaciente

        public GroupBox GrupoDatosPaciente
        {
            get { return grupoDatosPacientes; }
        }

        public GroupBox GrupoDatosPaciente1
        {
            get { return grupoDatosPaciente1; }
        }

        public GroupBox GrupoIntervencionQuirurgica
        {
            get { return grupoIntervencionQuirurgica; }
        }

        public Button BotonAgregarIQX
        {
            get { return botonAgregarIQX; }
        }

        public Button ModificarInformacion
        {
            get { return botonModificarInformacion; }
        }

        public Label TextoNombrePacienteIngresado
        {
            get { return textoNombrePacienteIngresado; }
        }

        public Label TextoApellidoPacienteIngresado
        {
            get { return textoApellidoPacienteIngresado; }
        }

        public Label TextoCIPacienteIngresado
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

        public Label TextoTelefonoMovilIngresado
        {
            get { return textoTelefonoMovilIngresado; }
        }

        public TextBox TextPrimerNombre
        {
            get { return textPrimerNombre; }
        }

        public TextBox TextSegundoNombre
        {
            get { return textSegundoNombre; }
        }

        public TextBox TextPrimerApellido
        {
            get { return textPrimerApellido; }
        }

        public TextBox TextSegundoApellido
        {
            get { return textSegundoApellido; }
        }

        public TextBox TextIdPaciente
        {
            get { return textIdPaciente; }
        }

        public TextBox TextCodigoAreaFijo
        {
            get { return textCodigoAreaFijo; }
        }

        public TextBox TextTelefonoFijo
        {
            get { return textTelefonoFijo; }
        }

        public TextBox TextCodigoAreaMovil
        {
            get { return textCodigoAreaMovil; }
        }

        public TextBox TextTelefonoMovil
        {
            get { return textTelefonoMovil; }
        }

        public TextBox TextCorreoElectronico
        {
            get { return textCorreoElectronico; }
        }

        public Label TextInformacionVentana
        {
            get { return textInformacionVentana; }
        }

        #endregion


    }
}
