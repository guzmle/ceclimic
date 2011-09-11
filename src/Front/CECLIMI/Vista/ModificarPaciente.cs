using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CECLIMI.Presentador;
using CECLIMI.Contratos;

namespace CECLIMI.Vista
{
    public partial class ModificarPaciente : CECLIMI.Vista.formInicial, IContratoModificarPaciente
    {
        private PresentadorModificarPaciente _presentador;
        public ModificarPaciente()
        {
            InitializeComponent();
            textCodigoAreaFijo.MaxLength = textCodigoAreaMovil.MaxLength = 3;
            textTelefonoFijo.MaxLength = textTelefonoMovil.MaxLength = 7;
            textPrimerNombre.MaxLength =
                textPrimerApellido.MaxLength = textSegundoNombre.MaxLength = textSegundoApellido.MaxLength = 30;
            textCorreoElectronico.MaxLength = 100;
            _presentador = new PresentadorModificarPaciente(this);
        }

        #region Implementation of IContratoModificarPaciente

        public TextBox TextoCiPaciente
        {
            get { return textoCiCirujano; }
        }

        public Button BotonBuscar
        {
            get { return botonBuscar; }
        }

        public Label PrimerNombre
        {
            get { return primerNombre; }
        }

        public Label SegundoNombre
        {
            get { return segundoNombre; }
        }

        public Label PrimerApellido
        {
            get { return primerApellido; }
        }

        public Label SegundoApellido
        {
            get { return segundoApellido; }
        }

        public Label CiPaciente
        {
            get { return ciPaciente; }
        }

        public Label TelefonoFijo
        {
            get { return telefonoFijo; }
        }

        public Label TelefonoMovil
        {
            get { return telefonoMovil; }
        }

        public Label CorreoElectronico
        {
            get { return correoElectrico; }
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

        public TextBox TextCodigoAreaMovil
        {
            get { return textCodigoAreaMovil; }
        }

        public TextBox TextTelefonoFijo
        {
            get { return textTelefonoFijo; }
        }

        public TextBox TextTelefonoMovil
        {
            get { return textTelefonoMovil; }
        }

        public TextBox TextCorreoElectronico
        {
            get { return textCorreoElectronico; }
        }

        public GroupBox GrupoDatosPaciente
        {
            get { return grupoDatosPacientes; }
        }

        #endregion

        private void BotonBuscarClick(object sender, EventArgs e)
        {
            _presentador.BuscarInformacionPaciente();
        }

        private void BotonAceptarClick(object sender, EventArgs e)
        {
            _presentador.ClickBotonAceptar();
        }
    }
}
