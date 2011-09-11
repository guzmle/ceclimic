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
    public class PresentadorAgregarCirugiaPaciente
    {
        private IContratoAgregarCirugiaPaciente _vista;
        private Paciente _paciente = new Paciente();

        public PresentadorAgregarCirugiaPaciente(IContratoAgregarCirugiaPaciente vista)
        {
            _vista = vista;
        }

        //metodo que busca la informacion del paciente
        public void BuscarInformacionPaciente()
        {
            try
            {
                LPaciente lPaciente = new LPaciente();
                _paciente = lPaciente.ObtenerInformacionPaciente(Convert.ToInt32(_vista.TextoCiPaciente.Text));
                _paciente.Id = Convert.ToInt32(_vista.TextoCiPaciente.Text);
                _paciente.Cedula = Convert.ToInt32(_vista.TextoCiPaciente.Text);
                if (_paciente.Nombre != null)
                {
                    CargarInformacionEnText(_paciente);
                    LCirugia lCirugia = new LCirugia();
                    LPersonalQuirurgico lPersonalQuirurgico = new LPersonalQuirurgico();

                    foreach (Cirugia cirugia  in lCirugia.ObtenerCirugias())
                    {
                        _vista.ComboIntervencionQuirurgica.Items.Add(cirugia);
                    }
                    _vista.ComboIntervencionQuirurgica.DisplayMember = "Nombre";
                    _vista.ComboIntervencionQuirurgica.ValueMember = "Id";

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

        //metodo que rellena toda la informacion al buscar un paciente
        public void CargarInformacionEnText(Paciente paciente)
        {
            _vista.GrupoInformacionPaciente.Visible = false;
            _vista.GrupoDatosPaciente1.Visible = _vista.GrupoIntervencionQuirurgica.Visible = true;
            _vista.TextoNombrePacienteIngresado.Text = paciente.Nombre + " " + paciente.SegundoNombre;
            _vista.TextoApellidoPacienteIngresado.Text = paciente.PrimerApellido + " " + paciente.SegundoApellido;
            _vista.TextoCiPacienteIngresado.Text = paciente.Id.ToString();
            _vista.TextoCiPaciente.Text = "";
            _vista.TextoCorreoElectronicoPacienteIngresado.Text = paciente.Correo;
            _vista.TextoTelefonoFijoPacienteIngresado.Text = paciente.Telefono;
            _vista.TextoTelefonoMovilPacienteIngresado.Text = paciente.TelefonoMovil;
        }

        //metodo que activa y desactiva los paneles necesarios, ademas de vaciar la informacion de los text.
        public void BuscarOtroPaciente()
        {
            _vista.GrupoInformacionPaciente.Visible = true;
            _vista.GrupoDatosPaciente1.Visible = _vista.GrupoIntervencionQuirurgica.Visible = false;
            _vista.TextoNombrePacienteIngresado.Text = "";
            _vista.TextoApellidoPacienteIngresado.Text = "";
            _vista.TextoCiPacienteIngresado.Text = "";
            _vista.TextoCiPaciente.Text = "";
            _vista.TextoCorreoElectronicoPacienteIngresado.Text = "";
            _vista.TextoTelefonoFijoPacienteIngresado.Text = "";
            _vista.TextoTelefonoMovilPacienteIngresado.Text = "";

            _vista.ComboIntervencionQuirurgica.Items.Clear();
            _vista.ComboIntervencionQuirurgica.Text = "";
            _vista.ComboPrimerAyudante.Items.Clear();
            _vista.ComboPrimerAyudante.Text = "";
            _vista.ComboCirculante.Items.Clear();
            _vista.ComboCirculante.Text = "";
            _vista.ComboAnestesiologo.Items.Clear();
            _vista.ComboAnestesiologo.Text = "";
            _vista.ComboInstrumentista.Items.Clear();
            _vista.ComboInstrumentista.Text = "";
            _vista.InstrumentistaEspecial.Items.Clear();
            _vista.InstrumentistaEspecial.Text = "";
            _vista.ComboCirujano.Items.Clear();
            _vista.ComboCirujano.Text = "";
            _vista.TextoHonorarioCirujano.Text = "";
            _vista.TextoHonorarioCirujano.Visible = _vista.TextoBsfHonorario.Visible = false;
            _vista.TextProtesis.Text = "";
            _vista.TextDescuento.Text = "0";
            _vista.TextDiaIqx1.Text = _vista.TextMesIqx1.Text = _vista.TextAnoIqx1.Text = "";
        }

        //metodo que al seleccionar una intervencion quirurgica, busca los cirujanos que practican esta.
        public void CargarInformacionCirujanos()
        {
            if (_vista.ComboIntervencionQuirurgica.SelectedIndex != -1)
            {
                LCirujano logica = new LCirujano();
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

        //metodo que dependiendo el cirujano y la cirugia seleccionada, buscar el precio de la operacion
        public void PrecioOperacion()
        {
            if (_vista.ComboCirujano.SelectedIndex != -1)
            {
                LCirugiaCirujano logica = new LCirugiaCirujano();
                _vista.TextoHonorarioCirujano.Text =
                    logica.ObtenerCirugiaCirujano((Cirugia)_vista.ComboIntervencionQuirurgica.SelectedItem,
                                                  (Cirujano)_vista.ComboCirujano.SelectedItem).ToString();
                _vista.TextoHonorarioCirujano.Visible = true;
                _vista.TextoBsfHonorario.Visible = true;
            }
        }

        //metodo de cuando toca aceptar
        public void ClickAceptar()
        {
            LPaqueteFinanciero logicaP = new LPaqueteFinanciero();
            PaqueteFinanciero paqueteFinanciero = new PaqueteFinanciero();

            paqueteFinanciero.FechaPaquete = DateTime.Now;
            paqueteFinanciero.Paciente = _paciente;
            int idPaqueteFinanciero = logicaP.AgregarPaqueteFinanciero(paqueteFinanciero);

            LCirugiaPaqueteFinanciero lCirugiaPaqueteFinanciero = new LCirugiaPaqueteFinanciero();
            CirugiaPqtFinanciero cirugiaPqtFinanciero = new CirugiaPqtFinanciero();
            cirugiaPqtFinanciero.Protesis = Convert.ToInt32(_vista.TextProtesis.Text);
            cirugiaPqtFinanciero.FechaOperacion = new DateTime(Convert.ToInt32(_vista.TextAnoIqx1.Text), 
                Convert.ToInt32(_vista.TextMesIqx1.Text), Convert.ToInt32(_vista.TextDiaIqx1.Text));
            Cirugia cirugia = new Cirugia();
            cirugia = (Cirugia) _vista.ComboIntervencionQuirurgica.SelectedItem;
            Cirujano cirujano = new Cirujano();
            cirujano = (Cirujano) _vista.ComboCirujano.SelectedItem;
            cirugiaPqtFinanciero.Cirugia.Id = Convert.ToInt32(cirugia.Id);
            cirugiaPqtFinanciero.Cirujano.Id = Convert.ToInt32(cirujano.Id);
            cirugiaPqtFinanciero.PaqueteFinanciero.Id = idPaqueteFinanciero;
            cirugiaPqtFinanciero.Descuento = Convert.ToInt32(_vista.TextDescuento.Text);
            cirugiaPqtFinanciero.MontoCirujano = Convert.ToInt32(_vista.TextoHonorarioCirujano.Text);
            int idCirugiaPqtFinanciero = lCirugiaPaqueteFinanciero.AgregarCirugiaPaquete(cirugiaPqtFinanciero);

            LCirugiaPersonalQ lCirugiaPersonalQ = new LCirugiaPersonalQ();
            PersonalPaquete personal = new PersonalPaquete();
            
            if (_vista.ComboPrimerAyudante.SelectedIndex != -1)
            {
                personal.Personal = (Personal)_vista.ComboPrimerAyudante.SelectedItem;
                personal.Especialidad = "1er Ayudante";
                personal.Cirugia.Id = idCirugiaPqtFinanciero;
                lCirugiaPersonalQ.AgregarCirugiaPersonalQ(personal);
            }
            if (_vista.ComboAnestesiologo.SelectedIndex != -1)
            {
                personal.Personal = (Personal)_vista.ComboAnestesiologo.SelectedItem;
                personal.Especialidad = "Anestesiologo";
                personal.Cirugia.Id = idCirugiaPqtFinanciero;
                lCirugiaPersonalQ.AgregarCirugiaPersonalQ(personal);
            }
            if (_vista.ComboInstrumentista.SelectedIndex != -1)
            {
                personal.Personal = (Personal)_vista.ComboInstrumentista.SelectedItem;
                personal.Especialidad = "Instrumentista";
                personal.Cirugia.Id = idCirugiaPqtFinanciero;
                lCirugiaPersonalQ.AgregarCirugiaPersonalQ(personal);
            }
            if (_vista.ComboCirculante.SelectedIndex != -1)
            {
                personal.Personal = (Personal)_vista.ComboCirculante.SelectedItem;
                personal.Especialidad = "Circulante";
                personal.Cirugia.Id = idCirugiaPqtFinanciero;
                lCirugiaPersonalQ.AgregarCirugiaPersonalQ(personal);
            }
            if (_vista.InstrumentistaEspecial.SelectedIndex != -1)
            {
                personal.Personal = (Personal)_vista.InstrumentistaEspecial.SelectedItem;
                personal.Especialidad = "Instrumentista Especial";
                personal.Cirugia.Id = idCirugiaPqtFinanciero;
                lCirugiaPersonalQ.AgregarCirugiaPersonalQ(personal);
            }

        }

    }
}
