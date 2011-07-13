using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CECLIMI
{
    public partial class ini : Form
    {
        public ini()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            if (width > 1280)
            {
                panel1.Width = panel1.Width + (width - 1280);
            }
            else
            {
                panel1.Width = panel1.Width - (1200 - width);
            }
            if (height > 800)
            {
                panel1.Height = panel1.Height + (height - 830);
                panelDatos.Height = panelDatos.Height + (height - 830);
            }
            else
            {
                panel1.Height = panel1.Height - (830 - height);
                panelDatos.Height = panelDatos.Height - (830 - height);
            }
        }

        protected new void WndProc(ref Message m)
        {
            base.WndProc(ref m);
        }

        private void panelDatos_Paint(object sender, PaintEventArgs e)
        {
            nombreMostrar.Text = "Daniel Antonio";
            apellidoMostrar.Text = "Zamora Bustamante";
            rollMostrar.Text = "Administrativo";
            usuarioMostrar.Text = "dzamora87";
        }
    }
}
