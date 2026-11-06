namespace _03_Operadores;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Primer numero entero: ");
        long x = int.Parse(Console.ReadLine() ?? "");

        Console.Write("Segundo numero entero: ");
        long y = int.Parse(Console.ReadLine() ?? "");

        Console.WriteLine($"Suma: {x + y}");
        Console.WriteLine($"Resta: {x - y}");
        Console.WriteLine($"Producto: {x * y}");

        if (y == 0)
        {
            Console.WriteLine("La división y el residuo requieren un segundo número distinto de cero.");
        }
        else
        {
            Console.WriteLine($"División real: {(double)x / y:F4}");
            Console.WriteLine($"División entera: {x / y}");
            Console.WriteLine($"Residuo: {x % y}");
        }

        bool primeroEsPar = x % 2 == 0;
        Console.WriteLine($"El primero es par: {(primeroEsPar ? "true" : "false")}");
    }
}

/*
Prueba de escritorio de la diapositiva 17

Inicio: x = 10, y = 3.
1. x / y da 3. Los valores siguen siendo x = 10, y = 3.
2. x % y da 1. Los valores siguen siendo x = 10, y = 3.
3. x += y suma 3 a x. Ahora x = 13, y = 3.
4. y++ aumenta y en 1. Ahora x = 13, y = 4.
5. x > y && y != 4 se evalúa como (13 > 4) && (4 != 4).
   La primera condición es true y la segunda es false.
   Resultado: false.
*/
