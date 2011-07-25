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
            _presentador= new PresentadorAgregarCirugia(this);
        
        }

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

        private void botonAceptarCirugia_Click(object sender, EventArgs e)
        {
            _presentador.BotonAceptar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
