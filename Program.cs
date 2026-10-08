using System;

namespace CalculadoraConMetodos
{
    class Program
    {
        // 1. Métodos de operaciones: reciben dos double y retornan el resultado
        static double Sumar(double a, double b)
        {
            return a + b;
        }

        static double Restar(double a, double b)
        {
            return a - b;
        }

        static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        // 3. Valida la división entre cero y muestra un mensaje de error
        static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("División: Error: no se puede dividir entre cero");
                return double.NaN; // indica que no hay resultado válido
            }

            return a / b;
        }

        // Reto extra: Potencia con Math.Pow(base, exponente)
        static double Potencia(double baseNum, double exponente)
        {
            return Math.Pow(baseNum, exponente);
        }

        // 2. Muestra el mensaje y retorna el número digitado
        static double LeerNumero(string mensaje)
        {
            double numero;
            Console.Write(mensaje);

            // Se repite hasta que el usuario escriba un número válido
            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Entrada inválida. " + mensaje);
            }

            return numero;
        }

        // 4. El Main solo llama a los métodos y muestra los resultados
        static void Main(string[] args)
        {
            Console.WriteLine("----- CALCULADORA -----");

            double num1 = LeerNumero("Ingrese el primer número: ");
            double num2 = LeerNumero("Ingrese el segundo número: ");

            Console.WriteLine("Suma: " + Sumar(num1, num2));
            Console.WriteLine("Resta: " + Restar(num1, num2));
            Console.WriteLine("Multiplicación: " + Multiplicar(num1, num2));

            double division = Dividir(num1, num2);
            if (!double.IsNaN(division))
            {
                Console.WriteLine("División: " + division);
            }

            // Reto extra
            Console.WriteLine("Potencia: " + Potencia(num1, num2));

            Console.ReadKey();
        }
    }
}
