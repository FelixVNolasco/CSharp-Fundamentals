using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Nombre
    {
        string primerNombre;
        string segundoNombre;
        string tercerNombre;
        string apellidoPaterno;
        string apellidoMaterno;

        public string PrimerNombre
        {
            get { return primerNombre; }
            set { primerNombre = value; }
        }

        public string SegundoNombre
        {
            get { return segundoNombre; }
            set { segundoNombre = value; }            
        }

        public string TercerNombre
        { 
            get { return tercerNombre; }
            set { tercerNombre = value; }
        }

        public string ApellidoPaterno
        {
            get { return apellidoPaterno; }
            set { apellidoPaterno = value; }
        }

        public string ApellidoMaterno
        {
            get { return apellidoMaterno; }
            set { apellidoMaterno = value; }
        }
         

        public Nombre (string nombre, string apellidoPaternoPa, string apellidoMaternoPa)
        {
            primerNombre = nombre;
            apellidoPaterno = apellidoPaternoPa;
            apellidoMaterno = apellidoMaternoPa;
        }
        public Nombre (string primerNombrePa, string segundoNombrePa, string apellidoPaternoPa, string apellidoMaternoPa)
        {
            primerNombre = primerNombrePa;
            segundoNombre = segundoNombrePa;
            apellidoPaterno = apellidoPaternoPa;
            apellidoMaterno = apellidoMaternoPa;
        }

        public Nombre (string primerNombrePa, string segundoNombrePa, string tercerNombrePa, string apellidoPaternoPa, string apellidoMaternoPa)
        {
            primerNombre = primerNombrePa;
            segundoNombre = segundoNombrePa;
            tercerNombre = tercerNombrePa;
            apellidoPaterno = apellidoPaternoPa;
            apellidoMaterno = apellidoMaternoPa;
        }
        
    }
}
