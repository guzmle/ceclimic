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
    public partial class ModificarCirujano : CECLIMI.Vista.formInicial, IContratoModificarCirujano
    {
        private PresentadorModificarCirujano _presentador;
        public ModificarCirujano()
        {
            InitializeComponent();
            textCodigoAreaFijo.MaxLength = textCodigoAreaMovil.MaxLength = 3;
            textTelefonoFijo.MaxLength = textTelefonoMovil.MaxLength= 7;
            textPrimerNombre.MaxLength =
                textPrimerApellido.MaxLength = textSegundoNombre.MaxLength = textSegundoApellido.MaxLength = 30;
            textCorreoElectronico.MaxLength = 100;
            _presentador = new PresentadorModificarCirujano(this);
        }

        #region Implementation of IContratoModificarCirujano

        public TextBox TextCiCirujano
        {
            get { return textoCiCirujano; }
        }

        public Button BotonBuscar
        {
            get { return botonBuscar; }
        }

        public GroupBox GrupoDatosCirujano
        {
            get { return grupoDatosCirujano; }
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
            _presentador.BuscarCirujano();
        }

        private void BotonAceptarClick(object sender, EventArgs e)
        {
            _presentador.ClickBotonAceptar();
        }

        
    }
}
