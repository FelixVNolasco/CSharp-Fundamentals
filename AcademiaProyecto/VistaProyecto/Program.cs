using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using BussinessProyect;

namespace VistaProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //----- BUSINESS CODE -----
            //BEstudiante estudiante = new BEstudiante();

            //estudiante.CrearNombre("Felix", "Enrique", "Vega", "Nolasco");

            //estudiante.CrearDireccion("Jacaranda", "S/n", "N/A", "San Martín Cuautlalpan", 56644, "Estado de México", "Chalco");

            //estudiante.CrearDatosAcademicos(2019602194, "Ingeniería en Informática", "UPIICSA", true);


            //----- TEMPORAL CODE -----

            Nombre nombre = new Nombre("Felix", "Enrique", "Vega", "Nolasco");

            Direccion direccion = new Direccion("Jacaranda", "S/n", "N/A", "San Martín Cuautlalpan", 56644, "Estado de México", "Chalco");

            Estudiante estudiante = new Estudiante(2019602194, nombre, direccion, "Ingeniería en Informática", "UPIICSA", true);

            Console.WriteLine("Nombre del alumno: {0} {1} {2} {3}", estudiante.Nombre.PrimerNombre, estudiante.Nombre.SegundoNombre, estudiante.Nombre.ApellidoMaterno, estudiante.Nombre.ApellidoPaterno);

            Console.WriteLine("Calle:{0} \nNumero Exterior: {1} \nNumero Interior: {2} \nColonia: {3} \nCodigo postal: {4} \nEstado: {5} \nMunicipio: {6}", estudiante.Direccion.Calle, estudiante.Direccion.NumeroExterior, estudiante.Direccion.NumeroInterior, estudiante.Direccion.ColoniaAlcaldia, estudiante.Direccion.CodigoPostal, estudiante.Direccion.Estado, estudiante.Direccion.DelegacionMunicipio);

            Console.WriteLine("Boleta: {0} \nCarrera: {1} \nPlantel: {2} \nActualmente esta inscrito?: {3}", estudiante.Boleta, estudiante.Carrera, estudiante.Plantel, estudiante.AlumnoInscrito);

            //DateTime fechaCreacion = new DateTime();
            //DateTime fechaFinalizacion = new DateTime(2023, 5, 1, 8, 30, 52);

            //List<Club> nuevoArray = estudiante.AgregarNuevoClub("Guitarra", "Jose Luis Flore Gallardo", fechaCreacion, fechaFinalizacion);

            //Console.WriteLine("Clubes: {0}", nuevoArray[0]);


        }
    }
}
