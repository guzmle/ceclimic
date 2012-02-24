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
    public class PresentadorEliminarCirugia
    {
        private IContratoEliminarCirugia _vista;
        private Paciente _paciente = new Paciente();
        public PresentadorEliminarCirugia(IContratoEliminarCirugia vista)
        {
            _vista = vista;
        }

        public void BuscarPaciente()
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
                    foreach (Paciente cirugiasPaciente in lPaciente.ObtenerCirugiasPaciente((int)_paciente.Id))
                    {
                        _vista.DataGridView1.Rows.Add(cirugiasPaciente.Cedula,cirugiasPaciente.Nombre,cirugiasPaciente.SegundoNombre,
                            cirugiasPaciente.FechaIngreso,cirugiasPaciente.PrimerApellido);
                    }
                    _vista.TextoCiPaciente.Text = "";

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

        // Boton que le permite al usuario buscar otro usuario.
        public void BuscarOtroPaciente()
        {
            _vista.GrupoDatosPaciente1.Visible = _vista.GrupoCirugiaPaciente.Visible = _vista.GrupoCirugiaEliminar.Visible = false;
            _vista.GrupoInformacionPaciente.Visible = true;
            _vista.DataGridView1.Rows.Clear();
        }

        //metodo que rellena toda la informacion al buscar un paciente
        public void CargarInformacionEnText(Paciente paciente)
        {
            _vista.GrupoInformacionPaciente.Visible = false;
            _vista.GrupoDatosPaciente1.Visible = _vista.GrupoCirugiaPaciente.Visible = _vista.GrupoCirugiaEliminar.Visible =  true;
            _vista.TextoNombrePacienteIngresado.Text = paciente.Nombre + " " + paciente.SegundoNombre;
            _vista.TextoApellidoPacienteIngresado.Text = paciente.PrimerApellido + " " + paciente.SegundoApellido;
            _vista.TextoCiPacienteIngresado.Text = paciente.Id.ToString();
            _vista.TextoCiPaciente.Text = "";
            _vista.TextoCorreoElectronicoPacienteIngresado.Text = paciente.Correo;
            _vista.TextoTelefonoFijoPacienteIngresado.Text = paciente.Telefono;
            _vista.TextoTelefonoMovilPacienteIngresado.Text = paciente.TelefonoMovil;
        }

        public void ClickBotonAceptar()
        {
            try
            {
                bool found = false;
                for (int i = 0; i < _vista.DataGridView1.Rows.Count; i++)
                {
                    Console.WriteLine("Cirugiaaaaaaaaaaaaaa:" + _vista.DataGridView1.Rows[i].Cells["idCirugia"].Value);
                    Console.WriteLine(_vista.TextIdCirugia.Text);
                    if (_vista.DataGridView1.Rows[i].Cells["idCirugia"].Value.ToString().Equals(_vista.TextIdCirugia.Text))
                        found = true;
                        
                }
                if (found)
                {
                    LCirugiaPaqueteFinanciero lCirugiaPaqueteFinanciero = new LCirugiaPaqueteFinanciero();
                    lCirugiaPaqueteFinanciero.EliminarCirugiaPaquete(Convert.ToInt32(_vista.TextIdCirugia.Text));
                    DialogResult result =
                    MessageBox.Show("Cirugia eliminada con exito.", "Cuidado!", MessageBoxButtons.OK);
                }
                else
                {
                    DialogResult result =
                    MessageBox.Show("Ese id de cirugia no es valido para este usuario.", "Cuidado!", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                DialogResult result =
                    MessageBox.Show("Introduzca un valor valido para el id de la cirugia.", "Cuidado!", MessageBoxButtons.OK);
            }
        }
    }
}
