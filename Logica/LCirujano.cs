﻿using System;
using System.Collections.Generic;

using System.Text;
using EnlaceDatos;
using Entidades;

namespace Logica
{
    /// <summary>
    /// clase que lleva el control de la logica de negocio con al entidad Cirujano
    /// </summary>
    public class LCirujano
    {
        /// <summary>
        /// obtiene una lista de cirujanos que va a ser mostrada en la ventana insertar cirugia.
        /// </summary>
        /// <param name="cirugia"></param>
        /// <returns></returns>
        public List<Cirujano> ObtenerCirujanos(Entidad cirugia)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOCirujano().ObtenerCirujanosCirugia(cirugia);
        }

        /// <summary>
        /// Obtiene todos los cirujanos de la clinica
        /// </summary>
        /// <returns></returns>
        public List<Cirujano> ObtenerCirujanos()
        {
            return DAO.ObtenerDAO(1).ObtenerDAOCirujano().ObtenerCirujanos();
        }

        /// <summary>
        /// Metodo que agrega un cirujano
        /// </summary>
        /// <param name="cirujano"></param>
        /// <returns></returns>
        public bool AgregarCirujano(Cirujano cirujano)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOCirujano().AgregarCirujano(cirujano);
        }

        /// <summary>
        /// Metodo que obtiene informacion del cirujano dado su cedula
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        public Cirujano ObtenerInformacionCirujano (int cedula)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOCirujano().ObtenerInformacionCirujano(cedula);
        }

        /// <summary>
        /// Metodo que edita los datos de un cirujano
        /// </summary>
        /// <param name="cirujano"></param>
        /// <returns></returns>
        public bool EditarCirujano(Cirujano cirujano)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOCirujano().EditarCirujano(cirujano);
        }

        /// <summary>
        /// Metodo que obtiene todas las cirujias que ha realizado el cirujano
        /// </summary>
        /// <param name="cirujano"></param>
        /// <returns></returns>
        public List<Cirugia> ObtenerCirugiasAgregarCirujano(Cirujano cirujano)
        {
            return DAO.ObtenerDAO(1).ObtenerDAOCirujano().ObtenerCirugiasAgregarCirujano(cirujano);
        }
    }
}