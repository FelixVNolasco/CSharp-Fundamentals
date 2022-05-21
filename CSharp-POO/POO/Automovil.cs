using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Automovil
    {

        public string modelo, color;
        public int numeroPuertas;
        public double velocidad;

        public Automovil (string modeloPa, string colorPa, int numeroPuertasPa)
        {
            //Console.WriteLine("Inicializando el constructor...");
            modelo = modeloPa;
            color = colorPa;
            numeroPuertas = numeroPuertasPa;
        }

        public Automovil (string modeloPa, string colorPa)
        {
            modelo = modeloPa;
            color = colorPa;
        }

        public Automovil (string modeloPa, string colorPa, int numeroPuertasPa, double velocidadPa)
        {
            modelo = modeloPa;
            color = colorPa;
            numeroPuertas = numeroPuertasPa;
            velocidad = velocidadPa;
        }
    }
}
