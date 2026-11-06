using System.Globalization;

namespace _06_Decisiones;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("nota entera entre 0 y 100: ");

        if (!int.TryParse(Console.ReadLine(), out int nota) || nota < 0 || nota > 100)
        {
            Console.WriteLine("Debe ser un entero entre 0 y 100.");
        }
        else if (nota >= 90)
        {
            Console.WriteLine("Calificación: A");
        }
        else if (nota >= 80)
        {
            Console.WriteLine("Calificación: B");
        }
        else if (nota >= 70)
        {
            Console.WriteLine("Calificación: C");
        }
        else
        {
            Console.WriteLine("Calificación: F");
        }

        // Parte 2. Calculadora
        Console.WriteLine();
        Console.WriteLine("Calculadora");

        Console.Write("Primer número: ");
        string? entradaPrimero = Console.ReadLine()?.Replace(',', '.');

        Console.Write("Segundo número: ");
        string? entradaSegundo = Console.ReadLine()?.Replace(',', '.');

        bool primeroValido = double.TryParse(
            entradaPrimero, NumberStyles.Float, CultureInfo.InvariantCulture, out double primero);
        bool segundoValido = double.TryParse(
            entradaSegundo, NumberStyles.Float, CultureInfo.InvariantCulture, out double segundo);

        if (!primeroValido || !segundoValido)
        {
            Console.WriteLine("Escribe dos números válidos.");
            return;
        }

        Console.Write("Opción (1 sumar, 2 restar, 3 multiplicar, 4 dividir): ");
        string? opcion = Console.ReadLine()?.Trim();

        switch (opcion)
        {
            case "1":
                Console.WriteLine($"Resultado: {primero + segundo}");
                break;
            case "2":
                Console.WriteLine($"Resultado: {primero - segundo}");
                break;
            case "3":
                Console.WriteLine($"Resultado: {primero * segundo}");
                break;
            case "4":
                if (segundo == 0)
                {
                    Console.WriteLine("No se puede dividir entre cero.");
                }
                else
                {
                    Console.WriteLine($"Resultado: {primero / segundo}");
                }
                break;
            default:
                Console.WriteLine("Elige un número del 1 al 4.");
                break;
        }
    }
}
