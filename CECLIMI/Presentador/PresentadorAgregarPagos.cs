using System;
using System.Collections.Generic;

using System.Text;
using System.Windows.Forms;
using CECLIMI.Contratos;
using Proxy;


namespace CECLIMI.Presentador
{
    public class PresentadorAgregarPagos
    {
        #region variables
        private Paciente paciente = new Paciente();
        private IContratoAgregarPagos _vista;
        private ServicioPagosSoap logica = new ServicioPagosSoap();
        private String cedula;
        private List<Pago> pagos = new List<Pago>();
        #endregion

        #region constructor
        public PresentadorAgregarPagos (IContratoAgregarPagos vista)
        {
            _vista = vista;
        }
        #endregion

        #region metodos

        /// <summary>
        /// Metodo utilizado para buscar la informacion de un paciente.
        /// </summary>
        public void ClickBotonBuscar ()
        {
            if (ValidarEntero(_vista.TextoCiPaciente.Text))
            {
                ServicioPacienteSoap logica = new ServicioPacienteSoap();
                int cedula = Convert.ToInt32(_vista.TextoCiPaciente.Text);
                paciente = logica.ObtenerInformacionPaciente(cedula);
                if (paciente.Nombre != null)
                {
                    paciente.Id = cedula;
                    CargarInformacionEnText(paciente);
                }
                else
                {
                    DialogResult result =
                    MessageBox.Show("Paciente no encontrado, asegurese que la cedula sea la correcta", "Cuidado!", MessageBoxButtons.OK);
                    _vista.GridPagosNuevos.Rows.Clear();
                }
            }
            else
            {
                DialogResult result =
                    MessageBox.Show("La cedula no puede contener letras.", "Cuidado!", MessageBoxButtons.OK);
            }
            
        }

        public void ActivarControlesOcultos()
        {
            LlenarComboPaquetes();
            _vista.GroupInformacionPago.Visible = true;
            _vista.GroupInformacionPaciente.Visible = true;
            _vista.GroupInformacionPaquetesFinancieros.Visible = true;
            _vista.BotonAceptarPagosAgregados.Visible = true;
            _vista.BotonCancelarAgregarPagos.Visible = true;
            _vista.GrupoInformacionPacienteBuscar.Visible = false;
        }

        public void LlenarComboPaquetes()
        {
            ServicioPaqueteFinancieroSoap lPaquete = new ServicioPaqueteFinancieroSoap();
            foreach (PaqueteFinanciero paqueteFinanciero in lPaquete.ObtenerPaqueteFPaciente((int) paciente.Id))
            {
                _vista.ComboPaquetes.Items.Add(paqueteFinanciero);
            }
            _vista.ComboPaquetes.DisplayMember = "Nombre";
            _vista.ComboPaquetes.ValueMember = "Id";
        }

        /// <summary>
        /// Metodo que llena en pantalla la informacion consultada del paciente
        /// </summary>
        /// <param name="paciente"></param>
        public void CargarInformacionEnText(Paciente paciente)
        {
            _vista.TextNombreModificar.Text = paciente.Nombre + " " + paciente.SegundoNombre;
            _vista.TextApellidoModificar.Text = paciente.PrimerApellido + " " + paciente.SegundoApellido;
            _vista.TextCedulaModificar.Text = paciente.Id.ToString();
            _vista.TextCorreoModificar.Text = paciente.Correo;
            _vista.TextTelefonoFijoModificar.Text = paciente.Telefono;
            _vista.TextTelefonoMovilModificar.Text = paciente.TelefonoMovil;
        }

