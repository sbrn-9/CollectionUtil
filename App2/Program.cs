
using CalculadoraCore;

namespace App2;


class Program
{

    static void Main(string[] args)
    {
        var c = new Calcu();
        Console.WriteLine($"[App2] add {c.Suma(1, 1)}");
        Console.ReadKey();
    }

}