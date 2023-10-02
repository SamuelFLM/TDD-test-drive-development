using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewTalents
{
    public class Calculadora
    {
        public Calculadora()
        {
        }
        public int Somar(int val1, int val2)
        {
            return val1 + val2;
        }

        public int Subtrair(int val1, int val2)
        {
            return val1 - val2;
        }

        public int Multiplicar(int val1, int val2)
        {
            return val1 * val2;
        }

        public int Dividir(int val1, int val2)
        {
            return val1 / val2;
        }

    }
}
