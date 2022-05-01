using System;
using Biblioteca; // Agrego la referencia de mi biblioteca de clases.

namespace Ejercicio_I01_Validador
{
    /* Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

    bool Validar (int valor, int min, int max)

    - valor: dato a validar.
    - min: mínimo valor incluido.
    - max: máximo valor incluido.

    Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

    Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
    
    IMPORTANTE: Utilizar variables escalares. No utilizar vectores/arrays. */

    internal class Program
    {
        static void Main(string[] args)
        {
            int numerosTotales = 10;
            int numero;
            string numeroString;

            int max = int.MinValue;
            int min = int.MaxValue;

            int acumulador = 0;
            float promedio;
            
            for (int i = 0; i < numerosTotales; i++)
            {
                // Va a pedir un número mientras que el TryParse no devuelva una variable del tipo int.
                do
                {
                Console.WriteLine("Ingrese un número:");
                numeroString = Console.ReadLine(); // Leo el string que ingresa el usuario.
                }while(!int.TryParse(numeroString, out numero)); // Con TryParse paso de string a int.

                if(Validador.Validar(numero, -100, 100)) // Invoco a mi método junto con sus parámetros. Si mi método Validar devuelve true, entra al cuerpo del if.    
                {
                    if (numero > max)
                    {
                        max = numero;
                    }
                    if (numero < min)
                    {
                        min = numero;
                    }
                    acumulador = acumulador + numero;
                }
            }
            promedio = acumulador / numerosTotales;
            Console.WriteLine($"El número máximo es: {max}, el número mínimo es {min} y el promedio es {promedio}");
        }
    }
  

}
