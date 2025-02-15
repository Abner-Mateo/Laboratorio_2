using System;

namespace OperacionesMatematicas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedir valores al usuario
            Console.Write("Introduce el primer número entero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo número entero: ");
            int numero2 = int.Parse(Console.ReadLine());

            // Operaciones aritméticas
            int suma = numero1 + numero2;
            int resta = numero1 - numero2;
            int multiplicacion = numero1 * numero2;
            int division = numero1 / numero2;

            // Mostrar resultados
            Console.WriteLine("\nResultados con int:");
            Console.WriteLine($"Suma: {numero1} + {numero2} = {suma}");
            Console.WriteLine($"Resta: {numero1} - {numero2} = {resta}");
            Console.WriteLine($"Multiplicación: {numero1} * {numero2} = {multiplicacion}");
            Console.WriteLine($"División: {numero1} / {numero2} = {division}");
        }
    }
}