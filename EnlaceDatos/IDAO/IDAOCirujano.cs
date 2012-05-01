﻿using System;
using System.Collections.Generic;

using System.Text;
using Entidades;

namespace EnlaceDatos.IDAO
{
    public interface IDAOCirujano
    {
        bool AgregarCirujano(Cirujano cirujano);
        bool EliminarCirujano(Entidad cirujano);
        bool EditarCirujano(Cirujano cirujano);
        Cirujano ObtenerInformacionCirujano(int cedula);
        List<Cirujano> ObtenerCirujanosCirugia(Entidad cirugia);
        List<Cirujano> ObtenerCirujanos();
        List<Cirugia> ObtenerCirugiasAgregarCirujano(Cirujano cirujano);
    }
}