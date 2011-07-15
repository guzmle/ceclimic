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
    public partial class AgregarCirujano : CECLIMI.Vista.formInicial, IContratoAgregarCirujano
    {
        private PresentadorAgregarCirujano _presentador;
        public AgregarCirujano()
        {
            InitializeComponent();
            _presentador = new PresentadorAgregarCirujano(this);
        }

        private void AgregarCirujano_Load(object sender, EventArgs e)
        {

        }

        #region Implementation of IContratoAgregarCirujano

        public Label Etiqueta
        {
            get { return label2; }
        }

        public TextBox Texto
        {
            get { return textBox1; }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            _presentador.AccionBoton();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
