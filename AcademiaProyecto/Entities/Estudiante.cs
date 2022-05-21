using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Estudiante
    {
        Nombre nombre;
        Direccion direccion;
        string plantel, carrera;
        int boleta;
        List<Club> clubSocial = new List<Club>();
        bool alumnoInscrito;
        
        public string Plantel 
        {
            get { return plantel; }
            set { plantel = value; }
        }

        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }


        public int Boleta
        {
            get { return boleta; }
            set { boleta = value; }
        }

        public List<Club> ClubSocial
        {
            get { return clubSocial; }
            set { clubSocial = value; }
        }

        public bool AlumnoInscrito
        {
            get { return alumnoInscrito; }
            set { alumnoInscrito = value; }
        }

        public Nombre Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Direccion Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public Estudiante (int boletaPa, Nombre nombrePa, Direccion direccionPa, string carreraPa, string plantelPa, bool alumnoInscritoPa)
        {
            boleta = boletaPa;
            nombre = nombrePa;
            direccion = direccionPa;
            carrera = carreraPa;
            plantel = plantelPa;
            alumnoInscrito = alumnoInscritoPa;
        }

        public List<Club> AgregarNuevoClub(string nombreClubPa, string nombreProfesorPa, DateTime fechaInicioPa, DateTime fechaFinalizacionPa)
        {
            Club nuevoClub = new Club(nombreClubPa, nombreProfesorPa, fechaInicioPa, fechaFinalizacionPa);
            clubSocial.Add(nuevoClub);
            return clubSocial;
        }

    }
}
