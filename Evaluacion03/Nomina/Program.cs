using System.Globalization;

namespace Nomina;

class Program
{
    static void Main(string[] args)
    {
        const decimal TASA_AFP = 0.0287m;
        const decimal TASA_SFS = 0.0304m;

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Horas trabajadas: ");
        string entradaHoras = Console.ReadLine() ?? "";
        decimal horas = decimal.Parse(entradaHoras.Replace(',', '.'), CultureInfo.InvariantCulture);

        Console.Write("Pago por hora: ");
        string entradaPago = Console.ReadLine() ?? "";
        decimal pagoPorHora = decimal.Parse(entradaPago.Replace(',', '.'), CultureInfo.InvariantCulture);

        decimal bruto = horas * pagoPorHora;
        decimal afp = bruto * TASA_AFP;
        decimal sfs = bruto * TASA_SFS;
        decimal neto = bruto - afp - sfs;

        Console.WriteLine($"Empleado: {nombre.ToUpperInvariant()}");
        Console.WriteLine($"Salario bruto: {bruto:N2}");
        Console.WriteLine($"Descuento AFP: {afp:N2}");
        Console.WriteLine($"Descuento SFS: {sfs:N2}");
        Console.WriteLine($"Salario neto: {neto:N2}");
    }
}