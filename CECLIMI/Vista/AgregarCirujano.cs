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
    public partial class AgregarCirujano : CECLIMI.Vista.formInicial , IContratoAgregarCirujano
    {
        private PresentadorAgregarCirujano _presentador;

        public AgregarCirujano()
        {
            InitializeComponent();
            _presentador = new PresentadorAgregarCirujano(this);
        }

        #region Implementation of IContratoAgregarCirujano

        public GroupBox GrupoDatosCirujano
        {
            get { return grupoDatosCirujano; }
        }

        public TextBox PNombre
        {
            get { return textPrimerNombre; }
        }

        public TextBox SNombre
        {
            get { return textSegundoNombre; }
        }

        public TextBox PApellido
        {
            get { return textPrimerApellido; }
        }

        public TextBox SApellido
        {
            get { return textSegundoApellido; }
        }

        public TextBox Cedula
        {
            get { return textIdCirujano; }
        }

        public TextBox CodigoTelefonoFijo
        {
            get { return textCodigoAreaFijo; }
        }

        public TextBox TelefonoFijo
        {
            get { return textTelefonoFijo; }
        }

        public TextBox CodigoTelefonoMovil
        {
            get { return textCodigoAreaMovil; }
        }

        public TextBox TelefonoMovil
        {
            get { return textTelefonoMovil; }
        }

        public TextBox CorreoElectronico
        {
            get { return textCorreoElectronico; }
        }

        public Label MensajePNombre
        {
            get { return mensajeDeErrorNombre; }
        }

        public Label MensajePApellido
        {
            get { return mensajeDeErrorApellido; }
        }

        public Label MensajeCedula
        {
            get { return mensajeDeErrorCedula; }
        }

        public Label MensajeTelefonoMovil
        {
            get { return mensajeDeErrorTelefonoMovil; }
        }

        #endregion

        private void BotonAceptarCirugiaClick(object sender, EventArgs e)
        {
            if(_presentador.InsertarCirujano())
            {
                DialogResult result =
                        MessageBox.Show("El cirujano fue agregado con exito al sistema.", "Transaccion Exitosa", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void BotonCancelarCirugiaClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
