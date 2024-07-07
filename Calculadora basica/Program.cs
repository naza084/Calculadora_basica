namespace Calculadora_basica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Ejercicio: Calculadora Básica con POO

            Objetivo:
            Crear una calculadora básica utilizando los principios de la Programación Orientada a Objetos (POO) en C#. 
            La calculadora debe ser capaz de realizar las cuatro operaciones aritméticas fundamentales: 
            suma, resta, multiplicación y división.


            Consideraciones adicionales:
            - Validar la entrada del usuario para asegurarse de que ingresa números válidos.
            - Manejar posibles excepciones que puedan ocurrir durante la ejecución de las operaciones aritméticas, 
              especialmente la división por cero.
            - Escribir comentarios adecuados en el código para mejorar la legibilidad y el mantenimiento.

            Ejemplo de ejecución:
            -------------------------
            Ingrese el primer número: 10
            Ingrese el segundo número: 5
            Seleccione la operación (suma, resta, multiplicación, división): suma
            Resultado: 15
            ¿Desea realizar otra operación? (s/n): s
            Ingrese el primer número: 20
            Ingrese el segundo número: 4
            Seleccione la operación (suma, resta, multiplicación, división): división
            Resultado: 5
            ¿Desea realizar otra operación? (s/n): n
            -------------------------
            ¡Gracias por usar la calculadora!
            */

            Calculadora calculadora = new();



            Console.ReadKey();
        }
    }
}
