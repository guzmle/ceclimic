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
    public partial class EliminarCirugia : CECLIMI.Vista.formInicial,IContratoEliminarCirugia
    {
        private PresentadorEliminarCirugia _presentador;
        public EliminarCirugia()
        {
            InitializeComponent();
            _presentador = new PresentadorEliminarCirugia(this);
        }

        #region Implementation of IContratoEliminarCirugia

        public GroupBox GrupoInformacionPaciente
        {
            get { return grupoInformacionPaciente; }
        }

        public TextBox TextoCiPaciente
        {
            get { return textoCiPaciente; }
        }

        public Button BotonBuscar
        {
            get { return botonBuscarPaciente; }
        }

        public GroupBox GrupoDatosPaciente1
        {
            get { return grupoDatosPaciente1; }
        }

        public Label TextoNombrePacienteIngresado
        {
            get { return textoNombrePacienteIngresado; }
        }

        public Label TextoApellidoPacienteIngresado
        {
            get { return textoApellidoPacienteIngresado; }
        }

        public Label TextoCiPacienteIngresado
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

        public Label TextoTelefonoMovilPacienteIngresado
        {
            get { return textoTelefonoMovilIngresado; }
        }

        public Button BotonModificarInformacion
        {
            get { throw new NotImplementedException(); }
        }

        public GroupBox GrupoCirugiaPaciente
        {
            get { return groupCirugias; }
        }

        public DataGridView DataGridView1
        {
            get { return dataGridView1; }
        }

        public GroupBox GrupoCirugiaEliminar
        {
            get { return groupCirugiaEliminar; }
        }

        public TextBox TextIdCirugia
        {
            get { return textIdCirugia; }
        }

        public Button BotonBuscarCirugia
        {
            get { throw new NotImplementedException(); }
        }

        #endregion

        private void BotonBuscarPacienteClick(object sender, EventArgs e)
        {
            _presentador.BuscarPaciente();
        }

        private void BotonModificarInformacionClick(object sender, EventArgs e)
        {
            _presentador.BuscarOtroPaciente();
        }

        private void BotonAceptarCirugiaClick(object sender, EventArgs e)
        {
            _presentador.ClickBotonAceptar();
        }
    }
}
