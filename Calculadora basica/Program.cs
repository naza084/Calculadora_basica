using System.Dynamic;

namespace Calculadora_basica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Variables
            List<string> listaOperaciones = new() { "suma", "resta", "multiplicación", "división" };
            bool continuarPrograma = true;
            int numero1, numero2;
            double resultado;
            string operacion;

            // Programa principal
            while (continuarPrograma)
            {
                numero1 = PedirEnteroValido("Ingrese el primer número: ", 0, int.MaxValue);
                numero2 = PedirEnteroValido("Ingrese el segundo número: ", 0, int.MaxValue);

                operacion = PedirOperacionValida("Seleccione la operación (suma, resta, multiplicación, división): ", listaOperaciones);

                resultado = EjecutarOperacion(numero1, numero2, operacion);

                Console.WriteLine($"El resultado es de la {operacion} es: {resultado}");

                continuarPrograma = PreguntarContinuar("¿Desea realizar otra operación? (s/n): ", "s", "n");
            }


            Console.Clear();
            Console.WriteLine("Gracias por usar la calculadora!");
            Console.ReadKey();
        }


        /// <summary>
        /// Pregunta al usuario si desea continuar basado en opciones alfanuméricas válidas.
        /// </summary>
        /// <param name="mensaje">El mensaje a mostrar al usuario.</param>
        /// <param name="opcionVerdadera">La opción que indica que el usuario desea continuar.</param>
        /// <param name="opcionFalsa">La opción que indica que el usuario no desea continuar.</param>
        /// <returns>True si el usuario desea continuar, false en caso contrario.</returns>
        public static bool PreguntarContinuar(string mensaje, string opcionVerdadera, string opcionFalsa)
        {
            bool continuar = false;
            bool opcionValida = false;
            string? entradaValor;

            do
            {
                Console.Write(mensaje);
                entradaValor = Console.ReadLine();

                // Verifica que la entrada no sea nula, vacía o solo espacios, y sea alfanumérica
                if (entradaValor is string opcionIngresada && !string.IsNullOrEmpty(opcionIngresada) && EsAlfanumerico(opcionIngresada))
                {
                    // Comparación insensible a mayusculas y minusculas
                    if (opcionIngresada.Equals(opcionVerdadera, StringComparison.OrdinalIgnoreCase))
                    {
                        continuar = true;
                        opcionValida = true;
                    }
                    else if (opcionIngresada.Equals(opcionFalsa, StringComparison.OrdinalIgnoreCase))
                    {
                        continuar = false;
                        opcionValida = true;
                    }
                }

                
            } while (!opcionValida);


            return continuar;
        }

        /// <summary>
        /// Ejecuta la operación basandose en los números dados.
        /// </summary>
        /// <param name="numero1">El primer número.</param>
        /// <param name="numero2">El segundo número.</param>
        /// <param name="operacion">La operación a realizar (suma, resta, multiplicación, división).</param>
        /// <returns>El resultado de la operación.</returns>
        public static double EjecutarOperacion(int numero1, int numero2, string operacion)
        {
            double resultado = 0.0;

            resultado = operacion switch
            {
                "suma" => Calculadora.Sumar(numero1, numero2),
                "resta" => Calculadora.Restar(numero1, numero2),
                "multiplicación" => Calculadora.Multiplicar(numero1, numero2),
                "división" => Calculadora.Dividir(numero1, numero2),
                _ => resultado
            };

            return resultado;
        }

        /// <summary>
        /// Obtener el numero valido entero.
        /// </summary>
        /// <param name="mensaje">el mensaje a mostrar al usuario.</param>
        /// <param name="valorMin">el entradaValor minimo.</param>
        /// <param name="valorMax">el entradaValor maximo.</param>
        /// <returns> Devuelve el valor valido. </returns>
        public static string PedirOperacionValida(string mensaje, List<string> operacionesValidas)
        {
            string? operacionIngresada;
            bool esValido;

            do
            {
                Console.Write(mensaje);
                operacionIngresada = Console.ReadLine();

                // Verifica la operación
                esValido = ValidarOperacion(operacionIngresada, operacionesValidas);
                if (!esValido)
                {
                    Console.WriteLine("Por favor, ingrese una operación valida");
                    operacionIngresada = string.Empty;
                }
            } while (!esValido);

            return operacionIngresada;
        }

        /// <summary>
        /// Obtener el numero valido entero.
        /// </summary>
        /// <param name="mensaje">el mensaje a mostrar al usuario.</param>
        /// <param name="valorMin">el entradaValor minimo.</param>
        /// <param name="valorMax">el entradaValor maximo.</param>
        /// <returns> Devuelve el valor valido. </returns>
        public static int PedirEnteroValido(string mensaje, int valorMin, int valorMax)
        {
            int numero;
            string? entrada;
            bool esValido;

            do
            {
                Console.Write(mensaje);
                entrada = Console.ReadLine();
                esValido = ValidarEntero(entrada, out numero, valorMin, valorMax);
                if (!esValido)
                {
                    Console.WriteLine($"Por favor, ingrese un número entero entre {valorMin} y {valorMax}.");
                }
            } while (!esValido);

            return numero;
        }



        /// <summary>
        /// Valida la entradaValor como un entero dentro del rango especificado.
        /// </summary>
        /// <param name="entrada">La cadena de entradaValor a validar.</param>
        /// <param name="resultado">El resultado entero analizado si tiene éxito.</param>
        /// <param name="valorMin">El entradaValor mínimo permitido.</param>
        /// <param name="valorMax">El entradaValor máximo permitido.</param>
        /// <returns> True si la entradaValor es un entero válido dentro del rango especificado, false de lo contrario.</returns>
        public static bool ValidarEntero(string entrada, out int resultado, int valorMin, int valorMax)
        {
            bool esValido = false;

            if (EsEntero(entrada, out resultado) && ValidarRango(resultado, valorMin, valorMax))
            {
                esValido = true;
            }

            return esValido;
        }

        /// <summary>
        /// Valida si la operación de entradaValor es válida verificando si existe en la lista de operaciones válidas.
        /// </summary>
        /// <param name="entrada">La operación a validar.</param>
        /// <param name="operacionesValidas">La lista de operaciones válidas.</param>
        /// <returns>Verdadero si la operación es válida; de lo contrario, falso.</returns>
        public static bool ValidarOperacion(string entrada, List<string> operacionesValidas)
        {
            bool esValido = false;
            entrada = entrada.ToLower();

            if (!string.IsNullOrEmpty(entrada) && operacionesValidas != null && operacionesValidas.Count > 0 && operacionesValidas.Contains(entrada))
            {
                esValido = true;
            }

            return esValido;
        }


        /// <summary>
        /// Valida si la entrada es un número entero.
        /// </summary>
        /// <param name="entrada">La cadena de entrada.</param>
        /// <param name="resultado">El resultado de la validación.</param>
        /// <returns> True si la entrada es un número entero; de lo contrario, false.</returns>
        public static bool EsEntero(string entrada, out int resultado)
        {
            bool enteroValido = int.TryParse(entrada, out resultado);

            return enteroValido;
        }


        /// <summary>
        /// Valida si la entrada es un número alfanumerico.
        /// </summary>
        /// <param name="entrada">La cadena de entrada.</param>
        /// <returns>True si la entrada es un número alfanumerico; de lo contrario, false.</returns>
        public static bool EsAlfanumerico(string cadena)
        {
            bool esAlfanumerico = true;

            foreach (char caracter in cadena)
            {
                if (!char.IsLetterOrDigit(caracter))
                {
                    esAlfanumerico = false;
                    break;
                }
            }

            return esAlfanumerico;
        }

        /// <summary>
        /// Valida si un entradaValor se encuentra dentro de un rango específico.
        /// </summary>
        /// <param name="entrada">El entradaValor a validar.</param>
        /// <param name="valorMin">El entradaValor mínimo del rango.</param>
        /// <param name="valorMax">El entradaValor máximo del rango.</param>
        /// <returns>True si el entradaValor está dentro del rango especificado; de lo contrario, false.</returns>
        public static bool ValidarRango(double entrada, double valorMin, double valorMax)
        {
            bool rangoValido;

            if (entrada >= valorMin && entrada <= valorMax)
            {
                rangoValido = true;
            }
            else
            {
                rangoValido = false;
            }

            return rangoValido;
        }

    }
}
