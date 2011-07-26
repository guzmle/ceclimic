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
        /// metodo agregar nueva intervencion quirurgica
        /// </summary>
        public void agregarIntervencionesQuirurgicas ()
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
            _vista.TextoCorreoElectronicoPacienteIngresado.Text = _vista.TextCorreoElectronico.Text;
            _vista.TextoTelefonoFijoPacienteIngresado.Text = _vista.TextCodigoAreaFijo.Text + " - " + _vista.TextTelefonoFijo.Text;
            _vista.TextoTelefonoMovilIngresado.Text = _vista.TextCodigoAreaMovil.Text + " - " + _vista.TextTelefonoMovil.Text;
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
            }
            _vista.Combo1ErAyudante.DisplayMember = "Nombre";
            _vista.Combo1ErAyudante.ValueMember = "Id";
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
            LCirujano logica = new LCirujano();
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

        /// <summary>
        /// funcion que dependiendo de la cirugia seleccionada y el cirujano, regresa el precio de la operacion
        /// </summary>
        public void PrecioOperacion()
        {
            LCirugiaCirujano logica = new LCirugiaCirujano();
            _vista.TextoHonorarioCirujano.Text =
                logica.ObtenerCirugiaCirujano((Cirugia) _vista.ComboIntervencionQuirurgica.SelectedItem,
                                              (Cirujano) _vista.ComboCirujano.SelectedItem).ToString();
            _vista.TextoHonorarioCirujano.Visible = true;
            _vista.TextoBsFHonorarios.Visible = true;
        }

        /// <summary>
        /// metodo que se usa para almacenar la intervencion guardada, y ademas para almacenar en el datagrid.
        /// </summary>
        public void AgregarNuevaIntervencionQuirurgica()
        {
            iteracion++;
            _vista.DataGridCirugias.Visible = true;
            _vista.DataGridCirugias.Rows.Add(iteracion.ToString(),_vista.ComboIntervencionQuirurgica.Text,
                _vista.ComboCirujano.Text,"BsF. "+_vista.TextProtesis.Text,_vista.TextDiaIQX1.Text +" / "+_vista.TextmesIQX1.Text+" / "+_vista.TextAnoIQX1.Text
                ,"BsF. "+ _vista.TextoHonorarioCirujano.Text,"pro");

            List<Personal> miListaPersonal = new List<Personal>();
            Personal personal = new Personal();
            if (!_vista.Combo1ErAyudante.Text.Equals(""))
            {
                personal =  (Personal) _vista.Combo1ErAyudante.SelectedItem;
                personal.Especializacion = _vista.Label1.Text;
                miListaPersonal.Add(personal);
            }
            if (!_vista.ComboAnestesiologo.Text.Equals(""))
            {
                personal.Id = (long)_vista.ComboAnestesiologo.SelectedItem;
                personal.Especializacion = _vista.Label2.Text;
                miListaPersonal.Add(personal);
            }
            if (!_vista.ComboInstrumentista.Text.Equals(""))
            {
                personal.Id = (long)_vista.ComboInstrumentista.SelectedItem;
                personal.Especializacion = _vista.Label3.Text;
                miListaPersonal.Add(personal);
            }
            if (!_vista.ComboCirculante.Text.Equals(""))
            {
                personal.Id = (long)_vista.ComboCirculante.SelectedItem;
                personal.Especializacion = _vista.Label4.Text;
                miListaPersonal.Add(personal);
            }
            if (!_vista.ComboInstrumentalEspecial.Text.Equals(""))
            {
                personal.Id = (long)_vista.ComboInstrumentalEspecial.SelectedItem;
                personal.Especializacion = _vista.Label5.Text;
                miListaPersonal.Add(personal);
            }
            Console.Write(miListaPersonal);
            personalCirugia.Add(miListaPersonal);
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
