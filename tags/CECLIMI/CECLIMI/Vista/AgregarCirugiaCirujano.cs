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
    public partial class AgregarCirugiaCirujano : CECLIMI.Vista.formInicial, IContratoAgregarCirugiaCirujano
    {
        private PresentadorAgregarCirugiaCirujano _presentador;
        public AgregarCirugiaCirujano()
        {
            InitializeComponent();
            _presentador = new PresentadorAgregarCirugiaCirujano(this);
        }



        private void BotonAceptarClick(object sender, EventArgs e)
        {
            if (_presentador.BotonAceptar())
            {
                this.Close();
            }
        }


        private void BotonBuscarCirujanoClick(object sender, EventArgs e)
        {
            _presentador.BuscarInformacionCirujano();
        }

        // Implementacion del icontrato
        #region Implementation of IContratoAgregarCirugiaCirujano

        public GroupBox GrupoInfoCirujano
        {
            get { return grupoInfoCirujano; }
        }

        public TextBox CedulaCirujano
        {
            get { return uxCedulaCirujano; }
        }

        public Button BotonBuscar
        {
            get { return botonBuscarCirujano; }
        }

        public GroupBox GrupoDatosCirujano
        {
            get { return grupoDatosCirujano; }
        }

        public Label UxNombre
        {
            get { return uxNombre; }
        }

        public Label UxApellido
        {
            get { return uxApellido; }
        }

        public Label UxCedula
        {
            get { return uxCedula; }
        }

        public Label UxCorreo
        {
            get { return uxCorreo; }
        }

        public Label UxTelefonoFijo
        {
            get { return uxTelefonoFijo; }
        }

        public Label UxTelefonoMovil
        {
            get { return uxTelefonoMovil; }
        }

        public GroupBox GrupoCirugias
        {
            get { return grupoCirugias; }
        }

        public ComboBox UxComboCirugias
        {
            get { return uxComboCirugias; }
        }

        public TextBox UxMontoCirugia
        {
            get { return uxMonto; }
        }

        public Button BotonAgregarIqx
        {
            get { return botonAgregarIqx; }
        }

        public Button BotonEliminarIqx
        {
            get { return botonEliminarIqx; }
        }

        public DataGridView GridCirugiasAgregar
        {
            get { return uxGridCirugias; }
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

        private void BotonAgregarIqxClick(object sender, EventArgs e)
        {
            _presentador.AgregarCirugia();
        }

        private void BotonEliminarIqxClick(object sender, EventArgs e)
        {
            _presentador.EliminarIntervencionQuirurgica();
        }
    }
}
