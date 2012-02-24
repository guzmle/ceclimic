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
    public partial class BeremoDeOperaciones : CECLIMI.Vista.formInicial, IContratoBeremoDeOperaciones
    {
        private PresentadorBeremoDeOperaciones _presentador;
        public BeremoDeOperaciones()
        {
            InitializeComponent();
            _presentador = new PresentadorBeremoDeOperaciones(this);
            _presentador.BuscarCirujanos();
        }

        private void BotonAceptarCirugiaClick(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Implementation of IContratoBeremoDeOperaciones

        public ComboBox UxCirujanos
        {
            get { return comboCirujanos; }
        }

        public GroupBox UxGrupoBeremo
        {
            get { return grupoBeremo; }
        }

        public DataGridView UxGridBeremo
        {
            get { return uxGridBeremo; }
        }

        public Button UxBotonAceptar
        {
            get { return botonAceptar; }
        }

        #endregion

        private void ComboCirujanosSelectedIndexChanged(object sender, EventArgs e)
        {
            _presentador.CargarBeremo();
        }
    }
}
