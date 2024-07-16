namespace Calculadora_basica
{
    internal static class Calculadora
    {
        // Metodos

        /// <summary>
        /// Calcula la suma de dos enteros
        /// </summary>
        /// <param name="numero1">El primer entero</param>
        /// <param name="numero2">El segundo entero</param>
        /// <returns>La suma de los dos enteros</returns>
        public static int Sumar(int numero1, int numero2)
        {
            int sumarRetorno = numero1 + numero2;

            return sumarRetorno;
        }

        /// <summary>
        /// Resta dos números enteros
        /// </summary>
        /// <param name="numero1">El primer número entero</param>
        /// <param name="numero2">El segundo número entero</param>
        /// <returns>La resta de los dos números enteros</returns>
        public static int Restar(int numero1, int numero2)
        {
            int restaRetorno = numero1 - numero2;

            return restaRetorno;
        }

        /// <summary>
        /// Multiplica dos números enteros
        /// </summary>
        /// <param name="numero1">El primer número entero</param>
        /// <param name="numero2">El segundo número entero</param>
        /// <returns>La multiplicación de los dos números enteros</returns>
        public static int Multiplicar(int numero1, int numero2)
        {
            int multiplicarRetorno = numero1 * numero2;

            return multiplicarRetorno;
        }

        /// <summary>
        /// Divide dos números de punto flotante
        /// </summary>
        /// <param name="numero1">El primer número en punto flotante</param>
        /// <param name="numero2">El segundo número en punto flotante</param>
        /// <returns>La división de los dos números en punto flotante</returns>
        public static double Dividir(double numero1, double numero2)
        {
            double divisionRetorno = 0;

            if (numero2.Equals(0))
            {
                Console.WriteLine("No se puede dividir por 0");
            }
            else
            {
                try
                {
                    divisionRetorno = numero1 / numero2;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            return divisionRetorno;
        }
    }
}