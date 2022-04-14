using System;

namespace Ejercicio_I01

    /* Ejercicio I01 - Máximo, mínimo y promedio.
     
     Ingresar 5 números por consola, guardándolos en una variable escalar. 
     Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio. */

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numerosTotales = 5;

            string numeroIngresado; // El usuario ingresa un string.
            int numeroParseado; // El TryParse devolverá un entero.

            int minimo = int.MaxValue; // Así tiene el número entero más grande posible. Y la primera vez cuando compare, le asignará el de la primera iteración. 
            int maximo = int.MinValue;

            float acumulador = 0;
            float promedio;

            for (int i = 0; i < numerosTotales; i++)
            {
                Console.WriteLine("Ingrese un número:\n");
                numeroIngresado = Console.ReadLine();

                if(int.TryParse(numeroIngresado, out numeroParseado)) // Si TryParse devuelve TRUE...
                {
                    if (numeroParseado > maximo)
                    {
                        maximo = numeroParseado;
                    }

                    if (numeroParseado < minimo)
                    {
                        minimo = numeroParseado;
                    }

                    acumulador += numeroParseado; // Voy acumulando los números ingresados.
                }
                else // Si devuelve FALSE, es que no pudo convertir de string a entero.
                {
                    Console.WriteLine("\nERROR. Ingrese un número válido:\n");
                    i--;
                }
            }

            promedio = acumulador / numerosTotales;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Máximo: {0}", maximo);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Mínimo: {0}", minimo);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Promedio: {0}", promedio);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Suma total: {0}", acumulador);

            Console.ReadKey();
        }
    }
}
