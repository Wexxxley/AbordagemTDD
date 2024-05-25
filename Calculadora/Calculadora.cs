using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        private List<string> Historico;
        public Calculadora()
        {
            Historico = new List<string>();
        }
        public int Somar(int a, int b)
        {
            int result = a+b;
            Historico.Insert(0, $"{a} + {b} = {result}");
            return result;
        }
        public int Subtrair(int a, int b)
        {
            int result = a-b;
            Historico.Insert(0, $"{a} - {b} = {result}");
            return result;
        }
        public int Multiplicar(int a, int b)
        {
            int result = a*b;
            Historico.Insert(0, $"{a} * {b} = {result}");
            return result;
        }
        public int Dividir(int a, int b)
        {
             int result = a/b;
            Historico.Insert(0, $"{a} / {b} = {result}");
            return result;
        }
        public List<string> ObterHistorico()
        {
            Historico.RemoveRange(3, Historico.Count()-3);
            return Historico;
        }
        
    }
}