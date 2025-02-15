using System;

namespace Declaracion_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar variables
            int numeroEntero;
            double numeroDecimal;
            string texto;
            bool valorBooleano;

            // Pedir valores por teclado
            Console.Write("Introduce un número entero: ");
            numeroEntero = int.Parse(Console.ReadLine());

            Console.Write("Introduce un número decimal: ");
            numeroDecimal = double.Parse(Console.ReadLine());

            Console.Write("Introduce un texto: ");
            texto = Console.ReadLine();

            Console.Write("Introduce un valor verdadero o falso (true/false): ");
            valorBooleano = bool.Parse(Console.ReadLine());

            // Mostrar los valores en consola
            Console.WriteLine("\nValores introducidos:");
            Console.WriteLine($"Número entero: {numeroEntero}");
            Console.WriteLine($"Número decimal: {numeroDecimal}");
            Console.WriteLine($"Texto: {texto}");
            Console.WriteLine($"Valor booleano: {valorBooleano}");
        }
    }
}
