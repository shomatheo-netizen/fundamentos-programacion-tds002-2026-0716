namespace PromedioValidado;

class Program
{
    static void Main(string[] args)
    {
        int cantidad = 0;
        long suma = 0;
        int mayor = 0;
        int menor = 100;
        int nota;
        bool notaValida;

        do
        {
            Console.Write("Nota de 0 a 100: ");
            string? entrada = Console.ReadLine();
            if (entrada == null)
            {
                return;
            }

            notaValida = int.TryParse(entrada, out nota)
                && (nota == -1 || (nota >= 0 && nota <= 100));

            if (!notaValida)
            {
                Console.WriteLine("Nota inválida");
            }
            else if (nota != -1)
            {
                cantidad++;
                suma += nota;
                mayor = Math.Max(mayor, nota);
                menor = Math.Min(menor, nota);
            }
        } while (!notaValida || nota != -1);

        if (cantidad == 0)
        {
            Console.WriteLine("No se ingresaron notas.");
            return;
        }

        double promedio = (double)suma / cantidad;
        Console.WriteLine($"Promedio: {promedio:F2}");
        Console.WriteLine($"Nota mayor: {mayor}");
        Console.WriteLine($"Nota menor: {menor}");
    }
}
