using System;

namespace CalculadoraConMetodos
{
    class Program
    {
        
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

        
        static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("División: Error: no se puede dividir entre cero");
                return double.NaN; 
            }

            return a / b;
        }

       
        static double Potencia(double baseNum, double exponente)
        {
            return Math.Pow(baseNum, exponente);
        }

       
        static double LeerNumero(string mensaje)
        {
            double numero;
            Console.Write(mensaje);

           
            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Entrada inválida. " + mensaje);
            }

            return numero;
        }

        
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
