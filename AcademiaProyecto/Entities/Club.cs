using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Club
    {
        string nombreClub;
        string nombreProfesor;
        DateTime fechaInicio;
        DateTime fechaFinalizacion;


        public string NombreClub
        {
            get { return nombreClub; }
            set { nombreClub = value; }
        }

        public string NombreProfesor
        { 
            get { return nombreProfesor; }
            set { nombreProfesor = value; }
        }

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        public DateTime FrechaFinalizacion
        {
            get { return fechaFinalizacion; }
            set { fechaFinalizacion = value; }
        }

        public Club(string nombreClubPa, string nombreProfesorPa, DateTime fechaInicioPa, DateTime fechaFinalizacionPa)
        {
            nombreClub = nombreClubPa;
            nombreProfesor = nombreProfesorPa;
            fechaInicio = fechaInicioPa;
            fechaFinalizacion = fechaFinalizacionPa;
        }
    }

}
