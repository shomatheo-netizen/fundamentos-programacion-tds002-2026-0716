using System.Globalization;

namespace _02_Variables;

class Program
{
    static void Main(string[] args)
    {
        const int ANIO_ACTUAL = 2026;

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine() ?? "");

        Console.Write("Estatura: ");
        string entradaEstatura = Console.ReadLine() ?? "";
        double estatura = double.Parse(entradaEstatura.Replace(',', '.'), CultureInfo.InvariantCulture);

        int anioNacimiento = ANIO_ACTUAL - edad;

        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad} años");
        Console.WriteLine($"Estatura: {estatura:0.00} m");
        Console.WriteLine($"Año de nacimiento estimado: {anioNacimiento}");
    }
}