using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class ClaseEjemplo
    {

        string nombre;
        string apellido;

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string Apellido
        {            
            set
            {
                apellido = value;
            }
            get { return apellido; }
        }

        public string SegundoNombre
        {
            get; set;
        }
    }
}
