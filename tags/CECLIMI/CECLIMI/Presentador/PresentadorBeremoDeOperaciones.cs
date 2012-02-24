using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CECLIMI.Contratos;
using Entidades;
using Logica;

namespace CECLIMI.Presentador
{
    public class PresentadorBeremoDeOperaciones
    {
        private IContratoBeremoDeOperaciones _vista;
        private LCirujano lCirujano = new LCirujano();
        private LCirugiaCirujano lCirugiaCirujano = new LCirugiaCirujano();

        public PresentadorBeremoDeOperaciones ( IContratoBeremoDeOperaciones vista )
        {
            _vista = vista;
        }

        public void BuscarCirujanos()
        {
            List<Cirujano> cirujanos = new List<Cirujano>();
            cirujanos = lCirujano.ObtenerCirujanos();

            foreach (Cirujano cirujano in cirujanos)
	        {
                _vista.UxCirujanos.Items.Add(cirujano);
	        }
            _vista.UxCirujanos.DisplayMember = "Nombre";
            _vista.UxCirujanos.ValueMember = "Id";
        }

        public void CargarBeremo()
        {
            Cirujano cirujano = (Cirujano) _vista.UxCirujanos.SelectedItem;

            foreach (CirugiaCirujano cirugiaCirujano in lCirugiaCirujano.ObtenerCirugiasCirujano((int) cirujano.Id))
            {
                float primerAyudante = ((cirugiaCirujano.Honorarios * 40) / 100);
                float anestesiologo = ((cirugiaCirujano.Honorarios * 30) / 100);
                float subtotal = primerAyudante + anestesiologo + 2332 + cirugiaCirujano.Honorarios;
                float clinica = ((subtotal*70)/30);
                _vista.UxGridBeremo.Rows.Add(cirugiaCirujano.Nombre, cirugiaCirujano.Honorarios, primerAyudante, anestesiologo, "2332,00", subtotal
                    ,clinica,subtotal+clinica);
            }
            _vista.UxGrupoBeremo.Visible = true;
        }
    }
}
