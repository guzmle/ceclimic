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
    public class PresentadorAgregarPaciente
    {
        private IContratoAgregarPaciente _vista;
        private List<Cirugia> _cirugias = new List<Cirugia>();
        private int iteracion = 0;
        private List<List<Personal>> personalCirugia = new List<List<Personal>>();

        public PresentadorAgregarPaciente (IContratoAgregarPaciente vista)
        {
            _vista = vista;
        }

        /// <summary>
        /// metodo agregar nueva intervencion quirurgica - hace el caso de uso de AgregarIQX
        /// </summary>
        public void AgregarIntervencionesQuirurgicas ()
        {
            if(_vista.TextPrimerNombre.Text.Equals("") || _vista.TextPrimerApellido.Text.Equals("") || _vista.TextIdPaciente.Text.Equals(""))
            {
                DialogResult result =
                MessageBox.Show("Asegurese de estar llenando los campos obligatorios (*)", "Cuidado!", MessageBoxButtons.OK);
            }
            else if(RevisarErrorAlCombertirAInt(_vista.TextIdPaciente.Text) != -1)
            {
                LCirugia logica = new LCirugia();
                LPersonalQuirurgico logicaPQ = new LPersonalQuirurgico();
                _vista.ComboIntervencionQuirurgica.Items.Clear();
                _vista.GrupoDatosPaciente.Visible = false;
                _vista.GrupoDatosPaciente1.Visible = true;
                _vista.GrupoIntervencionQuirurgica.Visible = true;
                _vista.TextoNombrePacienteIngresado.Text = _vista.TextPrimerNombre.Text + " " + _vista.TextSegundoNombre.Text;
                _vista.TextoApellidoPacienteIngresado.Text = _vista.TextPrimerApellido.Text + " " + _vista.TextSegundoApellido.Text;
                _vista.TextoCIPacienteIngresado.Text = _vista.TextIdPaciente.Text;

                if (_vista.TextCorreoElectronico.Text.Equals("")) _vista.TextoCorreoElectronicoPacienteIngresado.Text = "N/A";
                else _vista.TextoCorreoElectronicoPacienteIngresado.Text = _vista.TextCorreoElectronico.Text;

                if (_vista.TextTelefonoFijo.Text.Equals("")) _vista.TextoTelefonoFijoPacienteIngresado.Text = "N/A";
                else _vista.TextoTelefonoFijoPacienteIngresado.Text = _vista.TextCodigoAreaFijo.Text + " - " + _vista.TextTelefonoFijo.Text;

                if (_vista.TextTelefonoMovil.Text.Equals("")) _vista.TextoTelefonoMovilIngresado.Text = "N/A";
                else _vista.TextoTelefonoMovilIngresado.Text = _vista.TextCodigoAreaMovil.Text + " - " + _vista.TextTelefonoMovil.Text;
                
                

                _vista.TextInformacionVentana.Text = "Nuevo Paciente - Agregar Intervencion Quirurgica";
                foreach (Cirugia cirugia in logica.ObtenerCirugias())
                {
                    _vista.ComboIntervencionQuirurgica.Items.Add(cirugia);
                }
                _vista.ComboIntervencionQuirurgica.DisplayMember = "Nombre";
                _vista.ComboIntervencionQuirurgica.ValueMember = "Id";

                foreach (Personal personal in logicaPQ.ObtenerPersonalQ())
                {
                    _vista.Combo1ErAyudante.Items.Add(personal);
                    _vista.ComboAnestesiologo.Items.Add(personal);
                    _vista.ComboCirculante.Items.Add(personal);
                    _vista.ComboInstrumentalEspecial.Items.Add(personal);
                    _vista.ComboInstrumentista.Items.Add(personal);
                }
                _vista.Combo1ErAyudante.DisplayMember = _vista.ComboAnestesiologo.DisplayMember = _vista.ComboCirculante.DisplayMember =
                    _vista.ComboInstrumentalEspecial.DisplayMember = _vista.ComboInstrumentista.DisplayMember = "Nombre";
                _vista.Combo1ErAyudante.ValueMember = _vista.ComboAnestesiologo.ValueMember = _vista.ComboCirculante.ValueMember =
                    _vista.ComboInstrumentalEspecial.ValueMember = _vista.ComboInstrumentista.ValueMember = "Id";
            }
            else
            {
                DialogResult result =
                MessageBox.Show("La cedula de identidad no puede contener caracteres alfabeticos (*)", "Cuidado!", MessageBoxButtons.OK);
            }
            
        }

        /// <summary>
        /// metodo que revisa si una cedula de identidad no contiene caracteres alfabeticos, este metodo es utilizado por la Vista
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        public int RevisarErrorAlCombertirAInt(String cedula)
        {
            try
            {
                return Convert.ToInt32(cedula);
            }
            catch (Exception)
            {

                return -1;
            }
        }

        /// <summary>
        /// metodo modificar datos de _paciente
        /// </summary>
        public void ModificarInformacionPaciente()
        {
            _vista.GrupoDatosPaciente.Visible = true;
            _vista.GrupoDatosPaciente1.Visible = false;
            _vista.GrupoIntervencionQuirurgica.Visible = false;
            _vista.TextInformacionVentana.Text = "Nuevo Paciente";
        }

        /// <summary>
        /// metodo que cuando selecciona una cirugia se cargan todos los cirujanos que hacen esa cirugia.
        /// </summary>
        public void SeleccionCirugia()
        {
            if(_vista.ComboIntervencionQuirurgica.SelectedIndex != -1)
            {   LCirujano logica = new LCirujano();
                _vista.ComboCirujano.Items.Clear();
                _vista.ComboCirujano.Text = "";
                _vista.TextoHonorarioCirujano.Visible = false;
                _vista.TextoBsFHonorarios.Visible = false;
                _vista.TextoHonorarioCirujano.Text = "";
                foreach (Cirujano cirujano in logica.ObtenerCirujanos((Cirugia) _vista.ComboIntervencionQuirurgica.SelectedItem))
                {
                    _vista.ComboCirujano.Items.Add(cirujano);
                }
            
                _vista.ComboCirujano.DisplayMember = "Nombre";
                _vista.ComboCirujano.ValueMember = "Id";
            }
            
        }

        /// <summary>
        /// funcion que dependiendo de la cirugia seleccionada y el cirujano, regresa el precio de la operacion
        /// </summary>
        public void PrecioOperacion()
        {
            if (_vista.ComboCirujano.SelectedIndex != -1)
            {
                LCirugiaCirujano logica = new LCirugiaCirujano();
                _vista.TextoHonorarioCirujano.Text =
                    logica.ObtenerCirugiaCirujano((Cirugia)_vista.ComboIntervencionQuirurgica.SelectedItem,
                                                  (Cirujano)_vista.ComboCirujano.SelectedItem).ToString();
                _vista.TextoHonorarioCirujano.Visible = true;
                _vista.TextoBsFHonorarios.Visible = true;
            }
        }

        /// <summary>
        /// metodo que se usa para almacenar la intervencion guardada, y ademas para almacenar en el datagrid.
        /// </summary>
        public void AgregarNuevaIntervencionQuirurgica()
        {
            if (_vista.ComboCirujano.SelectedIndex == -1 || _vista.TextAnoIQX1.Text.Equals("") || 
                _vista.TextDiaIQX1.Text.Equals("") || _vista.TextmesIQX1.Text.Equals("") || _vista.TextAnoIQX1.Text.Length != 4)
            {
                DialogResult result =
                MessageBox.Show("Asegurese de estar llenando los campos obligatorios (*)", "Cuidado!", MessageBoxButtons.OK);
            }
            else
            {
                iteracion++;
                _vista.DataGridCirugias.Visible = true;
                _vista.DataGridCirugias.Rows.Add(iteracion.ToString(),_vista.TextDescuento.Text, _vista.ComboIntervencionQuirurgica.Text,
                    _vista.ComboCirujano.Text,_vista.TextProtesis.Text, _vista.TextDiaIQX1.Text + " / " + _vista.TextmesIQX1.Text + " / " + _vista.TextAnoIQX1.Text
                    ,_vista.TextoHonorarioCirujano.Text);

                List<Personal> miListaPersonal = new List<Personal>();
                Personal personal = new Personal();

                if (_vista.Combo1ErAyudante.SelectedIndex != -1)
                {
                    personal = (Personal)_vista.Combo1ErAyudante.SelectedItem;
                    personal.Especializacion = _vista.Label1.Text;
                    miListaPersonal.Add(personal);
                }
                if (_vista.ComboAnestesiologo.SelectedIndex != -1)
                {
                    personal = (Personal)_vista.ComboAnestesiologo.SelectedItem;
                    personal.Especializacion = _vista.Label2.Text;
                    miListaPersonal.Add(personal);
                }
                if (_vista.ComboInstrumentista.SelectedIndex != -1)
                {
                    personal = (Personal)_vista.ComboInstrumentista.SelectedItem;
                    personal.Especializacion = _vista.Label3.Text;
                    miListaPersonal.Add(personal);
                }
                if (_vista.ComboCirculante.SelectedIndex != -1)
                {
                    personal = (Personal)_vista.ComboCirculante.SelectedItem;
                    personal.Especializacion = _vista.Label4.Text;
                    miListaPersonal.Add(personal);
                }
                if (_vista.ComboInstrumentalEspecial.SelectedIndex != -1)
                {
                    personal = (Personal)_vista.ComboInstrumentalEspecial.SelectedItem;
                    personal.Especializacion = _vista.Label5.Text;
                    miListaPersonal.Add(personal);
                }
                Console.Write(miListaPersonal);
                personalCirugia.Add(miListaPersonal);

                _vista.ComboIntervencionQuirurgica.SelectedIndex = -1;
                _vista.ComboCirujano.SelectedIndex = -1;
                _vista.Combo1ErAyudante.SelectedIndex =
                    _vista.ComboAnestesiologo.SelectedIndex = _vista.ComboCirculante.SelectedIndex = -1;
                _vista.ComboInstrumentalEspecial.SelectedIndex = _vista.ComboInstrumentista.SelectedIndex = -1;
                _vista.TextoHonorarioCirujano.Text = "";
                _vista.TextoBsFHonorarios.Visible = false;
                _vista.TextAnoIQX1.Text = _vista.TextmesIQX1.Text = _vista.TextDiaIQX1.Text = _vista.TextProtesis.Text = "";
                _vista.TextDescuento.Text = "";
            }
            
        }

        /// <summary>
        /// Metodo para eliminar intervencion del datagrid o modificar una que este
        /// </summary>
        public void EliminarIntervencionQuirurgica()
        {
            if(_vista.DataGridCirugias.Rows.Count >= 1)
            {
                if (personalCirugia.Count == _vista.DataGridCirugias.Rows.Count)
                {
                    personalCirugia.RemoveAt(personalCirugia.Count-1);
                }
                _vista.DataGridCirugias.Rows.RemoveAt(_vista.DataGridCirugias.Rows.Count-1);
            }
        }

        /// <summary>
        /// metodo que realiza la accion del boton aceptar , (""Aun falta la parte de las iqx"")
        /// </summary>
        public void ClickAceptar()
        {
            LPaciente logica = new LPaciente();
            Paciente paciente = new Paciente();
            
            paciente.Nombre = _vista.TextPrimerNombre.Text;
            paciente.SegundoNombre = _vista.TextSegundoNombre.Text;
            paciente.SegundoApellido = _vista.TextSegundoApellido.Text;
            paciente.PrimerApellido = _vista.TextPrimerApellido.Text;
            paciente.Cedula = Convert.ToInt64(_vista.TextIdPaciente.Text);
            paciente.Correo = _vista.TextCorreoElectronico.Text;
            paciente.FechaIngreso = DateTime.Now;
            paciente.Telefono = _vista.TextCodigoAreaFijo.Text + _vista.TextTelefonoFijo.Text;
            paciente.TelefonoMovil = _vista.TextCodigoAreaMovil.Text + _vista.TextTelefonoMovil.Text;

            logica.AgregarPaciente(paciente);

            //luego de insertar un paciente debo agregar un paquete financiero a ese paciente
            LPaqueteFinanciero logicaP = new LPaqueteFinanciero();
            PaqueteFinanciero paqueteFinanciero = new PaqueteFinanciero();

            paqueteFinanciero.FechaPaquete = DateTime.Now;
            paqueteFinanciero.Paciente = paciente;
            int idPaqueteFinanciero = logicaP.AgregarPaqueteFinanciero(paqueteFinanciero);

            LCirugiaPaqueteFinanciero lCirugiaPaqueteFinanciero = new LCirugiaPaqueteFinanciero();
            CirugiaPqtFinanciero cirugiaPqtFinanciero = new CirugiaPqtFinanciero();

            cirugiaPqtFinanciero.Protesis = Convert.ToInt64(_vista.TextProtesis.Text);
            cirugiaPqtFinanciero.FechaOperacion = DateTime.Now;
            cirugiaPqtFinanciero.Cirugia = (Cirugia)_vista.ComboIntervencionQuirurgica.SelectedItem;
            cirugiaPqtFinanciero.Cirujano = (Cirujano)_vista.ComboCirujano.SelectedItem;
            cirugiaPqtFinanciero.PaqueteFinanciero.Id = idPaqueteFinanciero;

            int idCirugiaPqtFinanciero = lCirugiaPaqueteFinanciero.AgregarCirugiaPaquete(cirugiaPqtFinanciero);

            //luego debo crear por cada cirugia que se va a hacer un insert en la tabla cirugia_paquete financiero



        }
    }
}
