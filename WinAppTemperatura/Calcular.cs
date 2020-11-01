using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppTemperatura
{
    class Calcular
    {
        double fahrenheit, celsius;
        public Calcular(double Fahrenheit) {
            this.fahrenheit = Fahrenheit;
        }

        public double convertir() {
            celsius = (fahrenheit - 32) * 5 / 9;
            celsius = Math.Round(celsius,2);
            return celsius;
        }
    }
}
