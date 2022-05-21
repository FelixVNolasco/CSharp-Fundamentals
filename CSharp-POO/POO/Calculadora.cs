using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Calculadora
    {

        public int num1;
        public int num2;
        public int resultado;


        public void SumarConResultado(int num1, int num2)
        {
            int resultadoSuma;
            resultadoSuma = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, resultadoSuma);
        }

        public void Sumar()
        {
            resultado = num1 + num2;
        }

        public void MostarResultado()
        {
            Console.WriteLine("{0} + {1} = {2}", num1, num2, resultado);
        }
    }
}
