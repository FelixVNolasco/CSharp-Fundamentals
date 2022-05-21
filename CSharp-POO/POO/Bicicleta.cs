using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Bicicleta
    {

        public string marca;
        public string modelo;
        public string color;
        public int rodada;
        public int velocidades;

        public void Acelerar()
        {
            Console.WriteLine("Acelerando...");
        }

        public void Frenar()
        {
            Console.WriteLine("Frenando...");
        }

        public void CambioVelocidades()
        {
            Console.WriteLine("Cambiando de velocidad...");
        }

        public void MostarInformacion()
        {
            Console.WriteLine("Información del producto:");
            Console.WriteLine("Marca: {0}", marca);
            Console.WriteLine("Modelo: {0}", modelo);
            Console.WriteLine("Color: {0}", color);
            Console.WriteLine("Rodada: {0}", rodada);
            Console.WriteLine("Velocidades: {0}", velocidades);
        }
    }
}
