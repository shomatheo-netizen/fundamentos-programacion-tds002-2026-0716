using System.Globalization;

namespace Geometria;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Radio: ");
        string entradaRadio = Console.ReadLine() ?? "";
        double radio = double.Parse(entradaRadio.Replace(',', '.'), CultureInfo.InvariantCulture);

        Console.Write("Primer cateto: ");
        string entradaCateto1 = Console.ReadLine() ?? "";
        double cateto1 = double.Parse(entradaCateto1.Replace(',', '.'), CultureInfo.InvariantCulture);

        Console.Write("Segundo cateto: ");
        string entradaCateto2 = Console.ReadLine() ?? "";
        double cateto2 = double.Parse(entradaCateto2.Replace(',', '.'), CultureInfo.InvariantCulture);

        double area = Math.PI * Math.Pow(radio, 2);
        double circunferencia = 2 * Math.PI * radio;
        double hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

        Console.WriteLine($"area del circulo: {area:F2}");
        Console.WriteLine($"Circunferencia: {circunferencia:F2}");
        Console.WriteLine($"Hipotenusa: {hipotenusa:F2}");
    }
}