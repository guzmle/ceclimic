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
    public class PresentadorModificarPaciente
    {
        private IContratoModificarPaciente _vista;
        LPaciente logica = new LPaciente();
        Paciente paciente = new Paciente();
        private String cedula = "";

        public PresentadorModificarPaciente(IContratoModificarPaciente vista)
        {
            _vista = vista;
        }

        //mostrar informacion del paciente cuando se presiona el boton buscar.
        public void BuscarInformacionPaciente()
        {
            paciente = logica.ObtenerInformacionPaciente(Convert.ToInt32(_vista.TextoCiPaciente.Text));
            if (paciente.Nombre != null)
            {
                _vista.TextPrimerNombre.Text = paciente.Nombre;
                _vista.TextPrimerApellido.Text = paciente.PrimerApellido;
                _vista.TextSegundoNombre.Text = paciente.SegundoNombre;
                _vista.TextSegundoApellido.Text = paciente.SegundoApellido;
                if (paciente.Telefono.Length > 3)
                {
                    _vista.TextCodigoAreaFijo.Text = paciente.Telefono.Substring(0, 3);
                    _vista.TextTelefonoFijo.Text = paciente.Telefono.Substring(3);
                }
                if (paciente.TelefonoMovil.Length > 3)
                {
                    _vista.TextCodigoAreaMovil.Text = paciente.TelefonoMovil.Substring(0, 3);
                    _vista.TextTelefonoMovil.Text = paciente.TelefonoMovil.Substring(3);
                }
                _vista.TextCorreoElectronico.Text = paciente.Correo;
                cedula = _vista.TextoCiPaciente.Text;
                MostrarOcultarGrupoInformacion(true);
            }
            else
            {
                cedula = "";
                MostrarOcultarGrupoInformacion(false);
                DialogResult result =
                MessageBox.Show("El paciente que desea modificar no fue encontrado.", "Cuidado!", MessageBoxButtons.OK);
            }
            
        }

        // metodo que segun el boleano muestra o esconde el panel de informacion
        public void MostrarOcultarGrupoInformacion(bool opcion)
        {
            _vista.GrupoDatosPaciente.Visible = opcion;
            _vista.PrimerNombre.Visible = _vista.SegundoNombre.Visible = _vista.PrimerApellido.Visible = _vista.SegundoApellido.Visible = opcion;
            _vista.TelefonoFijo.Visible = _vista.TelefonoMovil.Visible = _vista.CorreoElectronico.Visible = opcion;
            _vista.TextPrimerNombre.Visible = _vista.TextSegundoNombre.Visible = _vista.TextPrimerApellido.Visible = _vista.TextSegundoApellido.Visible = opcion;
            _vista.TextCodigoAreaFijo.Visible = _vista.TextCodigoAreaMovil.Visible = _vista.TextTelefonoFijo.Visible = opcion;
            _vista.TextTelefonoMovil.Visible = _vista.TextCorreoElectronico.Visible = opcion;
            if (!opcion)
            {
                _vista.TextPrimerNombre.Text = _vista.TextSegundoNombre.Text = _vista.TextPrimerApellido.Text = _vista.TextSegundoApellido.Text = "";
                _vista.TextoCiPaciente.Text = _vista.TextCodigoAreaFijo.Text = _vista.TextCodigoAreaMovil.Text = _vista.TextTelefonoFijo.Text = "";
                _vista.TextTelefonoMovil.Text = _vista.TextCorreoElectronico.Text = _vista.TextIdPaciente.Text = "";
            }
        }

        public void ClickBotonAceptar()
        {
            if (!ValidarCamposTelefonicos())
            {
                DialogResult result =
                MessageBox.Show("Los campos telefonicos estan en el formato incorrecto.", "Cuidado!", MessageBoxButtons.OK);
            }
            else if (!cedula.Equals(""))
            {
                paciente.Cedula = Convert.ToInt32(_vista.TextoCiPaciente.Text);
                paciente.Nombre = _vista.TextPrimerNombre.Text;
                paciente.PrimerApellido = _vista.TextPrimerApellido.Text;
                paciente.SegundoNombre = _vista.TextSegundoNombre.Text;
                paciente.SegundoApellido = _vista.TextSegundoApellido.Text;
                paciente.Telefono = _vista.TextCodigoAreaFijo.Text + _vista.TextTelefonoFijo.Text;
                paciente.TelefonoMovil = _vista.TextCodigoAreaMovil.Text + _vista.TextTelefonoMovil.Text;
                paciente.Correo = _vista.TextCorreoElectronico.Text;
                logica.EditarPaciente(paciente);
            }
            else
            {
                DialogResult result =
                MessageBox.Show("Debe buscar al cliente para poder completar la operacion.", "Cuidado!", MessageBoxButtons.OK);
            }
        }

        public bool ValidarCamposTelefonicos()
        {
            try
            {
                if (_vista.TextTelefonoFijo.Text.Length > 0)
                {
                    if (_vista.TextCodigoAreaFijo.Text.Length != 3)
                        return false;
                }
                else if (_vista.TextCodigoAreaFijo.Text.Length != 0)
                {
                    return false;
                }

                if (_vista.TextTelefonoMovil.Text.Length > 0)
                {
                    if (_vista.TextCodigoAreaMovil.Text.Length != 3)
                        return false;
                }
                else if (_vista.TextCodigoAreaMovil.Text.Length != 0)
                {
                    return false;
                }

                if (_vista.TextTelefonoFijo.Text.Length != 7 && _vista.TextTelefonoFijo.Text.Length != 0)
                    return false;
                if (_vista.TextTelefonoMovil.Text.Length != 7 && _vista.TextTelefonoMovil.Text.Length != 0)
                    return false;

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
