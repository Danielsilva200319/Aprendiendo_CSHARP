using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Por favor ingrese un nombre: ");
        var nombre = Console.ReadLine();
        Console.Write("Por favor ingrese su cargo: ");
        var cargo = Console.ReadLine();
        Console.Write("Por favor ingrese su edad: ");
        var edad = Console.ReadLine();
        Console.WriteLine($"\nMi nombre es {nombre}");
        Console.WriteLine($"Mi cargo es {cargo}");
        Console.WriteLine($"Mi edad es {edad}");
    }
}