using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto
{
    class Program
    {
    
        static void Main(string[] args)
        {

            int primerNumero, segundoNumero, tercerNumero, cuartoNumero, quintoNumero;

           
            Console.WriteLine("Ingrese el primer número");
            int.TryParse(Console.ReadLine(), out primerNumero);
            Console.WriteLine("Ingrese el segundo número");
            int.TryParse(Console.ReadLine(), out segundoNumero);
            Console.WriteLine("Ingrese el tercer número");
            int.TryParse(Console.ReadLine(), out tercerNumero);
            Console.WriteLine("Ingrese el cuarto número");
            int.TryParse(Console.ReadLine(), out cuartoNumero);
            Console.WriteLine("Ingrese el quinto número");
            int.TryParse(Console.ReadLine(), out quintoNumero);
           

            Console.ReadKey(); // es similar a system pause

            Console.WriteLine("EL PROMEDIO ES: ");
            Console.WriteLine((primerNumero + segundoNumero + tercerNumero + cuartoNumero + quintoNumero) / 5);

            Console.ReadKey(); // es similar a system pause
        }
        

        

    }
}