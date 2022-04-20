using System;

namespace Ejercicio_I06

    /* Escribir un programa que determine si un año es bisiesto.

    Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. 
    Por ejemplo: el año 2000 es bisiesto pero 1900 no.

    Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango. */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el año de inicio:\n");
            string añoInicioString = Console.ReadLine();

            Console.WriteLine("Ingrese el año de fin:\n");
            string añoFinalString = Console.ReadLine();

            Int32.TryParse(añoInicioString, out int añoInicio);
            Int32.TryParse(añoFinalString, out int añoFinal);

            for (int i = añoInicio; i <= añoFinal; i++)
            {
                // Si el año no es múltiplo de 4, 100 y 400
                if (i % 4 == 0)
                {
                    if (i % 100 == 0)
                    {
                        if (i % 400 == 0)
                        {
                            Console.WriteLine("{0} no es un año bisiesto:\n", i);
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0} es un año bisiesto:\n", i);
                    }
                }
            }

        }
    }
}
