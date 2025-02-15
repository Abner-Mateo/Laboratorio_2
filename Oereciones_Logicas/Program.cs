using System;

namespace Oeraciones_Logicas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedir dos valores numéricos al usuario
            Console.Write("Introduce el primer número: ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());

            // Comparaciones
            bool esMayor = numero1 > numero2;
            bool esMenor = numero1 < numero2;
            bool esIgual = numero1 == numero2;

            // Uso de AND (&&) y OR (||)
            bool ambosPositivos = numero1 > 0 && numero2 > 0;
            bool algunoPositivo = numero1 > 0 || numero2 > 0;

            // Mostrar resultados en consola
            Console.WriteLine("\nResultados de las comparaciones:");
            Console.WriteLine($"{numero1} es mayor que {numero2}: {esMayor}");
            Console.WriteLine($"{numero1} es menor que {numero2}: {esMenor}");
            Console.WriteLine($"{numero1} es igual a {numero2}: {esIgual}");

            Console.WriteLine("\nResultados de las expresiones lógicas:");
            Console.WriteLine($"Ambos números son positivos: {ambosPositivos}");
            Console.WriteLine($"Alguno de los números es positivo: {algunoPositivo}");
        }
    }
}