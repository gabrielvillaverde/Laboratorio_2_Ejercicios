using System;

namespace Biblioteca
{
    public class Validador
    {
        /// <summary>
        /// Valida que el valor que recibe como primer argumento esté dentro del rango de los parámetros que recibe.
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static bool Validar(int valor, int min, int max)
        {
            return valor >= min && valor <= max; // De esta forma valido que 'valor' esté dentro del rango.
        }

        /* Versión extendida:
        public static bool Validar(int valor, int min, int max)
        {
            if (valor >= min && valor <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        */


    }
}
