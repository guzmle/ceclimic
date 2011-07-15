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
            textDescuento2.MaxLength = 3;
            textDescuento3.MaxLength = 3;
            textDescuento4.MaxLength = 3;
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
              if(iteracion==1)
              {
                  iteracion++;
                  comboIntervencionQuirurgica2.Visible = true;
                  comboCirujano2.Visible = true;
                  textDescuento2.Visible = true;
                  textAnoIQX2.Visible = textDiaIQX2.Visible = textMesIQX2.Visible = true;
              }
              else if ( iteracion == 2)
              {
                  iteracion++;
                  comboIntervencionQuirurgica3.Visible = true;
                  comboCirujano3.Visible = true;
                  textDescuento3.Visible = true;
                  textAnoIQX3.Visible = textDiaIQX3.Visible = textMesIQX3.Visible = true;
              }
              else if ( iteracion == 3)
              {
                  iteracion++;
                  comboIntervencionQuirurgica4.Visible = true;
                  comboCirujano4.Visible = true;
                  textDescuento4.Visible = true;
                  //textAnoIQX4.Visible = textDiaIQX4.Visible = textMesIQX4.Visible = true;
              }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if(iteracion == 4)
            {
                iteracion--;
                comboIntervencionQuirurgica4.Visible = false;
                comboCirujano4.Visible = false;
                textDescuento4.Visible = false;
                //textAnoIQX4.Visible = textDiaIQX4.Visible = textMesIQX4.Visible = false;
                //textAnoIQX4.Text = textDiaIQX4.Text = textMesIQX4.Text = "";
            }
            else if ( iteracion == 3)
            {
                iteracion--;
                comboIntervencionQuirurgica3.Visible = false;
                comboCirujano3.Visible = false;
                textDescuento3.Visible = false;
                textAnoIQX3.Visible = textDiaIQX3.Visible = textMesIQX3.Visible = false;
                textAnoIQX3.Text = textDiaIQX3.Text = textMesIQX3.Text = "";
            }
            else if (iteracion == 2)
            {
                iteracion--;
                comboIntervencionQuirurgica2.Visible = false;
                comboCirujano2.Visible = false;
                textDescuento2.Visible = false;
                textAnoIQX2.Visible = textDiaIQX2.Visible = textMesIQX2.Visible = false;
                textAnoIQX2.Text = textDiaIQX2.Text = textMesIQX2.Text = "";
            }
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

        }

        private void button6_Click(object sender, EventArgs e)
        {
            grupoDatosPacientes.Visible = true;
            grupoDatosPaciente1.Visible = false;
            grupoIntervencionQuirurgica.Visible = false;
        }
    }
}
