using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Humano
    {
        public string nombre, genero, nacionalidad;
        public double estatura;
        public int edad;

        public Humano (string nombrePa, string nacionalidadPa )
        {
            nombre = nombrePa;
            nacionalidad = nacionalidadPa;
        }
    }
}
