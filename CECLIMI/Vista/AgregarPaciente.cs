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
            textPrimerNombre.MaxLength = textPrimerApellido.MaxLength = textSegundoNombre.MaxLength = textSegundoApellido.MaxLength = 15;
            textCorreoElectronico.MaxLength = 100;
        }
        private void BotonAceptarClick(object sender, EventArgs e)
        {
            if (_presentador.ClickAceptar())
            {
                this.Close();
            }
        }

        
        #endregion

        #region Implementacion del Contrato - IContratoAgregarPaciente

        public GroupBox GrupoDatosPaciente
        {
            get { return grupoDatosPacientes; }
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
