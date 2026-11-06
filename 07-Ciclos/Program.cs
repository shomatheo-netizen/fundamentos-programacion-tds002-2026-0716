namespace _07_Ciclos;

class Program
{
    static void Main(string[] args)
    {
        const int LIMITE = 12;
        int numero;
        bool esValido;

        do
        {
            Console.Write($"entero entre 1 y {LIMITE}: ");
            string? entrada = Console.ReadLine();

            if (entrada == null)
            {
                return;
            }

            esValido = int.TryParse(entrada, out numero) && numero >= 1 && numero <= LIMITE;

            if (!esValido)
            {
                Console.WriteLine("Numero invalido");
            }
        } while (!esValido);

        int contador = 1;
        int suma = 0;

        while (contador <= LIMITE)
        {
            int resultado = numero * contador;
            Console.WriteLine($"{numero} x {contador} = {resultado}");

            suma += resultado;
            contador++;
        }

        Console.WriteLine($"Suma de los resultados: {suma}");
    }
}
