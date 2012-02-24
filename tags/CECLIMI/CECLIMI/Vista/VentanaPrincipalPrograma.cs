using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CECLIMI.Vista
{
    public partial class VentanaPrincipalPrograma : CECLIMI.Vista.formInicial
    {
        public VentanaPrincipalPrograma()
        {
            InitializeComponent();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            AgregarPaciente agregarPaciente = new AgregarPaciente();
            agregarPaciente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarCirugiaPaciente agregarCirugiaPaciente = new AgregarCirugiaPaciente();
            agregarCirugiaPaciente.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AgregarPagos agregarPagos = new AgregarPagos();
            agregarPagos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AgregarTransferencia agregarTransferencia = new AgregarTransferencia();
            agregarTransferencia.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ModificarPaciente modificarPaciente = new ModificarPaciente();
            modificarPaciente.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            EliminarCirugia eliminarCirugia = new EliminarCirugia();
            eliminarCirugia.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ModificarCirujano modificarCirujano = new ModificarCirujano();
            modificarCirujano.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ModificarCirugiaCirujano modificarCirugiaCirujano = new ModificarCirugiaCirujano();
            modificarCirugiaCirujano.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            AgregarCirugia agregarCirugia = new AgregarCirugia();
            agregarCirugia.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AgregarCirujano agregarCirujano = new AgregarCirujano();
            agregarCirujano.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AgregarCirugiaCirujano agregarCirugiaCirujano = new AgregarCirugiaCirujano();
            agregarCirugiaCirujano.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BeremoDeOperaciones beremoDeOperaciones = new BeremoDeOperaciones();
            beremoDeOperaciones.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ReportePaqueteFinanciero reportePaquete = new ReportePaqueteFinanciero();
            reportePaquete.Show();
        }
    }
}
