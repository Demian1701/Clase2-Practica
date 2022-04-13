using Clase2_Practica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase2_Practica.Servicios.Implementacines
{
    public class CalculadorIMCService : ICalculadorIMCService
    {
        public double calcular(double peso, double altura)
        {
            double _imc;

            if(altura != 0)
            {
                _imc = ( peso/ Math.Pow(altura, 2));
            }
            else
            {
                _imc = 0;
            }
            
            return _imc;
        }
    }
}
