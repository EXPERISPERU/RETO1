using System;
using System.Collections.Generic;
using OrderRangeApp;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 2, 1, 4, 5, 7, 9, 10 , 12 };

        OrderRange orderRange = new OrderRange();
        var (evenNumbers, oddNumbers) = orderRange.Build(numbers);

        Console.WriteLine("Arreglo: [" + string.Join(", ", numbers) + "]");
        Console.WriteLine("Pares: [" + string.Join(", ", evenNumbers) + "]");
        Console.WriteLine("Impares: [" + string.Join(", ", oddNumbers) + "]");

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}