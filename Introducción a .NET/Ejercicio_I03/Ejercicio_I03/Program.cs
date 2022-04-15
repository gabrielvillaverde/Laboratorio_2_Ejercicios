using System;

namespace Ejercicio_I03

    /* Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
    Validar que el dato ingresado por el usuario sea un número.
    Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
    Si ingresa "Salir", cerrar la consola.
    Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola. */

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            bool flag;

            do
            {
                Console.WriteLine("Ingrese un número:\n");
                string lectura = Console.ReadLine();

                if ((Int32.TryParse(lectura, out numeroIngresado) && numeroIngresado >= 2) || lectura == "Salir")
                {
                    Console.WriteLine("\nLos siguientes números son primos:\n");
                    flag = false; // Levanto la bandera ya que la línea 24 pudo convertir un string a integer y sale del bucle.

                    for (int i = 2; i < numeroIngresado; i++)
                    {
                        int cantDivisores = 0;

                        for (int k = 1; k <= i; k++)
                        {
                            if(i % k == 0) // Si tiene un divisor con resto 0...
                            {
                                cantDivisores++;
                            }
                        }

                        if(cantDivisores < 3)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nERROR. Ingrese un número válido o igual/mayor que 2:\n");
                    flag = true; // Sino, la bandera sigue siendo TRUE.
                }
            } while (flag == true);
        }
    }
}
