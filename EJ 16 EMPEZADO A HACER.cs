using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("angel","eduardo"); // SE LE ASIGNA MEMORIA DINAMICA AL OBJETO ALUMNO!
            Alumno alumno2 = new Alumno("ale", "eduardo");
            Alumno alumno3 = new Alumno("fer", "eduardo");
            Alumno.colegio = "UTN";




            // VER EN GIT VA A SUBIR EL EJEMPLO DE LA CLASE 2 !

            /*alumno1.apellido = "Perez";
            Console.WriteLine(alumno1.apellido);*/

            // ACA SE LLAMA A LAS FUNCIONES MOSTRAR, ESTUDIAR Y CALCULAR FINAL!
            //mostrar seria -----> Console.WriteLine(alumno1.mostrar); se ingresa al mostrar del alumno 1 !

        }
    }
}
