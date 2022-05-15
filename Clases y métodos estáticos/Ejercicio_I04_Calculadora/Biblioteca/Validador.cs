using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Validador
    {
        public static bool Validar(int value, int min, int max)
        {
            if (value >= min && value <= max)
            {
                return true;
            }
            return false; //return valor > min && valor < max;
        }

        public static bool ValidarRespuesta(string response)
        {
            if (response == "Yes" || response == "Y" || response == "Si" || response == "S")
            {
                return true;
            }
            return false; //return respuesta == "s" || respuesta == "S";
        }
    }
}
