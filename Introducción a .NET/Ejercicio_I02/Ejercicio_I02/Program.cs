using System;

namespace Ejercicio_I02

    /* Ejercicio I02 - Error al cubo
      
    Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
    Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
    
    IMPORTANTE: Utilizar el método "Math.Pow" para calcular las potencias. */

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroParseado;
            double calculoCuadrado;
            double calculoCubo;
            bool flag; // Devolverá TRUE o FALSE.

            do
            {
                Console.WriteLine("Ingrese un número:\n");
                string numeroIngresado = Console.ReadLine();


                if (Int32.TryParse(numeroIngresado, out numeroParseado) && numeroParseado > 0)
                {
                    calculoCuadrado = Math.Pow(numeroParseado, 2);
                    calculoCubo = Math.Pow(numeroParseado, 3);
                    Console.WriteLine("\nEl número {0} elevado al cuadrado es: {1}", numeroParseado, calculoCuadrado);
                    Console.WriteLine("\nEl número {0} elevado al cubo es: {1}", numeroParseado, calculoCubo);
                    flag = false; // Pongo la flag en FALSE para que se rompa el bucle.
                }
                else
                {
                    Console.WriteLine("\nERROR. Ingrese un número correcto o mayor a 0.");
                    flag = true; // Si sigue tirando error, la flag será TRUE y continúa el bucle.
                }
                
            } while (flag);

            Console.ReadKey();
        }
    }
}
