using System;
using System.Collections.Generic;

using System.Text;
using System.Windows.Forms;
using CECLIMI.Contratos;
using Proxy;


namespace CECLIMI.Presentador
{
    public class PresentadorAgregarPaciente
    {
        #region atributos
        private IContratoAgregarPaciente _vista;
        private List<Cirugia> _cirugias = new List<Cirugia>();
        private int _iteracion = 0;
        private List<List<Personal>> personaServicioCirugiaSoap = new List<List<Personal>>();
        ServicioPacienteSoap ServicioPacienteSoap = new ServicioPacienteSoap();
        #endregion

        #region constructor
        public PresentadorAgregarPaciente (IContratoAgregarPaciente vista)
        {
            _vista = vista;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// metodo que revisa si una cedula de identidad no contiene caracteres alfabeticos, este metodo es utilizado por la Vista
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        public int RevisarErrorAlConvertirAInt(String cedula)
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
        /// Metodo que valida los campos del formulario.
        /// </summary>
        /// <returns></returns>
        public bool ValidarCampos()
        {
            bool respuesta = true;
            if (_vista.TextPrimerNombre.Text.Equals("") || _vista.TextPrimerApellido.Text.Equals("") || _vista.TextIdPaciente.Text.Equals(""))
            {
                respuesta = false;
                DialogResult result =
                MessageBox.Show("Asegurese de estar llenando los campos obligatorios (*)", "Cuidado!", MessageBoxButtons.OK);
            }
            else if (RevisarErrorAlConvertirAInt(_vista.TextIdPaciente.Text) == -1)
            {
                respuesta = false;
                DialogResult result =
                MessageBox.Show("La cedula de identidad no puede contener caracteres alfabeticos.", "Cuidado!", MessageBoxButtons.OK);
            }
            else if (ServicioPacienteSoap.ValidarPacienteExistente(Convert.ToInt32(_vista.TextIdPaciente.Text)) == 1)
            {
                respuesta = false;
                DialogResult result =
                MessageBox.Show("Este paciente ya esta registrado en el sistema", "Cuidado!", MessageBoxButtons.OK);
            }
            return respuesta;
        }

        /// <summary>
        /// metodo que realiza la accion del boton aceptar
        /// </summary>
        public bool ClickAceptar()
        {
            bool respuesta = ValidarCampos();
            if (respuesta)
            {
                ServicioPacienteSoap logica = new ServicioPacienteSoap();
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

                respuesta = logica.AgregarPaciente(paciente);
                if (respuesta)
                {
                    DialogResult result =
                            MessageBox.Show("Paciente agregado correctamente,", "Transaccion Correcta", MessageBoxButtons.OK);
                }
                else
                {
                    DialogResult result =
                            MessageBox.Show("Paciente no pudo ser agregado correctamente,", "Cuidado!", MessageBoxButtons.OK);
                }
            }
            return respuesta;
        }
        #endregion
    }
}
