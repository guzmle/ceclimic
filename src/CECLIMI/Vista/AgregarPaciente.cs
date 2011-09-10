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
        #region Atributos
        private PresentadorAgregarPaciente _presentador;
        #endregion

        #region Constructor
        public AgregarPaciente()
        {
            InitializeComponent();
            _presentador = new PresentadorAgregarPaciente(this);
        }
        #endregion

        #region Metodos
        private void Panel1Paint(object sender, PaintEventArgs e)
        {
            textCodigoAreaFijo.MaxLength = 3;textTelefonoFijo.MaxLength = 7;
            textCodigoAreaMovil.MaxLength = 3;textTelefonoMovil.MaxLength = 7;
            textDescuento1.MaxLength = 3;textDiaIQX1.MaxLength = textMesIQX1.MaxLength = 2;
            textAnoIQX1.MaxLength = 4;
            textPrimerNombre.MaxLength = textPrimerApellido.MaxLength = textSegundoNombre.MaxLength = textSegundoApellido.MaxLength = 15;
            textCorreoElectronico.MaxLength = 100;
        }

        private void Button3Click(object sender, EventArgs e)
        {
            textCodigoAreaFijo.Text = "";textCodigoAreaMovil.Text = "";textCorreoElectronico.Text = "";textIdPaciente.Text = "";
            textPrimerApellido.Text = "";textSegundoApellido.Text = "";textPrimerNombre.Text = "";textSegundoNombre.Text = "";
            textTelefonoFijo.Text = "";textTelefonoMovil.Text = "";

        }

        private void BotonAgregarIntervencionQuirurgicaClick(object sender, EventArgs e)
        {
            _presentador.AgregarNuevaIntervencionQuirurgica();
        }

        private void Button5Click(object sender, EventArgs e)
        {
            _presentador.AgregarIntervencionesQuirurgicas();
        }

        private void Button6Click(object sender, EventArgs e)
        {
            _presentador.ModificarInformacionPaciente();
        }

        private void BotonAceptarClick(object sender, EventArgs e)
        {
            _presentador.ClickAceptar();
        }

        private void ComboIntervencionQuirurgica1SelectedIndexChanged(object sender, EventArgs e)
        {
            _presentador.SeleccionCirugia();
        }

        private void ComboCirujano1SelectedIndexChanged(object sender, EventArgs e)
        {
            _presentador.PrecioOperacion();
        }

        private void BotonQuitarIntervencionQuirurgicaClick(object sender, EventArgs e)
        {
            _presentador.EliminarIntervencionQuirurgica();
        }
        #endregion

        #region Implementacion del Contrato - IContratoAgregarPaciente

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

        public TextBox TextProtesis
        {
            get { return textProtesis; }
        }

        public TextBox TextDescuento
        {
            get { return textDescuento1; }
        }

        public Label TextInformacionVentana
        {
            get { return textInformacionVentana; }
        }

        public ComboBox ComboIntervencionQuirurgica
        {
            get { return comboIntervencionQuirurgica1; }
        }

        public ComboBox ComboCirujano
        {
            get { return comboCirujano1; }
        }

        public Label TextoHonorarioCirujano
        {
            get { return textoHonorarioCirujano; }
        }

        public Label TextoBsFHonorarios
        {
            get { return textoBsFHonorarios; }
        }

        public ComboBox Combo1ErAyudante
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
            get { return  comboCirculante; }
        }

        public ComboBox ComboInstrumentalEspecial
        {
            get { return comboInstrumentalEspecial; }
        }

        public Button BotonAgregarIntervencionQuirurgica
        {
            get { return botonAgregarIntervencionQuirurgica; }
        }

        public Button BotonQuitarIntervencionQuirurgica
        {
            get { return botonQuitarIntervencionQuirurgica; }
        }

        public DataGridView DataGridCirugias
        {
            get { return dataGridCirugias; }
        }

        public TextBox TextDiaIQX1
        {
            get { return textDiaIQX1; }
        }

        public TextBox TextmesIQX1
        {
            get { return textMesIQX1; }
        }

        public TextBox TextAnoIQX1
        {
            get { return textAnoIQX1; }
        }

        public Label Label1
        {
            get { return label17; }
        }

        public Label Label2
        {
            get { return label21; }
        }

        public Label Label3
        {
            get { return label22; }
        }

        public Label Label4
        {
            get { return label23; }
        }

        public Label Label5
        {
            get { return label24; }
        }

        #endregion

        


    }
}
