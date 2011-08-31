using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CECLIMI.Contratos;
using EnlaceDatos;
using Entidades;
using Logica;

namespace CECLIMI.Presentador
{
    public class PresentadorAgregarPagos
    {
        #region variables
        private Paciente paciente = new Paciente();
        private IContratoAgregarPagos _vista;
        private bool _pacienteEncontrado = false;
        private LPagos logica = new LPagos();
        private String cedula;
        #endregion

        #region constructor
        public PresentadorAgregarPagos (IContratoAgregarPagos vista)
        {
            _vista = vista;
        }
        #endregion

        #region metodos
        //metodo que muestra la informacion del paciente cuando busca por cedula en agregar pagos
        public void ClickBotonBuscar ()
        {
            LPaciente lPaciente = new LPaciente();
            paciente = lPaciente.ObtenerInformacionPaciente(Convert.ToInt32(_vista.TextoCiPaciente.Text));
            if (paciente.Nombre != null)
            {
                _pacienteEncontrado = true;
                _vista.GridInformacionPagos.Rows.Clear();
                LPagos logica = new LPagos();
                _vista.TextoInformacionGrid.Text = "";
                _vista.GridInformacionPagos.Visible = true;
                _vista.TextoSaldoFavor.Visible = true;
                paciente.Id = Convert.ToInt64(_vista.TextoCiPaciente.Text);
                Double monto = 0;
                foreach (Pago pago in logica.ObtenerPagosPaciente(paciente))
                {
                    _vista.GridInformacionPagos.Rows.Add(pago.Id,pago.Fecha,pago.Monto);
                    monto += pago.Monto;
                }
                _vista.TextoSaldoFavorModificar.Text = monto.ToString("##,##.##");
                _vista.TextoSaldoFavorModificar.Visible = true;
                cedula = _vista.TextoCiPaciente.Text;
                _vista.GroupInformacionPago.Visible =
                    _vista.GroupEstatusCuenta.Visible = _vista.GroupInformacionPaciente.Visible = true;

                _vista.TextNombreModificar.Text = paciente.Nombre + " " + paciente.SegundoNombre;
                _vista.TextApellidoModificar.Text = paciente.PrimerApellido + " " + paciente.SegundoApellido;
                _vista.TextCedulaModificar.Text = paciente.Id.ToString();
                _vista.TextCorreoModificar.Text = paciente.Correo;
                _vista.TextTelefonoFijoModificar.Text = paciente.Telefono;
                _vista.TextTelefonoMovilModificar.Text = paciente.TelefonoMovil;
            }
            else
            {
                _pacienteEncontrado = false;
                _vista.GridInformacionPagos.Rows.Clear();
                DialogResult result =
                MessageBox.Show("Paciente no encontrado, asegurese que la cedula sea la correcta", "Cuidado!", MessageBoxButtons.OK);
                _vista.GridInformacionPagos.Rows.Clear();
                _vista.GridInformacionPagos.Visible = false;
                _vista.TextoSaldoFavorModificar.Text = "";
                _vista.TextoSaldoFavor.Visible = _vista.TextoSaldoFavorModificar.Visible = false;
                _vista.GridPagosNuevos.Rows.Clear();
            }
        }

        public void ClickBotonAgregarPagos()
        {
            try
            {
                if (!_pacienteEncontrado)
                {
                    DialogResult result =
                    MessageBox.Show("Debe buscar el paciente antes de agregar pagos.", "Cuidado!", MessageBoxButtons.OK);
                }
                else if (logica.ValidarPagoExistente(Convert.ToInt32(_vista.TextoNumeroFactura.Text)) == 1)
                {
                    DialogResult result =
                    MessageBox.Show("Esta factura ya esta en sistema.", "Cuidado!", MessageBoxButtons.OK);
                }
                else if (RevisarFacturaRepetidaEnDataGrid(_vista.TextoNumeroFactura.Text))
                {
                    DialogResult result =
                    MessageBox.Show("No puede agregar esta factura dos (2) veces", "Cuidado!", MessageBoxButtons.OK);
                }
                else
                {
                    _vista.GridPagosNuevos.Rows.Add(_vista.TextoNumeroFactura.Text, _vista.TextoMontoFactura.Text,
                        _vista.TextoDia.Text + "/" + _vista.TextoMes.Text + "/" + _vista.TextoAno.Text, _vista.TextQuienPaga.Text
                        , _vista.TextSeguro.Text, _vista.TextTipoPago.Text);
                    _vista.TextoNumeroFactura.Text =
                        _vista.TextoMontoFactura.Text =
                        _vista.TextoDia.Text = _vista.TextoMes.Text = _vista.TextoAno.Text = "";
                    _vista.TextQuienPaga.Text = _vista.TextTipoPago.Text = _vista.TextSeguro.Text = "";
                }
            }
            catch (Exception)
            {
                DialogResult result =
                    MessageBox.Show("Verifique que la informacion proporcionada sea correcta.", "Cuidado!", MessageBoxButtons.OK);
            }
            
        }

        // metodo que busca si en el grid esa factura fue agregada, regresando true si fue y false si no fue encontrada.
        public bool RevisarFacturaRepetidaEnDataGrid (String factura)
        {
            bool encontrado = false;
            for (int i = 0; i < _vista.GridPagosNuevos.Rows.Count; i++)
            {
                if (_vista.GridPagosNuevos.Rows[i].Cells["idFactura"].Value.Equals(factura))
                {
                    encontrado = true;
                }
            }
            return encontrado;
        }

        public void ClickBotonAceptar()
        {
            for (int i = 0; i < _vista.GridPagosNuevos.Rows.Count; i++)
            {
                Pago pago = new Pago();
                pago.Id = Convert.ToInt32(_vista.GridPagosNuevos.Rows[i].Cells["idFactura"].Value);
                pago.Monto = float.Parse(_vista.GridPagosNuevos.Rows[i].Cells["monto"].Value.ToString());
                pago.Nombre = _vista.GridPagosNuevos.Rows[i].Cells["quienPaga"].Value.ToString();
                pago.Fecha = ConvertirFecha((string) _vista.GridPagosNuevos.Rows[i].Cells["fechaPago"].Value);
                pago.Seguro = (string) _vista.GridPagosNuevos.Rows[i].Cells["columnaSeguro"].Value; ;
                pago.TipoPago = (string) _vista.GridPagosNuevos.Rows[i].Cells["columnaTipoPago"].Value; ;
                pago.Usuario.Id = Convert.ToInt64(cedula);
                logica.AgregarPagos(pago);
            }
        }

        public DateTime ConvertirFecha(String fecha)
        {
            Console.WriteLine("FECHA "+fecha);
            String[] fech = fecha.Split('/');
            DateTime miFecha = new DateTime(Convert.ToInt32(fech[2]),Convert.ToInt32(fech[1]),Convert.ToInt32(fech[0]));
            return miFecha;
        }
        #endregion

    }
}
