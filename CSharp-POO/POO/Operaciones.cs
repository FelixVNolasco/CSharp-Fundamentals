using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Operaciones
    {

        private double num1, num2, resultado;        
           
        public void Multiplicacion()
        {
            LeerValores();
            resultado = num1 * num2;
            Console.WriteLine("{0} * {1} = {2}", num1, num2, resultado);
        }

        private void LeerValores()
        {
            Console.Write("Asigne el valor al primer numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Asigne el valor al segundo numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            
        }
    }
}
