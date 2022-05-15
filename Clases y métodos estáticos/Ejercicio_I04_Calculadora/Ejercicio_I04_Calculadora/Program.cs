using System;
using Biblioteca;

namespace Ejercicio_I04_Calculadora

{
    /* Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).
    Crear una clase llamada 'Calculadora' que posea dos métodos estáticos (de clase):

    - Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática.
    El método devolverá el resultado de la operación.

    - Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. 
    Este método devolverá true si el operando es distinto de cero.

    Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

    El usuario decidirá cuándo finalizar el programa. */
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;

            char operation;

            int result;

            do
            {
                if (Inputs.GetNumber("\nEnter the first number:", "Error. Please type a valid number\n", int.MinValue, int.MaxValue, out firstNumber) 
                 && Inputs.GetNumber("\nEnter the second number", "Error. Please type a valid number\n", int.MinValue, int.MaxValue, out secondNumber))
                {
                    Console.WriteLine("\nChoose the operation you want to execute: Addition: + | Substraction: - | Division: / | Multiplication: *\n");
                    operation = Console.ReadKey().KeyChar; // Para leer el char.
                    result = Calculadora.Calcular(firstNumber, secondNumber, operation);
                    Console.WriteLine($"\nThe result of the operation is: {result}\n");
                }
                else
                {
                    Console.WriteLine("\nTo stay in the program you have to keep trying.\n");
                }
                Console.WriteLine("\nDo you wish to continue?: Yes/No\n");
            }while(Validador.ValidarRespuesta(Console.ReadLine()));
        }
    }
}
