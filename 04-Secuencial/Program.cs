using System.Globalization;

namespace _04_Secuencial;

class Program
{
    static void Main(string[] args)
    {
        const double KG_POR_LIBRA = 0.453592;

        // Entrada
        Console.Write("Peso en libras: ");
        string entradaPeso = Console.ReadLine() ?? "";
        double libras = double.Parse(entradaPeso.Replace(',', '.'), CultureInfo.InvariantCulture);

        Console.Write("Temperatura en °F: ");
        string entradaTemperatura = Console.ReadLine() ?? "";
        double fahrenheit = double.Parse(entradaTemperatura.Replace(',', '.'), CultureInfo.InvariantCulture);

        // Proceso
        double kilogramos = libras * KG_POR_LIBRA;
        double celsius = (fahrenheit - 32) * 5 / 9;

        // Salida
        Console.WriteLine($"{libras} lb equivalen a {kilogramos:F2} kg.");
        Console.WriteLine($"{fahrenheit} °F equivalen a {celsius:F2} °C.");
    }
}
