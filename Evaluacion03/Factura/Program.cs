using System.Globalization;

namespace Factura;

class Program
{
    static void Main(string[] args)
    {
        const decimal TASA_ITBIS = 0.18m;

        Console.Write("Producto: ");
        string producto = Console.ReadLine() ?? "";

        Console.Write("Cantidad: ");
        int cantidad = int.Parse(Console.ReadLine() ?? "");

        Console.Write("Precio por unidad: ");
        string entradaPrecio = Console.ReadLine() ?? "";
        decimal precio = decimal.Parse(entradaPrecio.Replace(',', '.'), CultureInfo.InvariantCulture);

        decimal subtotal = cantidad * precio;
        decimal itbis = subtotal * TASA_ITBIS;
        decimal total = subtotal + itbis;

        Console.WriteLine($"{"Concepto",-18}{"Detalle",16}");
        Console.WriteLine($"{"Producto",-18}{producto,16}");
        Console.WriteLine($"{"Cantidad",-18}{cantidad,16}");
        Console.WriteLine($"{"Precio unitario",-18}{precio,16:N2}");
        Console.WriteLine($"{"Subtotal",-18}{subtotal,16:N2}");
        Console.WriteLine($"{"ITBIS",-18}{itbis,16:N2}");
        Console.WriteLine($"{"Total",-18}{total,16:N2}");
    }
}