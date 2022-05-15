using System;

namespace Biblioteca
{
    /* Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).
    Crear una clase llamada 'Calculadora' que posea dos métodos estáticos (de clase):

    - Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática.
    El método devolverá el resultado de la operación.

    - Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. 
    Este método devolverá true si el operando es distinto de cero.

    Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

    El usuario decidirá cuándo finalizar el programa. */
    public class Calculadora
    {
        public static int Calcular(int operandoUno, int operandoDos, char operacion)
        {
            switch(operacion)
            {
                case '+':
                    return operandoUno + operandoDos;
                case '-':
                    return operandoUno - operandoDos;
                case '*':
                    return operandoUno * operandoDos;
                case '/':
                    if(Calculadora.Validar(operandoDos)) // En caso de que el método Validar devuelva true, es porque el operando dos es distinto de 0.
                    {
                        return operandoUno / operandoDos;
                    }
                    else
                    {
                        Console.WriteLine("\nNo es posible dividir por 0. Ingrese otro número.\n");
                        return 0;
                    }
                default:
                    return 0;
            }
        }

        private static bool Validar(int operandoDos)
        {
            return operandoDos != 0;
        }
    }
}
