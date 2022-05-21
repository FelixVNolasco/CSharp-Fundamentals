using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Bicicleta Bicicleta1 = new Bicicleta();

            //Bicicleta1.marca = "Bennotto";
            //Bicicleta1.modelo = "Z25";
            //Bicicleta1.color = "Black";
            //Bicicleta1.velocidades = 5;
            //Bicicleta1.rodada = 25;

            ////System.Console.WriteLine(Bicicleta1.color);

            //Bicicleta1.Frenar();
            //Bicicleta1.Acelerar();

            //Bicicleta1.MostarInformacion();


            //Calculadora calculadora = new Calculadora();
            //calculadora.num1 = 7;
            //calculadora.num2 = 22;

            //calculadora.Sumar();

            //calculadora.MostarResultado();  

            //calculadora.SumarConResultado(12, 47);
            //calculadora.MostarResultado();



            //Operaciones operaciones = new Operaciones();

            //operaciones.Multiplicacion();


            //int opcion;

            //double num1Ar, num2Ar;
            //double resultado;

            //Console.WriteLine("1. Suma");
            //Console.WriteLine("2. Resta");
            //Console.WriteLine("3. Multiplicacion");
            //Console.Write("Escoge una de las opciones: ");
            //opcion = Convert.ToInt32(Console.ReadLine());

            //Matematicas matematicas = new Matematicas();

            //if (opcion == 1)
            //{
            //    matematicas.Suma();
            //}
            //else
            //{
            //    if (opcion == 2)
            //    {
            //        Console.Write("Dame el valor del primer numero: ");
            //        num1Ar = Convert.ToDouble(Console.ReadLine());

            //        Console.Write("Dame el valor del segundo numero: ");
            //        num2Ar = Convert.ToDouble(Console.ReadLine());

            //        matematicas.Resta(num1Ar, num2Ar);
            //    }
            //    else
            //    {
            //        if (opcion == 3)
            //        {
            //            resultado = matematicas.Multiplicacion();
            //            Console.WriteLine("El resultado de la multiplicacion es: {0}", resultado);
            //        }
            //    }
            //}

            //string nombre;
            //string apellido;

            //string segundoNombre;

            //ClaseEjemplo objetoEjemplo = new ClaseEjemplo();

            //Console.Write("Cual es su nombre?: ");
            //nombre = Console.ReadLine();
            //objetoEjemplo.Nombre = nombre;

            //Console.Write("Cual es su segundo nombre?: ");
            //segundoNombre = Console.ReadLine();
            //objetoEjemplo.SegundoNombre = segundoNombre;

            //Console.Write("Cual es su apellido?: ");
            //apellido = Console.ReadLine();
            //objetoEjemplo.Apellido = apellido;

            //Console.Write("Su nombre es : {0} {1} {2} \n", objetoEjemplo.Nombre, objetoEjemplo.SegundoNombre, objetoEjemplo.Apellido);

            //int opcion;

            //Console.WriteLine("1. Suma");
            //Console.WriteLine("2. Resta");
            //Console.WriteLine("3. Multiplicacion");
            //Console.WriteLine("4. Division");

            //Console.Write("Escoge una de las opciones: ");
            //opcion = Convert.ToInt32(Console.ReadLine());

            //Matematicas calculadora = new Matematicas();

            //Console.Write("Dame el valor del primer numero: ");
            //calculadora.Num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Dame el valor del segundo numero: ");
            //calculadora.Num2 = Convert.ToDouble(Console.ReadLine());

            //if (opcion == 1)
            //{
            //    calculadora.Suma();
            //    Console.WriteLine("{0} + {1} = {2}", calculadora.Num1, calculadora.Num2, calculadora.Resultado);
            //} else
            //{
            //    if (opcion == 2)
            //    {
            //        calculadora.Resta();
            //        Console.WriteLine("{0} - {1} = {2}", calculadora.Num1, calculadora.Num2, calculadora.Resultado);
            //    }
            //    else
            //    {
            //        if (opcion == 3)
            //        {
            //            calculadora.Multiplicacion();
            //            Console.WriteLine("{0} * {1} = {2}", calculadora.Num1, calculadora.Num2, calculadora.Resultado);
            //        }
            //        else
            //        {
            //            if (opcion == 4)
            //            {
            //                calculadora.Division();
            //                Console.WriteLine("{0} / {1} = {2}", calculadora.Num1, calculadora.Num2, calculadora.Resultado);
            //            }
            //        }
            //    }
            //}


            //int resultadoInt;
            //double resultadoDouble;

            //OperacionesSobrecarga objetoOperacion = new OperacionesSobrecarga();

            //resultadoInt = objetoOperacion.Suma(4, 2);

            //Console.WriteLine("El resultado es: {0}", resultadoInt);

            //resultadoDouble = objetoOperacion.Suma(5.2, 3.4);

            //Console.WriteLine("El resultado es: {0}", resultadoDouble);

            //resultadoInt = objetoOperacion.Suma(4, 2, 9);

            //Console.WriteLine("El resultado es: {0}", resultadoInt);


            //Automovil bmw = new Automovil("BMW", "negro", 2);
            //Console.WriteLine("\nModelo: {0}, Color: {1}, Numero de puertas: {2}", bmw.modelo, bmw.color, bmw.numeroPuertas);

            //Automovil ford = new Automovil("Ford", "Negro");
            //Console.WriteLine("\nModelo: {0}, Color: {1}", ford.modelo, ford.color);

            //Automovil ferrari = new Automovil("Ford", "Rojo", 2, 23.5);
            //Console.WriteLine("\nModelo: {0}, Color: {1}, Numero de puertas: {2}, Velocidad: {3} Km/h", ferrari.modelo, ferrari.color, ferrari.numeroPuertas, ferrari.velocidad);


            //Celular samsung = new Celular(4.5, "negro", "Samsung", "Android 5.0", 5000, true);

            //samsung.Procesador = "Snapdragon 710";

            //samsung.MostarInformacion();


            //Console.WriteLine("\n");

            //Celular xiamoi = new Celular(5.2, "gris", "Xiaomi", "Android 6.1", 5500, true);

            //xiamoi.MostarInformacion();

            //Console.WriteLine("\n");
            //Celular.MostrarProcesador();


            Mutante wolverine = new Mutante(true, "Logan", "Wolverine", "Canadiense", "Elite");

            //wolverine.nombre = "Logan";
            //wolverine.alias = "Wolverine";

            Console.WriteLine("{0} tienen el Gen x? : {1} \nAlias:{2} \nNacionalidad: {3} \nClasificacion: {4}", wolverine.nombre, wolverine.genx, wolverine.alias, wolverine.nacionalidad, wolverine.clasificacion);

            //Husky husky = new Husky();

            //husky.nombre = "Max";
            //husky.oxigeno = true;

            //Console.WriteLine("{0} tiene un tipo de respiracion con oxigeno?: {1}", husky.nombre, husky.oxigeno);
            //husky.Aullar();


            //Pug pug = new Pug();

            //pug.nombre = "nono";
            //pug.oxigeno = true;

            //Console.WriteLine("{0} tiene un tipo de respiracion con oxigeno?: {1}", pug.nombre, pug.oxigeno);
            //pug.Ladrar();

        }
    }
}
