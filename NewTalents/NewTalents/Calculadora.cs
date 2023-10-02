using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents
{
    public class Calculadora
    {

        private List<string> historico;
        public Calculadora()
        {
            historico = new List<string>(); 
        }
        public int Somar(int val1, int val2)
        {
            historico.Add($"Método Somar - Values Valor 1: {val1} - Valor 2: {val2}");
            return val1 + val2;
        }

        public int Subtrair(int val1, int val2)
        {
            historico.Add($"Método Subtrair - Values  Valor 1: {val1} - Valor 2: {val2}");
            return val1 - val2;
        }

        public int Multiplicar(int val1, int val2)
        {
            historico.Add($"Método Multiplicar - Values Valor 1: {val1} - Valor 2: {val2}");
            return val1 * val2;
        }

        public int Dividir(int val1, int val2)
        {
            historico.Add($"Método Somar - Values Valor 1: {val1} - Valor 2: {val2}");
            return val1 / val2;
        }

        public List<string> Historico()
        {
            historico.RemoveRange(3, historico.Count - 3);

            return historico;
        }
    }
}
