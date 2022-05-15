using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Inputs
    {
        public static bool GetNumber(string message, string msgError, int min, int max, out int number)
        {
            int numberAux;
            Console.WriteLine(message);
            if (int.TryParse(Console.ReadLine(), out numberAux) && Validador.Validar(numberAux, min, max))
            {
                number = numberAux;
                return true;
            }
            else
            {
                Console.WriteLine(msgError);
            }
            number = 0;
            return false;
        }
    }
}
