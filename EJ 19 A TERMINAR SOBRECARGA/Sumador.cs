using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Sumador
    {
        int cantidadSumas;

        //crear dos constructores!


        public Sumador(int numero) // ESTE ES UN SUMADOR EN EL QUE INGRESAN LOS DATOS EL USUARIO, EL DE ABAJO ES SIMILAR PERO INICIALIZA EN 0
        {
            this.cantidadSumas = numero;

        }

        public Sumador() : this(0) // ASI SE HACE PARA EVITAR EL TEXTO DE ABAJO!! ESTO ES UNA SOBRECARGA DE CONSTRUCTOR..
        { /*
            Sumador(0); // para evitar la linea de abajo se llama al sumador anterior!
            
            //this.cantidadSumas = 0; //PARA AHORRARTE PONER SUMADOR, SE ABREVIA PONIENDO EL THIS PARA QUE SEA MAS SIMPLE!
        */
        } // LLEVA LAS LLAVES SI O SI!!


        public long Sumar(long numero, long numero2)
        {
            this.cantidadSumas++; // ASE LE AGRWEGA UNO A LA CANTIDAD DE SUMAS!
            return numero + numero2; // DEVUELVE EL RESULTADO DE LA SUMA!

        }

        public String Sumar(string palabra, string palabra2)
        {
            return palabra + palabra2; // DESPUES SE LLAMA EN EL MAIN!
  
        }


    }
}
