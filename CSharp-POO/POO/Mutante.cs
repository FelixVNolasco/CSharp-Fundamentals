using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Mutante : Humano
    {
        public bool genx;
        public string alias, clasificacion;

        public Mutante(bool genxPa, string nombrePa, string aliasPa, string nacionalidadPa, string clasificacionPa) : base(nombrePa, nacionalidadPa)
        {
            genx = genxPa;
            alias = aliasPa;
            clasificacion = clasificacionPa;
        }
    }
}
