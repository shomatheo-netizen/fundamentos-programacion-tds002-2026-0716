using System.Globalization;

namespace Casting;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Escribe un numero con decimales: ");
        string entrada = Console.ReadLine() ?? "";
        double numeroDecimal = double.Parse(entrada.Replace(',', '.'), CultureInfo.InvariantCulture);

        // El casting explícito descarta la parte decimal.
        int parteEntera = (int)numeroDecimal;

        // La asignación de int a double hace la conversión implícita.
        double numeroComoDouble = parteEntera;

        Console.WriteLine($"Numero original: {numeroDecimal}");
        Console.WriteLine($"Parte entera: {parteEntera}");
        Console.WriteLine($"Entero convertido a double: {numeroComoDouble:F1}");
    }
}
