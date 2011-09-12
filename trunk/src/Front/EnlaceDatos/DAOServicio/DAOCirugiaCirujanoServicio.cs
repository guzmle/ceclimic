using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnlaceDatos.IDAO;
using Proxy.ProxyCirugiaCirujano;
using Cirugia = Entidades.Cirugia;
using CirugiaServicio = Proxy.ProxyCirugiaCirujano.Cirugia;
using CirugiaCirujano = Entidades.CirugiaCirujano;
using CirugiaCirujanoServicio = Proxy.ProxyCirugiaCirujano.CirugiaCirujano;
using Cirujano = Entidades.Cirujano;
using CirujanoServicio = Proxy.ProxyCirugiaCirujano.Cirujano;

namespace EnlaceDatos.DAOServicio
{
    /// <summary>
    /// Clase que mantiene el control sobre la entidad CirugiaCirujano
    /// </summary>
    public class DAOCirugiaCirujanoServicio: IDAOCirugiaCirujano 
    {
        #region Implementation of IDAOCirugiaCirujano

        /// <summary>
        /// Metodo que almacena una cirugiaCirujano en la base de datos
        /// </summary>
        /// <param name="objeto"></param>
        /// <returns></returns>
        public bool AgregarCirugiaCirujano(CirugiaCirujano objeto)
        {
            try
            {
                ServicioCirugiaCirujano servicio = new ServicioCirugiaCirujano();
                CirugiaCirujanoServicio cirugiaServicio = new CirugiaCirujanoServicio();
                cirugiaServicio.Cirugia = new CirugiaServicio();
                cirugiaServicio.Cirugia.Id = objeto.Cirugia.Id;
                cirugiaServicio.Cirujano = new CirujanoServicio();
                cirugiaServicio.Cirujano.Id = objeto.Cirujano.Id;
                cirugiaServicio.Honorarios = objeto.Honorarios;
                cirugiaServicio.Nombre = objeto.Nombre;

                return false;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditarCirugiaCirujano(float honorario, int cirugia, int cirujano)
        {
            try
            {
                ServicioCirugiaCirujano servicio = new ServicioCirugiaCirujano();
                return servicio.EditarCirugiaCirujano(honorario, cirugia, cirujano);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EliminarCirugiaCirujano(CirugiaCirujano objeto)
        {
            throw new NotImplementedException();
        }

        public List<CirugiaCirujano> ObtenerCirugiasCirujano(int cedula)
        {
            List<CirugiaCirujano> retorno = new List<CirugiaCirujano>();
            try
            {

                ServicioCirugiaCirujano servicio = new ServicioCirugiaCirujano();
                foreach (CirugiaCirujanoServicio cirugiaCirujanoServicio in servicio.ObtenerCirugiasCirujano(cedula))
                {
                    CirugiaCirujano cirugiaCirujano = new CirugiaCirujano();
                    cirugiaCirujano.Cirugia.Id = cirugiaCirujanoServicio.Cirugia.Id;
                    cirugiaCirujano.Cirujano.Id = cirugiaCirujanoServicio.Cirujano.Id;
                    cirugiaCirujano.Id = cirugiaCirujanoServicio.Id;
                    cirugiaCirujano.Honorarios = cirugiaCirujanoServicio.Honorarios;
                    retorno.Add(cirugiaCirujano);
                }
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        public float PrecioOperacion(Cirugia cirugia, Cirujano cirujano)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
