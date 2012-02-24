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
    public partial class AgregarCirugia : CECLIMI.Vista.formInicial, IContratoAgregarCirugia
    {
        private PresentadorAgregarCirugia _presentador;
        public AgregarCirugia()
        {
            InitializeComponent();
            textNombreCirugia.MaxLength = 100;
            textDescripcionCirugia.MaxLength = 200;
            _presentador= new PresentadorAgregarCirugia(this);
        
        }

        #region DeclaracionIcontratoAgregarCirugia
        public TextBox TextNombreCirugia
        {
            get { return textNombreCirugia; }
        }

        public TextBox TextDescripcionCirugia
        {
            get { return textDescripcionCirugia; }
        }

        public Button BotonAceptar
        {
            get { return botonAceptarCirugia; }
        }

        public Button BotonCancelar
        {
            get { return botonCancelarCirugia; }
        }

        public Label MensajeDeError
        {
            get { return mensajeDeError; }
        }
        #endregion
        
        private void BotonAceptarCirugiaClick(object sender, EventArgs e)
        {
            long respuesta = _presentador.BotonAceptar();
            if (respuesta != -1)
            {
                this.Close();
            }
        }

        private void BotonCancelarCirugiaClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
