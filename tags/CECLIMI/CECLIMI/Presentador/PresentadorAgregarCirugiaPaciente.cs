using System;
using System.Collections.Generic;

using System.Text;
using System.Windows.Forms;
using CECLIMI.Contratos;
using Proxys;


namespace CECLIMI.Presentador
{
    public class PresentadorAgregarCirugiaPaciente
    {
        #region Atributos
        private IContratoAgregarCirugiaPaciente _vista;
        private Paciente _paciente = new Paciente();
        private List<CirugiaPqtFinanciero> cirugiaPqtFinancieros = new List<CirugiaPqtFinanciero>();
        #endregion

        public PresentadorAgregarCirugiaPaciente(IContratoAgregarCirugiaPaciente vista)
        {
            _vista = vista;
        }

        /// <summary>
        /// Metodo que se encarga de buscar la informacion del paciente y validar si este se encuentra 
        /// registrado en el sistema
        /// </summary>
        public void BuscarInformacionPaciente()
        {
            try
            {
                ServicioPacienteSoap ServicioPacienteSoap = new ServicioPacienteSoap();
                int cedula = Convert.ToInt32(_vista.TextoCiPaciente.Text);
                _paciente = ServicioPacienteSoap.ObtenerInformacionPaciente(cedula);
                _paciente.Id = cedula;
                _paciente.Cedula = cedula;
                if (_paciente.Nombre != null)
                {
                    CargarInformacionEnText(_paciente);
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

        /// <summary>
        /// Metodo que se encarga de llenar el ComboBox de las cirugias del sistema
        /// </summary>
        public void LLenarCirugias()
        {
            ServicioCirugiaSoap ServicioCirugiaSoap = new ServicioCirugiaSoap();

            foreach (Cirugia cirugia  in ServicioCirugiaSoap.ObtenerCirugias())
            {
                _vista.ComboIntervencionQuirurgica.Items.Add(cirugia);
            }
            _vista.ComboIntervencionQuirurgica.DisplayMember = "Nombre";
            _vista.ComboIntervencionQuirurgica.ValueMember = "Id";
        }

        /// <summary>
        /// Metodo que se encarga de llenar los combobox del personal quirurgico
        /// </summary>
        public void LlenarPersonalQuirurgico()
        {
            ServicioCirugiaPersonalQSoap lPersonalQuirurgico = new ServicioCirugiaPersonalQSoap();
            foreach (Personal personal in lPersonalQuirurgico.ObtenerPersonalQ())
            {
                _vista.ComboPrimerAyudante.Items.Add(personal);
                _vista.ComboAnestesiologo.Items.Add(personal);
                _vista.ComboCirculante.Items.Add(personal);
                _vista.InstrumentistaEspecial.Items.Add(personal);
                _vista.ComboInstrumentista.Items.Add(personal);
            }
            _vista.ComboPrimerAyudante.DisplayMember = _vista.ComboAnestesiologo.DisplayMember = _vista.ComboCirculante.DisplayMember =
                _vista.InstrumentistaEspecial.DisplayMember = _vista.ComboInstrumentista.DisplayMember = "Nombre";
            _vista.ComboPrimerAyudante.ValueMember = _vista.ComboAnestesiologo.ValueMember = _vista.ComboCirculante.ValueMember =
                _vista.InstrumentistaEspecial.ValueMember = _vista.ComboInstrumentista.ValueMember = "Id";
        }

        /// <summary>
        /// Metodo que llena en pantalla la informacion consultada del paciente
        /// </summary>
        /// <param name="paciente"></param>
        public void CargarInformacionEnText(Paciente paciente)
        {
            _vista.TextoNombrePacienteIngresado.Text = paciente.Nombre + " " + paciente.SegundoNombre;
            _vista.TextoApellidoPacienteIngresado.Text = paciente.PrimerApellido + " " + paciente.SegundoApellido;
            _vista.TextoCiPacienteIngresado.Text = paciente.Id.ToString();
            _vista.TextoCiPaciente.Text = "";
            _vista.TextoCorreoElectronicoPacienteIngresado.Text = paciente.Correo;
            _vista.TextoTelefonoFijoPacienteIngresado.Text = paciente.Telefono;
            _vista.TextoTelefonoMoviServicioPacienteSoapIngresado.Text = paciente.TelefonoMovil;
        }

        /// <summary>
        /// Metodo que activa y desactiva los groupBox ocultos y los botones de aceptar y cancelar
        /// </summary>
        public void ActivarControladoresOcultos()
        {
            _vista.GrupoInformacionPaciente.Visible = false;
            _vista.GrupoDatosPaciente1.Visible = true;
            _vista.GrupoIntervencionQuirurgica.Visible = true;
            _vista.GrupoPersonalQuirurgico.Visible = true;
            _vista.BotonAceptar.Visible = true;
            _vista.BotonCancelar.Visible = true;
            _vista.LabelObservaciones.Visible = true;
            _vista.Observaciones.Visible = true;
        }

        /// <summary>
        /// Metodo que busca los cirujanos dada una cirugia.
        /// </summary>
        public void CargarInformacionCirujanos()
        {
            if (_vista.ComboIntervencionQuirurgica.SelectedIndex != -1)
            {
                ServicioCirujanoSoap logica = new ServicioCirujanoSoap();
                _vista.ComboCirujano.Items.Clear();
                _vista.ComboCirujano.Text = "";
                _vista.TextoHonorarioCirujano.Visible = false;
                _vista.TextoBsfHonorario.Visible = false;
                _vista.TextoHonorarioCirujano.Text = "";
                foreach (Cirujano cirujano in logica.ObtenerCirujanos((Cirugia)_vista.ComboIntervencionQuirurgica.SelectedItem))
                {
                    _vista.ComboCirujano.Items.Add(cirujano);
                }
                _vista.ComboCirujano.DisplayMember = "Nombre";
                _vista.ComboCirujano.ValueMember = "Id";
            }
            
        }

        /// <summary>
        /// Metodo que busca el precio de una cirugia dado un cirujano y una cirugia
        /// </summary>
        public void PrecioOperacion()
        {
            if (_vista.ComboCirujano.SelectedIndex != -1)
            {
                ServicioCirugiaCirujanoSoap logica = new ServicioCirugiaCirujanoSoap();
                _vista.TextoHonorarioCirujano.Text =
                    logica.ObtenerCirugiaCirujano((Cirugia)_vista.ComboIntervencionQuirurgica.SelectedItem,
                                                  (Cirujano)_vista.ComboCirujano.SelectedItem).ToString();
                _vista.TextoHonorarioCirujano.Visible = true;
                _vista.TextoBsfHonorario.Visible = true;
            }
        }

        /// <summary>
        /// Metodo que agrega la cirugia al grid y a la lista para que pueda ser agregado.
        /// </summary>
        public void AgregarCirugia()
        {
            if (ValidarFormulario())
            {
                CirugiaPqtFinanciero cirugiaPqt = new CirugiaPqtFinanciero();
                //Compruebo si el campo protesis no esta vacio
                if (_vista.TextProtesis.Text.Equals(""))
                    cirugiaPqt.Protesis = 0;
                else
                    cirugiaPqt.Protesis = Convert.ToSingle(_vista.TextProtesis.Text);
                //compruebo si el campo de descuento no esta vacio
                if (_vista.TextDescuento.Text.Equals(""))
                    cirugiaPqt.Descuento = 0;
                else
                    cirugiaPqt.Descuento = Convert.ToSingle(_vista.TextDescuento.Text);
                
                cirugiaPqt.MontoCirujano = Convert.ToSingle(_vista.TextoHonorarioCirujano.Text);
                cirugiaPqt.Cirugia = (Cirugia)_vista.ComboIntervencionQuirurgica.SelectedItem;
                cirugiaPqt.Cirujano = (Cirujano)_vista.ComboCirujano.SelectedItem;
                cirugiaPqtFinancieros.Add(cirugiaPqt);

                string total = ((cirugiaPqt.MontoCirujano - ((cirugiaPqt.MontoCirujano * cirugiaPqt.Descuento) / 100)) + cirugiaPqt.Protesis).ToString();
                _vista.GridCirugias.Rows.Add(cirugiaPqt.Cirugia.Nombre, cirugiaPqt.Cirujano.Nombre, 
                    cirugiaPqt.MontoCirujano, cirugiaPqt.Protesis, cirugiaPqt.Descuento, total);

                VaciarFormulario();
            }
        }

        public void VaciarFormulario()
        {
            _vista.ComboIntervencionQuirurgica.SelectedIndex = -1;
            _vista.ComboCirujano.SelectedIndex = -1;
            _vista.TextoBsfHonorario.Visible = false;
            _vista.TextoHonorarioCirujano.Visible = false;
            _vista.TextProtesis.Text = "";
            _vista.TextDescuento.Text = "";
        }

        public void EliminarCirugia()
        {
            if (_vista.GridCirugias.Rows.Count != 0)
            {
                int indexEliminar = _vista.GridCirugias.Rows.Count - 1;
                _vista.GridCirugias.Rows.RemoveAt(indexEliminar);
                cirugiaPqtFinancieros.RemoveAt(indexEliminar);
            }
        }

        //metodo de cuando toca aceptar
        public bool ClickAceptar()
        {
            bool respuesta = false;
            if (ValidarQueSePuedaAceptarLaTransaccion())
            {
                int paquete = InsertarPaqueteFinanciero();
                if (paquete != -1)
                {
                    InsertarCirugias(paquete);
                    InsertarPersonalQuirurgico(paquete);
                    respuesta = true;
                    DialogResult result =
                        MessageBox.Show("Se ha creado el paquete financiero con exito.", "Transaccion exitosa", MessageBoxButtons.OK);
                }
                else
                {
                    DialogResult result =
                        MessageBox.Show("Error 1004: No se pudo crear el paquete financiero.", "Cuidado", MessageBoxButtons.OK);
                    respuesta = false;
                }
            }
            return respuesta;
        }

        /// <summary>
        /// Metodo que inserta en base de datos la informacion del paquete financiero
        /// </summary>
        /// <returns></returns>
        public int InsertarPaqueteFinanciero()
        {
            PaqueteFinanciero paquete = new PaqueteFinanciero();
            ServicioPaqueteFinancieroSoap lPaquete = new ServicioPaqueteFinancieroSoap();

            paquete.FechaPaquete = new DateTime(Convert.ToInt32(_vista.TextAnoElaboracion.Text), 
                                                Convert.ToInt32(_vista.TextMesElaboracion.Text),
                                                Convert.ToInt32(_vista.TextDiaElaboracion.Text));
            paquete.Paciente = _paciente;
            paquete.FechaOperacion = new DateTime(Convert.ToInt32(_vista.TextAnoIqx1.Text), 
                                                  Convert.ToInt32(_vista.TextMesIqx1.Text),
                                                  Convert.ToInt32(_vista.TextDiaIqx1.Text));
            paquete.Observacion = _vista.Observaciones.Text;
            return lPaquete.AgregarPaqueteFinanciero(paquete);
        }

        /// <summary>
        /// Metodo que inserta las cirugias agregadas
        /// </summary>
        /// <param name="paquete"></param>
        public void InsertarCirugias(int paquete)
        {
            ServicioCirugiaPaqueteFinancieroSoap servicioCirugiaSoapPaquete = new ServicioCirugiaPaqueteFinancieroSoap();
            foreach (CirugiaPqtFinanciero cirugiaPqtFinanciero in cirugiaPqtFinancieros)
            {
                cirugiaPqtFinanciero.PaqueteFinanciero.Id = paquete;
                servicioCirugiaSoapPaquete.AgregarCirugiaPaquete(cirugiaPqtFinanciero);
            }
        }

        /// <summary>
        /// Metodo que inserta el personal quirurgico que va a estar presente en el paquete financiero
        /// </summary>
        /// <param name="paquete"></param>
        public void InsertarPersonalQuirurgico (int paquete)
        {
            ServicioCirugiaPersonalQSoap logica = new ServicioCirugiaPersonalQSoap();
            if (_vista.ComboPrimerAyudante.SelectedIndex != -1)
            {
                PersonalPaquete personalPaquete = new PersonalPaquete();
                personalPaquete.Paquete.Id = paquete;
                personalPaquete.Personal.Id = ((Personal) _vista.ComboPrimerAyudante.SelectedItem).Id;
                personalPaquete.Especialidad = "1er ayudante";
                logica.AgregarCirugiaPersonalQ(personalPaquete);
            }
            if (_vista.ComboAnestesiologo.SelectedIndex != -1)
            {
                PersonalPaquete personalPaquete = new PersonalPaquete();
                personalPaquete.Paquete.Id = paquete;
                personalPaquete.Personal.Id = ((Personal)_vista.ComboAnestesiologo.SelectedItem).Id;
                personalPaquete.Especialidad = "Anestesiologo";
                logica.AgregarCirugiaPersonalQ(personalPaquete);
            }
            if (_vista.ComboInstrumentista.SelectedIndex != -1)
            {
                PersonalPaquete personalPaquete = new PersonalPaquete();
                personalPaquete.Paquete.Id = paquete;
                personalPaquete.Personal.Id = ((Personal)_vista.ComboInstrumentista.SelectedItem).Id;
                personalPaquete.Especialidad = "Instrumentista";
                logica.AgregarCirugiaPersonalQ(personalPaquete);
            }
            if (_vista.ComboCirculante.SelectedIndex != -1)
            {
                PersonalPaquete personalPaquete = new PersonalPaquete();
                personalPaquete.Paquete.Id = paquete;
                personalPaquete.Personal.Id = ((Personal)_vista.ComboCirculante.SelectedItem).Id;
                personalPaquete.Especialidad = "Circulante";
                logica.AgregarCirugiaPersonalQ(personalPaquete);
            }
            if (_vista.InstrumentistaEspecial.SelectedIndex != -1)
            {
                PersonalPaquete personalPaquete = new PersonalPaquete();
                personalPaquete.Paquete.Id = paquete;
                personalPaquete.Personal.Id = ((Personal)_vista.InstrumentistaEspecial.SelectedItem).Id;
                personalPaquete.Especialidad = "Instrumentista Especial";
                logica.AgregarCirugiaPersonalQ(personalPaquete);
            }
        }

        #region Validaciones
        /// <summary>
        /// funcion que sirve para validar el formulario introducido por el cliente.
        /// </summary>
        /// <returns></returns>
        public bool ValidarFormulario()
        {
            if (_vista.ComboIntervencionQuirurgica.SelectedIndex == -1 || _vista.ComboCirujano.SelectedIndex == -1)
            {
                DialogResult result =
                        MessageBox.Show("Debe Seleccionar al menos una cirugia y un cirujano.", "Cuidado", MessageBoxButtons.OK);
                return false;
            }
            if (!_vista.TextProtesis.Text.Equals(""))
            {
                if (!ComprobarNumero(_vista.TextProtesis.Text))
                {
                    DialogResult result =
                            MessageBox.Show("El valor de la protesis no puede contener letras.", "Cuidado", MessageBoxButtons.OK);
                    return false;
                }
            }
            if (!_vista.TextDescuento.Text.Equals(""))
            {
                if (!ComprobarNumero(_vista.TextDescuento.Text))
                {
                    DialogResult result =
                           MessageBox.Show("El descuento no puede contener letras.", "Cuidado", MessageBoxButtons.OK);
                    return false;
                }
                else if (Convert.ToInt32(_vista.TextDescuento.Text) > 100 || Convert.ToInt32(_vista.TextDescuento.Text) < 0)
                {
                    DialogResult result =
                            MessageBox.Show("El decuento ofrecido es invalido.", "Cuidado", MessageBoxButtons.OK);
                    return false;
                }

            }
            return true;
        }

        public bool ComprobarNumero(string numero)
        {
            try
            {
                float.Parse(numero);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ComprobarFechaCorrecta(string dia, string mes, string ano)
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

        public bool ValidarQueSePuedaAceptarLaTransaccion()
        {
            if (cirugiaPqtFinancieros.Count == 0)
            {
                DialogResult result =
                            MessageBox.Show("Debe agregar cirugias para procesar la operacion.", "Cuidado", MessageBoxButtons.OK);
                return false;
            }
            if (!ComprobarFechaCorrecta(_vista.TextDiaIqx1.Text,_vista.TextMesIqx1.Text,_vista.TextAnoIqx1.Text))
            {
                DialogResult result =
                            MessageBox.Show("La fecha de la intervencion esta en un formato incorrecto.", "Cuidado", MessageBoxButtons.OK);
                return false;
            }
            if (!ComprobarFechaCorrecta(_vista.TextDiaElaboracion.Text,_vista.TextMesElaboracion.Text,_vista.TextAnoElaboracion.Text))
            {
                DialogResult result =
                            MessageBox.Show("La fecha de elaboracion esta en un formato incorrecto.", "Cuidado", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        #endregion

    }
}
