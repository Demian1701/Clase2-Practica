using Clase2_Practica.Entidades;
using System;
using System.Collections.Generic;

namespace Clase2_Practica.Servicios
{
    public interface ICalculadorIMCService
    {
        public double calcular(double peso, double altura);
    }
}