using System.Globalization;

namespace ConversorMoneda;

class Program
{
    static void Main(string[] args)
    {
        // Tasa de venta del Banco Central, cierre del 5 de noviembre de 2026.
        const double TASA_USD = 60.9038;

        Console.Write("Monto en pesos dominicanos: ");
        string entrada = Console.ReadLine() ?? "";
        double montoPesos = double.Parse(entrada.Replace(',', '.'), CultureInfo.InvariantCulture);

        double montoDolares = montoPesos / TASA_USD;

        Console.WriteLine($"RD${montoPesos:F2} equivalen a US${montoDolares:F2}.");
    }
}
