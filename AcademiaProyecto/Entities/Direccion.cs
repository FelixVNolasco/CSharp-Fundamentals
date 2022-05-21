using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Direccion
    {
        string calle;
        string numeroExterior;
        string numeroInterior;
        string coloniaAlcaldia;
        int codigoPostal;
        string estado;
        string delegacionMunicipio;

        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }

        public string NumeroExterior
        {
            get { return numeroExterior; }
            set { numeroExterior = value; }
        }

        public string NumeroInterior
        {
            get { return numeroInterior; }
            set { numeroInterior = value; }
        }

        public string ColoniaAlcaldia
        {
            get { return coloniaAlcaldia; }
            set { coloniaAlcaldia = value; }
        }

        public int CodigoPostal
        {
            get { return codigoPostal; }
            set { codigoPostal = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string DelegacionMunicipio
        {
            get { return delegacionMunicipio; }
            set { delegacionMunicipio = value; }
        }

        public Direccion(string callePa, string numeroExteriorPa, string numeroInteriorPa, string coloniaAlcaldiaPa, int codigoPostalPa, string estadoPa, string delegacionMunicipioPa)
        {
            calle = callePa;
            numeroExterior = numeroExteriorPa;
            numeroInterior = numeroInteriorPa;
            coloniaAlcaldia = coloniaAlcaldiaPa;
            codigoPostal = codigoPostalPa;
            estado = estadoPa;
            delegacionMunicipio = delegacionMunicipioPa;
        }
    }
}
