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
      int cuadrado = 2;
      int cubo = 3;
      int primerNumero;


      do
      {
        Console.WriteLine("Ingrese el número a elevar al 2 y 3");
        int.TryParse(Console.ReadLine(), out primerNumero);
        Console.ReadKey(); // es similar a system pause

        if (primerNumero > 0)
        {
          Console.WriteLine("EL RESULTADO DEL NUMERO AL 2 ES: ");
          Console.WriteLine((long)Math.Pow(primerNumero, cuadrado)); // ACA SE ELEVA AL 2 USANDO MATH.POW
          Console.ReadKey(); // es similar a system pause

          Console.WriteLine("EL RESULTADO DEL NUMERO AL 3 ES: ");
          Console.WriteLine((long)Math.Pow(primerNumero, cubo)); // ACA SE ELEVA AL 3 USANDO MATH.POW
          Console.ReadKey(); // es similar a system pause

        }
        else
        {
          Console.WriteLine("ERROR. ¡Reingresar número!");
          Console.ReadKey(); // es similar a system pause OJOOO SIN EL PAUSE NO SE VE, POR QUE EL PROGRAMA NO PIENSA EN QUE TE LO TIENE QUE MOSTRAR, PASA ESTA LINEA Y SE VA DEL PROGRAMA!
                             // LO QUE SE PUEDE HACER ES PONER UN  Console.ReadKey(); AL FINAL Y LISTO!

        }
      } while (primerNumero <= 0);


    }
  }
}
    
    

