using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        ConsoleColor color;
        short tinta;


        // OJO, NO SE PUEDEN PONER METODOS AFUERA DE LOS CORCHETES DE CLASE!!

        //ACA VA EL CONSTRUCTOR, ES UN CONSTRUCTOR POR QUE SE LLAMA IGUAL QUE LA CLASE!

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color=color;
            this.tinta=tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;

        }

        public short GetTinta()
        {
            return this.tinta;

        }

        private void SetTinta(short ingresoTinta) // PRIVATE ES LO OPUESTO DE PUBLIC, NO ESTA RELACIONADO CON STATIC, VER LA DIFERENCIA!
        {
            if ((ingresoTinta >= 0) && (ingresoTinta <= cantidadTintaMaxima))
            {
                this.tinta = ingresoTinta;
            }
            else
            {
                Console.WriteLine("EL INGRESO DE TINTA NO ES EL CORRECTO");
            }

        }

        private void recargar()
        {
            this.tinta=cantidadTintaMaxima;
        }


        /*
        private bool pintar( int gasto, out string dibujo)
        {
            


        }
        */

    }

    
}
