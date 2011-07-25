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
    
    public class PresenadorAgregarCirugia
    {
        private IContratoAgregarCirugia _vista;

        public PresenadorAgregarCirugia (IContratoAgregarCirugia vista)
        {
            _vista = vista;
        }

        public void BotonAceptar()
        {
            Cirugia cirugia = new Cirugia();
            LCirugia logica = new LCirugia();
            cirugia.Nombre = _vista.TextNombre.Text;
            cirugia.Descripcion = _vista.TextDescripcion.Text;
            if (logica.AgregarCirugia(cirugia))
            {

                DialogResult result = MessageBox.Show("Cirugia Agregado Con Exito!!", "Mensaje", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                }
            }
            else
            {

                DialogResult result = MessageBox.Show("Cirugia No pudo ser Agregado Con Exito!!", "Error", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                }
            }
        }
    }
}
