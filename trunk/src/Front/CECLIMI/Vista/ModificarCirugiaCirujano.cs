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
    public partial class ModificarCirugiaCirujano : CECLIMI.Vista.formInicial, IContratoModificarCirugiaCirujano
    {
        private PresentadorModificarCirugiaCirujano _presentador;
        public ModificarCirugiaCirujano()
        {
            InitializeComponent();
            _presentador = new PresentadorModificarCirugiaCirujano(this);
        }

        #region Implementation of IContratoModificarCirugiaCirujano

        public GroupBox GrupoInformacionCirujano
        {
            get { return grupoInformacionCirujano; }
        }

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

        public Label TextNombreModificar
        {
            get { return textNombreModificar; }
        }

        public Label TextApellidoModificar
        {
            get { return textApellidoModificar; }
        }

        public Label TextTelefonoModificar
        {
            get { return textTelefonoModificar; }
        }

        public Label TextTelefonoMovilModificar
        {
            get { return textTelefonoMovilModificar; }
        }

        public Label TextCorreoModificar
        {
            get { return textCorreoElectronicoModificar; }
        }

        public GroupBox GroupCirugiasCirujano
        {
            get { return groupCirugiasCirujano; }
        }

        public DataGridView GridInformacionCirugiasCirujano
        {
            get { return gridInformacionCirugiasCirujano; }
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
            _presentador.BotonAceptar();
        }


    }
}
