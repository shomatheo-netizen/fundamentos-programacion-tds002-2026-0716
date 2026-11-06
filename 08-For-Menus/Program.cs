namespace _08_For_Menus;

class Program
{
    static void Main(string[] args)
    {
        string? opcion;

        do
        {
            Console.WriteLine();
            Console.WriteLine("1. Tablas");
            Console.WriteLine("2. Triángulo");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");
            opcion = Console.ReadLine()?.Trim();

            switch (opcion)
            {
                case "1":
                    MostrarTablas();
                    break;
                case "2":
                    DibujarTriangulo();
                    break;
                case "0":
                    Console.WriteLine("Hasta luego.");
                    break;
                case null:
                    return;
                default:
                    Console.WriteLine("Elige 1, 2 o 0.");
                    break;
            }
        } while (opcion != "0");
    }

    static void MostrarTablas()
    {
        Console.Write("  x ");
        for (int tabla = 1; tabla <= 10; tabla++)
        {
            Console.Write($"{tabla,4}");
        }
        Console.WriteLine();

        for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
        {
            Console.Write($"{multiplicador,3}|");

            for (int tabla = 1; tabla <= 10; tabla++)
            {
                int valor = tabla * multiplicador;
                Console.Write($"{valor,4}");
            }

            Console.WriteLine();
        }
    }

    static void DibujarTriangulo()
    {
        Console.Write("Cuántas filas quieres? ");
        if (!int.TryParse(Console.ReadLine(), out int filas) || filas < 1)
        {
            Console.WriteLine("Escribe una cantidad de filas");
            return;
        }

        for (int fila = 0; fila < filas; fila++)
        {
            for (int columna = 0; columna <= fila; columna++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
