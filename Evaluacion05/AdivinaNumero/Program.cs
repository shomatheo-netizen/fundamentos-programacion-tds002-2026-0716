namespace AdivinaNumero;

class Program
{
    static void Main(string[] args)
    {
        int secreto = Random.Shared.Next(1, 101);
        int intento = 0;
        int intentos = 0;

        while (intento != secreto)
        {
            Console.Write("numero entre 1 y 100: ");
            string? entrada = Console.ReadLine();
            if (entrada == null)
            {
                return;
            }

            if (!int.TryParse(entrada, out intento) || intento < 1 || intento > 100)
            {
                Console.WriteLine("Escribe un entero del 1 al 100.");
                continue;
            }

            intentos++;

            if (intento < secreto)
            {
                Console.WriteLine("El número secreto es mayor.");
            }
            else if (intento > secreto)
            {
                Console.WriteLine("El número secreto es menor.");
            }
        }

        Console.WriteLine($"Acertaste, Intentos: {intentos}");
    }
}