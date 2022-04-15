using System;



namespace Ejercicio_I05
{
    /* Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, 
    cuyas sumas son iguales. 

    El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) 
    cuyas sumas son ambas iguales a 15.

    El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
   
    Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola. */

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I05 - Tirame un centro";

            bool flag;

            do
            {
                Console.WriteLine("Ingrese un número:\n");
                if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0)
                {
                    flag = false;
                    // Recorro desde el 1 hasta el número que ingresa el usuario.
                    for (int centro = 1; centro < numero; centro++)
                    {
                        // Sumo los números inferiores al centro
                        int sumaAntes = 0;

                        for (int i = 0; i < centro; i++)
                        {
                            sumaAntes = sumaAntes + i;
                        }

                        // Sumo los números superiores al centro
                        int sumaDespues = 0;

                        for (int j = centro + 1; j <= sumaAntes; j++)
                        {
                            if ((sumaAntes == sumaDespues) || (sumaDespues > sumaAntes))
                                break;

                            sumaDespues = sumaDespues + j;
                        }

                        // Muestro en pantalla

                        if (sumaAntes == sumaDespues)
                        {
                            Console.WriteLine("{0} es un centro numérico", centro);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nNo es un número correcto o mayor que 0.");
                    flag = true;
                }
            } while (flag);
        }
    }
}
