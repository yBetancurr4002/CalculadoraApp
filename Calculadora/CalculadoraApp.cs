using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class CalculadoraApp
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public int Restar(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public double Dividir(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("El divisor no puede ser cero.");
            }

            return (double)a / b;
        }

        public double SacarPorcentaje(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("El divisor no puede ser cero.");
            }
            var result = ((double)a / b) * 100;
            return result;
        }
    }
}
