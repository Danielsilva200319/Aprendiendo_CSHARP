using System.Runtime.InteropServices;
using Humanizer;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Please, write your name: ");
        var nombre = Console.ReadLine();
        Console.Write("Please, write your occupation: ");
        var cargo = Console.ReadLine();
        Console.Write("Please, write your age: ");
        var edad = int.Parse(Console.ReadLine());
        Console.WriteLine($"\nMy name is {nombre}");
        Console.WriteLine($"My occupation is {cargo}");
        Console.WriteLine($"My age is {edad.ToWords()}");
    }
}