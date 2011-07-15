using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CECLIMI.Vista
{
    public partial class AgregarPaciente : CECLIMI.Vista.formInicial
    {
        private int iteracion = 1;
        public AgregarPaciente()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            textCodigoAreaFijo.MaxLength = 4;
            textTelefonoFijo.MaxLength = 7;
            textCodigoAreaMovil.MaxLength = 4;
            textTelefonoMovil.MaxLength = 7;
            textDescuento1.MaxLength = 3;
            textDiaIQX1.MaxLength = textMesIQX1.MaxLength = 2;
            textAnoIQX1.MaxLength = 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textCodigoAreaFijo.Text = "";textCodigoAreaMovil.Text = "";textCorreoElectronico.Text = "";textIdPaciente.Text = "";
            textPrimerApellido.Text = "";textSegundoApellido.Text = "";textPrimerNombre.Text = "";textSegundoNombre.Text = "";
            textTelefonoFijo.Text = "";textTelefonoMovil.Text = "";

        }

        private void botonAgregarIntervencionQuirurgica_Click(object sender, EventArgs e)
        {
              
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            grupoDatosPacientes.Visible = false;
            grupoDatosPaciente1.Visible = true;
            grupoIntervencionQuirurgica.Visible = true;
            textoNombrePacienteIngresado.Text = textPrimerNombre.Text + " " + textSegundoNombre.Text;
            textoApellidoPacienteIngresado.Text = textPrimerApellido.Text + " " + textSegundoApellido.Text;
            textoCIPacienteIngresado.Text = textIdPaciente.Text;
            textoCorreoElectronicoPacienteIngresado.Text = textCorreoElectronico.Text;
            textoTelefonoFijoPacienteIngresado.Text = textCodigoAreaFijo.Text + " - " + textTelefonoFijo.Text;
            textoTelefonoMovilIngresado.Text = textCodigoAreaMovil.Text + " - " + textTelefonoMovil.Text;
            textInformacionVentana.Text = "Nuevo Paciente - Agregar Intervencion Quirurgica";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            grupoDatosPacientes.Visible = true;
            grupoDatosPaciente1.Visible = false;
            grupoIntervencionQuirurgica.Visible = false;
            textInformacionVentana.Text = "Nuevo Paciente";
        }
    }
}
