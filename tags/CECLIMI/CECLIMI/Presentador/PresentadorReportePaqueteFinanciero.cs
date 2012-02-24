using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CECLIMI.Contratos;
using Entidades;
using Logica;

namespace CECLIMI.Presentador
{
    public class PresentadorReportePaqueteFinanciero
    {
        private IContratoReportePaqueteFinanciero _vista;
        private Paciente _paciente = new Paciente();

        public PresentadorReportePaqueteFinanciero (IContratoReportePaqueteFinanciero vista)
        {
            _vista = vista;
        }

        public void BuscarInformacionPaciente()
        {
            try
            {
                LPaciente lPaciente = new LPaciente();
                int cedula = Convert.ToInt32(_vista.TextCiPaciente.Text);
                _paciente = lPaciente.ObtenerInformacionPaciente(cedula);
                _paciente.Id = cedula;
                _paciente.Cedula = cedula;
                if (_paciente.Nombre != null)
                {
                    CargarInformacionEnText();
                    LlenarComboPaquetes();
                }
                else
                {
                    DialogResult result =
                    MessageBox.Show("Este paciente no existe, asegurese de haber colocado la cedula correcta.", "Cuidado!", MessageBoxButtons.OK);

                }
            }
            catch (Exception)
            {
                DialogResult result =
                    MessageBox.Show("La cedula a buscar solo puede contener caracteres numericos.", "Cuidado!", MessageBoxButtons.OK);
            }
        }

        public void CargarInformacionEnText()
        {
            _vista.NombrePaciente.Text = _paciente.Nombre + " " + _paciente.SegundoNombre + " " +
                                         _paciente.PrimerApellido + " " + _paciente.SegundoApellido;
            _vista.Cedula.Text = _paciente.Cedula.ToString();
            _vista.Telefonos.Text = _paciente.Telefono + " / " + _paciente.TelefonoMovil;
            _vista.Correo.Text = _paciente.Correo;

            _vista.PaquetesFinancieros.Visible = true;
        }

        public void LlenarComboPaquetes()
        {
            LPaqueteFinanciero lPaquete = new LPaqueteFinanciero();
            foreach (PaqueteFinanciero paqueteFinanciero in lPaquete.ObtenerPaqueteFPaciente( (int) _paciente.Id) )
            {
                _vista.ComboPaquetesFinancieros.Items.Add(paqueteFinanciero);
            }
            _vista.ComboPaquetesFinancieros.DisplayMember = "Nombre";
            _vista.ComboPaquetesFinancieros.ValueMember = "Id";
        }

        public void BuscarInformacionPaquete()
        {
            LCirugiaPaqueteFinanciero lCirugiaPaquete = new LCirugiaPaqueteFinanciero();
            LPagos lPagos = new LPagos();
            _vista.InformacionPaciente.Visible = false;
            _vista.PaquetesFinancieros.Visible = false;
            _vista.PaqueteFinanciero.Visible = true;
            _vista.Aceptar.Visible = true;

            PaqueteFinanciero paquete = new PaqueteFinanciero();
            paquete = (PaqueteFinanciero)_vista.ComboPaquetesFinancieros.SelectedItem;
            _vista.ComboPaquetesFinancieros.Items.Clear();

            _vista.FechaElaboracion.Text = paquete.FechaPaquete.ToString().Split(' ')[0];
            _vista.FechaIntervencion.Text = paquete.FechaOperacion.ToString().Split(' ')[0];
            _vista.Observaciones.Text = paquete.Observacion;

            foreach (CirugiaPqtFinanciero cirugiaPqt in lCirugiaPaquete.ObtenerCirugiasPaqueteFinanciero(paquete))
            {
                float total = (cirugiaPqt.MontoCirujano - ((cirugiaPqt.MontoCirujano*cirugiaPqt.Descuento)/100)) +
                            cirugiaPqt.Protesis;
                _vista.Cirugias.Rows.Add(cirugiaPqt.Cirugia.Nombre, cirugiaPqt.Cirujano.Nombre, cirugiaPqt.MontoCirujano,
                                         cirugiaPqt.Protesis, cirugiaPqt.Descuento,total);
            }

            List<Pago> pagos = lPagos.ObtenerPagosPaqueteFinanciero(paquete);
            List<string> nombres = new List<string>();
            foreach (Pago pago in pagos)
            {
                _vista.Pagos.Rows.Add(pago.Nombre, pago.Monto, pago.Fecha.ToString().Split(' ')[0], pago.Seguro,
                                      pago.TipoPago);
                nombres.Add(pago.Nombre);
            }
            PacienteAlterno(nombres);
        }

        public void PacienteAlterno(List<string> nombres)
        {
            _vista.PacientesAlternos.Text = "";
            for (int i = 0; i < nombres.Count; i++)
            {
                for (int j = i+1; j < nombres.Count; j++)
                {
                    if (nombres[j].Equals(nombres[i]))
                    {
                        nombres.RemoveAt(j);
                    }
                }
                _vista.PacientesAlternos.Text += nombres[i] + ", " ;
            }
        }
    }
}
