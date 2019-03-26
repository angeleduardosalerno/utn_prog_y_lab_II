using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Alumno // SIEMPRE HAY QUE USAR LA PALABRA PUBLICA PARA PODER ACCEDERLAS!!
    {
        public byte nota1, nota2;  // // SIEMPRE HAY QUE USAR LA PALABRA PUBLICA PARA PODER ACCEDERLAS!! ARRIBA Y ABAJO!
        public float notaFinal;
        public string apellido, nombre;
        public int legajo;
        public static string colegio; // AL HACER ESTO CON LA PALABRA STATIC SE INDICA QUE TODOS LOS ALUMNOS COMPARTEN EL MISMO COLEGIO, LO STATIC QUE NO SE MODIFICA ES EL COLEGIO!

        // aca se declararia el constructor!
        // este es el constructor, guarda los datos de nombre y apellido pasados en el programa principal!

        public Alumno(string apellido, string nombre)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        //este es un constructor statico!

        static Alumno()
        {
            colegio = "UTN";

        }


        //LOS METODOS DEL EJERCICIO 16 SE ESCRIBEN ACA, POR QUE SON OPERACIONES A REALIZAR SOBRE ALUMNOS!,  SON LAS FUNCIONES!
        //SE PONEN ACA LOS METODOS PARA QUE SOLO SE VEAN DESDE ACA Y HALLA MAS SEGURIDAD!!


        /* VER COMO HACER ESTE METODO, HAY QUE HACER QUE DEVUELVA LO QUE PIDE 
        public string Mostrar()
        {   
            return legajo.ToString() + ......Y ACA SIGUEN LOS DEMAS CAMPOS VER!


        }
        */
    }
}
