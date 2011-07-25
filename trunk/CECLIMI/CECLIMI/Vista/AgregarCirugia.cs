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
    public partial class AgregarCirugia : CECLIMI.Vista.formInicial, IContratoAgregarCirugia
    {
        private PresenadorAgregarCirugia _presentador;
        public AgregarCirugia()
        {
            InitializeComponent();
            _presentador = new PresenadorAgregarCirugia(this);

        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            _presentador.BotonAceptar();
        }

        #region Implementation of IContratoAgregarCirugia

        public TextBox TextNombre
        {
            get { return textNombre; }
        }

        public TextBox TextDescripcion
        {
            get { return textDescripcion; }
        }

        public Button BotonAceptar
        {
            get { return botonAceptar; }
        }

        #endregion
    }
}
