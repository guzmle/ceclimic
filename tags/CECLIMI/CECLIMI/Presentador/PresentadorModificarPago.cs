using System;
using System.Collections.Generic;

using System.Text;
using System.Windows.Forms;
using CECLIMI.Contratos;
using Proxys;


namespace CECLIMI.Presentador
{
    public class PresentadorModificarPago
    {
        private IContratoModificarPago _vista;

        public PresentadorModificarPago (IContratoModificarPago vista)
        {
            _vista = vista;
        }

        public void BuscarPaciente()
        {
            try
            {
                ServicioPacienteSoap ServicioPacienteSoap = new ServicioPacienteSoap();
                Paciente paciente = new Paciente();

                paciente = ServicioPacienteSoap.ObtenerInformacionPaciente(Convert.ToInt32(_vista.TextoCiPaciente.Text));
                paciente.Id = Convert.ToInt32(_vista.TextoCiPaciente.Text);

                if (paciente.Nombre != null)
                {
                    CargarInformacionEnText(paciente);
                    ServicioPagosSoap lPagos = new ServicioPagosSoap();
                    float monto = 0;
                    foreach (Pago pago in lPagos.ObtenerPagosPaciente(paciente))
                    {
                        _vista.GridInformacionPagos.Rows.Add(pago.Id, pago.Fecha, pago.Monto.ToString("##,##.##"));
                        monto += pago.Monto;
                    }
                    _vista.TextoSaldoFavorModificar.Text = monto.ToString("##,##.##");
                    _vista.GridInformacionPagos.Visible = true;
                }
                else
                {
                    DialogResult result =
                    MessageBox.Show("El paciente buscado no esta en el sistema.", "Cuidado!", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                DialogResult result =
                    MessageBox.Show("La cedula introducida esta en formato incorrecto.", "Cuidado!", MessageBoxButtons.OK);
            }
        }

        //metodo que rellena toda la informacion al buscar un paciente
        public void CargarInformacionEnText(Paciente paciente)
        {
            _vista.GrupoInformacionPaciente.Visible = false;
            _vista.GrupoDatosPaciente1.Visible = _vista.GroupEstatusCuenta.Visible = _vista.DatoModificar.Visible = true;
            _vista.TextoNombrePacienteIngresado.Text = paciente.Nombre + " " + paciente.SegundoNombre;
            _vista.TextoApellidoPacienteIngresado.Text = paciente.PrimerApellido + " " + paciente.SegundoApellido;
            _vista.TextoCiPacienteIngresado.Text = paciente.Id.ToString();
            _vista.TextoCiPaciente.Text = "";
            _vista.TextoCorreoElectronicoPacienteIngresado.Text = paciente.Correo;
            _vista.TextoTelefonoFijoPacienteIngresado.Text = paciente.Telefono;
            _vista.TextoTelefonoMoviServicioPacienteSoapIngresado.Text = paciente.TelefonoMovil;
        }

        public void BuscarFactura()
        {
            
        }
    }
}
