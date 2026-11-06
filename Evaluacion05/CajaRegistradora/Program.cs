using System.Globalization;

namespace CajaRegistradora;

class Program
{
    static void Main(string[] args)
    {
        const decimal TASA_ITBIS = 0.18m;

        const decimal LIMITE_SUBTOTAL = decimal.MaxValue / 2m;

        int productos = 0;
        decimal subtotal = 0m;
        decimal precio;
        bool precioValido;

        do
        {
            Console.Write("Precio del producto: ");
            string? entrada = Console.ReadLine();
            if (entrada == null)
            {
                return;
            }

            precioValido = decimal.TryParse(entrada.Replace(',', '.'),
                NumberStyles.Float, CultureInfo.InvariantCulture, out precio)
                && precio >= 0m && precio <= LIMITE_SUBTOTAL - subtotal;

            if (!precioValido)
            {
                Console.WriteLine("Escribe un precio mayor o igual a cero.");
            }
            else if (precio > 0m)
            {
                productos++;
                subtotal += precio;
            }
        } while (!precioValido || precio != 0m);

        decimal itbis = subtotal * TASA_ITBIS;
        decimal total = subtotal + itbis;

        Console.WriteLine($"Productos: {productos}");
        Console.WriteLine($"Subtotal: RD${subtotal:N2}");
        Console.WriteLine($"ITBIS: RD${itbis:N2}");
        Console.WriteLine($"Total: RD${total:N2}");
    }
}