        public void ClickBotonAgregarPagos()
        {
            if (!ValidarFormulario())
            {
                
            }
            else if (logica.ValidarPagoExistente(_vista.TextoNumeroFactura.Text) == 1)
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
                Pago pago = new Pago();
                pago.Factura = _vista.TextoNumeroFactura.Text;
                pago.Monto = Convert.ToSingle(_vista.TextoMontoFactura.Text);
                pago.Nombre = _vista.TextQuienPaga.Text;
                pago.Fecha = new DateTime(Convert.ToInt32(_vista.TextoAno.Text), 
                                          Convert.ToInt32(_vista.TextoMes.Text), 
                                          Convert.ToInt32(_vista.TextoDia.Text));
                pago.Seguro = _vista.TextSeguro.Text;
                pago.TipoPago = _vista.TextTipoPago.Text;
                pago.Paciente = paciente;
                _vista.GridPagosNuevos.Rows.Add(pago.Factura, pago.Monto, pago.Fecha.ToString().Split(' ')[0], 
                    pago.Nombre, pago.Seguro,pago.TipoPago);
                pagos.Add(pago);
                VaciarFormulario();
            }
            
        }

        public void VaciarFormulario()
        {
            _vista.TextoNumeroFactura.Text = "";
            _vista.TextoMontoFactura.Text = "";
            _vista.TextoDia.Text = "";
            _vista.TextoMes.Text = "";
            _vista.TextoAno.Text = "";
            _vista.TextQuienPaga.Text = "";
            _vista.TextTipoPago.Text = "";
            _vista.TextSeguro.Text = "";
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

        public bool ClickBotonAceptar()
        {
            if (_vista.GridPagosNuevos.Rows.Count > 0)
            {
                if (_vista.ComboPaquetes.SelectedIndex != -1)
                {
                    foreach (Pago pago in pagos)
                    {
                        pago.Paquete = (PaqueteFinanciero) _vista.ComboPaquetes.SelectedItem;
                        logica.AgregarPagos(pago);
                    }
                    DialogResult result =
                        MessageBox.Show("Los pagos fueron creado correctamente.", "Transaccion Correcta", MessageBoxButtons.OK);
                    return true;  
                }
                else
                {
                    DialogResult result =
                        MessageBox.Show("Debe seleccionar a que paquete se le van a agregar estos pagos.", "Cuidado", MessageBoxButtons.OK);
                    return false;  
                }
                
            }
            else
            {
                DialogResult result =
                        MessageBox.Show("No se puede procesar la transaccion si no ha agregado ningun pago.", "Cuidado", MessageBoxButtons.OK);
                return false;
            }
        }

        public DateTime ConvertirFecha(String fecha)
        {
            Console.WriteLine("FECHA "+fecha);
            String[] fech = fecha.Split('/');
            DateTime miFecha = new DateTime(Convert.ToInt32(fech[2]),Convert.ToInt32(fech[1]),Convert.ToInt32(fech[0]));
            return miFecha;
        }

        #region Validacion de formulario
        public bool ValidarFormulario()
        {
            if (_vista.TextoNumeroFactura.Text.Equals("") || _vista.TextoMontoFactura.Text.Equals("") || _vista.TextoDia.Text.Equals("")
                || _vista.TextoMes.Text.Equals("") || _vista.TextoAno.Text.Equals("") || _vista.TextQuienPaga.Text.Equals("") ||
                _vista.TextSeguro.Text.Equals("") || _vista.TextTipoPago.Text.Equals(""))
            {
                DialogResult result =
                MessageBox.Show("Asegurese de haber llenado todos los campos obligatorios (*).", "Cuidado!", MessageBoxButtons.OK);
                return false;
            }
            else if (!ValidarMonto(_vista.TextoMontoFactura.Text))
            {
                DialogResult result =
                MessageBox.Show("El monto introducido es incorrecto.", "Cuidado!", MessageBoxButtons.OK);
                return false;
            }
            else if (!ValidarFecha(_vista.TextoDia.Text, _vista.TextoMes.Text, _vista.TextoAno.Text))
            {
                DialogResult result =
                MessageBox.Show("La fecha esta en un formato incorrecto.", "Cuidado!", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        public bool ValidarMonto(string monto)
        {
            try
            {
                Convert.ToSingle(monto);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ValidarFecha(string dia, string mes, string ano)
        {
            try
            {
                new DateTime(Convert.ToInt32(ano), Convert.ToInt32(mes), Convert.ToInt32(dia));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ValidarEntero(string entero)
        {
            try
            {
                Convert.ToInt32(entero);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
        #endregion

    }
}
