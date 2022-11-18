using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO73
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;

            Queue colastring = new Queue();

            Console.WriteLine("Ingrese la cadena para agregar a la cola:");

            cadena = Console.ReadLine();

            while (cadena != "salir")
            {
                colastring.Enqueue(cadena);
                Console.WriteLine("Ingrese próxima cadena, ingrese ´salir´ para salir:");
                cadena = Console.ReadLine();

            }

            if (cadena == "salir")
            {
                Console.WriteLine("La cola ingresada es:");
            }

            while (colastring.Count > 0)
            {

                string cad = (string)colastring.Dequeue();

                Console.WriteLine(cad);

            }

            Console.ReadKey();
        }
    }
}