using System;

namespace Clase2_Practica.Entidades
{

    public class IMC
    {
        public Double Kg { get; set; }

        public Double Estatura { get; set; }

        public Double CalcularIMC => ( Kg / Math.Pow(Estatura,2) );

    }

    /*public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }*/
}
