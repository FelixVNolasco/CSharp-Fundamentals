using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Matematicas
    {
        private double num1, num2, resultado;

        public double Num1
        {
            get { return num1; }    
            set { num1 = value; }
        }

        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public double Resultado
        {
            get { return resultado; }
        }

        public void Suma()
        {
            resultado = num1 + num2;
        }

        public void Resta()
        {
            resultado = num1  - num2;
        }

        public void Multiplicacion()
        {
            resultado = num1 * num2;
        }

        public void Division()
        {
            if (num2 == 0)
            {
                Console.WriteLine("No se puede dividir entre 0");
            } else
            {
                resultado = num1 / num2;
            }            
        }

        //public void Suma()
        //{
        //    Console.Write("Dame el valor del primer numero: ");
        //    num1 = Convert.ToDouble(Console.ReadLine());

        //    Console.Write("Dame el valor del segundo numero: ");
        //    num2 = Convert.ToDouble(Console.ReadLine());

        //    resultado = num1 + num2;

        //    Console.WriteLine("{0} + {1} = {2}", num1, num2, resultado);
        //}

        //public void Resta(double num1Pa, double num2Pa)
        //{
        //    resultado = num1Pa - num2Pa;

        //    Console.WriteLine("{0} - {1} = {2}", num1Pa, num2Pa, resultado);
        //}

        //public double Multiplicacion()
        //{
        //    Console.Write("Dame el valor del primer numero: ");
        //    num1 = Convert.ToDouble(Console.ReadLine());

        //    Console.Write("Dame el valor del segundo numero: ");
        //    num2 = Convert.ToDouble(Console.ReadLine());

        //    resultado = num1 * num2;

        //    return resultado;

        //}
    }
}
