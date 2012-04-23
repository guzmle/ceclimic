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
    public partial class ReportePaqueteFinanciero : CECLIMI.Vista.formInicial, IContratoReportePaqueteFinanciero
    {
        private PresentadorReportePaqueteFinanciero _presentador;
        public ReportePaqueteFinanciero()
        {
            InitializeComponent();
            _presentador = new PresentadorReportePaqueteFinanciero(this);
        }

        private void BotonAceptarClick(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Implementation of IContratoReportePaqueteFinanciero

        public GroupBox InformacionPaciente
        {
            get { return grupoInformacionPaciente; }
        }

        public TextBox TextCiPaciente
        {
            get { return textoCiPaciente; }
        }

        public Button BotonBuscar
        {
            get { return botonBuscar; }
        }

        public GroupBox PaquetesFinancieros
        {
            get { return grupoPaquetesFinancieros; }
        }

        public ComboBox ComboPaquetesFinancieros
        {
            get { return comboPaquetesFinancieros; }
        }

        public GroupBox PaqueteFinanciero
        {
            get { return grupoPaqueteFinanciero; }
        }

        public Label NombrePaciente
        {
            get { return nombrePaciente; }
        }

        public Label FechaElaboracion
        {
            get { return fechaElaboracion; }
        }

        public Label Cedula
        {
            get { return cedulaPaciente; }
        }

        public Label Telefonos
        {
            get { return telefonosPaciente; }
        }

        public Label Correo
        {
            get { return correoPaciente; }
        }

        public Label PacientesAlternos
        {
            get { return pacientesAlternos; }
        }

        public DataGridView Cirugias
        {
            get { return gridCirugias; }
        }

        public DataGridView Pagos
        {
            get { return gridPagos; }
        }

        public Label FechaIntervencion
        {
            get { return fechaIntervencion; }
        }

        public Label Observaciones
        {
            get { return observaciones; }
        }

        public Button Aceptar
        {
            get { return botonAceptar; }
        }

        public Label TotalCirugia
        {
            get { return totalCirugia; }
        }

        public Label TotalPagos
        {
            get { return totalPagos; }
        }

        #endregion

        private void BotonBuscarClick(object sender, EventArgs e)
        {
            _presentador.BuscarInformacionPaciente();
        }

        private void ComboPaquetesFinancierosSelectedIndexChanged(object sender, EventArgs e)
        {
            _presentador.BuscarInformacionPaquete();
        }
    }
}
