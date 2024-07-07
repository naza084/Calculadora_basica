namespace Calculadora_basica
{
    internal class Calculadora
    {
        public Calculadora() 
        {
            
        }

        // Metodos
        public static int Sumar(int numero1, int numero2)
        {
            int sumarRetorno = numero1 + numero2;

            return sumarRetorno;
        }

        public static int Restar(int numero1, int numero2)
        {
            int restaRetorno = numero1 - numero2;

            return restaRetorno;
        }

        public static int Multiplicar(int numero1, int numero2)
        {
            int multiplicarRetorno = numero1 * numero2;

            return multiplicarRetorno;
        }

        public static double Dividir(double numero1, double numero2)
        {
            double divisionRetorno = numero1 / numero2;

            return divisionRetorno;
        }
        // TODO: hacer los demas metodos, luego agregar validaciones y hacer un obtenerOpcionValida en main
    }
}
